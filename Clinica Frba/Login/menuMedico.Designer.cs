namespace Clinica_Frba.Login
{
    partial class menuMedico
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
            this.btCancelarT = new System.Windows.Forms.Button();
            this.btRegRes = new System.Windows.Forms.Button();
            this.btAgenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCancelarT
            // 
            this.btCancelarT.Location = new System.Drawing.Point(12, 114);
            this.btCancelarT.Name = "btCancelarT";
            this.btCancelarT.Size = new System.Drawing.Size(171, 35);
            this.btCancelarT.TabIndex = 6;
            this.btCancelarT.Text = "CANCELACION TURNO";
            this.btCancelarT.UseVisualStyleBackColor = true;
            this.btCancelarT.Click += new System.EventHandler(this.btCancelarT_Click);
            // 
            // btRegRes
            // 
            this.btRegRes.Location = new System.Drawing.Point(12, 63);
            this.btRegRes.Name = "btRegRes";
            this.btRegRes.Size = new System.Drawing.Size(171, 35);
            this.btRegRes.TabIndex = 5;
            this.btRegRes.Text = "REGISTRO RESULTADO";
            this.btRegRes.UseVisualStyleBackColor = true;
            this.btRegRes.Click += new System.EventHandler(this.btRegRes_Click);
            // 
            // btAgenda
            // 
            this.btAgenda.Location = new System.Drawing.Point(12, 12);
            this.btAgenda.Name = "btAgenda";
            this.btAgenda.Size = new System.Drawing.Size(171, 35);
            this.btAgenda.TabIndex = 4;
            this.btAgenda.Text = "CARGAR AGENDA";
            this.btAgenda.UseVisualStyleBackColor = true;
            this.btAgenda.Click += new System.EventHandler(this.btAgenda_Click_1);
            // 
            // menuMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 171);
            this.Controls.Add(this.btCancelarT);
            this.Controls.Add(this.btRegRes);
            this.Controls.Add(this.btAgenda);
            this.Name = "menuMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuMedico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCancelarT;
        private System.Windows.Forms.Button btRegRes;
        private System.Windows.Forms.Button btAgenda;
    }
}