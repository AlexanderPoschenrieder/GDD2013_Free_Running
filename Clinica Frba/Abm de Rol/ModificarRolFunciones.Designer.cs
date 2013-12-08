namespace Clinica_Frba.Abm_de_Rol
{
    partial class ModificarRolFunciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbRol = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btLimpiarRol = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.dgvFun = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBuscar1 = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btLimpiar2 = new System.Windows.Forms.Button();
            this.dgvAgregar = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBuscFunc2 = new System.Windows.Forms.TextBox();
            this.btBuscar2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFun)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rol";
            // 
            // tbRol
            // 
            this.tbRol.Location = new System.Drawing.Point(99, 33);
            this.tbRol.Name = "tbRol";
            this.tbRol.Size = new System.Drawing.Size(193, 20);
            this.tbRol.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbEstado);
            this.groupBox1.Controls.Add(this.btLimpiarRol);
            this.groupBox1.Controls.Add(this.btModificar);
            this.groupBox1.Controls.Add(this.tbRol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 87);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombre del Rol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Habilitado",
            "Inhabilitado"});
            this.cbEstado.Location = new System.Drawing.Point(587, 33);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 4;
            // 
            // btLimpiarRol
            // 
            this.btLimpiarRol.Location = new System.Drawing.Point(315, 32);
            this.btLimpiarRol.Name = "btLimpiarRol";
            this.btLimpiarRol.Size = new System.Drawing.Size(75, 23);
            this.btLimpiarRol.TabIndex = 3;
            this.btLimpiarRol.Text = "Limpiar";
            this.btLimpiarRol.UseVisualStyleBackColor = true;
            this.btLimpiarRol.Click += new System.EventHandler(this.btLimpiarRol_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(405, 32);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 23);
            this.btModificar.TabIndex = 2;
            this.btModificar.Text = "Guardar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btLimpiar);
            this.groupBox2.Controls.Add(this.dgvFun);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbBuscar1);
            this.groupBox2.Controls.Add(this.btBuscar);
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 362);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar Funcionalidades";
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(19, 321);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 6;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // dgvFun
            // 
            this.dgvFun.AllowUserToAddRows = false;
            this.dgvFun.AllowUserToDeleteRows = false;
            this.dgvFun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFun.Location = new System.Drawing.Point(19, 88);
            this.dgvFun.Name = "dgvFun";
            this.dgvFun.ReadOnly = true;
            this.dgvFun.Size = new System.Drawing.Size(317, 209);
            this.dgvFun.TabIndex = 4;
            this.dgvFun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFun_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Funcionalidad";
            // 
            // tbBuscar1
            // 
            this.tbBuscar1.Location = new System.Drawing.Point(99, 37);
            this.tbBuscar1.Name = "tbBuscar1";
            this.tbBuscar1.Size = new System.Drawing.Size(145, 20);
            this.tbBuscar1.TabIndex = 1;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(261, 35);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 0;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btLimpiar2);
            this.groupBox3.Controls.Add(this.dgvAgregar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbBuscFunc2);
            this.groupBox3.Controls.Add(this.btBuscar2);
            this.groupBox3.Location = new System.Drawing.Point(403, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 362);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agregar Funcionalidades";
            // 
            // btLimpiar2
            // 
            this.btLimpiar2.Location = new System.Drawing.Point(19, 321);
            this.btLimpiar2.Name = "btLimpiar2";
            this.btLimpiar2.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar2.TabIndex = 6;
            this.btLimpiar2.Text = "Limpiar";
            this.btLimpiar2.UseVisualStyleBackColor = true;
            this.btLimpiar2.Click += new System.EventHandler(this.btLimpiar2_Click);
            // 
            // dgvAgregar
            // 
            this.dgvAgregar.AllowUserToAddRows = false;
            this.dgvAgregar.AllowUserToDeleteRows = false;
            this.dgvAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregar.Location = new System.Drawing.Point(19, 88);
            this.dgvAgregar.Name = "dgvAgregar";
            this.dgvAgregar.ReadOnly = true;
            this.dgvAgregar.Size = new System.Drawing.Size(317, 209);
            this.dgvAgregar.TabIndex = 4;
            this.dgvAgregar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgregar_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Funcionalidad";
            // 
            // tbBuscFunc2
            // 
            this.tbBuscFunc2.Location = new System.Drawing.Point(99, 37);
            this.tbBuscFunc2.Name = "tbBuscFunc2";
            this.tbBuscFunc2.Size = new System.Drawing.Size(145, 20);
            this.tbBuscFunc2.TabIndex = 1;
            // 
            // btBuscar2
            // 
            this.btBuscar2.Location = new System.Drawing.Point(261, 35);
            this.btBuscar2.Name = "btBuscar2";
            this.btBuscar2.Size = new System.Drawing.Size(75, 23);
            this.btBuscar2.TabIndex = 0;
            this.btBuscar2.Text = "Buscar";
            this.btBuscar2.UseVisualStyleBackColor = true;
            this.btBuscar2.Click += new System.EventHandler(this.btBuscar2_Click);
            // 
            // ModificarRolFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 497);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ModificarRolFunciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarRolFunciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFun)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvFun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBuscar1;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btLimpiar2;
        private System.Windows.Forms.DataGridView dgvAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBuscFunc2;
        private System.Windows.Forms.Button btBuscar2;
        private System.Windows.Forms.Button btLimpiarRol;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEstado;
    }
}