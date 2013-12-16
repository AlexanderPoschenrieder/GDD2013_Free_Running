namespace Clinica_Frba.Abm_de_Profesional
{
    partial class Agregar_Especilidades
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
            this.ListaDeEspecialidades = new System.Windows.Forms.DataGridView();
            this.Especilidadestxt = new System.Windows.Forms.ComboBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDeEspecialidades)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaDeEspecialidades
            // 
            this.ListaDeEspecialidades.AllowUserToAddRows = false;
            this.ListaDeEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaDeEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero});
            this.ListaDeEspecialidades.Location = new System.Drawing.Point(53, 64);
            this.ListaDeEspecialidades.Name = "ListaDeEspecialidades";
            this.ListaDeEspecialidades.Size = new System.Drawing.Size(139, 173);
            this.ListaDeEspecialidades.TabIndex = 6;
            this.ListaDeEspecialidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Especialidad_CellContentClick);
            // 
            // Especilidadestxt
            // 
            this.Especilidadestxt.FormattingEnabled = true;
            this.Especilidadestxt.Items.AddRange(new object[] {
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
            this.Especilidadestxt.Location = new System.Drawing.Point(23, 22);
            this.Especilidadestxt.Name = "Especilidadestxt";
            this.Especilidadestxt.Size = new System.Drawing.Size(105, 21);
            this.Especilidadestxt.TabIndex = 5;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(150, 22);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 4;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Especialidad";
            this.Numero.Name = "Numero";
            // 
            // Agregar_Especilidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListaDeEspecialidades);
            this.Controls.Add(this.Especilidadestxt);
            this.Controls.Add(this.Agregar);
            this.Name = "Agregar_Especilidades";
            this.Text = "Agregar_Especilidades";
            this.Load += new System.EventHandler(this.Agregar_Especilidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaDeEspecialidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaDeEspecialidades;
        private System.Windows.Forms.ComboBox Especilidadestxt;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
    }
}