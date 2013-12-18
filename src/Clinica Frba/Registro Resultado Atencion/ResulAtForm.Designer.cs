namespace Clinica_Frba.Registro_Resultado_Atencion
{
    partial class ResulAtForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbSintomas = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEnfermedades = new System.Windows.Forms.RichTextBox();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escriba los sintomas del paciente";
            // 
            // tbSintomas
            // 
            this.tbSintomas.Location = new System.Drawing.Point(13, 30);
            this.tbSintomas.Name = "tbSintomas";
            this.tbSintomas.Size = new System.Drawing.Size(267, 83);
            this.tbSintomas.TabIndex = 3;
            this.tbSintomas.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enumere las enfermedades del paciente";
            // 
            // tbEnfermedades
            // 
            this.tbEnfermedades.Location = new System.Drawing.Point(12, 145);
            this.tbEnfermedades.Name = "tbEnfermedades";
            this.tbEnfermedades.Size = new System.Drawing.Size(267, 84);
            this.tbEnfermedades.TabIndex = 5;
            this.tbEnfermedades.Text = "";
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(204, 235);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(75, 23);
            this.botonAceptar.TabIndex = 6;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // ResulAtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.tbEnfermedades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSintomas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ResulAtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrese síntomas";
            this.Load += new System.EventHandler(this.ResulAtForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tbSintomas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbEnfermedades;
        private System.Windows.Forms.Button botonAceptar;
    }
}