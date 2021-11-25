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
    public partial class VizualizarCliente : Form
    {

        Point DragCursosr;
        Point DragForm;
        bool Dragging;

        public VizualizarCliente(ControleComun cc, DataGridViewRow linha)
        {         
            InitializeComponent();
                        
            NomeCliente.Text = linha.Cells[1].Value.ToString();
            PreencheListaProdutos(linha.Cells[7]);
        }

        private void VizualizarCliente_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursosr = Cursor.Position;
            DragForm = this.Location;
        }

        private void VizualizarCliente_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursosr));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void VizualizarCliente_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PreencheListaProdutos(DataGridViewCell cell)
        {
            String[] dados = cell.Value.ToString().Trim().Split(';');
            float total = 0;
            for (int i = 0; i < dados.Length - 1; i+=4)
            {
                ListaProdutos.Rows.Add(dados[i], dados[i+1], dados[i+2], dados[i+3]);
                total += float.Parse(dados[i + 3]);
            }
            ListaProdutos.Rows.Add("TOTAL", "------", "------", total);
        }

        private void BtnImprimirCliente_Click(object sender, EventArgs e)
        {

        }

        private void BtnExcluirCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
