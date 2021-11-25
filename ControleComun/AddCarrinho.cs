using ControleComun.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleComun
{
    public partial class Form4 : Form
    {
        form_AddCLiente FormularioDeAdicionarEstoque;
        int LinhaTabela;

        Point DragCursosr;
        Point DragForm;
        bool Dragging;
        public Form4(form_AddCLiente estoque, String nome_produto, int linha, decimal quantidade)
        {
            InitializeComponent();

            FormularioDeAdicionarEstoque = estoque;
            NomeProdutoLabel.Text = nome_produto;
            LinhaTabela = linha;
            numericUpDown1.Value = quantidade;
            
        }

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursosr = Cursor.Position;
            DragForm = this.Location;
        }

        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursosr));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void Form4_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void CancelarProdutoCliente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdicionarProdutoCliente_Click(object sender, EventArgs e)
        {
            FormularioDeAdicionarEstoque.AdicionarProdutoClienteTabela(float.Parse(numericUpDown1.Value.ToString()), LinhaTabela);
            Close();
        }
    }
}
