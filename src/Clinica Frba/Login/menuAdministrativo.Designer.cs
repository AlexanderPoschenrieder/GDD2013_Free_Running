namespace Clinica_Frba.Login
{
    partial class menuAdministrativo
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
            this.btEstadist = new System.Windows.Forms.Button();
            this.btLlegada = new System.Windows.Forms.Button();
            this.btCompra = new System.Windows.Forms.Button();
            this.btProf = new System.Windows.Forms.Button();
            this.btAfiliado = new System.Windows.Forms.Button();
            this.btRol = new System.Windows.Forms.Button();
            this.btAgenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btEstadist
            // 
            this.btEstadist.Location = new System.Drawing.Point(13, 252);
            this.btEstadist.Name = "btEstadist";
            this.btEstadist.Size = new System.Drawing.Size(194, 32);
            this.btEstadist.TabIndex = 13;
            this.btEstadist.Text = "LISTADO ESTADISTICA";
            this.btEstadist.UseVisualStyleBackColor = true;
            this.btEstadist.Click += new System.EventHandler(this.btEstadist_Click);
            // 
            // btLlegada
            // 
            this.btLlegada.Location = new System.Drawing.Point(13, 207);
            this.btLlegada.Name = "btLlegada";
            this.btLlegada.Size = new System.Drawing.Size(194, 32);
            this.btLlegada.TabIndex = 12;
            this.btLlegada.Text = "LLEGADA ATENCION MEDICA";
            this.btLlegada.UseVisualStyleBackColor = true;
            this.btLlegada.Click += new System.EventHandler(this.btLlegada_Click);
            // 
            // btCompra
            // 
            this.btCompra.Location = new System.Drawing.Point(13, 162);
            this.btCompra.Name = "btCompra";
            this.btCompra.Size = new System.Drawing.Size(194, 32);
            this.btCompra.TabIndex = 10;
            this.btCompra.Text = "COMPRA BONO";
            this.btCompra.UseVisualStyleBackColor = true;
            this.btCompra.Click += new System.EventHandler(this.btCompra_Click);
            // 
            // btProf
            // 
            this.btProf.Location = new System.Drawing.Point(13, 117);
            this.btProf.Name = "btProf";
            this.btProf.Size = new System.Drawing.Size(194, 32);
            this.btProf.TabIndex = 9;
            this.btProf.Text = "PROFESIONAL";
            this.btProf.UseVisualStyleBackColor = true;
            this.btProf.Click += new System.EventHandler(this.btProf_Click);
            // 
            // btAfiliado
            // 
            this.btAfiliado.Location = new System.Drawing.Point(13, 72);
            this.btAfiliado.Name = "btAfiliado";
            this.btAfiliado.Size = new System.Drawing.Size(194, 32);
            this.btAfiliado.TabIndex = 8;
            this.btAfiliado.Text = "AFILIADO";
            this.btAfiliado.UseVisualStyleBackColor = true;
            this.btAfiliado.Click += new System.EventHandler(this.btAfiliado_Click);
            // 
            // btRol
            // 
            this.btRol.Location = new System.Drawing.Point(13, 27);
            this.btRol.Name = "btRol";
            this.btRol.Size = new System.Drawing.Size(194, 32);
            this.btRol.TabIndex = 7;
            this.btRol.Text = "ROL";
            this.btRol.UseVisualStyleBackColor = true;
            this.btRol.Click += new System.EventHandler(this.btRol_Click);
            // 
            // btAgenda
            // 
            this.btAgenda.Location = new System.Drawing.Point(13, 297);
            this.btAgenda.Name = "btAgenda";
            this.btAgenda.Size = new System.Drawing.Size(194, 32);
            this.btAgenda.TabIndex = 14;
            this.btAgenda.Text = "CARGAR AGENDA";
            this.btAgenda.UseVisualStyleBackColor = true;
            this.btAgenda.Click += new System.EventHandler(this.btAgenda_Click);
            // 
            // menuAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 356);
            this.Controls.Add(this.btAgenda);
            this.Controls.Add(this.btEstadist);
            this.Controls.Add(this.btLlegada);
            this.Controls.Add(this.btCompra);
            this.Controls.Add(this.btProf);
            this.Controls.Add(this.btAfiliado);
            this.Controls.Add(this.btRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "menuAdministrativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuAdministrativo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menuAdministrativo_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEstadist;
        private System.Windows.Forms.Button btLlegada;
        private System.Windows.Forms.Button btCompra;
        private System.Windows.Forms.Button btProf;
        private System.Windows.Forms.Button btAfiliado;
        private System.Windows.Forms.Button btRol;
        private System.Windows.Forms.Button btAgenda;
    }
}