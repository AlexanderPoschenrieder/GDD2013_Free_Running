namespace Clinica_Frba.Pedir_Turno
{
    partial class MostrarAgendaForm
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
            this.botonSeleccionar = new System.Windows.Forms.Button();
            this.calendarioDeAgenda = new System.Windows.Forms.MonthCalendar();
            this.horariosDisponibles = new System.Windows.Forms.DataGridView();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.horariosDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // botonSeleccionar
            // 
            this.botonSeleccionar.Location = new System.Drawing.Point(12, 206);
            this.botonSeleccionar.Name = "botonSeleccionar";
            this.botonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.botonSeleccionar.TabIndex = 5;
            this.botonSeleccionar.Text = "Seleccionar";
            this.botonSeleccionar.UseVisualStyleBackColor = true;
            // 
            // calendarioDeAgenda
            // 
            this.calendarioDeAgenda.Location = new System.Drawing.Point(5, 36);
            this.calendarioDeAgenda.Name = "calendarioDeAgenda";
            this.calendarioDeAgenda.TabIndex = 4;
            // 
            // horariosDisponibles
            // 
            this.horariosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.horariosDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoraInicio});
            this.horariosDisponibles.Location = new System.Drawing.Point(206, 36);
            this.horariosDisponibles.Name = "horariosDisponibles";
            this.horariosDisponibles.Size = new System.Drawing.Size(144, 150);
            this.horariosDisponibles.TabIndex = 6;
            this.horariosDisponibles.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.horariosDisponibles_CellMouseClick);
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.Name = "HoraInicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione una fecha en negrita";
            // 
            // MostrarAgendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.horariosDisponibles);
            this.Controls.Add(this.botonSeleccionar);
            this.Controls.Add(this.calendarioDeAgenda);
            this.Name = "MostrarAgendaForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.horariosDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonSeleccionar;
        private System.Windows.Forms.MonthCalendar calendarioDeAgenda;
        private System.Windows.Forms.DataGridView horariosDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.Label label1;
    }
}