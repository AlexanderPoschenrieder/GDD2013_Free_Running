namespace Clinica_Frba.Pedir_Turno
{
    partial class BusquedaProfesionalForm
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
            this.NombreProfTB = new System.Windows.Forms.TextBox();
            this.comboEspecialidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gridResultados = new System.Windows.Forms.DataGridView();
            this.SeleccionarButton = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NombreProfesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreProfTB
            // 
            this.NombreProfTB.Location = new System.Drawing.Point(13, 32);
            this.NombreProfTB.Name = "NombreProfTB";
            this.NombreProfTB.Size = new System.Drawing.Size(159, 20);
            this.NombreProfTB.TabIndex = 1;
            this.NombreProfTB.TextChanged += new System.EventHandler(this.NombreProfTB_TextChanged);
            // 
            // comboEspecialidad
            // 
            this.comboEspecialidad.FormattingEnabled = true;
            this.comboEspecialidad.Location = new System.Drawing.Point(13, 79);
            this.comboEspecialidad.Name = "comboEspecialidad";
            this.comboEspecialidad.Size = new System.Drawing.Size(159, 21);
            this.comboEspecialidad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione la especialidad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.botonBuscar);
            // 
            // gridResultados
            // 
            this.gridResultados.AllowUserToAddRows = false;
            this.gridResultados.AllowUserToDeleteRows = false;
            this.gridResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProfesional,
            this.Apellido,
            this.Id});
            this.gridResultados.Location = new System.Drawing.Point(13, 136);
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.ReadOnly = true;
            this.gridResultados.Size = new System.Drawing.Size(344, 118);
            this.gridResultados.TabIndex = 5;
            // 
            // SeleccionarButton
            // 
            this.SeleccionarButton.Location = new System.Drawing.Point(14, 260);
            this.SeleccionarButton.Name = "SeleccionarButton";
            this.SeleccionarButton.Size = new System.Drawing.Size(75, 23);
            this.SeleccionarButton.TabIndex = 6;
            this.SeleccionarButton.Text = "Seleccionar";
            this.SeleccionarButton.UseVisualStyleBackColor = true;
            
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(205, 106);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 7;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingrese el DNI";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(208, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NombreProfesional
            // 
            this.NombreProfesional.HeaderText = "Nombre";
            this.NombreProfesional.Name = "NombreProfesional";
            this.NombreProfesional.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // BusquedaProfesionalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 289);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.SeleccionarButton);
            this.Controls.Add(this.gridResultados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboEspecialidad);
            this.Controls.Add(this.NombreProfTB);
            this.Controls.Add(this.label1);
            this.Name = "BusquedaProfesionalForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreProfTB;
        private System.Windows.Forms.ComboBox comboEspecialidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridResultados;
        private System.Windows.Forms.Button SeleccionarButton;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProfesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}