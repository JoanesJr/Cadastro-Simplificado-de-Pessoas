namespace CADASTROPESSOA
{
    partial class TelaPrincipal
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
            this.dgvTelaPrincipal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelaPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTelaPrincipal
            // 
            this.dgvTelaPrincipal.AllowUserToAddRows = false;
            this.dgvTelaPrincipal.AllowUserToDeleteRows = false;
            this.dgvTelaPrincipal.AllowUserToOrderColumns = true;
            this.dgvTelaPrincipal.BackgroundColor = System.Drawing.Color.White;
            this.dgvTelaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTelaPrincipal.Location = new System.Drawing.Point(0, 0);
            this.dgvTelaPrincipal.Name = "dgvTelaPrincipal";
            this.dgvTelaPrincipal.ReadOnly = true;
            this.dgvTelaPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelaPrincipal.Size = new System.Drawing.Size(800, 411);
            this.dgvTelaPrincipal.TabIndex = 0;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTelaPrincipal);
            this.Name = "TelaPrincipal";
            this.Size = new System.Drawing.Size(800, 411);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelaPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvTelaPrincipal;
    }
}
