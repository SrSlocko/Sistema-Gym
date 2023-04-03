using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.ClasesEntidades;
using LogicaNegocio.ClasesLN;

namespace PlatinumGym.Formularios
{
    public partial class frmRoles : Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }
        public bool ClikGuardar, Agregar;
        LNRoles LNR = new LNRoles();
        ERoles R = new ERoles();
        LNValidaciones V = new LNValidaciones();
  
        private void ListarRoles()
        {
            dtgDatos.DataSource = LNR.ListadeRoles(txtBuscar.Text);
        }

        private void HabilitarBotones(bool Opc)
        {
            btnAgregar.Enabled = Opc;
            btnGuardar.Enabled = Opc;
            btnCancelar.Enabled = Opc;
            btnEditar.Enabled = Opc;
            btnEliminar.Enabled = Opc;
            btnSalir.Enabled = Opc;
        }


        private void ContarRegistros()
        {
            if (dtgDatos.Rows.Count == 0)
            {
                HabilitarBotones(false);
                btnAgregar.Enabled = true;
                btnSalir.Enabled = true;
            }
            if (dtgDatos.Rows.Count > 0)
            {
                HabilitarBotones(true);
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        private void habilitarEdicion(bool op)
        {
            V.Activartexbox(this, !op, panel1);
            chkClientes.Enabled = op;
            chkRespaldo.Enabled = op;
            chkRoles.Enabled = op;
            chkRespaldo.Enabled = op;
            chkUsuarios.Enabled = op;
        }

        private void LimpiarControles()
        {
            V.Limpiartexbox(this, panel1);
            chkClientes.Checked = false;
            chkRespaldo.Checked = false;
            chkRoles.Checked = false;
            chkRespaldo.Checked = false;
            chkUsuarios.Checked = false;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Agregar = true;
            LimpiarControles();
            habilitarEdicion(true);
            txtBuscar.ReadOnly = true;
            HabilitarBotones(false);
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Agregar = false;
            habilitarEdicion(true);
            txtBuscar.ReadOnly = true;
            HabilitarBotones(false);
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalir.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult RR = MessageBox.Show("Esta Seguro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (RR == DialogResult.Yes)
            {
                R.IdeRol = Int16.Parse(dtgDatos.CurrentRow.Cells["IdeRol"].Value.ToString());
                LNR.EliminarRoles(R);
                ListarRoles();
                ContarRegistros();
            }
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            ListarRoles();
            ContarRegistros();
            habilitarEdicion(false);
            txtBuscar.ReadOnly = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            habilitarEdicion(false);
            txtBuscar.ReadOnly = false;
            ListarRoles();
            ContarRegistros();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ListarRoles();
            ContarRegistros();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text == "")
            {
                MessageBox.Show("Ingrese Nombre del Rol");
                return;
            }
            R.NombreRol = txtNombres.Text;
            R.Clientes = chkClientes.Checked;
            R.Usuarios = chkUsuarios.Checked;
            R.Roles = chkRoles.Checked;
            R.Respaldo = chkRespaldo.Checked;
            R.Membresias = chkMembresia.Checked;
            R.Productos = chkProductos.Checked;
           

            if (Agregar == true)
            {
                LNR.InsertarRoles(R);
                MessageBox.Show("Datos Insertados correctamente ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                R.IdeRol = Int16.Parse(txtIdentidad.Text);
                LNR.ModificarRoles(R);
                MessageBox.Show("Cliente Actualizado correctamente ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            habilitarEdicion(false);
            txtBuscar.ReadOnly = false;
            ListarRoles();
            ContarRegistros();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
