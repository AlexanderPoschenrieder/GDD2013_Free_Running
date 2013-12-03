namespace Clinica_Frba.Abm_de_Profesional
{
    partial class Menu_Profesional
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
            this.btBaja = new System.Windows.Forms.Button();
            this.btMod = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBaja
            // 
            this.btBaja.Location = new System.Drawing.Point(30, 156);
            this.btBaja.Name = "btBaja";
            this.btBaja.Size = new System.Drawing.Size(97, 44);
            this.btBaja.TabIndex = 8;
            this.btBaja.Text = "Dar_Baja";
            this.btBaja.UseVisualStyleBackColor = true;
            this.btBaja.Click += new System.EventHandler(this.button3_Click);
            // 
            // btMod
            // 
            this.btMod.Location = new System.Drawing.Point(30, 88);
            this.btMod.Name = "btMod";
            this.btMod.Size = new System.Drawing.Size(97, 44);
            this.btMod.TabIndex = 7;
            this.btMod.Text = "Modificar";
            this.btMod.UseVisualStyleBackColor = true;
            this.btMod.Click += new System.EventHandler(this.button2_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(30, 27);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(97, 44);
            this.btAgregar.TabIndex = 6;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu_Profesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 243);
            this.Controls.Add(this.btBaja);
            this.Controls.Add(this.btMod);
            this.Controls.Add(this.btAgregar);
            this.Name = "Menu_Profesional";
            this.Text = "Menu_Profesional";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBaja;
        private System.Windows.Forms.Button btMod;
        private System.Windows.Forms.Button btAgregar;
    }
}