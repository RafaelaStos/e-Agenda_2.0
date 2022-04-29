namespace e_Agenda_2._0.Fom.WinApp
{
    partial class Menu
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
            this.btnTarefas = new System.Windows.Forms.Button();
            this.btnContatos = new System.Windows.Forms.Button();
            this.btnCompromissos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTarefas
            // 
            this.btnTarefas.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTarefas.Location = new System.Drawing.Point(53, 51);
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.Size = new System.Drawing.Size(98, 53);
            this.btnTarefas.TabIndex = 0;
            this.btnTarefas.Text = "Tarefas";
            this.btnTarefas.UseVisualStyleBackColor = true;
            // 
            // btnContatos
            // 
            this.btnContatos.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContatos.Location = new System.Drawing.Point(52, 152);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(98, 53);
            this.btnContatos.TabIndex = 1;
            this.btnContatos.Text = "Contatos";
            this.btnContatos.UseVisualStyleBackColor = true;
            // 
            // btnCompromissos
            // 
            this.btnCompromissos.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompromissos.Location = new System.Drawing.Point(52, 254);
            this.btnCompromissos.Name = "btnCompromissos";
            this.btnCompromissos.Size = new System.Drawing.Size(98, 53);
            this.btnCompromissos.TabIndex = 2;
            this.btnCompromissos.Text = "Compromissos";
            this.btnCompromissos.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(223, 349);
            this.Controls.Add(this.btnCompromissos);
            this.Controls.Add(this.btnContatos);
            this.Controls.Add(this.btnTarefas);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.Text = "e-Agenda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTarefas;
        private System.Windows.Forms.Button btnContatos;
        private System.Windows.Forms.Button btnCompromissos;
    }
}
