namespace ControleComun.Resources
{
    partial class form_AddCLiente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_AddCLiente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.VoltarProdutosAddCliente = new System.Windows.Forms.Button();
            this.AvancarProdutosAddCliente = new System.Windows.Forms.Button();
            this.SearchBoxProdutoAddCliente = new System.Windows.Forms.TextBox();
            this.PbCarrinho = new System.Windows.Forms.PictureBox();
            this.LabelTOTAL = new System.Windows.Forms.Label();
            this.bt_Adicionar = new System.Windows.Forms.Label();
            this.cb_Situacao = new System.Windows.Forms.CheckBox();
            this.ESTOQUE = new System.Windows.Forms.DataGridView();
            this.ID_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PREÇO_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adicionado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_NomeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numericUpDown3);
            this.panel1.Controls.Add(this.VoltarProdutosAddCliente);
            this.panel1.Controls.Add(this.AvancarProdutosAddCliente);
            this.panel1.Controls.Add(this.SearchBoxProdutoAddCliente);
            this.panel1.Controls.Add(this.PbCarrinho);
            this.panel1.Controls.Add(this.LabelTOTAL);
            this.panel1.Controls.Add(this.bt_Adicionar);
            this.panel1.Controls.Add(this.cb_Situacao);
            this.panel1.Controls.Add(this.ESTOQUE);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_NomeCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // numericUpDown3
            // 
            resources.ApplyResources(this.numericUpDown3, "numericUpDown3");
            this.numericUpDown3.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            // 
            // VoltarProdutosAddCliente
            // 
            resources.ApplyResources(this.VoltarProdutosAddCliente, "VoltarProdutosAddCliente");
            this.VoltarProdutosAddCliente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.VoltarProdutosAddCliente.BackgroundImage = global::ControleComun.Properties.Resources.icons8_less_than_40;
            this.VoltarProdutosAddCliente.ForeColor = System.Drawing.Color.DarkGray;
            this.VoltarProdutosAddCliente.Name = "VoltarProdutosAddCliente";
            this.VoltarProdutosAddCliente.UseVisualStyleBackColor = false;
            this.VoltarProdutosAddCliente.Click += new System.EventHandler(this.VoltarProdutosAddCliente_Click);
            // 
            // AvancarProdutosAddCliente
            // 
            resources.ApplyResources(this.AvancarProdutosAddCliente, "AvancarProdutosAddCliente");
            this.AvancarProdutosAddCliente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AvancarProdutosAddCliente.BackgroundImage = global::ControleComun.Properties.Resources.icons8_more_than_80;
            this.AvancarProdutosAddCliente.ForeColor = System.Drawing.Color.DarkGray;
            this.AvancarProdutosAddCliente.Name = "AvancarProdutosAddCliente";
            this.AvancarProdutosAddCliente.UseVisualStyleBackColor = false;
            this.AvancarProdutosAddCliente.Click += new System.EventHandler(this.AvancarProdutosAddCliente_Click);
            // 
            // SearchBoxProdutoAddCliente
            // 
            this.SearchBoxProdutoAddCliente.BackColor = System.Drawing.Color.White;
            this.SearchBoxProdutoAddCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBoxProdutoAddCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SearchBoxProdutoAddCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.SearchBoxProdutoAddCliente, "SearchBoxProdutoAddCliente");
            this.SearchBoxProdutoAddCliente.ForeColor = System.Drawing.Color.Black;
            this.SearchBoxProdutoAddCliente.Name = "SearchBoxProdutoAddCliente";
            this.SearchBoxProdutoAddCliente.TextChanged += new System.EventHandler(this.SearchBoxProdutoAddCliente_TextChanged);
            // 
            // PbCarrinho
            // 
            this.PbCarrinho.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.PbCarrinho, "PbCarrinho");
            this.PbCarrinho.Name = "PbCarrinho";
            this.PbCarrinho.TabStop = false;
            // 
            // LabelTOTAL
            // 
            this.LabelTOTAL.BackColor = System.Drawing.Color.White;
            this.LabelTOTAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.LabelTOTAL, "LabelTOTAL");
            this.LabelTOTAL.ForeColor = System.Drawing.Color.DarkOrange;
            this.LabelTOTAL.Name = "LabelTOTAL";
            // 
            // bt_Adicionar
            // 
            this.bt_Adicionar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.bt_Adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.bt_Adicionar, "bt_Adicionar");
            this.bt_Adicionar.ForeColor = System.Drawing.Color.Ivory;
            this.bt_Adicionar.Name = "bt_Adicionar";
            this.bt_Adicionar.Click += new System.EventHandler(this.Btn_Adicionar_Click);
            // 
            // cb_Situacao
            // 
            resources.ApplyResources(this.cb_Situacao, "cb_Situacao");
            this.cb_Situacao.BackColor = System.Drawing.Color.SpringGreen;
            this.cb_Situacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Situacao.ForeColor = System.Drawing.Color.White;
            this.cb_Situacao.Name = "cb_Situacao";
            this.cb_Situacao.UseVisualStyleBackColor = false;
            this.cb_Situacao.CheckedChanged += new System.EventHandler(this.CheckBox_Situacao_CheckedChanged);
            // 
            // ESTOQUE
            // 
            this.ESTOQUE.AllowUserToAddRows = false;
            this.ESTOQUE.AllowUserToDeleteRows = false;
            this.ESTOQUE.AllowUserToResizeColumns = false;
            this.ESTOQUE.AllowUserToResizeRows = false;
            this.ESTOQUE.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.ESTOQUE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ESTOQUE.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ESTOQUE.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.ESTOQUE.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DodgerBlue;
            this.ESTOQUE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(this.ESTOQUE, "ESTOQUE");
            this.ESTOQUE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ESTOQUE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUTO,
            this.NOME_PRODUTO,
            this.PREÇO_PRODUTO,
            this.QUANTIDADE_PRODUTO,
            this.Adicionado,
            this.TOTAL});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ESTOQUE.DefaultCellStyle = dataGridViewCellStyle13;
            this.ESTOQUE.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ESTOQUE.EnableHeadersVisualStyles = false;
            this.ESTOQUE.GridColor = System.Drawing.Color.White;
            this.ESTOQUE.Name = "ESTOQUE";
            this.ESTOQUE.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Impact", 15.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ESTOQUE.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.ESTOQUE.RowHeadersVisible = false;
            this.ESTOQUE.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ESTOQUE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ESTOQUE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EstoqueCellContentClick);
            // 
            // ID_PRODUTO
            // 
            this.ID_PRODUTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ID_PRODUTO.DefaultCellStyle = dataGridViewCellStyle9;
            resources.ApplyResources(this.ID_PRODUTO, "ID_PRODUTO");
            this.ID_PRODUTO.Name = "ID_PRODUTO";
            this.ID_PRODUTO.ReadOnly = true;
            // 
            // NOME_PRODUTO
            // 
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.NOME_PRODUTO.DefaultCellStyle = dataGridViewCellStyle10;
            this.NOME_PRODUTO.FillWeight = 152.8662F;
            resources.ApplyResources(this.NOME_PRODUTO, "NOME_PRODUTO");
            this.NOME_PRODUTO.Name = "NOME_PRODUTO";
            this.NOME_PRODUTO.ReadOnly = true;
            this.NOME_PRODUTO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PREÇO_PRODUTO
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.PREÇO_PRODUTO.DefaultCellStyle = dataGridViewCellStyle11;
            this.PREÇO_PRODUTO.FillWeight = 82.37791F;
            resources.ApplyResources(this.PREÇO_PRODUTO, "PREÇO_PRODUTO");
            this.PREÇO_PRODUTO.Name = "PREÇO_PRODUTO";
            this.PREÇO_PRODUTO.ReadOnly = true;
            this.PREÇO_PRODUTO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // QUANTIDADE_PRODUTO
            // 
            this.QUANTIDADE_PRODUTO.FillWeight = 82.37791F;
            resources.ApplyResources(this.QUANTIDADE_PRODUTO, "QUANTIDADE_PRODUTO");
            this.QUANTIDADE_PRODUTO.Name = "QUANTIDADE_PRODUTO";
            this.QUANTIDADE_PRODUTO.ReadOnly = true;
            this.QUANTIDADE_PRODUTO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Adicionado
            // 
            this.Adicionado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Adicionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.Adicionado, "Adicionado");
            this.Adicionado.Name = "Adicionado";
            this.Adicionado.ReadOnly = true;
            this.Adicionado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Adicionado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.TOTAL.DefaultCellStyle = dataGridViewCellStyle12;
            this.TOTAL.FillWeight = 82.37791F;
            resources.ApplyResources(this.TOTAL, "TOTAL");
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Name = "label6";
            // 
            // tb_NomeCliente
            // 
            this.tb_NomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tb_NomeCliente, "tb_NomeCliente");
            this.tb_NomeCliente.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tb_NomeCliente.Name = "tb_NomeCliente";
            this.tb_NomeCliente.TextChanged += new System.EventHandler(this.Tabela_NomeCliente_TextChanged);
            this.tb_NomeCliente.Enter += new System.EventHandler(this.TextBox_AddCliente_placeholder);
            this.tb_NomeCliente.Leave += new System.EventHandler(this.TextBox_AddCliente_Leave);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Name = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::ControleComun.Properties.Resources.pngwing_com__1_;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Name = "label5";
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.DarkOrange;
            // 
            // form_AddCLiente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_AddCLiente";
            this.ShowIcon = false;
            this.Activated += new System.EventHandler(this.form_AddCLiente_Activated);
            this.Load += new System.EventHandler(this.AddCLiente_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_AddCLiente_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_AddCLiente_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.form_AddCLiente_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESTOQUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_NomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bt_Adicionar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ESTOQUE;
        private System.Windows.Forms.CheckBox cb_Situacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label LabelTOTAL;
        private System.Windows.Forms.PictureBox PbCarrinho;
        private System.Windows.Forms.TextBox SearchBoxProdutoAddCliente;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button VoltarProdutosAddCliente;
        private System.Windows.Forms.Button AvancarProdutosAddCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PREÇO_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE_PRODUTO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Adicionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
    }
}