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
            this.components = new System.ComponentModel.Container();
            this.cbSintomas = new System.Windows.Forms.ComboBox();
            this.btSintomas = new System.Windows.Forms.Button();
            this.btEnfermedad = new System.Windows.Forms.Button();
            this.cbEnfermedad = new System.Windows.Forms.ComboBox();
            this.gD2C2013DataSet2 = new Clinica_Frba.GD2C2013DataSet2();
            this.enfermedadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enfermedadesTableAdapter = new Clinica_Frba.GD2C2013DataSet2TableAdapters.EnfermedadesTableAdapter();
            this.gD2C2013DataSet3 = new Clinica_Frba.GD2C2013DataSet3();
            this.sintomasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sintomasTableAdapter = new Clinica_Frba.GD2C2013DataSet3TableAdapters.SintomasTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2013DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enfermedadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2013DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sintomasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSintomas
            // 
            this.cbSintomas.DataSource = this.sintomasBindingSource;
            this.cbSintomas.DisplayMember = "Id";
            this.cbSintomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSintomas.FormattingEnabled = true;
            this.cbSintomas.Location = new System.Drawing.Point(25, 44);
            this.cbSintomas.Name = "cbSintomas";
            this.cbSintomas.Size = new System.Drawing.Size(171, 21);
            this.cbSintomas.TabIndex = 7;
            // 
            // btSintomas
            // 
            this.btSintomas.Location = new System.Drawing.Point(220, 43);
            this.btSintomas.Name = "btSintomas";
            this.btSintomas.Size = new System.Drawing.Size(145, 23);
            this.btSintomas.TabIndex = 8;
            this.btSintomas.Text = "Agregar Sintomas";
            this.btSintomas.UseVisualStyleBackColor = true;
            this.btSintomas.Click += new System.EventHandler(this.btSintomas_Click);
            // 
            // btEnfermedad
            // 
            this.btEnfermedad.Location = new System.Drawing.Point(220, 112);
            this.btEnfermedad.Name = "btEnfermedad";
            this.btEnfermedad.Size = new System.Drawing.Size(145, 23);
            this.btEnfermedad.TabIndex = 10;
            this.btEnfermedad.Text = "Agregar Enfermedad";
            this.btEnfermedad.UseVisualStyleBackColor = true;
            this.btEnfermedad.Click += new System.EventHandler(this.btEnfermedad_Click);
            // 
            // cbEnfermedad
            // 
            this.cbEnfermedad.DataSource = this.enfermedadesBindingSource;
            this.cbEnfermedad.DisplayMember = "Id";
            this.cbEnfermedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEnfermedad.FormattingEnabled = true;
            this.cbEnfermedad.Location = new System.Drawing.Point(25, 113);
            this.cbEnfermedad.Name = "cbEnfermedad";
            this.cbEnfermedad.Size = new System.Drawing.Size(171, 21);
            this.cbEnfermedad.TabIndex = 9;
            // 
            // gD2C2013DataSet2
            // 
            this.gD2C2013DataSet2.DataSetName = "GD2C2013DataSet2";
            this.gD2C2013DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enfermedadesBindingSource
            // 
            this.enfermedadesBindingSource.DataMember = "Enfermedades";
            this.enfermedadesBindingSource.DataSource = this.gD2C2013DataSet2;
            // 
            // enfermedadesTableAdapter
            // 
            this.enfermedadesTableAdapter.ClearBeforeFill = true;
            // 
            // gD2C2013DataSet3
            // 
            this.gD2C2013DataSet3.DataSetName = "GD2C2013DataSet3";
            this.gD2C2013DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sintomasBindingSource
            // 
            this.sintomasBindingSource.DataMember = "Sintomas";
            this.sintomasBindingSource.DataSource = this.gD2C2013DataSet3;
            // 
            // sintomasTableAdapter
            // 
            this.sintomasTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Terminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResulAtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 203);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEnfermedad);
            this.Controls.Add(this.cbEnfermedad);
            this.Controls.Add(this.btSintomas);
            this.Controls.Add(this.cbSintomas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ResulAtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrese síntomas";
            this.Load += new System.EventHandler(this.ResulAtForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2013DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enfermedadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2013DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sintomasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSintomas;
        private System.Windows.Forms.Button btSintomas;
        private System.Windows.Forms.Button btEnfermedad;
        private System.Windows.Forms.ComboBox cbEnfermedad;
        private GD2C2013DataSet2 gD2C2013DataSet2;
        private System.Windows.Forms.BindingSource enfermedadesBindingSource;
        private Clinica_Frba.GD2C2013DataSet2TableAdapters.EnfermedadesTableAdapter enfermedadesTableAdapter;
        private GD2C2013DataSet3 gD2C2013DataSet3;
        private System.Windows.Forms.BindingSource sintomasBindingSource;
        private Clinica_Frba.GD2C2013DataSet3TableAdapters.SintomasTableAdapter sintomasTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;

    }
}