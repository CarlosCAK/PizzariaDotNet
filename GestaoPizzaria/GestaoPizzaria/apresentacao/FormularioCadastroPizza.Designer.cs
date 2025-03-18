namespace GestaoPizzaria
{
    partial class FormularioCadastroPizza
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new TextBox();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            idLbl = new Label();
            nomelbl = new Label();
            lblPreco = new Label();
            btnSalvar = new Button();
            btnExcluir = new Button();
            dtgPizzas = new DataGridView();
            btnLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgPizzas).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(92, 56);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(198, 57);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(129, 23);
            txtNome.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(333, 57);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(142, 23);
            txtPreco.TabIndex = 2;
            // 
            // idLbl
            // 
            idLbl.AutoSize = true;
            idLbl.Location = new Point(93, 39);
            idLbl.Name = "idLbl";
            idLbl.Size = new Size(17, 15);
            idLbl.TabIndex = 3;
            idLbl.Text = "id";
            // 
            // nomelbl
            // 
            nomelbl.AutoSize = true;
            nomelbl.Location = new Point(198, 39);
            nomelbl.Name = "nomelbl";
            nomelbl.Size = new Size(40, 15);
            nomelbl.TabIndex = 4;
            nomelbl.Text = "Nome";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(333, 39);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 5;
            lblPreco.Text = "Preço";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(481, 55);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(481, 84);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dtgPizzas
            // 
            dtgPizzas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPizzas.Location = new Point(92, 90);
            dtgPizzas.Name = "dtgPizzas";
            dtgPizzas.Size = new Size(383, 210);
            dtgPizzas.TabIndex = 8;
            dtgPizzas.CellDoubleClick += dtgPizzas_CellDoubleClick;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(481, 113);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // FormularioCadastroPizza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpar);
            Controls.Add(dtgPizzas);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(lblPreco);
            Controls.Add(nomelbl);
            Controls.Add(idLbl);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Name = "FormularioCadastroPizza";
            Text = "Form1";
            Load += FormularioCadastroPizza_Load;
            ((System.ComponentModel.ISupportInitialize)dtgPizzas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtPreco;
        private Label idLbl;
        private Label nomelbl;
        private Label lblPreco;
        private Button btnSalvar;
        private Button btnExcluir;
        private DataGridView inforacoesPizza;
        private DataGridView dtgPizzas;
        private Button btnLimpar;
    }
}
