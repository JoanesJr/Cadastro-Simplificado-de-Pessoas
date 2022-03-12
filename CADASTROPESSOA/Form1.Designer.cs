namespace CADASTROPESSOA
{
    partial class telaShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaShow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tstAdicionar = new System.Windows.Forms.ToolStripButton();
            this.tstEditar = new System.Windows.Forms.ToolStripButton();
            this.tstVisualizar = new System.Windows.Forms.ToolStripButton();
            this.tstExcluir = new System.Windows.Forms.ToolStripButton();
            this.tstSalvar = new System.Windows.Forms.ToolStripButton();
            this.tstCancelar = new System.Windows.Forms.ToolStripButton();
            this.tstEfetuarEdicao = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucAcoes = new CADASTROPESSOA.Acoes();
            this.ucView = new CADASTROPESSOA.TelaPrincipal();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstAdicionar,
            this.tstEditar,
            this.tstVisualizar,
            this.tstExcluir,
            this.tstSalvar,
            this.tstCancelar,
            this.tstEfetuarEdicao});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tstAdicionar
            // 
            this.tstAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tstAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("tstAdicionar.Image")));
            this.tstAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstAdicionar.Name = "tstAdicionar";
            this.tstAdicionar.Size = new System.Drawing.Size(23, 22);
            this.tstAdicionar.Text = "Adicionar";
            this.tstAdicionar.Click += new System.EventHandler(this.tstAdicionar_Click);
            // 
            // tstEditar
            // 
            this.tstEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tstEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstEditar.Image = ((System.Drawing.Image)(resources.GetObject("tstEditar.Image")));
            this.tstEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstEditar.Name = "tstEditar";
            this.tstEditar.Size = new System.Drawing.Size(23, 22);
            this.tstEditar.Text = "Editar";
            this.tstEditar.Click += new System.EventHandler(this.tstEditar_Click);
            // 
            // tstVisualizar
            // 
            this.tstVisualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tstVisualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("tstVisualizar.Image")));
            this.tstVisualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstVisualizar.Name = "tstVisualizar";
            this.tstVisualizar.Size = new System.Drawing.Size(23, 22);
            this.tstVisualizar.Text = "Visualizar";
            this.tstVisualizar.Click += new System.EventHandler(this.tstVisualizar_Click);
            // 
            // tstExcluir
            // 
            this.tstExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tstExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tstExcluir.Image")));
            this.tstExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstExcluir.Name = "tstExcluir";
            this.tstExcluir.Size = new System.Drawing.Size(23, 22);
            this.tstExcluir.Text = "Excluir";
            this.tstExcluir.Click += new System.EventHandler(this.tstExcluir_Click);
            // 
            // tstSalvar
            // 
            this.tstSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tstSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstSalvar.Enabled = false;
            this.tstSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tstSalvar.Image")));
            this.tstSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstSalvar.Name = "tstSalvar";
            this.tstSalvar.Size = new System.Drawing.Size(23, 22);
            this.tstSalvar.Text = "Salvar";
            this.tstSalvar.Click += new System.EventHandler(this.tstSalvar_Click);
            // 
            // tstCancelar
            // 
            this.tstCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstCancelar.Enabled = false;
            this.tstCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tstCancelar.Image")));
            this.tstCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstCancelar.Name = "tstCancelar";
            this.tstCancelar.Size = new System.Drawing.Size(23, 22);
            this.tstCancelar.Text = "Fechar";
            this.tstCancelar.Click += new System.EventHandler(this.tstCancelar_Click);
            // 
            // tstEfetuarEdicao
            // 
            this.tstEfetuarEdicao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstEfetuarEdicao.Image = ((System.Drawing.Image)(resources.GetObject("tstEfetuarEdicao.Image")));
            this.tstEfetuarEdicao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstEfetuarEdicao.Name = "tstEfetuarEdicao";
            this.tstEfetuarEdicao.Size = new System.Drawing.Size(23, 22);
            this.tstEfetuarEdicao.Text = "Efetuar Edição";
            this.tstEfetuarEdicao.Click += new System.EventHandler(this.tstEfetuarEdicao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "CADASTRO SIMPLIFICADO DE PESSOAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(661, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "JOANES JUNIOR";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 41);
            this.panel1.TabIndex = 5;
            // 
            // ucAcoes
            // 
            this.ucAcoes.Location = new System.Drawing.Point(-3, 12);
            this.ucAcoes.Name = "ucAcoes";
            this.ucAcoes.Size = new System.Drawing.Size(800, 411);
            this.ucAcoes.TabIndex = 7;
            // 
            // ucView
            // 
            this.ucView.Location = new System.Drawing.Point(-3, 27);
            this.ucView.Name = "ucView";
            this.ucView.Size = new System.Drawing.Size(800, 411);
            this.ucView.TabIndex = 6;
            // 
            // telaShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ucAcoes);
            this.Controls.Add(this.ucView);
            this.Name = "telaShow";
            this.Text = "Tela Principal";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tstAdicionar;
        private System.Windows.Forms.ToolStripButton tstEditar;
        private System.Windows.Forms.ToolStripButton tstVisualizar;
        private System.Windows.Forms.ToolStripButton tstExcluir;
        private System.Windows.Forms.ToolStripButton tstSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton tstCancelar;
        private TelaPrincipal ucView;
        private Acoes ucAcoes;
        public System.Windows.Forms.ToolStripButton tstEfetuarEdicao;
    }
}

