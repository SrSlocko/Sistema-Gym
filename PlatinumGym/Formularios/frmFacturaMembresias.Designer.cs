namespace PlatinumGym.Formularios
{
    partial class frmFacturaMembresias
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
            this.IdeDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdeMembresia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMembr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IniciMembr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalMembr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoMembr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInicioMembresia = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtNombreMembresia = new System.Windows.Forms.TextBox();
            this.btnAgregarMembresia = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(343, 407);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 33);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(202, 407);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 33);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminarItem
            // 
            this.btnEliminarItem.Location = new System.Drawing.Point(628, 230);
            this.btnEliminarItem.Name = "btnEliminarItem";
            this.btnEliminarItem.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarItem.TabIndex = 33;
            this.btnEliminarItem.Text = "Eliminar";
            this.btnEliminarItem.UseVisualStyleBackColor = true;
            this.btnEliminarItem.Click += new System.EventHandler(this.btnEliminarItem_Click);
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Location = new System.Drawing.Point(628, 201);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarItem.TabIndex = 31;
            this.btnAgregarItem.Text = "Agregar";
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            // 
            // txtTotalFact
            // 
            this.txtTotalFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTotalFact.Location = new System.Drawing.Point(628, 380);
            this.txtTotalFact.Name = "txtTotalFact";
            this.txtTotalFact.ReadOnly = true;
            this.txtTotalFact.Size = new System.Drawing.Size(80, 20);
            this.txtTotalFact.TabIndex = 13;
            // 
            // txtIvaFact
            // 
            this.txtIvaFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtIvaFact.Location = new System.Drawing.Point(628, 331);
            this.txtIvaFact.Name = "txtIvaFact";
            this.txtIvaFact.ReadOnly = true;
            this.txtIvaFact.Size = new System.Drawing.Size(80, 20);
            this.txtIvaFact.TabIndex = 17;
            // 
            // txtSubtotalFact
            // 
            this.txtSubtotalFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSubtotalFact.Location = new System.Drawing.Point(628, 284);
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
            this.label17.Location = new System.Drawing.Point(647, 361);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 16);
            this.label17.TabIndex = 26;
            this.label17.Text = "TOTAL";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(655, 312);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 16);
            this.label16.TabIndex = 30;
            this.label16.Text = "IVA";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(628, 265);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 16);
            this.label15.TabIndex = 24;
            this.label15.Text = "SUBTOTAL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgDetalle);
            this.groupBox2.Location = new System.Drawing.Point(16, 201);
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
            this.IdeDetalle,
            this.NroFact,
            this.IdeMembresia,
            this.NombreMembr,
            this.IniciMembr,
            this.FinalMembr,
            this.CostoMembr,
            this.Cantidad,
            this.PVP,
            this.Valor});
            this.dtgDetalle.Location = new System.Drawing.Point(10, 19);
            this.dtgDetalle.Name = "dtgDetalle";
            this.dtgDetalle.ReadOnly = true;
            this.dtgDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDetalle.Size = new System.Drawing.Size(586, 170);
            this.dtgDetalle.TabIndex = 1;
            // 
            // IdeDetalle
            // 
            this.IdeDetalle.HeaderText = "IdeDetalle";
            this.IdeDetalle.Name = "IdeDetalle";
            this.IdeDetalle.ReadOnly = true;
            // 
            // NroFact
            // 
            this.NroFact.HeaderText = "NroFact";
            this.NroFact.Name = "NroFact";
            this.NroFact.ReadOnly = true;
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
            this.groupBox1.Location = new System.Drawing.Point(9, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL CLIENTE";
            // 
            // txtTelefonoClie
            // 
            this.txtTelefonoClie.BackColor = System.Drawing.Color.White;
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
            this.txtNombreClie.BackColor = System.Drawing.Color.White;
            this.txtNombreClie.Location = new System.Drawing.Point(293, 29);
            this.txtNombreClie.Name = "txtNombreClie";
            this.txtNombreClie.ReadOnly = true;
            this.txtNombreClie.Size = new System.Drawing.Size(271, 21);
            this.txtNombreClie.TabIndex = 1;
            // 
            // txtDireccionClie
            // 
            this.txtDireccionClie.BackColor = System.Drawing.Color.White;
            this.txtDireccionClie.Location = new System.Drawing.Point(82, 58);
            this.txtDireccionClie.Name = "txtDireccionClie";
            this.txtDireccionClie.ReadOnly = true;
            this.txtDireccionClie.Size = new System.Drawing.Size(315, 21);
            this.txtDireccionClie.TabIndex = 1;
            // 
            // txtCedulaClie
            // 
            this.txtCedulaClie.BackColor = System.Drawing.Color.White;
            this.txtCedulaClie.Location = new System.Drawing.Point(82, 27);
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
            this.lblFechaFact.Location = new System.Drawing.Point(593, 9);
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
            this.lblNroFact.Location = new System.Drawing.Point(138, 9);
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
            this.label3.Location = new System.Drawing.Point(460, 9);
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
            this.label1.Location = new System.Drawing.Point(12, 9);
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
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtInicioMembresia);
            this.panel2.Controls.Add(this.txtCosto);
            this.panel2.Controls.Add(this.txtNombreMembresia);
            this.panel2.Location = new System.Drawing.Point(9, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 31);
            this.panel2.TabIndex = 37;
            // 
            // txtFinalMembresia
            // 
            this.txtFinalMembresia.Location = new System.Drawing.Point(387, 4);
            this.txtFinalMembresia.Name = "txtFinalMembresia";
            this.txtFinalMembresia.Size = new System.Drawing.Size(76, 20);
            this.txtFinalMembresia.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Final";
            // 
            // txtIdeMembresia
            // 
            this.txtIdeMembresia.Location = new System.Drawing.Point(422, 7);
            this.txtIdeMembresia.Multiline = true;
            this.txtIdeMembresia.Name = "txtIdeMembresia";
            this.txtIdeMembresia.Size = new System.Drawing.Size(23, 14);
            this.txtIdeMembresia.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Inicio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(470, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Costo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Membresia";
            // 
            // txtInicioMembresia
            // 
            this.txtInicioMembresia.Location = new System.Drawing.Point(252, 4);
            this.txtInicioMembresia.Name = "txtInicioMembresia";
            this.txtInicioMembresia.Size = new System.Drawing.Size(100, 20);
            this.txtInicioMembresia.TabIndex = 14;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(510, 4);
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
            // btnAgregarMembresia
            // 
            this.btnAgregarMembresia.Location = new System.Drawing.Point(602, 154);
            this.btnAgregarMembresia.Name = "btnAgregarMembresia";
            this.btnAgregarMembresia.Size = new System.Drawing.Size(107, 31);
            this.btnAgregarMembresia.TabIndex = 38;
            this.btnAgregarMembresia.Text = "Agregar Membresia";
            this.btnAgregarMembresia.UseVisualStyleBackColor = true;
            this.btnAgregarMembresia.Click += new System.EventHandler(this.btnAgregarMembresia_Click);
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(721, 464);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAgregarMembresia);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminarItem);
            this.Controls.Add(this.btnAgregarItem);
            this.Controls.Add(this.txtTotalFact);
            this.Controls.Add(this.txtIvaFact);
            this.Controls.Add(this.txtSubtotalFact);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFechaFact);
            this.Controls.Add(this.lblNroFact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInicioMembresia;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtNombreMembresia;
        public System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.DataGridView dtgDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdeDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdeMembresia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMembr;
        private System.Windows.Forms.DataGridViewTextBoxColumn IniciMembr;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalMembr;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoMembr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}