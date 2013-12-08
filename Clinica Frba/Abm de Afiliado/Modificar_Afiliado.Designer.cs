namespace Clinica_Frba.Abm_de_Afiliado
{
    partial class Modificar_Afiliado
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
            this.components = new System.ComponentModel.Container();
            this.Estadotxt = new System.Windows.Forms.ComboBox();
            this.TipoDoctxt = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nroAfiliadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantFamiliaresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planMedicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2013DataSet1 = new Clinica_Frba.GD2C2013DataSet1();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.PlanMedtxt = new System.Windows.Forms.ComboBox();
            this.EstadoCivtxt = new System.Windows.Forms.ComboBox();
            this.Sexotxt = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NroAfiliadotxt = new System.Windows.Forms.TextBox();
            this.btMod = new System.Windows.Forms.Button();
            this.CantFamHijtxt = new System.Windows.Forms.TextBox();
            this.FechaNactxt = new System.Windows.Forms.TextBox();
            this.Mailtxt = new System.Windows.Forms.TextBox();
            this.Teltxt = new System.Windows.Forms.TextBox();
            this.Directxt = new System.Windows.Forms.TextBox();
            this.Doctxt = new System.Windows.Forms.TextBox();
            this.Apellidotxt = new System.Windows.Forms.TextBox();
            this.Nombretxt = new System.Windows.Forms.TextBox();
            this.pacienteTableAdapter = new Clinica_Frba.GD2C2013DataSet1TableAdapters.PacienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2013DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Estadotxt
            // 
            this.Estadotxt.AutoCompleteCustomSource.AddRange(new string[] {
            "Soltero",
            "Casado",
            "Viudo",
            "Concubinato",
            "Divorciado"});
            this.Estadotxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Estadotxt.FormattingEnabled = true;
            this.Estadotxt.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Estadotxt.Location = new System.Drawing.Point(834, 340);
            this.Estadotxt.Name = "Estadotxt";
            this.Estadotxt.Size = new System.Drawing.Size(100, 21);
            this.Estadotxt.TabIndex = 15;
            this.Estadotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Estadotxt_KeyPress);
            // 
            // TipoDoctxt
            // 
            this.TipoDoctxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoDoctxt.FormattingEnabled = true;
            this.TipoDoctxt.Items.AddRange(new object[] {
            "DNI",
            "LC",
            "CI"});
            this.TipoDoctxt.Location = new System.Drawing.Point(454, 420);
            this.TipoDoctxt.Name = "TipoDoctxt";
            this.TipoDoctxt.Size = new System.Drawing.Size(100, 21);
            this.TipoDoctxt.TabIndex = 11;
            this.TipoDoctxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TipoDoctxt_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroAfiliadoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.documentoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.fechaNacDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.tipoDocumentoDataGridViewTextBoxColumn,
            this.estadoCivilDataGridViewTextBoxColumn,
            this.cantFamiliaresDataGridViewTextBoxColumn,
            this.planMedicoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pacienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(892, 230);
            this.dataGridView1.TabIndex = 151;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // nroAfiliadoDataGridViewTextBoxColumn
            // 
            this.nroAfiliadoDataGridViewTextBoxColumn.DataPropertyName = "Nro_Afiliado";
            this.nroAfiliadoDataGridViewTextBoxColumn.HeaderText = "Nro_Afiliado";
            this.nroAfiliadoDataGridViewTextBoxColumn.Name = "nroAfiliadoDataGridViewTextBoxColumn";
            this.nroAfiliadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentoDataGridViewTextBoxColumn
            // 
            this.documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            this.documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            this.documentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacDataGridViewTextBoxColumn
            // 
            this.fechaNacDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Nac";
            this.fechaNacDataGridViewTextBoxColumn.HeaderText = "Fecha_Nac";
            this.fechaNacDataGridViewTextBoxColumn.Name = "fechaNacDataGridViewTextBoxColumn";
            this.fechaNacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDocumentoDataGridViewTextBoxColumn
            // 
            this.tipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Documento";
            this.tipoDocumentoDataGridViewTextBoxColumn.HeaderText = "Tipo_Documento";
            this.tipoDocumentoDataGridViewTextBoxColumn.Name = "tipoDocumentoDataGridViewTextBoxColumn";
            this.tipoDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoCivilDataGridViewTextBoxColumn
            // 
            this.estadoCivilDataGridViewTextBoxColumn.DataPropertyName = "Estado_Civil";
            this.estadoCivilDataGridViewTextBoxColumn.HeaderText = "Estado_Civil";
            this.estadoCivilDataGridViewTextBoxColumn.Name = "estadoCivilDataGridViewTextBoxColumn";
            this.estadoCivilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantFamiliaresDataGridViewTextBoxColumn
            // 
            this.cantFamiliaresDataGridViewTextBoxColumn.DataPropertyName = "Cant_Familiares";
            this.cantFamiliaresDataGridViewTextBoxColumn.HeaderText = "Cant_Familiares";
            this.cantFamiliaresDataGridViewTextBoxColumn.Name = "cantFamiliaresDataGridViewTextBoxColumn";
            this.cantFamiliaresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planMedicoDataGridViewTextBoxColumn
            // 
            this.planMedicoDataGridViewTextBoxColumn.DataPropertyName = "Plan_Medico";
            this.planMedicoDataGridViewTextBoxColumn.HeaderText = "Plan_Medico";
            this.planMedicoDataGridViewTextBoxColumn.Name = "planMedicoDataGridViewTextBoxColumn";
            this.planMedicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.gD2C2013DataSet1;
            // 
            // gD2C2013DataSet1
            // 
            this.gD2C2013DataSet1.DataSetName = "GD2C2013DataSet1";
            this.gD2C2013DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Usertxt
            // 
            this.Usertxt.Location = new System.Drawing.Point(834, 377);
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(100, 20);
            this.Usertxt.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(773, 381);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 149;
            this.label16.Text = "Username";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(559, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 22);
            this.button3.TabIndex = 9;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(381, 307);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(212, 13);
            this.label15.TabIndex = 147;
            this.label15.Text = "Ingrese los datos a modificar en los campos";
            // 
            // PlanMedtxt
            // 
            this.PlanMedtxt.AutoCompleteCustomSource.AddRange(new string[] {
            "Soltero",
            "Casado",
            "Viudo",
            "Concubinato",
            "Divorciado"});
            this.PlanMedtxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlanMedtxt.FormattingEnabled = true;
            this.PlanMedtxt.Items.AddRange(new object[] {
            "555555",
            "555556",
            "555557",
            "555558",
            "555559"});
            this.PlanMedtxt.Location = new System.Drawing.Point(667, 421);
            this.PlanMedtxt.Name = "PlanMedtxt";
            this.PlanMedtxt.Size = new System.Drawing.Size(100, 21);
            this.PlanMedtxt.TabIndex = 14;
            // 
            // EstadoCivtxt
            // 
            this.EstadoCivtxt.AutoCompleteCustomSource.AddRange(new string[] {
            "Soltero",
            "Casado",
            "Viudo",
            "Concubinato",
            "Divorciado"});
            this.EstadoCivtxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstadoCivtxt.FormattingEnabled = true;
            this.EstadoCivtxt.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Viudo",
            "Concubinato",
            "Divorciado"});
            this.EstadoCivtxt.Location = new System.Drawing.Point(667, 340);
            this.EstadoCivtxt.Name = "EstadoCivtxt";
            this.EstadoCivtxt.Size = new System.Drawing.Size(100, 21);
            this.EstadoCivtxt.TabIndex = 12;
            this.EstadoCivtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EstadoCivtxt_KeyPress);
            // 
            // Sexotxt
            // 
            this.Sexotxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sexotxt.FormattingEnabled = true;
            this.Sexotxt.Items.AddRange(new object[] {
            "M",
            "F"});
            this.Sexotxt.Location = new System.Drawing.Point(454, 381);
            this.Sexotxt.Name = "Sexotxt";
            this.Sexotxt.Size = new System.Drawing.Size(100, 21);
            this.Sexotxt.TabIndex = 10;
            this.Sexotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sexotxt_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(788, 343);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 143;
            this.label14.Text = "Estado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(590, 424);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 142;
            this.label13.Text = "Plan Medico";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(597, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 141;
            this.label12.Text = "Cant_Fam";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(590, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 140;
            this.label11.Text = "Estado Civil";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(381, 424);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 139;
            this.label10.Text = "Tipo_Docum";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 138;
            this.label9.Text = "Sexo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 137;
            this.label8.Text = "Fecha_Nac";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 136;
            this.label7.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 135;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 134;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 133;
            this.label4.Text = "Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 132;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 131;
            this.label2.Text = "Nombre";
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(525, 20);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btFiltrar.TabIndex = 2;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 129;
            this.label1.Text = "Nro Afiliado";
            // 
            // NroAfiliadotxt
            // 
            this.NroAfiliadotxt.Location = new System.Drawing.Point(397, 22);
            this.NroAfiliadotxt.Name = "NroAfiliadotxt";
            this.NroAfiliadotxt.Size = new System.Drawing.Size(100, 20);
            this.NroAfiliadotxt.TabIndex = 1;
            this.NroAfiliadotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NroAfiliadotxt_KeyPress);
            // 
            // btMod
            // 
            this.btMod.Location = new System.Drawing.Point(434, 463);
            this.btMod.Name = "btMod";
            this.btMod.Size = new System.Drawing.Size(132, 23);
            this.btMod.TabIndex = 17;
            this.btMod.Text = "Modificar datos";
            this.btMod.UseVisualStyleBackColor = true;
            this.btMod.Click += new System.EventHandler(this.button1_Click);
            // 
            // CantFamHijtxt
            // 
            this.CantFamHijtxt.Location = new System.Drawing.Point(667, 378);
            this.CantFamHijtxt.Name = "CantFamHijtxt";
            this.CantFamHijtxt.Size = new System.Drawing.Size(100, 20);
            this.CantFamHijtxt.TabIndex = 13;
            this.CantFamHijtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantFamHijtxt_KeyPress);
            // 
            // FechaNactxt
            // 
            this.FechaNactxt.Location = new System.Drawing.Point(454, 340);
            this.FechaNactxt.Name = "FechaNactxt";
            this.FechaNactxt.ReadOnly = true;
            this.FechaNactxt.Size = new System.Drawing.Size(100, 20);
            this.FechaNactxt.TabIndex = 125;
            this.FechaNactxt.TabStop = false;
            // 
            // Mailtxt
            // 
            this.Mailtxt.Location = new System.Drawing.Point(275, 421);
            this.Mailtxt.Name = "Mailtxt";
            this.Mailtxt.Size = new System.Drawing.Size(100, 20);
            this.Mailtxt.TabIndex = 8;
            // 
            // Teltxt
            // 
            this.Teltxt.Location = new System.Drawing.Point(275, 378);
            this.Teltxt.Name = "Teltxt";
            this.Teltxt.Size = new System.Drawing.Size(100, 20);
            this.Teltxt.TabIndex = 7;
            this.Teltxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teltxt_KeyPress);
            // 
            // Directxt
            // 
            this.Directxt.Location = new System.Drawing.Point(275, 340);
            this.Directxt.Name = "Directxt";
            this.Directxt.Size = new System.Drawing.Size(100, 20);
            this.Directxt.TabIndex = 6;
            // 
            // Doctxt
            // 
            this.Doctxt.Location = new System.Drawing.Point(104, 421);
            this.Doctxt.Name = "Doctxt";
            this.Doctxt.Size = new System.Drawing.Size(100, 20);
            this.Doctxt.TabIndex = 5;
            this.Doctxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Doctxt_KeyPress);
            // 
            // Apellidotxt
            // 
            this.Apellidotxt.Location = new System.Drawing.Point(104, 378);
            this.Apellidotxt.Name = "Apellidotxt";
            this.Apellidotxt.Size = new System.Drawing.Size(100, 20);
            this.Apellidotxt.TabIndex = 4;
            this.Apellidotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apellidotxt_KeyPress);
            // 
            // Nombretxt
            // 
            this.Nombretxt.Location = new System.Drawing.Point(104, 340);
            this.Nombretxt.Name = "Nombretxt";
            this.Nombretxt.Size = new System.Drawing.Size(100, 20);
            this.Nombretxt.TabIndex = 3;
            this.Nombretxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombretxt_KeyPress);
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // Modificar_Afiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 506);
            this.Controls.Add(this.Estadotxt);
            this.Controls.Add(this.TipoDoctxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Usertxt);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.PlanMedtxt);
            this.Controls.Add(this.EstadoCivtxt);
            this.Controls.Add(this.Sexotxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NroAfiliadotxt);
            this.Controls.Add(this.btMod);
            this.Controls.Add(this.CantFamHijtxt);
            this.Controls.Add(this.FechaNactxt);
            this.Controls.Add(this.Mailtxt);
            this.Controls.Add(this.Teltxt);
            this.Controls.Add(this.Directxt);
            this.Controls.Add(this.Doctxt);
            this.Controls.Add(this.Apellidotxt);
            this.Controls.Add(this.Nombretxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Modificar_Afiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar_Afiliado";
            this.Load += new System.EventHandler(this.Modificar_Afiliado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2013DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Estadotxt;
        private System.Windows.Forms.ComboBox TipoDoctxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Usertxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox PlanMedtxt;
        private System.Windows.Forms.ComboBox EstadoCivtxt;
        private System.Windows.Forms.ComboBox Sexotxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NroAfiliadotxt;
        private System.Windows.Forms.Button btMod;
        private System.Windows.Forms.TextBox CantFamHijtxt;
        private System.Windows.Forms.TextBox FechaNactxt;
        private System.Windows.Forms.TextBox Mailtxt;
        private System.Windows.Forms.TextBox Teltxt;
        private System.Windows.Forms.TextBox Directxt;
        private System.Windows.Forms.TextBox Doctxt;
        private System.Windows.Forms.TextBox Apellidotxt;
        private System.Windows.Forms.TextBox Nombretxt;
        private GD2C2013DataSet1 gD2C2013DataSet1;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private Clinica_Frba.GD2C2013DataSet1TableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroAfiliadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantFamiliaresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planMedicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
    }
}