namespace e_Agenda_2._0.Fom.WinApp
{
    partial class TelaVisualizarFiltroCompromisso
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
            this.listCargos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnpesquisarContatos = new System.Windows.Forms.Button();
            this.textFiltroCargos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listCargos
            // 
            this.listCargos.FormattingEnabled = true;
            this.listCargos.ItemHeight = 15;
            this.listCargos.Location = new System.Drawing.Point(31, 107);
            this.listCargos.Name = "listCargos";
            this.listCargos.Size = new System.Drawing.Size(491, 259);
            this.listCargos.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cargo:";
            // 
            // btnpesquisarContatos
            // 
            this.btnpesquisarContatos.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnpesquisarContatos.Location = new System.Drawing.Point(421, 34);
            this.btnpesquisarContatos.Name = "btnpesquisarContatos";
            this.btnpesquisarContatos.Size = new System.Drawing.Size(101, 34);
            this.btnpesquisarContatos.TabIndex = 18;
            this.btnpesquisarContatos.Text = "Pesquisar";
            this.btnpesquisarContatos.UseVisualStyleBackColor = true;
            // 
            // textFiltroCargos
            // 
            this.textFiltroCargos.Location = new System.Drawing.Point(81, 43);
            this.textFiltroCargos.Name = "textFiltroCargos";
            this.textFiltroCargos.Size = new System.Drawing.Size(323, 23);
            this.textFiltroCargos.TabIndex = 19;
            // 
            // TelaVisualizarFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 395);
            this.Controls.Add(this.textFiltroCargos);
            this.Controls.Add(this.btnpesquisarContatos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listCargos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaVisualizarFiltro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contatos Com FIltro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listCargos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnpesquisarContatos;
        private System.Windows.Forms.TextBox textFiltroCargos;
    }
}