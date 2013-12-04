namespace Clinica_Frba.Abm_de_Afiliado
{
    partial class Agregar_Hijo_Familiar
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
            this.label10 = new System.Windows.Forms.Label();
            this.TipoDoctxt = new System.Windows.Forms.ComboBox();
            this.Clavetxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.PlanMedtxt = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Sexotxt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FechaNactxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Teltxt = new System.Windows.Forms.TextBox();
            this.Mailtxt = new System.Windows.Forms.TextBox();
            this.NroDoctxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Apellidotxt = new System.Windows.Forms.TextBox();
            this.Nombretxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(222, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 155;
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
            this.TipoDoctxt.Location = new System.Drawing.Point(116, 99);
            this.TipoDoctxt.Name = "TipoDoctxt";
            this.TipoDoctxt.Size = new System.Drawing.Size(100, 21);
            this.TipoDoctxt.TabIndex = 154;
            this.TipoDoctxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TipoDoctxt_KeyPress);
            // 
            // Clavetxt
            // 
            this.Clavetxt.Location = new System.Drawing.Point(116, 406);
            this.Clavetxt.Name = "Clavetxt";
            this.Clavetxt.Size = new System.Drawing.Size(100, 20);
            this.Clavetxt.TabIndex = 153;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 152;
            this.label9.Text = "Clave";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 374);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 151;
            this.label13.Text = "Username";
            // 
            // Usertxt
            // 
            this.Usertxt.Location = new System.Drawing.Point(116, 371);
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(100, 20);
            this.Usertxt.TabIndex = 150;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 149;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 148;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 147;
            this.label11.Text = "Plan Médico";
            // 
            // PlanMedtxt
            // 
            this.PlanMedtxt.AutoCompleteCustomSource.AddRange(new string[] {
            "555555",
            "555556",
            "555557",
            "555558",
            "555559"});
            this.PlanMedtxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlanMedtxt.FormattingEnabled = true;
            this.PlanMedtxt.Items.AddRange(new object[] {
            "555559",
            "555556",
            "555558",
            "555555",
            "555557"});
            this.PlanMedtxt.Location = new System.Drawing.Point(116, 333);
            this.PlanMedtxt.Name = "PlanMedtxt";
            this.PlanMedtxt.Size = new System.Drawing.Size(100, 21);
            this.PlanMedtxt.TabIndex = 138;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 146;
            this.label8.Text = "Sexo";
            // 
            // Sexotxt
            // 
            this.Sexotxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sexotxt.FormattingEnabled = true;
            this.Sexotxt.Items.AddRange(new object[] {
            "M",
            "F"});
            this.Sexotxt.Location = new System.Drawing.Point(116, 291);
            this.Sexotxt.Name = "Sexotxt";
            this.Sexotxt.Size = new System.Drawing.Size(100, 21);
            this.Sexotxt.TabIndex = 137;
            this.Sexotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sexotxt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 145;
            this.label7.Text = "Fecha Nacimiento";
            // 
            // FechaNactxt
            // 
            this.FechaNactxt.Location = new System.Drawing.Point(116, 254);
            this.FechaNactxt.Name = "FechaNactxt";
            this.FechaNactxt.ReadOnly = true;
            this.FechaNactxt.Size = new System.Drawing.Size(100, 20);
            this.FechaNactxt.TabIndex = 136;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 144;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 143;
            this.label5.Text = "Mail";
            // 
            // Teltxt
            // 
            this.Teltxt.Location = new System.Drawing.Point(116, 174);
            this.Teltxt.Name = "Teltxt";
            this.Teltxt.Size = new System.Drawing.Size(100, 20);
            this.Teltxt.TabIndex = 134;
            this.Teltxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teltxt_KeyPress);
            // 
            // Mailtxt
            // 
            this.Mailtxt.Location = new System.Drawing.Point(116, 215);
            this.Mailtxt.Name = "Mailtxt";
            this.Mailtxt.Size = new System.Drawing.Size(100, 20);
            this.Mailtxt.TabIndex = 135;
            // 
            // NroDoctxt
            // 
            this.NroDoctxt.Location = new System.Drawing.Point(116, 137);
            this.NroDoctxt.Name = "NroDoctxt";
            this.NroDoctxt.Size = new System.Drawing.Size(100, 20);
            this.NroDoctxt.TabIndex = 133;
            this.NroDoctxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NroDoctxt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 142;
            this.label4.Text = "Nro de Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 141;
            this.label3.Text = "Tipo de Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 140;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 139;
            this.label1.Text = "Nombre";
            // 
            // Apellidotxt
            // 
            this.Apellidotxt.Location = new System.Drawing.Point(116, 61);
            this.Apellidotxt.Name = "Apellidotxt";
            this.Apellidotxt.Size = new System.Drawing.Size(100, 20);
            this.Apellidotxt.TabIndex = 132;
            this.Apellidotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apellidotxt_KeyPress);
            // 
            // Nombretxt
            // 
            this.Nombretxt.Location = new System.Drawing.Point(116, 22);
            this.Nombretxt.Name = "Nombretxt";
            this.Nombretxt.Size = new System.Drawing.Size(100, 20);
            this.Nombretxt.TabIndex = 131;
            this.Nombretxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombretxt_KeyPress);
            // 
            // Agregar_Hijo_Familiar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 485);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TipoDoctxt);
            this.Controls.Add(this.Clavetxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Usertxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PlanMedtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Sexotxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FechaNactxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Teltxt);
            this.Controls.Add(this.Mailtxt);
            this.Controls.Add(this.NroDoctxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Apellidotxt);
            this.Controls.Add(this.Nombretxt);
            this.Name = "Agregar_Hijo_Familiar";
            this.Text = "Agregar_Hijo_Familiar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox TipoDoctxt;
        private System.Windows.Forms.TextBox Clavetxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Usertxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox PlanMedtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Sexotxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FechaNactxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Teltxt;
        private System.Windows.Forms.TextBox Mailtxt;
        private System.Windows.Forms.TextBox NroDoctxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Apellidotxt;
        private System.Windows.Forms.TextBox Nombretxt;

    }
}