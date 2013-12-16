namespace Clinica_Frba.Abm_de_Rol
{
    partial class ABM_ROL
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
            this.btModificar = new System.Windows.Forms.Button();
            this.btBaja = new System.Windows.Forms.Button();
            this.btAlta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(12, 135);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(146, 39);
            this.btModificar.TabIndex = 5;
            this.btModificar.Text = "MODIFICAR ROL";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btBaja
            // 
            this.btBaja.Location = new System.Drawing.Point(12, 74);
            this.btBaja.Name = "btBaja";
            this.btBaja.Size = new System.Drawing.Size(146, 39);
            this.btBaja.TabIndex = 4;
            this.btBaja.Text = "BAJA ROL";
            this.btBaja.UseVisualStyleBackColor = true;
            this.btBaja.Click += new System.EventHandler(this.btBaja_Click);
            // 
            // btAlta
            // 
            this.btAlta.Location = new System.Drawing.Point(12, 16);
            this.btAlta.Name = "btAlta";
            this.btAlta.Size = new System.Drawing.Size(146, 39);
            this.btAlta.TabIndex = 3;
            this.btAlta.Text = "ALTA ROL";
            this.btAlta.UseVisualStyleBackColor = true;
            this.btAlta.Click += new System.EventHandler(this.btAlta_Click);
            // 
            // ABM_ROL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 205);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btBaja);
            this.Controls.Add(this.btAlta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ABM_ROL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM_ROL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btBaja;
        private System.Windows.Forms.Button btAlta;
    }
}