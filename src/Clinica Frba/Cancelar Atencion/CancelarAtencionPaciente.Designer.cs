﻿namespace Clinica_Frba.Cancelar_Atencion
{
    partial class CancelarAtencionPaciente
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
            this.dataGridTurnos = new System.Windows.Forms.DataGridView();
            this.Turno_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.botonSeleccionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTurnos
            // 
            this.dataGridTurnos.AllowUserToAddRows = false;
            this.dataGridTurnos.AllowUserToDeleteRows = false;
            this.dataGridTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Turno_Fecha,
            this.Especialidad,
            this.idTurno});
            this.dataGridTurnos.Location = new System.Drawing.Point(14, 33);
            this.dataGridTurnos.Name = "dataGridTurnos";
            this.dataGridTurnos.ReadOnly = true;
            this.dataGridTurnos.Size = new System.Drawing.Size(247, 110);
            this.dataGridTurnos.TabIndex = 0;
            // 
            // Turno_Fecha
            // 
            this.Turno_Fecha.HeaderText = "Fecha";
            this.Turno_Fecha.Name = "Turno_Fecha";
            this.Turno_Fecha.ReadOnly = true;
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            // 
            // idTurno
            // 
            this.idTurno.HeaderText = "idTurno";
            this.idTurno.Name = "idTurno";
            this.idTurno.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el turno a cancelar";
            // 
            // botonSeleccionar
            // 
            this.botonSeleccionar.Location = new System.Drawing.Point(14, 152);
            this.botonSeleccionar.Name = "botonSeleccionar";
            this.botonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.botonSeleccionar.TabIndex = 2;
            this.botonSeleccionar.Text = "Seleccionar";
            this.botonSeleccionar.UseVisualStyleBackColor = true;
            this.botonSeleccionar.Click += new System.EventHandler(this.botonSeleccionar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelarAtencionPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botonSeleccionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridTurnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CancelarAtencionPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turnos";
            this.Load += new System.EventHandler(this.CancelarAtencionPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTurnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTurno;
        private System.Windows.Forms.Button button1;
    }
}