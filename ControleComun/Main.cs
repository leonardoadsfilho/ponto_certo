using ControleComun.Resources;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ControleComun
{
    public partial class ControleComun : Form
    {
        public ControleComun()
        {
            InitializeComponent();

            Tabela_Clientes.ScrollBars = ScrollBars.Vertical;
            Tabela_Produtos.ScrollBars = ScrollBars.Vertical;
        }

        Point DragCursosr;
        Point DragForm;
        bool Dragging;
        long pagina = 0;
        long pagina_produtos = 0;
        long QuantidadePaginas = 0;
        int maxClientesTabela = 20;
        long QuantidadePaginasProdutos = 0;
        int maxProdutosTabela = 20;

        private void ControleComun_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursosr = Cursor.Position;
            DragForm = this.Location;
        }

        private void ControleComun_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void ControleComun_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursosr));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void Btn_AddProduto_Click(object sender, EventArgs e)
        {
            Form AddProduto = Application.OpenForms["Form3"];
            if (AddProduto != null)
            {
                AddProduto.Close();
                AddProduto = new AddProduto();
                AddProduto.Show();
            }
            else
            {
                AddProduto = new AddProduto();
                AddProduto.Show();
            }
        }

        private void Btn_AddCliente_Click(object sender, EventArgs e)
        {
            Form AddCliente = Application.OpenForms["form_AddCliente"];
            if (AddCliente != null)
            {
                AddCliente.Close();
                AddCliente = new form_AddCLiente();
                AddCliente.Show();
            }
            else
            {
                AddCliente = new form_AddCLiente();
                AddCliente.Show();
            }
        }

        private void Tabela_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex != -1)
            {
                if (MessageBox.Show("Tem certeza que deseja deletar " + Tabela_Clientes[1, e.RowIndex].Value.ToString(), "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CellbtnDeletarCliente(e.RowIndex);
                    MessageBox.Show("Registro deletado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (e.ColumnIndex == 5 && e.RowIndex != -1)
            {
                DataGridViewRow row_att_cliente = Tabela_Clientes.SelectedRows[0];
                Atualizar_Click(row_att_cliente.Cells[0].Value.ToString(), row_att_cliente.Cells[1].Value.ToString(), row_att_cliente.Cells[7].Value.ToString(), row_att_cliente.Cells[3].Value.ToString());
            }
        }

        private void Show_Produtos()
        {
            if (Tabela_Clientes.SelectedRows.Count > 0)
            {
                Form visualizar_cliente = Application.OpenForms["VizualizarCliente"];
                if (visualizar_cliente != null)
                {
                    visualizar_cliente.Close();
                    visualizar_cliente = new VizualizarCliente(this, Tabela_Clientes.Rows[Tabela_Clientes.SelectedRows[0].Index]);
                    visualizar_cliente.Show();
                }
                else
                {
                    visualizar_cliente = new VizualizarCliente(this, Tabela_Clientes.Rows[Tabela_Clientes.SelectedRows[0].Index]);
                    visualizar_cliente.Show();
                }
            }
        }

        private void CellbtnDeletarCliente(int linha)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=controle_comun;uid=root;password=''");
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                String comsql = "DELETE FROM clientes WHERE id = @id";

                MySqlCommand mySqlCommand = new MySqlCommand
                {
                    Connection = connection,
                    CommandText = comsql
                };
                mySqlCommand.Prepare();
                mySqlCommand.Parameters.AddWithValue("@id", Tabela_Clientes[0, linha].Value.ToString());
                mySqlCommand.ExecuteNonQuery();
            }

            connection.Close();
        }

        private void QuantidadeDeRegistroClientes()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=controle_comun;uid=root;password=''");
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                String comsql = "SELECT COUNT(*) FROM clientes";
                MySqlCommand mySqlCommand = new MySqlCommand
                {
                    Connection = connection,
                    CommandText = comsql
                };

                QuantidadePaginas = Convert.ToInt32(mySqlCommand.ExecuteScalar());
                numericUpDown1.Maximum = (int)QuantidadePaginas / maxClientesTabela;
            }

            connection.Close();
        }

        private void PreencheTabelaClientes()
        {
            QuantidadeDeRegistroClientes();

            MySqlConnection connection = new MySqlConnection("server=localhost;database=controle_comun;uid=root;password=''");
            connection.Open();

            Tabela_Clientes.Rows.Clear();

            if (connection.State == ConnectionState.Open)
            {
                if (String.IsNullOrWhiteSpace(SearchBoxCliente.Text))
                {
                    String comsql = "SELECT * FROM clientes LIMIT " + pagina + "," + maxClientesTabela;

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter
                    {
                        SelectCommand = new MySqlCommand(comsql, connection)
                    };
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        Tabela_Clientes.Rows.Add(row[0], row[1].ToString(), row[4], row[3], row[5].ToString().Split(' ')[0], "ATUALIZAR", "DELETAR", row[2].ToString());
                    }
                    dataTable.Rows.Clear();
                }
                else
                {
                    String comsql = "SELECT * FROM clientes WHERE nome LIKE '" + SearchBoxCliente.Text + "%' OR id LIKE '" + SearchBoxCliente.Text + "%' LIMIT " + pagina + "," + maxClientesTabela;

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter
                    {
                        SelectCommand = new MySqlCommand(comsql, connection)
                    };
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        Tabela_Clientes.Rows.Add(row[0], row[1].ToString(), row[4], row[3], row[5].ToString().Split(' ')[0], "ATUALIZAR", "DELETAR", row[2].ToString());
                    }
                    dataTable.Rows.Clear();
                }
            }

            connection.Close();
        }

        private void QuantidadeDeRegistroProdutos()
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

                QuantidadePaginasProdutos = Convert.ToInt32(mySqlCommand.ExecuteScalar());
                numericUpDown2.Maximum = (int)QuantidadePaginasProdutos / maxProdutosTabela;
            }

            connection.Close();
        }

        private void PreencheTabelaProdutos()
        {
            QuantidadeDeRegistroProdutos();

            MySqlConnection connection = new MySqlConnection("server=localhost;database=controle_comun;uid=root;password=''");
            connection.Open();

            Tabela_Produtos.Rows.Clear();

            if (connection.State == ConnectionState.Open)
            {
                if (String.IsNullOrWhiteSpace(SearchBoxProduto.Text))
                {
                    String comsql = "SELECT * FROM produtos LIMIT " + pagina_produtos + "," + maxProdutosTabela;

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter
                    {
                        SelectCommand = new MySqlCommand(comsql, connection)
                    };
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        Tabela_Produtos.Rows.Add(row[0], row[1].ToString(), row[2], "ATUALIZAR", "DELETAR");
                    }
                    dataTable.Rows.Clear();
                }
                else
                {
                    String comsql = "SELECT * FROM produtos WHERE nome LIKE '" + SearchBoxProduto.Text + "%' OR id LIKE'" + SearchBoxProduto.Text + "%' LIMIT " + pagina_produtos + "," + maxProdutosTabela;

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter
                    {
                        SelectCommand = new MySqlCommand(comsql, connection)
                    };
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        Tabela_Produtos.Rows.Add(row[0], row[1].ToString(), row[2], "ATUALIZAR", "DELETAR");
                    }
                    dataTable.Rows.Clear();
                }
            }
        }

        private void ControleComun_Activated(object sender, EventArgs e)
        {
            PreencheTabelaClientes();
            PreencheTabelaProdutos();
        }

        private void Tabela_Podutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                if (MessageBox.Show("Tem certeza que deseja deletar " + Tabela_Produtos[1, e.RowIndex].Value.ToString(), "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CellbtnDeletarProduto(e.RowIndex);
                    MessageBox.Show("Registro deletado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                DataGridViewRow row = Tabela_Clientes.SelectedRows[0];
                Atualizar_Click(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[7].Value.ToString(), row.Cells[3].Value.ToString());
            }
        }

        private void CellbtnDeletarProduto(int linha)
        {            
            MySqlConnection connection = new MySqlConnection("server=localhost;database=controle_comun;uid=root;password=''");
            connection.Open();
            
            if (connection.State == ConnectionState.Open)
            {
                String comsql = "DELETE FROM produtos WHERE id = @id";
                MySqlCommand mySqlCommand = new MySqlCommand
                {
                    Connection = connection,
                    CommandText = comsql
                };
                mySqlCommand.Prepare();                
                mySqlCommand.Parameters.AddWithValue("@id", Tabela_Produtos[0, linha].Value);
                mySqlCommand.ExecuteNonQuery();
            }
                
            connection.Close();                         
        }

        private void DeletarRegistros()
        {
            DataGridViewSelectedRowCollection linhas_selecionadas = Abas.SelectedTab.Text == "CLIENTES" ? Tabela_Clientes.SelectedRows : Tabela_Produtos.SelectedRows;
            String tabela = "CellbtnDeletar";
            if (Abas.SelectedTab.Text == "CLIENTES")
            {
                linhas_selecionadas = Tabela_Clientes.SelectedRows;
                tabela += "Cliente";
            }
            else
            {
                linhas_selecionadas = Tabela_Produtos.SelectedRows;
                tabela += "Produto";
            }
            if (linhas_selecionadas.Count > 0)
            {
                int[] linhas_idex = new int[linhas_selecionadas.Count];
                for (int i = 0; i < linhas_idex.Length; i++)
                {
                    linhas_idex[i] = linhas_selecionadas[i].Index;
                }

                if (MessageBox.Show(String.Format("Tem certeza que deseja deletar {0} registro(s)", linhas_idex.Length), "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < linhas_idex.Length; i++)
                    {
                        if (tabela.Equals("CellbtnDeletarCliente"))
                        {
                            CellbtnDeletarCliente(linhas_idex[i]);
                        }
                        else
                        {
                            CellbtnDeletarProduto(linhas_idex[i]);
                        }
                    }
                    MessageBox.Show("Operação concluida", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MaxApp_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }            
        }

        private void MinApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            DeletarRegistros();
        } 

        private void Atualizar_Click(String id, String name, String produtos, String check)
        {
            Form AddCliente = Application.OpenForms["form_AddCliente"];
            if (AddCliente != null)
            {
                AddCliente.Close();
                AddCliente = new form_AddCLiente(id, name, produtos, check);
                AddCliente.Show();
            }
            else
            {
                AddCliente = new form_AddCLiente(id, name, produtos, check);
                AddCliente.Show();
            }
        }

        private void AtualizarProdutos_Click(String id, String nome, String preco)
        {
            Form AddCliente = Application.OpenForms["Form3"];
            if (AddCliente != null)
            {
                AddCliente.Close();
                AddCliente = new AddProduto(id, nome, preco);
                AddCliente.Show();
            }
            else
            {
                AddCliente = new AddProduto(id, nome, preco);
                AddCliente.Show();
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            if (Tabela_Clientes.SelectedRows.Count > 0)
            {
                DataGridViewRow row = Tabela_Clientes.SelectedRows[0];
                Atualizar_Click(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[7].Value.ToString(), row.Cells[3].Value.ToString());
            }            
        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            Show_Produtos();
        }

        private void BtnVisualizarProtudo_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnDeletarProduto_Click(object sender, EventArgs e)
        {
            DeletarRegistros();
        }

        private void Btn_addClient_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_addClient, "Adicionar Cliente");
        }

        private void BtnAtualizarCliente_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(BtnAtualizarCliente, "Atualizar Cliente");
        }

        private void BtnVisualizarCliente_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(BtnVisualizarCliente, "Visualizar Cliente");
        }

        private void BtnDeletarCliente_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(BtnDeletarCliente, "Selecione o(s) cliente(s) para deletar");
        }

        private void AvancarClientes_Click(object sender, EventArgs e)
        {
            if (pagina < QuantidadePaginas && numericUpDown1.Value != numericUpDown1.Maximum)
            {
                pagina += maxClientesTabela;
                numericUpDown1.Value++;
                PreencheTabelaClientes();
            }                        
        }

        private void VoltarClientes_Click(object sender, EventArgs e)
        {
            if (pagina > 0)
            {
                pagina -= maxClientesTabela;
                numericUpDown1.Value--;
                PreencheTabelaClientes();
            }            
        }

        private void Tabela_Clientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeletarRegistros();
            }
        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                pagina = (long)(int.Parse(numericUpDown1.Value.ToString()) * maxClientesTabela);
                PreencheTabelaClientes();
            }
        }

        private void SearchBoxCliente_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(SearchBoxCliente, "Não insira caracteres especiais!");

            if (SearchBoxCliente.Text.Contains(";"))
            {
                toolTip1.Show("Retire o ';'!", SearchBoxCliente);
            }
            else
            {
                PreencheTabelaClientes();                  
            }
        }

        private void SearchBoxProduto_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(SearchBoxProduto, "Não insira caracteres especiais!");

            if (SearchBoxProduto.Text.Contains(";"))
            {
                toolTip1.Show("Retire o ';'!", SearchBoxProduto);
            }
            else
            {
                PreencheTabelaProdutos();
            }
        }

        private void VoltarProdutos_Click(object sender, EventArgs e)
        {
            if (pagina_produtos > 0)
            {
                pagina_produtos -= maxProdutosTabela;
                numericUpDown2.Value--;
                PreencheTabelaProdutos();
            }
        }

        private void AvancarProdutos_Click(object sender, EventArgs e)
        {
            if (pagina_produtos < QuantidadePaginasProdutos && numericUpDown2.Value != numericUpDown2.Maximum)
            {
                pagina_produtos += maxProdutosTabela;
                numericUpDown2.Value++;
                PreencheTabelaProdutos();
            }
        }

        private void BtnAtualizarProduto_Click(object sender, EventArgs e)
        {
            if (Tabela_Produtos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = Tabela_Produtos.SelectedRows[0];
                AtualizarProdutos_Click(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString());
            }
        }

        private void numericUpDown2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pagina_produtos = (long)(int.Parse(numericUpDown2.Value.ToString()) * maxProdutosTabela);
                PreencheTabelaProdutos();
            }
        }

        private void Tabela_Produtos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeletarRegistros();
            }
        }
    }
}
