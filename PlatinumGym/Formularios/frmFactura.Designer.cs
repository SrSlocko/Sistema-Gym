namespace PlatinumGym.Formularios
{
    partial class frmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminarItem = new System.Windows.Forms.Button();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.txtTotalFact = new System.Windows.Forms.TextBox();
            this.txtIvaFact = new System.Windows.Forms.TextBox();
            this.txtSubtotalFact = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgDetalle = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefonoClie = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.btnBuscarClie = new System.Windows.Forms.Button();
            this.txtNombreClie = new System.Windows.Forms.TextBox();
            this.txtDireccionClie = new System.Windows.Forms.TextBox();
            this.txtCedulaClie = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdeClie = new System.Windows.Forms.TextBox();
            this.lblFechaFact = new System.Windows.Forms.Label();
            this.lblNroFact = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFinalMembresia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdeMembresia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtNombreMembresia = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIdeArti = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPVP = new System.Windows.Forms.TextBox();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnAgregarMembresia = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdeArti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreArti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdeMembresia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMembr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IniciMembr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalMembr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoMembr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(347, 443);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 33);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(206, 443);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 33);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminarItem
            // 
            this.btnEliminarItem.Location = new System.Drawing.Point(627, 249);
            this.btnEliminarItem.Name = "btnEliminarItem";
            this.btnEliminarItem.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarItem.TabIndex = 33;
            this.btnEliminarItem.Text = "Eliminar";
            this.btnEliminarItem.UseVisualStyleBackColor = true;
            this.btnEliminarItem.Click += new System.EventHandler(this.btnEliminarItem_Click);
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Location = new System.Drawing.Point(627, 220);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarItem.TabIndex = 31;
            this.btnAgregarItem.Text = "Agregar";
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // txtTotalFact
            // 
            this.txtTotalFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTotalFact.Location = new System.Drawing.Point(627, 399);
            this.txtTotalFact.Name = "txtTotalFact";
            this.txtTotalFact.ReadOnly = true;
            this.txtTotalFact.Size = new System.Drawing.Size(80, 20);
            this.txtTotalFact.TabIndex = 13;
            // 
            // txtIvaFact
            // 
            this.txtIvaFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtIvaFact.Location = new System.Drawing.Point(627, 350);
            this.txtIvaFact.Name = "txtIvaFact";
            this.txtIvaFact.ReadOnly = true;
            this.txtIvaFact.Size = new System.Drawing.Size(80, 20);
            this.txtIvaFact.TabIndex = 17;
            // 
            // txtSubtotalFact
            // 
            this.txtSubtotalFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSubtotalFact.Location = new System.Drawing.Point(627, 303);
            this.txtSubtotalFact.Name = "txtSubtotalFact";
            this.txtSubtotalFact.ReadOnly = true;
            this.txtSubtotalFact.Size = new System.Drawing.Size(80, 20);
            this.txtSubtotalFact.TabIndex = 12;
            this.txtSubtotalFact.TextChanged += new System.EventHandler(this.txtSubtotalFact_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(646, 380);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 16);
            this.label17.TabIndex = 26;
            this.label17.Text = "TOTAL";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(654, 331);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 16);
            this.label16.TabIndex = 30;
            this.label16.Text = "IVA";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(627, 284);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 16);
            this.label15.TabIndex = 24;
            this.label15.Text = "SUBTOTAL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgDetalle);
            this.groupBox2.Location = new System.Drawing.Point(15, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 209);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DETALLE DE FACTURA";
            // 
            // dtgDetalle
            // 
            this.dtgDetalle.AllowUserToAddRows = false;
            this.dtgDetalle.AllowUserToDeleteRows = false;
            this.dtgDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detalle,
            this.NroFact,
            this.IdeArti,
            this.NombreArti,
            this.Cantidad,
            this.PVP,
            this.Valor,
            this.IdeMembresia,
            this.NombreMembr,
            this.IniciMembr,
            this.FinalMembr,
            this.CostoMembr});
            this.dtgDetalle.Location = new System.Drawing.Point(14, 29);
            this.dtgDetalle.Name = "dtgDetalle";
            this.dtgDetalle.ReadOnly = true;
            this.dtgDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDetalle.Size = new System.Drawing.Size(592, 174);
            this.dtgDetalle.TabIndex = 0;
            this.dtgDetalle.Tag = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefonoClie);
            this.groupBox1.Controls.Add(this.txtGenero);
            this.groupBox1.Controls.Add(this.btnBuscarClie);
            this.groupBox1.Controls.Add(this.txtNombreClie);
            this.groupBox1.Controls.Add(this.txtDireccionClie);
            this.groupBox1.Controls.Add(this.txtCedulaClie);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtIdeClie);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL CLIENTE";
            // 
            // txtTelefonoClie
            // 
            this.txtTelefonoClie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTelefonoClie.Location = new System.Drawing.Point(462, 58);
            this.txtTelefonoClie.Name = "txtTelefonoClie";
            this.txtTelefonoClie.ReadOnly = true;
            this.txtTelefonoClie.Size = new System.Drawing.Size(102, 21);
            this.txtTelefonoClie.TabIndex = 1;
            // 
            // txtGenero
            // 
            this.txtGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtGenero.Location = new System.Drawing.Point(496, 64);
            this.txtGenero.Multiline = true;
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.ReadOnly = true;
            this.txtGenero.Size = new System.Drawing.Size(26, 15);
            this.txtGenero.TabIndex = 3;
            // 
            // btnBuscarClie
            // 
            this.btnBuscarClie.Location = new System.Drawing.Point(597, 27);
            this.btnBuscarClie.Name = "btnBuscarClie";
            this.btnBuscarClie.Size = new System.Drawing.Size(86, 50);
            this.btnBuscarClie.TabIndex = 2;
            this.btnBuscarClie.Text = "Buscar Cliente";
            this.btnBuscarClie.UseVisualStyleBackColor = true;
            this.btnBuscarClie.Click += new System.EventHandler(this.btnBuscarClie_Click);
            // 
            // txtNombreClie
            // 
            this.txtNombreClie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNombreClie.Location = new System.Drawing.Point(293, 29);
            this.txtNombreClie.Name = "txtNombreClie";
            this.txtNombreClie.ReadOnly = true;
            this.txtNombreClie.Size = new System.Drawing.Size(271, 21);
            this.txtNombreClie.TabIndex = 1;
            // 
            // txtDireccionClie
            // 
            this.txtDireccionClie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDireccionClie.Location = new System.Drawing.Point(82, 58);
            this.txtDireccionClie.Name = "txtDireccionClie";
            this.txtDireccionClie.ReadOnly = true;
            this.txtDireccionClie.Size = new System.Drawing.Size(315, 21);
            this.txtDireccionClie.TabIndex = 1;
            // 
            // txtCedulaClie
            // 
            this.txtCedulaClie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCedulaClie.Location = new System.Drawing.Point(82, 29);
            this.txtCedulaClie.Name = "txtCedulaClie";
            this.txtCedulaClie.ReadOnly = true;
            this.txtCedulaClie.Size = new System.Drawing.Size(127, 21);
            this.txtCedulaClie.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cedula";
            // 
            // txtIdeClie
            // 
            this.txtIdeClie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIdeClie.Location = new System.Drawing.Point(496, 29);
            this.txtIdeClie.Name = "txtIdeClie";
            this.txtIdeClie.ReadOnly = true;
            this.txtIdeClie.Size = new System.Drawing.Size(68, 21);
            this.txtIdeClie.TabIndex = 1;
            // 
            // lblFechaFact
            // 
            this.lblFechaFact.AutoSize = true;
            this.lblFechaFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFact.ForeColor = System.Drawing.Color.Red;
            this.lblFechaFact.Location = new System.Drawing.Point(596, 7);
            this.lblFechaFact.Name = "lblFechaFact";
            this.lblFechaFact.Size = new System.Drawing.Size(99, 20);
            this.lblFechaFact.TabIndex = 10;
            this.lblFechaFact.Text = "00/00/0000";
            // 
            // lblNroFact
            // 
            this.lblNroFact.AutoSize = true;
            this.lblNroFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroFact.ForeColor = System.Drawing.Color.Red;
            this.lblNroFact.Location = new System.Drawing.Point(36, 7);
            this.lblNroFact.Name = "lblNroFact";
            this.lblNroFact.Size = new System.Drawing.Size(109, 20);
            this.lblNroFact.TabIndex = 9;
            this.lblNroFact.Text = "0000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(463, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha Emision";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(-324, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Factura Nro";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtFinalMembresia);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtIdeMembresia);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtCosto);
            this.panel2.Controls.Add(this.txtNombreMembresia);
            this.panel2.Location = new System.Drawing.Point(12, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 31);
            this.panel2.TabIndex = 37;
            // 
            // txtFinalMembresia
            // 
            this.txtFinalMembresia.Location = new System.Drawing.Point(236, 4);
            this.txtFinalMembresia.Name = "txtFinalMembresia";
            this.txtFinalMembresia.Size = new System.Drawing.Size(76, 20);
            this.txtFinalMembresia.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Final";
            // 
            // txtIdeMembresia
            // 
            this.txtIdeMembresia.Location = new System.Drawing.Point(271, 7);
            this.txtIdeMembresia.Multiline = true;
            this.txtIdeMembresia.Name = "txtIdeMembresia";
            this.txtIdeMembresia.Size = new System.Drawing.Size(23, 14);
            this.txtIdeMembresia.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(319, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Costo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Membresia";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(359, 4);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(49, 20);
            this.txtCosto.TabIndex = 13;
            // 
            // txtNombreMembresia
            // 
            this.txtNombreMembresia.Location = new System.Drawing.Point(71, 5);
            this.txtNombreMembresia.Name = "txtNombreMembresia";
            this.txtNombreMembresia.Size = new System.Drawing.Size(112, 20);
            this.txtNombreMembresia.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNombreArticulo);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtIdeArti);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.txtStock);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtPVP);
            this.panel1.Location = new System.Drawing.Point(15, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 30);
            this.panel1.TabIndex = 36;
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Location = new System.Drawing.Point(68, 3);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(79, 20);
            this.txtNombreArticulo.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(343, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 13);
            this.label22.TabIndex = 23;
            this.label22.Text = "Cantidad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(454, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Valor";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(398, 3);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(55, 20);
            this.txtCantidad.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(252, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Stock";
            // 
            // txtIdeArti
            // 
            this.txtIdeArti.Location = new System.Drawing.Point(77, 6);
            this.txtIdeArti.Multiline = true;
            this.txtIdeArti.Name = "txtIdeArti";
            this.txtIdeArti.Size = new System.Drawing.Size(29, 10);
            this.txtIdeArti.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Articulo";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(491, 3);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(68, 20);
            this.txtValor.TabIndex = 3;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(293, 3);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(47, 20);
            this.txtStock.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(152, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "PVP";
            // 
            // txtPVP
            // 
            this.txtPVP.Location = new System.Drawing.Point(186, 3);
            this.txtPVP.Name = "txtPVP";
            this.txtPVP.Size = new System.Drawing.Size(60, 20);
            this.txtPVP.TabIndex = 1;
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(600, 185);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(104, 23);
            this.btnAgregarArticulo.TabIndex = 39;
            this.btnAgregarArticulo.Text = "Agregar Articulo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnAgregarMembresia
            // 
            this.btnAgregarMembresia.Location = new System.Drawing.Point(506, 150);
            this.btnAgregarMembresia.Name = "btnAgregarMembresia";
            this.btnAgregarMembresia.Size = new System.Drawing.Size(107, 23);
            this.btnAgregarMembresia.TabIndex = 38;
            this.btnAgregarMembresia.Text = "Agregar Membresia";
            this.btnAgregarMembresia.UseVisualStyleBackColor = true;
            this.btnAgregarMembresia.Click += new System.EventHandler(this.btnAgregarMembresia_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Coral;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnAgregarArticulo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.lblNroFact);
            this.panel3.Controls.Add(this.btnAgregarMembresia);
            this.panel3.Controls.Add(this.lblFechaFact);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.btnEliminarItem);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.btnAgregarItem);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.txtTotalFact);
            this.panel3.Controls.Add(this.txtSubtotalFact);
            this.panel3.Controls.Add(this.txtIvaFact);
            this.panel3.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(726, 528);
            this.panel3.TabIndex = 40;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Detalle
            // 
            this.Detalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Detalle.HeaderText = "IdeDetalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Width = 92;
            // 
            // NroFact
            // 
            this.NroFact.HeaderText = "NroFact";
            this.NroFact.Name = "NroFact";
            this.NroFact.ReadOnly = true;
            // 
            // IdeArti
            // 
            this.IdeArti.HeaderText = "IdeArti";
            this.IdeArti.Name = "IdeArti";
            this.IdeArti.ReadOnly = true;
            // 
            // NombreArti
            // 
            this.NombreArti.HeaderText = "NombreArticulo";
            this.NombreArti.Name = "NombreArti";
            this.NombreArti.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // PVP
            // 
            this.PVP.HeaderText = "PVP";
            this.PVP.Name = "PVP";
            this.PVP.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // IdeMembresia
            // 
            this.IdeMembresia.HeaderText = "IdeMembresia";
            this.IdeMembresia.Name = "IdeMembresia";
            this.IdeMembresia.ReadOnly = true;
            // 
            // NombreMembr
            // 
            this.NombreMembr.HeaderText = "NombreMembr";
            this.NombreMembr.Name = "NombreMembr";
            this.NombreMembr.ReadOnly = true;
            // 
            // IniciMembr
            // 
            this.IniciMembr.HeaderText = "IniciMembr";
            this.IniciMembr.Name = "IniciMembr";
            this.IniciMembr.ReadOnly = true;
            // 
            // FinalMembr
            // 
            this.FinalMembr.HeaderText = "FinalMembr";
            this.FinalMembr.Name = "FinalMembr";
            this.FinalMembr.ReadOnly = true;
            // 
            // CostoMembr
            // 
            this.CostoMembr.HeaderText = "CostoMembr";
            this.CostoMembr.Name = "CostoMembr";
            this.CostoMembr.ReadOnly = true;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(754, 601);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFactura";
            this.Text = "Factura";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnEliminarItem;
        public System.Windows.Forms.Button btnAgregarItem;
        public System.Windows.Forms.TextBox txtTotalFact;
        public System.Windows.Forms.TextBox txtIvaFact;
        public System.Windows.Forms.TextBox txtSubtotalFact;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgDetalle;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnBuscarClie;
        public System.Windows.Forms.TextBox txtNombreClie;
        public System.Windows.Forms.TextBox txtDireccionClie;
        public System.Windows.Forms.TextBox txtTelefonoClie;
        public System.Windows.Forms.TextBox txtCedulaClie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtIdeClie;
        public System.Windows.Forms.Label lblFechaFact;
        public System.Windows.Forms.Label lblNroFact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFinalMembresia;
        private System.Windows.Forms.Button btnAgregarMembresia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdeMembresia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtNombreMembresia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIdeArti;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPVP;
        public System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdeArti;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreArti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdeMembresia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMembr;
        private System.Windows.Forms.DataGridViewTextBoxColumn IniciMembr;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalMembr;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoMembr;
        }
}