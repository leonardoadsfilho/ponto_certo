namespace ControleComun
{
    partial class Form4
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.AdicionarProdutoCliente = new System.Windows.Forms.Button();
            this.CancelarProdutoCliente = new System.Windows.Forms.Button();
            this.NomeProdutoLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.DimGray;
            this.numericUpDown1.Location = new System.Drawing.Point(213, 109);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(128, 45);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AdicionarProdutoCliente
            // 
            this.AdicionarProdutoCliente.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.AdicionarProdutoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdicionarProdutoCliente.FlatAppearance.BorderSize = 0;
            this.AdicionarProdutoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdicionarProdutoCliente.Font = new System.Drawing.Font("Impact", 20F);
            this.AdicionarProdutoCliente.ForeColor = System.Drawing.Color.White;
            this.AdicionarProdutoCliente.Location = new System.Drawing.Point(15, 164);
            this.AdicionarProdutoCliente.Name = "AdicionarProdutoCliente";
            this.AdicionarProdutoCliente.Size = new System.Drawing.Size(143, 47);
            this.AdicionarProdutoCliente.TabIndex = 1;
            this.AdicionarProdutoCliente.Text = "ADICIONAR";
            this.AdicionarProdutoCliente.UseVisualStyleBackColor = false;
            this.AdicionarProdutoCliente.Click += new System.EventHandler(this.AdicionarProdutoCliente_Click);
            // 
            // CancelarProdutoCliente
            // 
            this.CancelarProdutoCliente.BackColor = System.Drawing.Color.Red;
            this.CancelarProdutoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarProdutoCliente.FlatAppearance.BorderSize = 0;
            this.CancelarProdutoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarProdutoCliente.Font = new System.Drawing.Font("Impact", 20F);
            this.CancelarProdutoCliente.ForeColor = System.Drawing.Color.White;
            this.CancelarProdutoCliente.Location = new System.Drawing.Point(198, 164);
            this.CancelarProdutoCliente.Name = "CancelarProdutoCliente";
            this.CancelarProdutoCliente.Size = new System.Drawing.Size(143, 47);
            this.CancelarProdutoCliente.TabIndex = 2;
            this.CancelarProdutoCliente.Text = "CANCELAR";
            this.CancelarProdutoCliente.UseVisualStyleBackColor = false;
            this.CancelarProdutoCliente.Click += new System.EventHandler(this.CancelarProdutoCliente_Click);
            // 
            // NomeProdutoLabel
            // 
            this.NomeProdutoLabel.BackColor = System.Drawing.Color.White;
            this.NomeProdutoLabel.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeProdutoLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.NomeProdutoLabel.Location = new System.Drawing.Point(16, 13);
            this.NomeProdutoLabel.Name = "NomeProdutoLabel";
            this.NomeProdutoLabel.Size = new System.Drawing.Size(325, 81);
            this.NomeProdutoLabel.TabIndex = 3;
            this.NomeProdutoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.CancelarProdutoCliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NomeProdutoLabel);
            this.panel1.Controls.Add(this.AdicionarProdutoCliente);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 218);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(16, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUANTIDADE:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(384, 246);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button AdicionarProdutoCliente;
        private System.Windows.Forms.Button CancelarProdutoCliente;
        private System.Windows.Forms.Label NomeProdutoLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}