namespace Clinica_Frba.Registrar_Agenda
{
    partial class Form1
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
            this.gbDiaSemana = new System.Windows.Forms.GroupBox();
            this.cbSabado = new System.Windows.Forms.CheckBox();
            this.cbViernes = new System.Windows.Forms.CheckBox();
            this.cbJueves = new System.Windows.Forms.CheckBox();
            this.cbMiercoles = new System.Windows.Forms.CheckBox();
            this.cbMartes = new System.Windows.Forms.CheckBox();
            this.cbLunes = new System.Windows.Forms.CheckBox();
            this.gbHorario = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.gbDiaSemana.SuspendLayout();
            this.gbHorario.SuspendLayout();
            this.gbFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDiaSemana
            // 
            this.gbDiaSemana.BackColor = System.Drawing.SystemColors.Control;
            this.gbDiaSemana.Controls.Add(this.cbSabado);
            this.gbDiaSemana.Controls.Add(this.cbViernes);
            this.gbDiaSemana.Controls.Add(this.cbJueves);
            this.gbDiaSemana.Controls.Add(this.cbMiercoles);
            this.gbDiaSemana.Controls.Add(this.cbMartes);
            this.gbDiaSemana.Controls.Add(this.cbLunes);
            this.gbDiaSemana.Location = new System.Drawing.Point(35, 27);
            this.gbDiaSemana.Name = "gbDiaSemana";
            this.gbDiaSemana.Size = new System.Drawing.Size(142, 258);
            this.gbDiaSemana.TabIndex = 0;
            this.gbDiaSemana.TabStop = false;
            this.gbDiaSemana.Text = "Seleccionar Dias";
            // 
            // cbSabado
            // 
            this.cbSabado.AutoSize = true;
            this.cbSabado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSabado.Location = new System.Drawing.Point(18, 210);
            this.cbSabado.Name = "cbSabado";
            this.cbSabado.Size = new System.Drawing.Size(76, 21);
            this.cbSabado.TabIndex = 5;
            this.cbSabado.Text = "Sabado";
            this.cbSabado.UseVisualStyleBackColor = true;
            this.cbSabado.CheckedChanged += new System.EventHandler(this.cbSabado_CheckedChanged);
            // 
            // cbViernes
            // 
            this.cbViernes.AutoSize = true;
            this.cbViernes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbViernes.Location = new System.Drawing.Point(18, 173);
            this.cbViernes.Name = "cbViernes";
            this.cbViernes.Size = new System.Drawing.Size(75, 21);
            this.cbViernes.TabIndex = 4;
            this.cbViernes.Text = "Viernes";
            this.cbViernes.UseVisualStyleBackColor = true;
            // 
            // cbJueves
            // 
            this.cbJueves.AutoSize = true;
            this.cbJueves.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJueves.Location = new System.Drawing.Point(18, 136);
            this.cbJueves.Name = "cbJueves";
            this.cbJueves.Size = new System.Drawing.Size(72, 21);
            this.cbJueves.TabIndex = 3;
            this.cbJueves.Text = "Jueves";
            this.cbJueves.UseVisualStyleBackColor = true;
            // 
            // cbMiercoles
            // 
            this.cbMiercoles.AutoSize = true;
            this.cbMiercoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMiercoles.Location = new System.Drawing.Point(18, 99);
            this.cbMiercoles.Name = "cbMiercoles";
            this.cbMiercoles.Size = new System.Drawing.Size(87, 21);
            this.cbMiercoles.TabIndex = 2;
            this.cbMiercoles.Text = "Miercoles";
            this.cbMiercoles.UseVisualStyleBackColor = true;
            // 
            // cbMartes
            // 
            this.cbMartes.AutoSize = true;
            this.cbMartes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMartes.Location = new System.Drawing.Point(18, 62);
            this.cbMartes.Name = "cbMartes";
            this.cbMartes.Size = new System.Drawing.Size(70, 21);
            this.cbMartes.TabIndex = 1;
            this.cbMartes.Text = "Martes";
            this.cbMartes.UseVisualStyleBackColor = true;
            // 
            // cbLunes
            // 
            this.cbLunes.AutoSize = true;
            this.cbLunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLunes.Location = new System.Drawing.Point(18, 25);
            this.cbLunes.Name = "cbLunes";
            this.cbLunes.Size = new System.Drawing.Size(66, 21);
            this.cbLunes.TabIndex = 0;
            this.cbLunes.Text = "Lunes";
            this.cbLunes.UseVisualStyleBackColor = true;
            // 
            // gbHorario
            // 
            this.gbHorario.Controls.Add(this.label2);
            this.gbHorario.Controls.Add(this.label1);
            this.gbHorario.Controls.Add(this.dtpHoraFin);
            this.gbHorario.Controls.Add(this.dtpHoraInicio);
            this.gbHorario.Location = new System.Drawing.Point(199, 27);
            this.gbHorario.Name = "gbHorario";
            this.gbHorario.Size = new System.Drawing.Size(340, 120);
            this.gbHorario.TabIndex = 1;
            this.gbHorario.TabStop = false;
            this.gbHorario.Text = "Rango Horario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hora Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hora Inicio";
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.CustomFormat = "HH:mm";
            this.dtpHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraFin.Location = new System.Drawing.Point(197, 55);
            this.dtpHoraFin.MaxDate = new System.DateTime(9997, 10, 26, 21, 0, 0, 0);
            this.dtpHoraFin.MinDate = new System.DateTime(1753, 10, 26, 6, 0, 0, 0);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(66, 26);
            this.dtpHoraFin.TabIndex = 1;
            this.dtpHoraFin.Value = new System.DateTime(2013, 10, 26, 7, 30, 0, 0);
            this.dtpHoraFin.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.CustomFormat = "HH:mm";
            this.dtpHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraInicio.Location = new System.Drawing.Point(39, 55);
            this.dtpHoraInicio.MaxDate = new System.DateTime(9997, 10, 26, 21, 0, 0, 0);
            this.dtpHoraInicio.MinDate = new System.DateTime(1753, 10, 26, 6, 0, 0, 0);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(66, 26);
            this.dtpHoraInicio.TabIndex = 0;
            this.dtpHoraInicio.Value = new System.DateTime(2013, 10, 26, 7, 0, 0, 0);
            this.dtpHoraInicio.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // gbFecha
            // 
            this.gbFecha.Controls.Add(this.label4);
            this.gbFecha.Controls.Add(this.label3);
            this.gbFecha.Controls.Add(this.dtpFechaFin);
            this.gbFecha.Controls.Add(this.dtpFechaInicio);
            this.gbFecha.Location = new System.Drawing.Point(199, 162);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Size = new System.Drawing.Size(340, 123);
            this.gbFecha.TabIndex = 2;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Rango Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Inicio";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(197, 55);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(107, 26);
            this.dtpFechaFin.TabIndex = 1;
            this.dtpFechaFin.Value = new System.DateTime(2013, 10, 27, 0, 0, 0, 0);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(39, 55);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(107, 26);
            this.dtpFechaInicio.TabIndex = 0;
            this.dtpFechaInicio.Value = new System.DateTime(2013, 10, 27, 0, 0, 0, 0);
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(54, 307);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 3;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(441, 307);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 4;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 364);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.gbFecha);
            this.Controls.Add(this.gbHorario);
            this.Controls.Add(this.gbDiaSemana);
            this.Name = "Form1";
            this.Text = "Agenda";
            this.gbDiaSemana.ResumeLayout(false);
            this.gbDiaSemana.PerformLayout();
            this.gbHorario.ResumeLayout(false);
            this.gbHorario.PerformLayout();
            this.gbFecha.ResumeLayout(false);
            this.gbFecha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDiaSemana;
        private System.Windows.Forms.CheckBox cbSabado;
        private System.Windows.Forms.CheckBox cbViernes;
        private System.Windows.Forms.CheckBox cbJueves;
        private System.Windows.Forms.CheckBox cbMiercoles;
        private System.Windows.Forms.CheckBox cbMartes;
        private System.Windows.Forms.CheckBox cbLunes;
        private System.Windows.Forms.GroupBox gbHorario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btGuardar;
        public System.Windows.Forms.DateTimePicker dtpHoraInicio;
        public System.Windows.Forms.DateTimePicker dtpHoraFin;
    }
}