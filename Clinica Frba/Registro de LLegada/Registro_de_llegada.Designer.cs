namespace Clinica_Frba.Registro_de_LLegada
{
    partial class Registro_de_llegada
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
            this.dgvProfecional = new System.Windows.Forms.DataGridView();
            this.gbBuscarTurno = new System.Windows.Forms.GroupBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tbEspecialidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProfecional = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfecional)).BeginInit();
            this.gbBuscarTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProfecional
            // 
            this.dgvProfecional.AllowUserToAddRows = false;
            this.dgvProfecional.AllowUserToDeleteRows = false;
            this.dgvProfecional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfecional.Location = new System.Drawing.Point(12, 161);
            this.dgvProfecional.Name = "dgvProfecional";
            this.dgvProfecional.ReadOnly = true;
            this.dgvProfecional.Size = new System.Drawing.Size(602, 303);
            this.dgvProfecional.TabIndex = 7;
            this.dgvProfecional.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfecional_CellClick);
            // 
            // gbBuscarTurno
            // 
            this.gbBuscarTurno.Controls.Add(this.btLimpiar);
            this.gbBuscarTurno.Controls.Add(this.btBuscar);
            this.gbBuscarTurno.Controls.Add(this.tbEspecialidad);
            this.gbBuscarTurno.Controls.Add(this.label3);
            this.gbBuscarTurno.Controls.Add(this.tbProfecional);
            this.gbBuscarTurno.Controls.Add(this.label2);
            this.gbBuscarTurno.Location = new System.Drawing.Point(12, 12);
            this.gbBuscarTurno.Name = "gbBuscarTurno";
            this.gbBuscarTurno.Size = new System.Drawing.Size(602, 127);
            this.gbBuscarTurno.TabIndex = 6;
            this.gbBuscarTurno.TabStop = false;
            this.gbBuscarTurno.Text = "Buscar Profesional";
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(479, 52);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 7;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(360, 52);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 6;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // tbEspecialidad
            // 
            this.tbEspecialidad.Location = new System.Drawing.Point(131, 76);
            this.tbEspecialidad.Name = "tbEspecialidad";
            this.tbEspecialidad.Size = new System.Drawing.Size(149, 20);
            this.tbEspecialidad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Especialidad";
            // 
            // tbProfecional
            // 
            this.tbProfecional.Location = new System.Drawing.Point(131, 31);
            this.tbProfecional.Name = "tbProfecional";
            this.tbProfecional.Size = new System.Drawing.Size(149, 20);
            this.tbProfecional.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Profesional Apellido";
            // 
            // Registro_de_llegada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 480);
            this.Controls.Add(this.dgvProfecional);
            this.Controls.Add(this.gbBuscarTurno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Registro_de_llegada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Registro de llegada";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfecional)).EndInit();
            this.gbBuscarTurno.ResumeLayout(false);
            this.gbBuscarTurno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProfecional;
        private System.Windows.Forms.GroupBox gbBuscarTurno;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox tbEspecialidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProfecional;
        private System.Windows.Forms.Label label2;
    }
}