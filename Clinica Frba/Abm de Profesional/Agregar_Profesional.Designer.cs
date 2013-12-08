namespace Clinica_Frba.Abm_de_Profesional
{
    partial class Agregar_Profesional
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
            this.label12 = new System.Windows.Forms.Label();
            this.Matriculatxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TipoDoctxt = new System.Windows.Forms.ComboBox();
            this.Clavetxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Sexotxt = new System.Windows.Forms.ComboBox();
            this.Especialtxt = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaNactxt = new System.Windows.Forms.TextBox();
            this.Mailtxt = new System.Windows.Forms.TextBox();
            this.Teltxt = new System.Windows.Forms.TextBox();
            this.Directxt = new System.Windows.Forms.TextBox();
            this.Doctxt = new System.Windows.Forms.TextBox();
            this.Apellidotxt = new System.Windows.Forms.TextBox();
            this.Nombretxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 143;
            this.label12.Text = "Matricula";
            // 
            // Matriculatxt
            // 
            this.Matriculatxt.Location = new System.Drawing.Point(110, 332);
            this.Matriculatxt.Name = "Matriculatxt";
            this.Matriculatxt.Size = new System.Drawing.Size(100, 20);
            this.Matriculatxt.TabIndex = 10;
            this.Matriculatxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Matriculatxt_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 141;
            this.label10.Text = "*@*.com.xx";
            // 
            // TipoDoctxt
            // 
            this.TipoDoctxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoDoctxt.FormattingEnabled = true;
            this.TipoDoctxt.Items.AddRange(new object[] {
            "DNI",
            "LC",
            "CI"});
            this.TipoDoctxt.Location = new System.Drawing.Point(110, 92);
            this.TipoDoctxt.Name = "TipoDoctxt";
            this.TipoDoctxt.Size = new System.Drawing.Size(100, 21);
            this.TipoDoctxt.TabIndex = 3;
            // 
            // Clavetxt
            // 
            this.Clavetxt.Location = new System.Drawing.Point(110, 422);
            this.Clavetxt.Name = "Clavetxt";
            this.Clavetxt.Size = new System.Drawing.Size(100, 20);
            this.Clavetxt.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(66, 425);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 138;
            this.label14.Text = "Clave";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 397);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 137;
            this.label13.Text = "Username";
            // 
            // Usertxt
            // 
            this.Usertxt.Location = new System.Drawing.Point(110, 394);
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(100, 20);
            this.Usertxt.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 22);
            this.button2.TabIndex = 8;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sexotxt
            // 
            this.Sexotxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sexotxt.FormattingEnabled = true;
            this.Sexotxt.Items.AddRange(new object[] {
            "M",
            "F"});
            this.Sexotxt.Location = new System.Drawing.Point(110, 305);
            this.Sexotxt.Name = "Sexotxt";
            this.Sexotxt.Size = new System.Drawing.Size(100, 21);
            this.Sexotxt.TabIndex = 9;
            // 
            // Especialtxt
            // 
            this.Especialtxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Especialtxt.FormattingEnabled = true;
            this.Especialtxt.Items.AddRange(new object[] {
            "10000",
            "10002",
            "10004",
            "10005",
            "10006",
            "10007",
            "10008",
            "10009",
            "10010",
            "10014",
            "10015",
            "10016",
            "10017",
            "10018",
            "10020",
            "10022",
            "10023",
            "10024",
            "10025",
            "10026",
            "10027",
            "10028",
            "10029",
            "10030",
            "10031",
            "10032",
            "10033",
            "10035",
            "10037",
            "10038",
            "10042",
            "10047",
            "10048"});
            this.Especialtxt.Location = new System.Drawing.Point(110, 358);
            this.Especialtxt.Name = "Especialtxt";
            this.Especialtxt.Size = new System.Drawing.Size(100, 21);
            this.Especialtxt.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 132;
            this.label11.Text = "Especialidades";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 131;
            this.label9.Text = "Sexo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 130;
            this.label8.Text = "Fecha Nac";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 129;
            this.label7.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 128;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 127;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 126;
            this.label4.Text = "Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 125;
            this.label3.Text = "Tipo Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 124;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "Nombre";
            // 
            // FechaNactxt
            // 
            this.FechaNactxt.Location = new System.Drawing.Point(110, 270);
            this.FechaNactxt.Name = "FechaNactxt";
            this.FechaNactxt.ReadOnly = true;
            this.FechaNactxt.Size = new System.Drawing.Size(100, 20);
            this.FechaNactxt.TabIndex = 122;
            this.FechaNactxt.TabStop = false;
            // 
            // Mailtxt
            // 
            this.Mailtxt.Location = new System.Drawing.Point(110, 236);
            this.Mailtxt.Name = "Mailtxt";
            this.Mailtxt.Size = new System.Drawing.Size(100, 20);
            this.Mailtxt.TabIndex = 7;
            // 
            // Teltxt
            // 
            this.Teltxt.Location = new System.Drawing.Point(110, 203);
            this.Teltxt.Name = "Teltxt";
            this.Teltxt.Size = new System.Drawing.Size(100, 20);
            this.Teltxt.TabIndex = 6;
            this.Teltxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teltxt_KeyPress);
            // 
            // Directxt
            // 
            this.Directxt.Location = new System.Drawing.Point(110, 165);
            this.Directxt.Name = "Directxt";
            this.Directxt.Size = new System.Drawing.Size(100, 20);
            this.Directxt.TabIndex = 5;
            // 
            // Doctxt
            // 
            this.Doctxt.Location = new System.Drawing.Point(110, 127);
            this.Doctxt.Name = "Doctxt";
            this.Doctxt.Size = new System.Drawing.Size(100, 20);
            this.Doctxt.TabIndex = 4;
            this.Doctxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Doctxt_KeyPress);
            // 
            // Apellidotxt
            // 
            this.Apellidotxt.Location = new System.Drawing.Point(110, 58);
            this.Apellidotxt.Name = "Apellidotxt";
            this.Apellidotxt.Size = new System.Drawing.Size(100, 20);
            this.Apellidotxt.TabIndex = 2;
            this.Apellidotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apellidotxt_KeyPress);
            // 
            // Nombretxt
            // 
            this.Nombretxt.Location = new System.Drawing.Point(110, 23);
            this.Nombretxt.Name = "Nombretxt";
            this.Nombretxt.Size = new System.Drawing.Size(100, 20);
            this.Nombretxt.TabIndex = 1;
            this.Nombretxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombretxt_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Agregar_Profesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Matriculatxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TipoDoctxt);
            this.Controls.Add(this.Clavetxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Usertxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Sexotxt);
            this.Controls.Add(this.Especialtxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaNactxt);
            this.Controls.Add(this.Mailtxt);
            this.Controls.Add(this.Teltxt);
            this.Controls.Add(this.Directxt);
            this.Controls.Add(this.Doctxt);
            this.Controls.Add(this.Apellidotxt);
            this.Controls.Add(this.Nombretxt);
            this.Name = "Agregar_Profesional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar_Profesional";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Matriculatxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox TipoDoctxt;
        private System.Windows.Forms.TextBox Clavetxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Usertxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox Sexotxt;
        private System.Windows.Forms.ComboBox Especialtxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Mailtxt;
        private System.Windows.Forms.TextBox Teltxt;
        private System.Windows.Forms.TextBox Directxt;
        private System.Windows.Forms.TextBox Doctxt;
        private System.Windows.Forms.TextBox Apellidotxt;
        private System.Windows.Forms.TextBox Nombretxt;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox FechaNactxt;
    }
}