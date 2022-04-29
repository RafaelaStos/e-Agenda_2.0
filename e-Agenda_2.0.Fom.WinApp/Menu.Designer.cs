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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnContatos = new System.Windows.Forms.Button();
            this.btnTarefa = new System.Windows.Forms.Button();
            this.btnCompromisso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::e_Agenda_2._0.Fom.WinApp.Properties.Resources.reuniao_de_equipe_como_fazer_1024x538_1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(562, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnContatos
            // 
            this.btnContatos.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContatos.Image = global::e_Agenda_2._0.Fom.WinApp.Properties.Resources.icons8_gestão_de_desenvolvimento_comercial_30;
            this.btnContatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContatos.Location = new System.Drawing.Point(385, 111);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(126, 53);
            this.btnContatos.TabIndex = 4;
            this.btnContatos.Text = "Contatos";
            this.btnContatos.UseVisualStyleBackColor = true;
            // 
            // btnTarefa
            // 
            this.btnTarefa.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTarefa.Image = global::e_Agenda_2._0.Fom.WinApp.Properties.Resources.icons8_lista_24;
            this.btnTarefa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTarefa.Location = new System.Drawing.Point(43, 111);
            this.btnTarefa.Name = "btnTarefa";
            this.btnTarefa.Size = new System.Drawing.Size(120, 53);
            this.btnTarefa.TabIndex = 5;
            this.btnTarefa.Text = "Tarefas";
            this.btnTarefa.UseVisualStyleBackColor = true;
            this.btnTarefa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCompromisso
            // 
            this.btnCompromisso.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompromisso.Image = global::e_Agenda_2._0.Fom.WinApp.Properties.Resources.icons8_relógio_24;
            this.btnCompromisso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompromisso.Location = new System.Drawing.Point(200, 111);
            this.btnCompromisso.Name = "btnCompromisso";
            this.btnCompromisso.Size = new System.Drawing.Size(145, 53);
            this.btnCompromisso.TabIndex = 6;
            this.btnCompromisso.Text = "Compromissos";
            this.btnCompromisso.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(564, 299);
            this.Controls.Add(this.btnCompromisso);
            this.Controls.Add(this.btnTarefa);
            this.Controls.Add(this.btnContatos);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnContatos;
        private System.Windows.Forms.Button btnTarefa;
        private System.Windows.Forms.Button btnCompromisso;
    }
}
