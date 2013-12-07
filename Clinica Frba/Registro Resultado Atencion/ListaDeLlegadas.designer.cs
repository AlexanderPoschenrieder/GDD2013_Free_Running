namespace Clinica_Frba.Registro_Resultado_Atencion
{
    partial class ListaDeLlegadas
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
            this.dataGridLlegadas = new System.Windows.Forms.DataGridView();
            this.botonSeleccionar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLlegadas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la atención correspondiente";
            // 
            // dataGridLlegadas
            // 
            this.dataGridLlegadas.AllowUserToAddRows = false;
            this.dataGridLlegadas.AllowUserToDeleteRows = false;
            this.dataGridLlegadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLlegadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaHora,
            this.Paciente,
            this.Id});
            this.dataGridLlegadas.Location = new System.Drawing.Point(16, 40);
            this.dataGridLlegadas.Name = "dataGridLlegadas";
            this.dataGridLlegadas.ReadOnly = true;
            this.dataGridLlegadas.Size = new System.Drawing.Size(243, 161);
            this.dataGridLlegadas.TabIndex = 1;
            // 
            // botonSeleccionar
            // 
            this.botonSeleccionar.Location = new System.Drawing.Point(16, 211);
            this.botonSeleccionar.Name = "botonSeleccionar";
            this.botonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.botonSeleccionar.TabIndex = 2;
            this.botonSeleccionar.Text = "Seleccionar";
            this.botonSeleccionar.UseVisualStyleBackColor = true;
            this.botonSeleccionar.Click += new System.EventHandler(this.botonSeleccionar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(183, 211);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 3;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // FechaHora
            // 
            this.FechaHora.HeaderText = "Fecha y hora";
            this.FechaHora.Name = "FechaHora";
            this.FechaHora.ReadOnly = true;
            // 
            // Paciente
            // 
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ListaDeLlegadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 247);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonSeleccionar);
            this.Controls.Add(this.dataGridLlegadas);
            this.Controls.Add(this.label1);
            this.Name = "ListaDeLlegadas";
            this.Text = "Selección de Atención";
            this.Load += new System.EventHandler(this.ListaDeLlegadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLlegadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridLlegadas;
        private System.Windows.Forms.Button botonSeleccionar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}