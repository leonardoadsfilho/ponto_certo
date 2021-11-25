namespace ControleComun
{
    partial class VizualizarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VizualizarCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NomeCliente = new System.Windows.Forms.TextBox();
            this.ListaProdutos = new System.Windows.Forms.DataGridView();
            this.PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCloseForm = new System.Windows.Forms.PictureBox();
            this.BtnImprimirCliente = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCloseForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnImprimirCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.NomeCliente);
            this.panel1.Controls.Add(this.ListaProdutos);
            this.panel1.Location = new System.Drawing.Point(13, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 470);
            this.panel1.TabIndex = 0;
            // 
            // NomeCliente
            // 
            this.NomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NomeCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.NomeCliente.Font = new System.Drawing.Font("Impact", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeCliente.ForeColor = System.Drawing.Color.DarkOrange;
            this.NomeCliente.Location = new System.Drawing.Point(15, 15);
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.Size = new System.Drawing.Size(411, 65);
            this.NomeCliente.TabIndex = 4;
            this.NomeCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ListaProdutos
            // 
            this.ListaProdutos.AllowUserToAddRows = false;
            this.ListaProdutos.AllowUserToDeleteRows = false;
            this.ListaProdutos.AllowUserToResizeColumns = false;
            this.ListaProdutos.AllowUserToResizeRows = false;
            this.ListaProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ListaProdutos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.ListaProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ListaProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListaProdutos.ColumnHeadersHeight = 35;
            this.ListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ListaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRODUTO,
            this.PRECO,
            this.QUANTIDADE,
            this.SUBTOTAL});
            this.ListaProdutos.EnableHeadersVisualStyles = false;
            this.ListaProdutos.Location = new System.Drawing.Point(15, 91);
            this.ListaProdutos.Name = "ListaProdutos";
            this.ListaProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ListaProdutos.RowHeadersVisible = false;
            this.ListaProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ListaProdutos.RowTemplate.Height = 30;
            this.ListaProdutos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaProdutos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ListaProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaProdutos.Size = new System.Drawing.Size(411, 363);
            this.ListaProdutos.TabIndex = 3;
            // 
            // PRODUTO
            // 
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.PRODUTO.DefaultCellStyle = dataGridViewCellStyle2;
            this.PRODUTO.HeaderText = "PRODUTO";
            this.PRODUTO.Name = "PRODUTO";
            this.PRODUTO.ReadOnly = true;
            this.PRODUTO.Width = 103;
            // 
            // PRECO
            // 
            this.PRECO.HeaderText = "PRECO";
            this.PRECO.Name = "PRECO";
            this.PRECO.ReadOnly = true;
            this.PRECO.Width = 103;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.HeaderText = "QUANTIDADE";
            this.QUANTIDADE.Name = "QUANTIDADE";
            this.QUANTIDADE.ReadOnly = true;
            this.QUANTIDADE.Width = 102;
            // 
            // SUBTOTAL
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.SUBTOTAL.DefaultCellStyle = dataGridViewCellStyle3;
            this.SUBTOTAL.HeaderText = "SUBTOTAL";
            this.SUBTOTAL.Name = "SUBTOTAL";
            this.SUBTOTAL.ReadOnly = true;
            this.SUBTOTAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SUBTOTAL.Width = 103;
            // 
            // BtnCloseForm
            // 
            this.BtnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCloseForm.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnCloseForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCloseForm.BackgroundImage")));
            this.BtnCloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCloseForm.Location = new System.Drawing.Point(409, 0);
            this.BtnCloseForm.Name = "BtnCloseForm";
            this.BtnCloseForm.Size = new System.Drawing.Size(60, 50);
            this.BtnCloseForm.TabIndex = 1;
            this.BtnCloseForm.TabStop = false;
            this.BtnCloseForm.Click += new System.EventHandler(this.BtnCloseForm_Click);
            // 
            // BtnImprimirCliente
            // 
            this.BtnImprimirCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnImprimirCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnImprimirCliente.BackgroundImage")));
            this.BtnImprimirCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnImprimirCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImprimirCliente.Location = new System.Drawing.Point(343, 0);
            this.BtnImprimirCliente.Name = "BtnImprimirCliente";
            this.BtnImprimirCliente.Size = new System.Drawing.Size(60, 50);
            this.BtnImprimirCliente.TabIndex = 4;
            this.BtnImprimirCliente.TabStop = false;
            this.BtnImprimirCliente.Click += new System.EventHandler(this.BtnImprimirCliente_Click);
            // 
            // VizualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(468, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnImprimirCliente);
            this.Controls.Add(this.BtnCloseForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VizualizarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VizualizarCliente_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VizualizarCliente_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VizualizarCliente_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCloseForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnImprimirCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BtnCloseForm;
        private System.Windows.Forms.PictureBox BtnImprimirCliente;
        private System.Windows.Forms.DataGridView ListaProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBTOTAL;
        private System.Windows.Forms.TextBox NomeCliente;
    }
}