namespace Clinica_Frba.Listados_Estadisticos
{
    partial class Estadisticas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btEspMasBF = new System.Windows.Forms.Button();
            this.btAfiliadoBFvenc = new System.Windows.Forms.Button();
            this.btEspCanc = new System.Windows.Forms.Button();
            this.nSemestre = new System.Windows.Forms.NumericUpDown();
            this.dtpAño = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nSemestre)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Semestre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Año";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 39);
            this.button3.TabIndex = 13;
            this.button3.Text = "Afiliados con mas bonos utilizados no propios";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btEspMasBF
            // 
            this.btEspMasBF.Location = new System.Drawing.Point(12, 225);
            this.btEspMasBF.Name = "btEspMasBF";
            this.btEspMasBF.Size = new System.Drawing.Size(179, 39);
            this.btEspMasBF.TabIndex = 12;
            this.btEspMasBF.Text = "Especialidades con mas bono farmacia recetados";
            this.btEspMasBF.UseVisualStyleBackColor = true;
            this.btEspMasBF.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btAfiliadoBFvenc
            // 
            this.btAfiliadoBFvenc.Location = new System.Drawing.Point(12, 164);
            this.btAfiliadoBFvenc.Name = "btAfiliadoBFvenc";
            this.btAfiliadoBFvenc.Size = new System.Drawing.Size(179, 39);
            this.btAfiliadoBFvenc.TabIndex = 11;
            this.btAfiliadoBFvenc.Text = "Afiliados con mas bonos farmacia vencidos";
            this.btAfiliadoBFvenc.UseVisualStyleBackColor = true;
            this.btAfiliadoBFvenc.Click += new System.EventHandler(this.btAfiliadoBFvenc_Click_1);
            // 
            // btEspCanc
            // 
            this.btEspCanc.Location = new System.Drawing.Point(12, 104);
            this.btEspCanc.Name = "btEspCanc";
            this.btEspCanc.Size = new System.Drawing.Size(179, 39);
            this.btEspCanc.TabIndex = 10;
            this.btEspCanc.Text = "especialidades más canceladas";
            this.btEspCanc.UseVisualStyleBackColor = true;
            this.btEspCanc.Click += new System.EventHandler(this.btEspCanc_Click_1);
            // 
            // nSemestre
            // 
            this.nSemestre.Location = new System.Drawing.Point(67, 58);
            this.nSemestre.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nSemestre.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nSemestre.Name = "nSemestre";
            this.nSemestre.Size = new System.Drawing.Size(39, 20);
            this.nSemestre.TabIndex = 9;
            this.nSemestre.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpAño
            // 
            this.dtpAño.CustomFormat = "yyyy";
            this.dtpAño.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAño.Location = new System.Drawing.Point(44, 15);
            this.dtpAño.Name = "dtpAño";
            this.dtpAño.ShowUpDown = true;
            this.dtpAño.Size = new System.Drawing.Size(66, 20);
            this.dtpAño.TabIndex = 8;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 340);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btEspMasBF);
            this.Controls.Add(this.btAfiliadoBFvenc);
            this.Controls.Add(this.btEspCanc);
            this.Controls.Add(this.nSemestre);
            this.Controls.Add(this.dtpAño);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.nSemestre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btEspMasBF;
        private System.Windows.Forms.Button btAfiliadoBFvenc;
        private System.Windows.Forms.Button btEspCanc;
        private System.Windows.Forms.NumericUpDown nSemestre;
        private System.Windows.Forms.DateTimePicker dtpAño;
    }
}