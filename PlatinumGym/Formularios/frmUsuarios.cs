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
using CapaDatos.Conexion;
using CapaDatos.CDDatos;
using LogicaNegocio.ClasesLN;
using PlatinumGym.Formularios;
using System.IO;
namespace PlatinumGym.Formularios
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        LNUsuarios LNU = new LNUsuarios();
        LNRoles LNR = new LNRoles();
        EUsuarios U = new EUsuarios();
        LNValidaciones V = new LNValidaciones();
        public bool Nuevo = true;
        public bool Guardar;
        public bool ClikGuardar, Agregar;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LlenarComboRol()
        {
            cboRoles.DataSource = LNR.ListadeRoles("");
            cboRoles.DisplayMember = "NombreRol";
            cboRoles.ValueMember = "IdeRol";
            cboRoles.SelectedIndex = -1;
            txtIdeRol.Text = "";
        }

        private void HabilitarBotones(bool Opc)
        {
            btnNuevo.Enabled = Opc;
            btnGuardar.Enabled = Opc;
            btnCancelar.Enabled = Opc;
            btnEditar.Enabled = Opc;
            btnEliminar.Enabled = Opc;
            btnSalir.Enabled = Opc;
        }

        private void ContarRegistros()
        {
            if (dtgvDatos.Rows.Count == 0)
            {
                HabilitarBotones(false);
                btnNuevo.Enabled = true;
                btnSalir.Enabled = true;
            }
            if (dtgvDatos.Rows.Count > 0)
            {
                HabilitarBotones(true);
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        private void habilitarEdicion(bool op)
        {
            //V.Activartexbox(this, !op, panel1);
            chkUsuarioActivo.Enabled = op;
        }

        private void LimpiarControles()
        {
            //V.Limpiartexbox(this, panel1);
            chkUsuarioActivo.Checked = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreUsu.Text == "" || txtLogin.Text == "" || txtPassword.Text == "" || cboRoles.Text == "")
            {
                MessageBox.Show("Debe Ingresar todos los datos del Usuario");
                return;
            }
            U.NombreUsu = txtNombreUsu.Text;
            U.CedulaUsu = txtCedulaUsu.Text;
            U.LoginUsu = txtLogin.Text;
            U.PasswordUsu = txtPassword.Text;
            U.IdeRol = int.Parse(txtIdeRol.Text);
            U.ActivoUsu = chkUsuarioActivo.Checked;

            if (Agregar == true)
            {
                LNU.InsertarUsuarios(U);
                MessageBox.Show("Datos Insertados correctamente ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                U.IdeUsu = Int16.Parse(txtideUsu.Text);
                LNU.ModificarUsuarios(U);
                MessageBox.Show("Usuarios Actualizado correctamente ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            habilitarEdicion(false);
            txtBuscar.ReadOnly = false;
            ListarUsuarios();
            ContarRegistros();

            
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            LimpiarControles();
            dtgvDatos.EnableHeadersVisualStyles = false;
            LlenarComboRol();
            ListarUsuarios();
            ContarRegistros();
            habilitarEdicion(false);
            txtBuscar.ReadOnly = false;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarControles();
            habilitarEdicion(false);
            txtBuscar.ReadOnly = false;
            ListarUsuarios();
            ContarRegistros();
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
            LimpiarControles();
        }

        private void cboRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRoles.Text != "")
                txtIdeRol.Text = cboRoles.SelectedValue.ToString();
            else
                txtIdeRol.Text = "";
        }

        private void ListarUsuarios()
        {
            dtgvDatos.DataSource = LNU.ListadeUsuarios(txtBuscar.Text);
            
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
            DialogResult R = MessageBox.Show("Esta Seguro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (R == DialogResult.Yes)
            {
                U.IdeUsu = Int16.Parse(dtgvDatos.CurrentRow.Cells["IdeUsu"].Value.ToString());
                LNU.EliminarUsuarios(U);
                ListarUsuarios();
                ContarRegistros();
            }
        }

        private void dtgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvDatos.Rows.Count > 0)
            {
                txtideUsu.Text = dtgvDatos.CurrentRow.Cells[0].Value.ToString();
                txtNombreUsu.Text = dtgvDatos.CurrentRow.Cells[1].Value.ToString();
                txtCedulaUsu.Text = dtgvDatos.CurrentRow.Cells[2].Value.ToString();
                txtLogin.Text = dtgvDatos.CurrentRow.Cells[3].Value.ToString();
                txtPassword.Text = dtgvDatos.CurrentRow.Cells[4].Value.ToString();
                chkUsuarioActivo.Checked = bool.Parse(dtgvDatos.CurrentRow.Cells["ActivoUsu"].Value.ToString());
                txtIdeRol.Text = dtgvDatos.CurrentRow.Cells[5].Value.ToString();
                cboRoles.Text = dtgvDatos.CurrentRow.Cells[6].Value.ToString();
            }
        }
    }
}
