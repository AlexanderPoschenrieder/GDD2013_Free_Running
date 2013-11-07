namespace Clinica_Frba.Listados_Estadisticos
{
    partial class AfiliadoBFvenc
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
            this.dgvTop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTop
            // 
            this.dgvTop.AllowUserToAddRows = false;
            this.dgvTop.AllowUserToDeleteRows = false;
            this.dgvTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTop.Location = new System.Drawing.Point(8, 12);
            this.dgvTop.Name = "dgvTop";
            this.dgvTop.ReadOnly = true;
            this.dgvTop.Size = new System.Drawing.Size(276, 185);
            this.dgvTop.TabIndex = 1;
            // 
            // AfiliadoBFvenc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 270);
            this.Controls.Add(this.dgvTop);
            this.Name = "AfiliadoBFvenc";
            this.Text = "AfiliadoBFvenc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTop;
    }
}