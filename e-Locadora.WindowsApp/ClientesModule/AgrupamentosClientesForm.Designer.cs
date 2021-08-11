
namespace e_Locadora.WindowsApp.ClientesModule
{
    partial class AgrupamentosClientesForm
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
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbCpf = new System.Windows.Forms.RadioButton();
            this.rbCnpj = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(28, 27);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(192, 17);
            this.rbTodos.TabIndex = 0;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Visualizar sem nehum Agrupamento";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // rbCpf
            // 
            this.rbCpf.AutoSize = true;
            this.rbCpf.Location = new System.Drawing.Point(28, 60);
            this.rbCpf.Name = "rbCpf";
            this.rbCpf.Size = new System.Drawing.Size(236, 17);
            this.rbCpf.TabIndex = 1;
            this.rbCpf.TabStop = true;
            this.rbCpf.Text = "Visualizar Apenas Clientes Cadastrados(CPF)";
            this.rbCpf.UseVisualStyleBackColor = true;
            // 
            // rbCnpj
            // 
            this.rbCnpj.AutoSize = true;
            this.rbCnpj.Location = new System.Drawing.Point(28, 93);
            this.rbCnpj.Name = "rbCnpj";
            this.rbCnpj.Size = new System.Drawing.Size(275, 17);
            this.rbCnpj.TabIndex = 2;
            this.rbCnpj.TabStop = true;
            this.rbCnpj.Text = "Visualizar Empressas Cadastras como Clientes(CNPJ)";
            this.rbCnpj.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(226, 142);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(145, 142);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 9;
            this.btnGravar.Text = "Filtrar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // AgrupamentosClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 177);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.rbCnpj);
            this.Controls.Add(this.rbCpf);
            this.Controls.Add(this.rbTodos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgrupamentosClientesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Agrupamento de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbCpf;
        private System.Windows.Forms.RadioButton rbCnpj;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
    }
}