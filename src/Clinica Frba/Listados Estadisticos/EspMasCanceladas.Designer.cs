﻿namespace Clinica_Frba.Listados_Estadisticos
{
    partial class EspMasCanceladas
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
            this.dvgTop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTop)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgTop
            // 
            this.dvgTop.AllowUserToAddRows = false;
            this.dvgTop.AllowUserToDeleteRows = false;
            this.dvgTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgTop.Location = new System.Drawing.Point(0, 0);
            this.dvgTop.Name = "dvgTop";
            this.dvgTop.ReadOnly = true;
            this.dvgTop.Size = new System.Drawing.Size(621, 257);
            this.dvgTop.TabIndex = 1;
            // 
            // EspMasCanceladas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 257);
            this.Controls.Add(this.dvgTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EspMasCanceladas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOP 5 Especialidad Mas Cancelada";
            ((System.ComponentModel.ISupportInitialize)(this.dvgTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgTop;
    }
}