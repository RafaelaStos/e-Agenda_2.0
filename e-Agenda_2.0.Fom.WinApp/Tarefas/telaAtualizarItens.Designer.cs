namespace e_Agenda_2._0.Fom.WinApp
{
    partial class TelaAtualizarCompromisso
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
            this.checkedListBoxItens = new System.Windows.Forms.CheckedListBox();
            this.labelTitiloTarefa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxItens
            // 
            this.checkedListBoxItens.FormattingEnabled = true;
            this.checkedListBoxItens.Location = new System.Drawing.Point(12, 94);
            this.checkedListBoxItens.Name = "checkedListBoxItens";
            this.checkedListBoxItens.Size = new System.Drawing.Size(446, 256);
            this.checkedListBoxItens.TabIndex = 0;
            // 
            // labelTitiloTarefa
            // 
            this.labelTitiloTarefa.AutoSize = true;
            this.labelTitiloTarefa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitiloTarefa.Location = new System.Drawing.Point(80, 35);
            this.labelTitiloTarefa.Name = "labelTitiloTarefa";
            this.labelTitiloTarefa.Size = new System.Drawing.Size(82, 15);
            this.labelTitiloTarefa.TabIndex = 6;
            this.labelTitiloTarefa.Text = "[TituloTarefa]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tarefa:";
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGravar.Location = new System.Drawing.Point(227, 395);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(98, 43);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(360, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // telaAtualizarItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.labelTitiloTarefa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxItens);
            this.MaximizeBox = false;
            this.Name = "telaAtualizarItens";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Itens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxItens;
        private System.Windows.Forms.Label labelTitiloTarefa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button button1;
    }
}