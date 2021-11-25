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

namespace ControleComun
{
    public partial class AddProduto : Form
    {
        public AddProduto()
        {
            InitializeComponent();
        }

        String id;

        public AddProduto(String id, String nome, String preco)
        {
            InitializeComponent();

            tb_NomeProduto.Text = nome;
            this.id = id;
            numericUpDown1.Value = decimal.Parse(preco);
            bt_Adicionar.Text = "ATUALIZAR";
        }

        Point DragCursor;
        Point DragForm;
        bool Dragging;

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidacaoDadosProdutoCadastro()
        {
            return (tb_NomeProduto.Text != "Digite o nome do produto..."
                && !String.IsNullOrWhiteSpace(tb_NomeProduto.Text)
                && !tb_NomeProduto.Text.Contains(';'));
        }

        private void AdicionarCadastroProduto()
        {
            if (ValidacaoDadosProdutoCadastro())
            {
                bt_Adicionar.Visible = true;
            }
            else
            {
                bt_Adicionar.Visible = false;
            }
        }

        private void AdicionarProduto()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=controle_comun;uid=root;password=''");
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                String comsql = "INSERT INTO produtos(nome,preco) VALUES(@nome,@preco)";

                MySqlCommand mySqlCommand = new MySqlCommand
                {
                    Connection = connection,
                    CommandText = comsql
                };
                mySqlCommand.Prepare();
                mySqlCommand.Parameters.AddWithValue("@nome", tb_NomeProduto.Text);
                mySqlCommand.Parameters.AddWithValue("@preco", numericUpDown1.Value);
                mySqlCommand.ExecuteNonQuery();
            }

            connection.Close();
            tb_NomeProduto.Text = "";
        }

        private void AtualizarProduto()
        {
            if (MessageBox.Show(String.Format("Tem certeza que deseja atulizar os dados de {0}", tb_NomeProduto.Text), "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;database=controle_comun;uid=root;password=''");
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    String comsql = "UPDATE produtos SET nome = @nome, preco = @preco WHERE id = @id";

                    MySqlCommand mySqlCommand = new MySqlCommand
                    {
                        Connection = connection,
                        CommandText = comsql
                    };
                    mySqlCommand.Prepare();
                    mySqlCommand.Parameters.AddWithValue("@nome", tb_NomeProduto.Text);
                    mySqlCommand.Parameters.AddWithValue("@preco", numericUpDown1.Value);
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
                AtualizarProduto();
            }
            else
            {
                AdicionarProduto();
            }
        }

        private void TextBox_NomeProduto_Enter(object sender, EventArgs e)
        {
            if (tb_NomeProduto.Text == "Digite o nome do produto...")
            {
                tb_NomeProduto.Text = "";
                tb_NomeProduto.ForeColor = Color.Gray;
            }
        }

        private void TextBox_NomeProduto_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_NomeProduto.Text))
            {
                tb_NomeProduto.ForeColor = Color.DarkGray;
                tb_NomeProduto.Text = "Digite o nome do produto...";
            }
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.ForeColor = Color.DarkGray;
        }

        private void TextBox_NomeProduto_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(tb_NomeProduto, "Não insira caracteres especiais!");

            if (tb_NomeProduto.Text.Contains(";"))
            {
                toolTip1.Show("Retire o ';'", tb_NomeProduto);
            }

            AdicionarCadastroProduto();
                                    
        }
    }
}
