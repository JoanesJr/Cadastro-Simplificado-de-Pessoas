namespace CADASTROPESSOA
{
    partial class Acoes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcAcoes = new System.Windows.Forms.TabControl();
            this.tpPessoa = new System.Windows.Forms.TabPage();
            this.mtxtRG = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbReligiao = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gpSexp = new System.Windows.Forms.GroupBox();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.mTxtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpEndereco = new System.Windows.Forms.TabPage();
            this.cbUf = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tpContato = new System.Windows.Forms.TabPage();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.mtbNumero = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lvlErrors = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tcAcoes.SuspendLayout();
            this.tpPessoa.SuspendLayout();
            this.gpSexp.SuspendLayout();
            this.tpEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.tpContato.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAcoes
            // 
            this.tcAcoes.Controls.Add(this.tpPessoa);
            this.tcAcoes.Controls.Add(this.tpEndereco);
            this.tcAcoes.Controls.Add(this.tpContato);
            this.tcAcoes.Location = new System.Drawing.Point(0, 19);
            this.tcAcoes.Name = "tcAcoes";
            this.tcAcoes.SelectedIndex = 0;
            this.tcAcoes.Size = new System.Drawing.Size(800, 389);
            this.tcAcoes.TabIndex = 0;
            // 
            // tpPessoa
            // 
            this.tpPessoa.Controls.Add(this.lblId);
            this.tpPessoa.Controls.Add(this.mtxtRG);
            this.tpPessoa.Controls.Add(this.label12);
            this.tpPessoa.Controls.Add(this.mtxtCPF);
            this.tpPessoa.Controls.Add(this.label11);
            this.tpPessoa.Controls.Add(this.cbReligiao);
            this.tpPessoa.Controls.Add(this.label10);
            this.tpPessoa.Controls.Add(this.gpSexp);
            this.tpPessoa.Controls.Add(this.mTxtNascimento);
            this.tpPessoa.Controls.Add(this.label2);
            this.tpPessoa.Controls.Add(this.txtNome);
            this.tpPessoa.Controls.Add(this.label1);
            this.tpPessoa.Location = new System.Drawing.Point(4, 22);
            this.tpPessoa.Name = "tpPessoa";
            this.tpPessoa.Padding = new System.Windows.Forms.Padding(3);
            this.tpPessoa.Size = new System.Drawing.Size(792, 363);
            this.tpPessoa.TabIndex = 0;
            this.tpPessoa.Text = "Pessoa";
            this.tpPessoa.UseVisualStyleBackColor = true;
            // 
            // mtxtRG
            // 
            this.mtxtRG.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtRG.Location = new System.Drawing.Point(481, 78);
            this.mtxtRG.Mask = "00.000.000-99";
            this.mtxtRG.Name = "mtxtRG";
            this.mtxtRG.Size = new System.Drawing.Size(123, 23);
            this.mtxtRG.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(424, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "RG:";
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCPF.Location = new System.Drawing.Point(138, 75);
            this.mtxtCPF.Mask = "000.000.000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(161, 23);
            this.mtxtCPF.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "CPF:";
            // 
            // cbReligiao
            // 
            this.cbReligiao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReligiao.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReligiao.FormattingEnabled = true;
            this.cbReligiao.Items.AddRange(new object[] {
            "Católico",
            "Protestante",
            "Evangelico",
            "Adventista",
            "Espirita",
            "Nenhuma"});
            this.cbReligiao.Location = new System.Drawing.Point(139, 145);
            this.cbReligiao.Name = "cbReligiao";
            this.cbReligiao.Size = new System.Drawing.Size(160, 24);
            this.cbReligiao.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Religião";
            // 
            // gpSexp
            // 
            this.gpSexp.Controls.Add(this.rbFeminino);
            this.gpSexp.Controls.Add(this.rbMasculino);
            this.gpSexp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpSexp.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSexp.Location = new System.Drawing.Point(187, 193);
            this.gpSexp.Name = "gpSexp";
            this.gpSexp.Size = new System.Drawing.Size(417, 140);
            this.gpSexp.TabIndex = 5;
            this.gpSexp.TabStop = false;
            this.gpSexp.Text = "Sexo:";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFeminino.Location = new System.Drawing.Point(294, 67);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 20);
            this.rbFeminino.TabIndex = 1;
            this.rbFeminino.Text = "Femino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.Location = new System.Drawing.Point(55, 67);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(83, 20);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // mTxtNascimento
            // 
            this.mTxtNascimento.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtNascimento.Location = new System.Drawing.Point(547, 145);
            this.mTxtNascimento.Mask = "00/00/0000";
            this.mTxtNascimento.Name = "mTxtNascimento";
            this.mTxtNascimento.Size = new System.Drawing.Size(81, 23);
            this.mTxtNascimento.TabIndex = 3;
            this.mTxtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Nascimento:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(138, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(630, 23);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tpEndereco
            // 
            this.tpEndereco.Controls.Add(this.cbUf);
            this.tpEndereco.Controls.Add(this.txtCidade);
            this.tpEndereco.Controls.Add(this.txtBairro);
            this.tpEndereco.Controls.Add(this.nudNumero);
            this.tpEndereco.Controls.Add(this.txtRua);
            this.tpEndereco.Controls.Add(this.label7);
            this.tpEndereco.Controls.Add(this.label6);
            this.tpEndereco.Controls.Add(this.label5);
            this.tpEndereco.Controls.Add(this.label4);
            this.tpEndereco.Controls.Add(this.label3);
            this.tpEndereco.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpEndereco.Location = new System.Drawing.Point(4, 22);
            this.tpEndereco.Name = "tpEndereco";
            this.tpEndereco.Padding = new System.Windows.Forms.Padding(3);
            this.tpEndereco.Size = new System.Drawing.Size(792, 363);
            this.tpEndereco.TabIndex = 1;
            this.tpEndereco.Text = "Endereço";
            this.tpEndereco.UseVisualStyleBackColor = true;
            // 
            // cbUf
            // 
            this.cbUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUf.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUf.FormattingEnabled = true;
            this.cbUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            ""});
            this.cbUf.Location = new System.Drawing.Point(344, 208);
            this.cbUf.Name = "cbUf";
            this.cbUf.Size = new System.Drawing.Size(121, 24);
            this.cbUf.TabIndex = 9;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(459, 108);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(268, 23);
            this.txtCidade.TabIndex = 8;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(71, 108);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(268, 23);
            this.txtBairro.TabIndex = 7;
            // 
            // nudNumero
            // 
            this.nudNumero.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumero.Location = new System.Drawing.Point(471, 18);
            this.nudNumero.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(126, 23);
            this.nudNumero.TabIndex = 6;
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(71, 19);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(268, 23);
            this.txtRua.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Bairro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rua:";
            // 
            // tpContato
            // 
            this.tpContato.Controls.Add(this.cbTipo);
            this.tpContato.Controls.Add(this.mtbNumero);
            this.tpContato.Controls.Add(this.label9);
            this.tpContato.Controls.Add(this.label8);
            this.tpContato.Location = new System.Drawing.Point(4, 22);
            this.tpContato.Name = "tpContato";
            this.tpContato.Size = new System.Drawing.Size(792, 363);
            this.tpContato.TabIndex = 2;
            this.tpContato.Text = "Contato";
            this.tpContato.UseVisualStyleBackColor = true;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "CEL",
            "COM",
            "RES"});
            this.cbTipo.Location = new System.Drawing.Point(80, 22);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 24);
            this.cbTipo.TabIndex = 4;
            // 
            // mtbNumero
            // 
            this.mtbNumero.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNumero.Location = new System.Drawing.Point(80, 70);
            this.mtbNumero.Mask = "(99) 00000-0000";
            this.mtbNumero.Name = "mtbNumero";
            this.mtbNumero.Size = new System.Drawing.Size(105, 23);
            this.mtbNumero.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Número:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tipo";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(210, 11);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 1;
            // 
            // lvlErrors
            // 
            this.lvlErrors.AutoSize = true;
            this.lvlErrors.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlErrors.ForeColor = System.Drawing.Color.Red;
            this.lvlErrors.Location = new System.Drawing.Point(282, 11);
            this.lvlErrors.Name = "lvlErrors";
            this.lvlErrors.Size = new System.Drawing.Size(0, 15);
            this.lvlErrors.TabIndex = 12;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(11, 248);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 12;
            this.lblId.Visible = false;
            // 
            // Acoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvlErrors);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.tcAcoes);
            this.Name = "Acoes";
            this.Size = new System.Drawing.Size(800, 411);
            this.tcAcoes.ResumeLayout(false);
            this.tpPessoa.ResumeLayout(false);
            this.tpPessoa.PerformLayout();
            this.gpSexp.ResumeLayout(false);
            this.gpSexp.PerformLayout();
            this.tpEndereco.ResumeLayout(false);
            this.tpEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.tpContato.ResumeLayout(false);
            this.tpContato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.GroupBox gpSexp;
        public System.Windows.Forms.MaskedTextBox mTxtNascimento;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtRua;
        public System.Windows.Forms.ComboBox cbUf;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.NumericUpDown nudNumero;
        public System.Windows.Forms.MaskedTextBox mtbNumero;
        public System.Windows.Forms.MaskedTextBox mtxtRG;
        public System.Windows.Forms.MaskedTextBox mtxtCPF;
        public System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblError;
        public System.Windows.Forms.Label lvlErrors;
        public System.Windows.Forms.RadioButton rbFeminino;
        public System.Windows.Forms.RadioButton rbMasculino;
        public System.Windows.Forms.ComboBox cbReligiao;
        public System.Windows.Forms.TabPage tpPessoa;
        public System.Windows.Forms.TabPage tpEndereco;
        public System.Windows.Forms.TabPage tpContato;
        public System.Windows.Forms.TabControl tcAcoes;
        public System.Windows.Forms.Label lblId;
    }
}
