using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ControleComun.Resources
{
    public partial class form_AddCLiente : Form
    {
        private String id;

        private long pagina = 0;
        private long QuantidadePaginas = 0;
        private int maxProdutosTabela = 20;

        public form_AddCLiente()
        {
            InitializeComponent();

            cb_Situacao.Checked = true;
            cb_Situacao.Text = "SIM";
            id = "-1";
        }

        public form_AddCLiente(String id, String name, String produtos, String check)
        {
            InitializeComponent();

            tb_NomeCliente.Text = name;
            bt_Adicionar.Text = "ATUALIZAR";
            this.id = id;
            cb_Situacao.Checked = bool.Parse(check);
            cb_Situacao.Text = cb_Situacao.Checked ? "SIM" : "NÃO";
            String[] dados = produtos.Trim().Split(';');
            
            for (int i = 0; i < dados.Length - 1; i += 4)
            {
                ESTOQUE.Rows.Add(-1, dados[i], dados[i + 1], dados[i + 2], true, dados[i + 3]);
            }
        }

        Point DragCursor;
        Point DragForm;
        bool Dragging;

        private void form_AddCLiente_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void form_AddCLiente_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void form_AddCLiente_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void TextBox_AddCliente_placeholder(object sender, EventArgs e)
        {
            if (tb_NomeCliente.Text == "Digite o nome do cliente...")
            {
                tb_NomeCliente.Text = "";
                tb_NomeCliente.ForeColor = Color.DodgerBlue;
            }
        }

        private void TextBox_AddCliente_Leave(object sender, EventArgs e)
        {
            if (tb_NomeCliente.Text == "")
            {
                tb_NomeCliente.ForeColor = Color.DarkGray;
                tb_NomeCliente.Text = "Digite o nome do cliente...";
            }
        }

        private void CheckBox_Situacao_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Situacao.Checked)
            {
                cb_Situacao.Text = "SIM";
                cb_Situacao.BackColor = Color.MediumSpringGreen;
            }
            else
            {
                cb_Situacao.Text = "NÃO";
                cb_Situacao.BackColor = Color.Red;
            }
        }

        private bool ValidacaoDadosClienteCadastro()
        {
            return (tb_NomeCliente.Text != "Digite o nome do cliente..."
                && !String.IsNullOrWhiteSpace(tb_NomeCliente.Text)
                && !tb_NomeCliente.Text.Contains(";"));
        }

        private void AdicionarCadastroCliente()
        {
            if (ValidacaoDadosClienteCadastro())
            {
                bt_Adicionar.Visible = true;
            }
            else
            {
                bt_Adicionar.Visible = false;
            }
        }

        private void Tabela_NomeCliente_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(tb_NomeCliente, "Não insira caracteres especiais!");

            if (tb_NomeCliente.Text.Contains(";"))
            {
                toolTip1.Show("Retire o ';'!", tb_NomeCliente);
            }

            AdicionarCadastroCliente();
        }

        private void Adicionar_Click()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=controle_comun;uid=root;password=''");
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                String comsql = "INSERT INTO clientes(nome,carrinho,situacao,total) VALUES(@nome,@carrinho,@situacao,@total)";

                MySqlCommand mySqlCommand = new MySqlCommand
                {
                    Connection = connection,
                    CommandText = comsql
                };
                mySqlCommand.Prepare();
                mySqlCommand.Parameters.AddWithValue("@nome", tb_NomeCliente.Text);
                mySqlCommand.Parameters.AddWithValue("@carrinho", ProdutosToString());
                mySqlCommand.Parameters.AddWithValue("@situacao", cb_Situacao.Checked);
                mySqlCommand.Parameters.AddWithValue("@total", ProdutosTotal());
                mySqlCommand.ExecuteNonQuery();
            }

            connection.Close();
            foreach (DataGridViewRow row in ESTOQUE.Rows)
            {
                row.Cells[3].Value = "0";
                row.Cells[4].Value = false;
                row.Cells[5].Value = "0";
            }
            LabelTOTAL.Text = "0";
            tb_NomeCliente.Text = "";
        }

        private void Atualizar_Click()
        {
            if (MessageBox.Show(String.Format("Tem certeza que deseja atulizar os dados de {0}", tb_NomeCliente.Text), "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;database=controle_comun;uid=root;password=''");
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    String comsql = "UPDATE clientes SET nome = @nome, carrinho = @carrinho, situacao = @situacao, total = @total WHERE id = @id";

                    MySqlCommand mySqlCommand = new MySqlCommand
                    {
                        Connection = connection,
                        CommandText = comsql
                    };
                    mySqlCommand.Prepare();
                    mySqlCommand.Parameters.AddWithValue("@nome", tb_NomeCliente.Text);
                    mySqlCommand.Parameters.AddWithValue("@carrinho", ProdutosToString());
                    mySqlCommand.Parameters.AddWithValue("@situacao", cb_Situacao.Checked);
                    mySqlCommand.Parameters.AddWithValue("@total", ProdutosTotal());
                    mySqlCommand.Parameters.AddWithValue("@id", id);
                    mySqlCommand.ExecuteNonQuery();
                }

                connection.Close();
                MessageBox.Show("Operação concluida", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (bt_Adicionar.Text == "ATUALIZAR")
            {
                Atualizar_Click();
            }
            else
            {
                Adicionar_Click();
            }
        }

        private float ProdutosTotal()
        {
            float total = 0;
            for (int i = 0; i < ESTOQUE.RowCount; i++)
            {
                if (bool.Parse(ESTOQUE[4, i].Value.ToString()))
                {
                    total += float.Parse(ESTOQUE[5, i].Value.ToString());
                }
            }
            return total;
        }

        private String ProdutosToString()
        {
            String carrinho = "";
            for (int i = 0; i < ESTOQUE.RowCount; i++)
            {
                if (bool.Parse(ESTOQUE[4, i].Value.ToString()))
                {
                    carrinho += String.Format("{0};{1};{2};{3};",
                                ESTOQUE[1, i].Value.ToString(),
                                ESTOQUE[2, i].Value.ToString(),
                                ESTOQUE[3, i].Value.ToString(),
                                ESTOQUE[5, i].Value.ToString());
                }
            }
            return carrinho;
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool VerificaExistenciaProduto(String nome_produto, String[] dados_nomes_produtos)
        {
            bool existe = false;
            if (dados_nomes_produtos[0] != "Vazio")
            {
                for (int i = 0; i < dados_nomes_produtos.Length; i += 4)
                {
                    if (nome_produto.Equals(dados_nomes_produtos[i]) && float.Parse(dados_nomes_produtos[i+3]) != 0)
                    {
                        existe = true;
                        break;
                    }
                }
            }

            return existe;
        }

        private void QuantidadeDeRegistroProdutosAddCliente()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=controle_comun;uid=root;password=''");
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                String comsql = "SELECT COUNT(*) FROM produtos";
                MySqlCommand mySqlCommand = new MySqlCommand
                {
                    Connection = connection,
                    CommandText = comsql
                };

                QuantidadePaginas = Convert.ToInt32(mySqlCommand.ExecuteScalar());
                numericUpDown3.Maximum = (int)QuantidadePaginas / maxProdutosTabela;
            }

            connection.Close();
        }

        private bool VerificaProdutoAdicionado(DataRow row)
        {
            bool existe = false;

            foreach (DataGridViewRow linha in ESTOQUE.Rows)
            {
                if (linha.Cells[1].Value.ToString() == row[1].ToString())
                {
                    existe = true;
                }
            }

            return existe;
        }

        private void LimparDataGridProdutos()
        {
            List<DataGridViewRow> mantem_produto = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in ESTOQUE.Rows)
            {
                if (bool.Parse(row.Cells[4].Value.ToString()))
                {
                    mantem_produto.Add(row);
                }
            }

            ESTOQUE.Rows.Clear();

            foreach (DataGridViewRow row in mantem_produto)
            {
                ESTOQUE.Rows.Add(row);
            }
        }

        private void PreencherTabelaProdutosAddCliente()
        {
            QuantidadeDeRegistroProdutosAddCliente();

            float total = ProdutosTotal();

            LimparDataGridProdutos();

            MySqlConnection connection = new MySqlConnection("server=localhost;database=controle_comun;uid=root;password=''");
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                if (String.IsNullOrWhiteSpace(SearchBoxProdutoAddCliente.Text))
                {
                    String comsql = "SELECT * FROM produtos LIMIT " + pagina + "," + maxProdutosTabela;

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter
                    {
                        SelectCommand = new MySqlCommand(comsql, connection)
                    };
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (!VerificaProdutoAdicionado(row))
                        {
                            ESTOQUE.Rows.Add(row[0], row[1].ToString(), row[2].ToString(), "0", false, "0");
                        }
                    }

                    dataTable.Rows.Clear();
                }
                else
                {
                    String comsql = "SELECT * FROM produtos WHERE nome LIKE '" + SearchBoxProdutoAddCliente.Text + "%' OR id LIKE'" + SearchBoxProdutoAddCliente.Text + "%' LIMIT " + pagina + "," + maxProdutosTabela;

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter
                    {
                        SelectCommand = new MySqlCommand(comsql, connection)
                    };
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (!VerificaProdutoAdicionado(row))
                        {
                            ESTOQUE.Rows.Add(row[0], row[1].ToString(), row[2], "0", false, "0");
                        }
                    }
                    dataTable.Rows.Clear();
                }
            }

            LabelTOTAL.Text = total.ToString();

            connection.Close();
        }

        private void AddCLiente_Load(object sender, EventArgs e)
        {
            PreencherTabelaProdutosAddCliente();
        }

        private void EstoqueCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                AlterarQuantidade(e.RowIndex);
            }
        }

        private void AlterarQuantidade(int linha)
        {
            Form AddProduto = Application.OpenForms["Form4"];
            if (AddProduto != null)
            {
                AddProduto.Close();
                AddProduto = new Form4(this, ESTOQUE[1, linha].Value.ToString(), linha, decimal.Parse(ESTOQUE[3, linha].Value.ToString()));
                AddProduto.Show();
            }
            else
            {
                AddProduto = new Form4(this, ESTOQUE[1, linha].Value.ToString(), linha, decimal.Parse(ESTOQUE[3, linha].Value.ToString()));
                AddProduto.Show();
            }
        }

        public void AdicionarProdutoClienteTabela(float quantidade, int linha)
        {
            if (quantidade != 0)
            {
                ESTOQUE[3, linha].Value = quantidade;
                ESTOQUE[4, linha].Value = true;
                ESTOQUE[5, linha].Value = quantidade * float.Parse(ESTOQUE[2, linha].Value.ToString());
            }
            else
            {              
                ESTOQUE[3, linha].Value = quantidade;
                ESTOQUE[4, linha].Value = false;
                ESTOQUE[5, linha].Value = quantidade * float.Parse(ESTOQUE[2, linha].Value.ToString());
            }
        }

        private void form_AddCLiente_Activated(object sender, EventArgs e)
        {
            float total = 0;
            foreach (DataGridViewRow row in ESTOQUE.Rows)
            {
                if (bool.Parse(row.Cells[4].Value.ToString()))
                {
                    total += float.Parse(row.Cells[5].Value.ToString());
                }
            }
            LabelTOTAL.Text = total.ToString();
        }

        private void SearchBoxProdutoAddCliente_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(SearchBoxProdutoAddCliente, "Não insira caracteres especiais!");

            if (SearchBoxProdutoAddCliente.Text.Contains(";"))
            {
                toolTip1.Show("Retire o ';'!", SearchBoxProdutoAddCliente);
            }
            else
            {
                PreencherTabelaProdutosAddCliente();
            }
        }

        private void VoltarProdutosAddCliente_Click(object sender, EventArgs e)
        {
            if (pagina > 0)
            {
                pagina -= maxProdutosTabela;
                numericUpDown3.Value--;
                PreencherTabelaProdutosAddCliente();
            }
        }

        private void AvancarProdutosAddCliente_Click(object sender, EventArgs e)
        {
            if (pagina < QuantidadePaginas && numericUpDown3.Value != numericUpDown3.Maximum)
            {
                pagina += maxProdutosTabela;
                numericUpDown3.Value++;
                PreencherTabelaProdutosAddCliente();
            }
        }
    }
}
