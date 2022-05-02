namespace e_Agenda_2._0.Fom.WinApp
{
    partial class TelaCompromisso
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
            this.tabCompromisso = new System.Windows.Forms.TabControl();
            this.tabTarefasPendentes = new System.Windows.Forms.TabPage();
            this.tabTarefasConcluidas = new System.Windows.Forms.TabPage();
            this.bntExcluirCompromisso = new System.Windows.Forms.Button();
            this.bntEditarCompromisso = new System.Windows.Forms.Button();
            this.btnAdicionarCompromisso = new System.Windows.Forms.Button();
            this.btnAtualizarCompromisso = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabCompromisso.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCompromisso
            // 
            this.tabCompromisso.Controls.Add(this.tabTarefasPendentes);
            this.tabCompromisso.Controls.Add(this.tabTarefasConcluidas);
            this.tabCompromisso.Location = new System.Drawing.Point(34, 106);
            this.tabCompromisso.Name = "tabCompromisso";
            this.tabCompromisso.SelectedIndex = 0;
            this.tabCompromisso.Size = new System.Drawing.Size(605, 313);
            this.tabCompromisso.TabIndex = 12;
            // 
            // tabTarefasPendentes
            // 
            this.tabTarefasPendentes.Location = new System.Drawing.Point(4, 24);
            this.tabTarefasPendentes.Name = "tabTarefasPendentes";
            this.tabTarefasPendentes.Padding = new System.Windows.Forms.Padding(3);
            this.tabTarefasPendentes.Size = new System.Drawing.Size(597, 285);
            this.tabTarefasPendentes.TabIndex = 0;
            this.tabTarefasPendentes.Text = "Compromisso Pendentes";
            this.tabTarefasPendentes.UseVisualStyleBackColor = true;
            // 
            // tabTarefasConcluidas
            // 
            this.tabTarefasConcluidas.Location = new System.Drawing.Point(4, 24);
            this.tabTarefasConcluidas.Name = "tabTarefasConcluidas";
            this.tabTarefasConcluidas.Padding = new System.Windows.Forms.Padding(3);
            this.tabTarefasConcluidas.Size = new System.Drawing.Size(597, 285);
            this.tabTarefasConcluidas.TabIndex = 1;
            this.tabTarefasConcluidas.Text = "Compromisso Concluidas";
            this.tabTarefasConcluidas.UseVisualStyleBackColor = true;
            // 
            // bntExcluirCompromisso
            // 
            this.bntExcluirCompromisso.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntExcluirCompromisso.Location = new System.Drawing.Point(281, 31);
            this.bntExcluirCompromisso.Name = "bntExcluirCompromisso";
            this.bntExcluirCompromisso.Size = new System.Drawing.Size(98, 53);
            this.bntExcluirCompromisso.TabIndex = 9;
            this.bntExcluirCompromisso.Text = "Excluir";
            this.bntExcluirCompromisso.UseVisualStyleBackColor = true;
            // 
            // bntEditarCompromisso
            // 
            this.bntEditarCompromisso.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntEditarCompromisso.Location = new System.Drawing.Point(157, 31);
            this.bntEditarCompromisso.Name = "bntEditarCompromisso";
            this.bntEditarCompromisso.Size = new System.Drawing.Size(98, 53);
            this.bntEditarCompromisso.TabIndex = 8;
            this.bntEditarCompromisso.Text = "Editar";
            this.bntEditarCompromisso.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarCompromisso
            // 
            this.btnAdicionarCompromisso.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionarCompromisso.Location = new System.Drawing.Point(38, 31);
            this.btnAdicionarCompromisso.Name = "btnAdicionarCompromisso";
            this.btnAdicionarCompromisso.Size = new System.Drawing.Size(98, 53);
            this.btnAdicionarCompromisso.TabIndex = 7;
            this.btnAdicionarCompromisso.Text = "Acicionar";
            this.btnAdicionarCompromisso.UseVisualStyleBackColor = true;
            this.btnAdicionarCompromisso.Click += new System.EventHandler(this.btnAdicionarCompromisso_Click);
            // 
            // btnAtualizarCompromisso
            // 
            this.btnAtualizarCompromisso.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizarCompromisso.Location = new System.Drawing.Point(408, 31);
            this.btnAtualizarCompromisso.Name = "btnAtualizarCompromisso";
            this.btnAtualizarCompromisso.Size = new System.Drawing.Size(98, 53);
            this.btnAtualizarCompromisso.TabIndex = 10;
            this.btnAtualizarCompromisso.Text = "Atualizar";
            this.btnAtualizarCompromisso.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(537, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "Filtar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TelaCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabCompromisso);
            this.Controls.Add(this.btnAtualizarCompromisso);
            this.Controls.Add(this.bntExcluirCompromisso);
            this.Controls.Add(this.bntEditarCompromisso);
            this.Controls.Add(this.btnAdicionarCompromisso);
            this.MinimizeBox = false;
            this.Name = "TelaCompromisso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Agenda Compromisso";
            this.tabCompromisso.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCompromisso;
        private System.Windows.Forms.TabPage tabTarefasPendentes;
        private System.Windows.Forms.TabPage tabTarefasConcluidas;
        private System.Windows.Forms.Button bntExcluirCompromisso;
        private System.Windows.Forms.Button bntEditarCompromisso;
        private System.Windows.Forms.Button btnAdicionarCompromisso;
        private System.Windows.Forms.Button btnAtualizarCompromisso;
        private System.Windows.Forms.Button button1;
    }
}