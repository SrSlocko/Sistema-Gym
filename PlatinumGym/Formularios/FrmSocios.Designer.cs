namespace PlatinumGym.Formularios
{
    partial class FrmSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSocios));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.chkClienteActivo = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.datetimeCumple = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.datetimeSociodesde = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregarFoto = new System.Windows.Forms.Button();
            this.txtIdeClie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreClie = new System.Windows.Forms.TextBox();
            this.ptbClie = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccionClie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefonoClie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPesoidoneo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.chkPesoActual = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.chkDatosAdicionales = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txttelefonodeltrabajo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtocupacion = new System.Windows.Forms.TextBox();
            this.txtapodo = new System.Windows.Forms.TextBox();
            this.txttelefonodecasa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClie)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(597, 39);
            this.toolStrip1.TabIndex = 38;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 36);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 36);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chkClienteActivo
            // 
            this.chkClienteActivo.AutoSize = true;
            this.chkClienteActivo.Location = new System.Drawing.Point(154, 16);
            this.chkClienteActivo.Name = "chkClienteActivo";
            this.chkClienteActivo.Size = new System.Drawing.Size(86, 17);
            this.chkClienteActivo.TabIndex = 66;
            this.chkClienteActivo.Text = "Socio Activo";
            this.chkClienteActivo.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(249, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 59;
            this.label14.Text = "Cumpleaños";
            // 
            // datetimeCumple
            // 
            this.datetimeCumple.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeCumple.Location = new System.Drawing.Point(320, 69);
            this.datetimeCumple.Name = "datetimeCumple";
            this.datetimeCumple.Size = new System.Drawing.Size(138, 20);
            this.datetimeCumple.TabIndex = 58;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(320, 43);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(138, 20);
            this.txtEmail.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(273, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Socio desde";
            // 
            // datetimeSociodesde
            // 
            this.datetimeSociodesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeSociodesde.Location = new System.Drawing.Point(320, 95);
            this.datetimeSociodesde.Name = "datetimeSociodesde";
            this.datetimeSociodesde.Size = new System.Drawing.Size(138, 20);
            this.datetimeSociodesde.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Genero";
            // 
            // btnAgregarFoto
            // 
            this.btnAgregarFoto.Location = new System.Drawing.Point(478, 137);
            this.btnAgregarFoto.Name = "btnAgregarFoto";
            this.btnAgregarFoto.Size = new System.Drawing.Size(78, 23);
            this.btnAgregarFoto.TabIndex = 34;
            this.btnAgregarFoto.Text = "Agregar Foto";
            this.btnAgregarFoto.UseVisualStyleBackColor = true;
            this.btnAgregarFoto.Click += new System.EventHandler(this.btnAgregarFoto_Click);
            // 
            // txtIdeClie
            // 
            this.txtIdeClie.Location = new System.Drawing.Point(77, 14);
            this.txtIdeClie.Name = "txtIdeClie";
            this.txtIdeClie.ReadOnly = true;
            this.txtIdeClie.Size = new System.Drawing.Size(69, 20);
            this.txtIdeClie.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "CodigoClie";
            // 
            // txtNombreClie
            // 
            this.txtNombreClie.Location = new System.Drawing.Point(77, 43);
            this.txtNombreClie.Name = "txtNombreClie";
            this.txtNombreClie.Size = new System.Drawing.Size(163, 20);
            this.txtNombreClie.TabIndex = 17;
            // 
            // ptbClie
            // 
            this.ptbClie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbClie.BackgroundImage")));
            this.ptbClie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbClie.ErrorImage = null;
            this.ptbClie.InitialImage = null;
            this.ptbClie.Location = new System.Drawing.Point(464, 14);
            this.ptbClie.Name = "ptbClie";
            this.ptbClie.Size = new System.Drawing.Size(103, 114);
            this.ptbClie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClie.TabIndex = 32;
            this.ptbClie.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombres";
            // 
            // txtDireccionClie
            // 
            this.txtDireccionClie.Location = new System.Drawing.Point(77, 121);
            this.txtDireccionClie.Multiline = true;
            this.txtDireccionClie.Name = "txtDireccionClie";
            this.txtDireccionClie.Size = new System.Drawing.Size(381, 39);
            this.txtDireccionClie.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cedula";
            // 
            // txtTelefonoClie
            // 
            this.txtTelefonoClie.Location = new System.Drawing.Point(320, 17);
            this.txtTelefonoClie.Name = "txtTelefonoClie";
            this.txtTelefonoClie.Size = new System.Drawing.Size(138, 20);
            this.txtTelefonoClie.TabIndex = 19;
            this.txtTelefonoClie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoClie_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Direccion";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.txtDireccionClie);
            this.panel1.Controls.Add(this.txtGenero);
            this.panel1.Controls.Add(this.cboGenero);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.btnAgregarFoto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.chkClienteActivo);
            this.panel1.Controls.Add(this.datetimeCumple);
            this.panel1.Controls.Add(this.txtIdeClie);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.ptbClie);
            this.panel1.Controls.Add(this.txtNombreClie);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.datetimeSociodesde);
            this.panel1.Controls.Add(this.txtTelefonoClie);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(7, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 175);
            this.panel1.TabIndex = 39;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(178, 137);
            this.txtGenero.Multiline = true;
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(14, 11);
            this.txtGenero.TabIndex = 73;
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cboGenero.Location = new System.Drawing.Point(77, 69);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(128, 21);
            this.cboGenero.TabIndex = 72;
            this.cboGenero.SelectedIndexChanged += new System.EventHandler(this.cboGenero_SelectedIndexChanged);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(77, 95);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(163, 20);
            this.txtCedula.TabIndex = 71;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged_1);
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtPesoidoneo);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.txtCondicion);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.txtPeso);
            this.panel3.Controls.Add(this.txtAltura);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(7, 369);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(581, 73);
            this.panel3.TabIndex = 91;
            // 
            // txtPesoidoneo
            // 
            this.txtPesoidoneo.Location = new System.Drawing.Point(398, 40);
            this.txtPesoidoneo.Name = "txtPesoidoneo";
            this.txtPesoidoneo.ReadOnly = true;
            this.txtPesoidoneo.Size = new System.Drawing.Size(163, 20);
            this.txtPesoidoneo.TabIndex = 85;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(326, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 86;
            this.label18.Text = "Peso idoneo";
            // 
            // txtCondicion
            // 
            this.txtCondicion.Location = new System.Drawing.Point(398, 11);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.ReadOnly = true;
            this.txtCondicion.Size = new System.Drawing.Size(163, 20);
            this.txtCondicion.TabIndex = 83;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(326, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 84;
            this.label17.Text = "Condicion";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(74, 14);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.ReadOnly = true;
            this.txtPeso.Size = new System.Drawing.Size(163, 20);
            this.txtPeso.TabIndex = 75;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(75, 40);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.ReadOnly = true;
            this.txtAltura.Size = new System.Drawing.Size(163, 20);
            this.txtAltura.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 81;
            this.label13.Text = "Peso";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 82;
            this.label15.Text = "Altura";
            // 
            // chkPesoActual
            // 
            this.chkPesoActual.Location = new System.Drawing.Point(177, 341);
            this.chkPesoActual.Name = "chkPesoActual";
            this.chkPesoActual.Size = new System.Drawing.Size(35, 17);
            this.chkPesoActual.TabIndex = 90;
            this.chkPesoActual.Text = "Si";
            this.chkPesoActual.UseVisualStyleBackColor = true;
            this.chkPesoActual.CheckedChanged += new System.EventHandler(this.chkPesoActual_CheckedChanged);
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(11, 342);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 13);
            this.label16.TabIndex = 89;
            this.label16.Text = "Desea Añadir su peso actual";
            // 
            // chkDatosAdicionales
            // 
            this.chkDatosAdicionales.Location = new System.Drawing.Point(177, 230);
            this.chkDatosAdicionales.Name = "chkDatosAdicionales";
            this.chkDatosAdicionales.Size = new System.Drawing.Size(35, 17);
            this.chkDatosAdicionales.TabIndex = 88;
            this.chkDatosAdicionales.Text = "Si";
            this.chkDatosAdicionales.UseVisualStyleBackColor = true;
            this.chkDatosAdicionales.CheckedChanged += new System.EventHandler(this.chkDatosAdicionales_CheckedChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 13);
            this.label9.TabIndex = 87;
            this.label9.Text = "Desea Añadir Datos Adicionales";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txttelefonodeltrabajo);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtocupacion);
            this.panel2.Controls.Add(this.txtapodo);
            this.panel2.Controls.Add(this.txttelefonodecasa);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(7, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 71);
            this.panel2.TabIndex = 86;
            // 
            // txttelefonodeltrabajo
            // 
            this.txttelefonodeltrabajo.Location = new System.Drawing.Point(429, 41);
            this.txttelefonodeltrabajo.Name = "txttelefonodeltrabajo";
            this.txttelefonodeltrabajo.ReadOnly = true;
            this.txttelefonodeltrabajo.Size = new System.Drawing.Size(134, 20);
            this.txttelefonodeltrabajo.TabIndex = 81;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(316, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 13);
            this.label19.TabIndex = 82;
            this.label19.Text = "Telefono del Trabajo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 80;
            this.label12.Text = "Ocupacion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 13);
            this.label10.TabIndex = 73;
            this.label10.Text = "Le gusta ser llamado por: ";
            // 
            // txtocupacion
            // 
            this.txtocupacion.Location = new System.Drawing.Point(145, 38);
            this.txtocupacion.Name = "txtocupacion";
            this.txtocupacion.ReadOnly = true;
            this.txtocupacion.Size = new System.Drawing.Size(163, 20);
            this.txtocupacion.TabIndex = 74;
            // 
            // txtapodo
            // 
            this.txtapodo.Location = new System.Drawing.Point(144, 12);
            this.txtapodo.Name = "txtapodo";
            this.txtapodo.ReadOnly = true;
            this.txtapodo.Size = new System.Drawing.Size(163, 20);
            this.txtapodo.TabIndex = 73;
            // 
            // txttelefonodecasa
            // 
            this.txttelefonodecasa.Location = new System.Drawing.Point(429, 15);
            this.txttelefonodecasa.Name = "txttelefonodecasa";
            this.txttelefonodecasa.ReadOnly = true;
            this.txttelefonodecasa.Size = new System.Drawing.Size(134, 20);
            this.txttelefonodecasa.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Telefono de Casa";
            // 
            // FrmSocios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(597, 537);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chkPesoActual);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.chkDatosAdicionales);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmSocios";
            this.Text = "Socios";
            this.Load += new System.EventHandler(this.FrmSocios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClie)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.ToolStripButton btnGuardar;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.DateTimePicker datetimeSociodesde;
        public System.Windows.Forms.Button btnAgregarFoto;
        public System.Windows.Forms.TextBox txtIdeClie;
        public System.Windows.Forms.TextBox txtNombreClie;
        public System.Windows.Forms.PictureBox ptbClie;
        public System.Windows.Forms.TextBox txtDireccionClie;
        public System.Windows.Forms.TextBox txtTelefonoClie;
        public System.Windows.Forms.DateTimePicker datetimeCumple;
        public System.Windows.Forms.CheckBox chkClienteActivo;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtCedula;
        public System.Windows.Forms.TextBox txtGenero;
        public System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtPesoidoneo;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox txtPeso;
        public System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkPesoActual;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkDatosAdicionales;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txttelefonodeltrabajo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtocupacion;
        public System.Windows.Forms.TextBox txtapodo;
        public System.Windows.Forms.TextBox txttelefonodecasa;
        private System.Windows.Forms.Label label7;
    }
}