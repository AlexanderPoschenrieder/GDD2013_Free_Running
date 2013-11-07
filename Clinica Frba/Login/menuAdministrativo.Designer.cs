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
            this.btPedido = new System.Windows.Forms.Button();
            this.btCompra = new System.Windows.Forms.Button();
            this.btProf = new System.Windows.Forms.Button();
            this.btAfiliado = new System.Windows.Forms.Button();
            this.btRol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btEstadist
            // 
            this.btEstadist.Location = new System.Drawing.Point(12, 292);
            this.btEstadist.Name = "btEstadist";
            this.btEstadist.Size = new System.Drawing.Size(194, 32);
            this.btEstadist.TabIndex = 13;
            this.btEstadist.Text = "LISTADO ESTADISTICA";
            this.btEstadist.UseVisualStyleBackColor = true;
            // 
            // btLlegada
            // 
            this.btLlegada.Location = new System.Drawing.Point(12, 245);
            this.btLlegada.Name = "btLlegada";
            this.btLlegada.Size = new System.Drawing.Size(194, 32);
            this.btLlegada.TabIndex = 12;
            this.btLlegada.Text = "LLEGADA ATENCION MEDICA";
            this.btLlegada.UseVisualStyleBackColor = true;
            // 
            // btPedido
            // 
            this.btPedido.Location = new System.Drawing.Point(12, 198);
            this.btPedido.Name = "btPedido";
            this.btPedido.Size = new System.Drawing.Size(194, 32);
            this.btPedido.TabIndex = 11;
            this.btPedido.Text = "PEDIDO TURNO";
            this.btPedido.UseVisualStyleBackColor = true;
            // 
            // btCompra
            // 
            this.btCompra.Location = new System.Drawing.Point(12, 151);
            this.btCompra.Name = "btCompra";
            this.btCompra.Size = new System.Drawing.Size(194, 32);
            this.btCompra.TabIndex = 10;
            this.btCompra.Text = "COMPRA BONO";
            this.btCompra.UseVisualStyleBackColor = true;
            // 
            // btProf
            // 
            this.btProf.Location = new System.Drawing.Point(12, 104);
            this.btProf.Name = "btProf";
            this.btProf.Size = new System.Drawing.Size(194, 32);
            this.btProf.TabIndex = 9;
            this.btProf.Text = "PROFECIONAL";
            this.btProf.UseVisualStyleBackColor = true;
            // 
            // btAfiliado
            // 
            this.btAfiliado.Location = new System.Drawing.Point(12, 57);
            this.btAfiliado.Name = "btAfiliado";
            this.btAfiliado.Size = new System.Drawing.Size(194, 32);
            this.btAfiliado.TabIndex = 8;
            this.btAfiliado.Text = "AFILIADO";
            this.btAfiliado.UseVisualStyleBackColor = true;
            // 
            // btRol
            // 
            this.btRol.Location = new System.Drawing.Point(12, 10);
            this.btRol.Name = "btRol";
            this.btRol.Size = new System.Drawing.Size(194, 32);
            this.btRol.TabIndex = 7;
            this.btRol.Text = "ROL";
            this.btRol.UseVisualStyleBackColor = true;
            this.btRol.Click += new System.EventHandler(this.btRol_Click);
            // 
            // menuAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 341);
            this.Controls.Add(this.btEstadist);
            this.Controls.Add(this.btLlegada);
            this.Controls.Add(this.btPedido);
            this.Controls.Add(this.btCompra);
            this.Controls.Add(this.btProf);
            this.Controls.Add(this.btAfiliado);
            this.Controls.Add(this.btRol);
            this.Name = "menuAdministrativo";
            this.Text = "menuAdministrativo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEstadist;
        private System.Windows.Forms.Button btLlegada;
        private System.Windows.Forms.Button btPedido;
        private System.Windows.Forms.Button btCompra;
        private System.Windows.Forms.Button btProf;
        private System.Windows.Forms.Button btAfiliado;
        private System.Windows.Forms.Button btRol;
    }
}