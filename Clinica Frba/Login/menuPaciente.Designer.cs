namespace Clinica_Frba.Login
{
    partial class menuPaciente
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.btComprar = new System.Windows.Forms.Button();
            this.btPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(12, 76);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(137, 41);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar Turno";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btComprar
            // 
            this.btComprar.Location = new System.Drawing.Point(12, 19);
            this.btComprar.Name = "btComprar";
            this.btComprar.Size = new System.Drawing.Size(137, 41);
            this.btComprar.TabIndex = 2;
            this.btComprar.Text = "Comprar Bono";
            this.btComprar.UseVisualStyleBackColor = true;
            this.btComprar.Click += new System.EventHandler(this.btComprar_Click);
            // 
            // btPedido
            // 
            this.btPedido.Location = new System.Drawing.Point(12, 133);
            this.btPedido.Name = "btPedido";
            this.btPedido.Size = new System.Drawing.Size(137, 41);
            this.btPedido.TabIndex = 4;
            this.btPedido.Text = "Pedir Turno";
            this.btPedido.UseVisualStyleBackColor = true;
            this.btPedido.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 192);
            this.Controls.Add(this.btPedido);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btComprar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "menuPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuPaciente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menuPaciente_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btComprar;
        private System.Windows.Forms.Button btPedido;
    }
}