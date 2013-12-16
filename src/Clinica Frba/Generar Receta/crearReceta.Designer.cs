namespace Clinica_Frba.Generar_Receta
{
    partial class crearReceta
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
            this.tbBF = new System.Windows.Forms.TextBox();
            this.tbMedicamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCargar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCant = new System.Windows.Forms.TextBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btSlect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBF
            // 
            this.tbBF.Location = new System.Drawing.Point(99, 25);
            this.tbBF.Name = "tbBF";
            this.tbBF.Size = new System.Drawing.Size(168, 20);
            this.tbBF.TabIndex = 0;
            // 
            // tbMedicamento
            // 
            this.tbMedicamento.Location = new System.Drawing.Point(99, 60);
            this.tbMedicamento.Name = "tbMedicamento";
            this.tbMedicamento.ReadOnly = true;
            this.tbMedicamento.Size = new System.Drawing.Size(168, 20);
            this.tbMedicamento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bono Farmacia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Medicamento";
            // 
            // btCargar
            // 
            this.btCargar.Location = new System.Drawing.Point(304, 176);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(75, 23);
            this.btCargar.TabIndex = 4;
            this.btCargar.Text = "Cargar";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad";
            // 
            // tbCant
            // 
            this.tbCant.Location = new System.Drawing.Point(99, 96);
            this.tbCant.Name = "tbCant";
            this.tbCant.Size = new System.Drawing.Size(168, 20);
            this.tbCant.TabIndex = 5;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(18, 176);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 7;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btSlect
            // 
            this.btSlect.Location = new System.Drawing.Point(277, 59);
            this.btSlect.Name = "btSlect";
            this.btSlect.Size = new System.Drawing.Size(91, 23);
            this.btSlect.TabIndex = 8;
            this.btSlect.Text = "Seleccionar...";
            this.btSlect.UseVisualStyleBackColor = true;
            this.btSlect.Click += new System.EventHandler(this.button3_Click);
            // 
            // crearReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 211);
            this.Controls.Add(this.btSlect);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCant);
            this.Controls.Add(this.btCargar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMedicamento);
            this.Controls.Add(this.tbBF);
            this.Name = "crearReceta";
            this.Text = "crearReceta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCant;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btSlect;
        public System.Windows.Forms.TextBox tbMedicamento;
    }
}