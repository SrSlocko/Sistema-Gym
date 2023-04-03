using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio.ClasesLN;
using Entidades.ClasesEntidades;
namespace PlatinumGym.Formularios
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }
        LNProveedores LNP = new LNProveedores();
        EProveedores EP = new EProveedores();

      

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        bool Nuevo;

        private void HabilitarBotones(bool opc)
        {
            btnNuevo.Enabled = opc;
            btnEditar.Enabled = opc;
            btnCancelar.Enabled = opc;
            btnGuardar.Enabled = opc;
            btnEliminar.Enabled = opc;
            btnConsultar.Enabled = opc;
        }

        private void contarRegistros()
        {
            if (dtgDatos.Rows.Count == 0)
            {
                HabilitarBotones(false);
                btnNuevo.Enabled = true;
            }
            else
            {
                HabilitarBotones(true);
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        private void HabilitarTextbox(bool op)
        {
            txtNombre.ReadOnly = !op;
            txtCedulaRuc.ReadOnly = !op;
            txtDireccion.ReadOnly = !op;
            txtTelefono.ReadOnly = !op;
        }

        private void LimpiarTextBox()
        {
            txtCedulaRuc.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtIde.Clear();
        }

        private void ListarDatos()
        {
            dtgDatos.DataSource = LNP.ListarProveedores(txtBuscar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EP.RucProve = txtCedulaRuc.Text;
            EP.Nombre = txtNombre.Text;
            EP.DireccionProve = txtDireccion.Text;
            EP.TelefonoProve = txtTelefono.Text;
            if (Nuevo == true)
                LNP.InsertarProveedor(EP);
            else
            {
                EP.IdProve = int.Parse(txtIde.Text);
                LNP.ActualizarPproveedor(EP);
            }
            ListarDatos();
            contarRegistros();
            HabilitarTextbox(false);
            PanelDatos.Visible = false;
            PanelLista.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            PanelLista.Visible = false;
            PanelDatos.Visible = true;
            HabilitarTextbox(true);
            HabilitarBotones(false);
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            Nuevo = false;
            txtCedulaRuc.Focus();
        }

        private void dtgDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgDatos.Rows.Count > 0)
            {
                txtIde.Text = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                txtCedulaRuc.Text = dtgDatos.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dtgDatos.CurrentRow.Cells[2].Value.ToString();
                txtDireccion.Text = dtgDatos.CurrentRow.Cells[3].Value.ToString();
                txtTelefono.Text = dtgDatos.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarTextBox();
            HabilitarTextbox(false);
            ListarDatos();
            contarRegistros();
            PanelDatos.Visible = false;
            PanelLista.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgDatos.Rows.Count > 0)
            {
                DialogResult R = MessageBox.Show("Esta Seguro", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == R)
                {
                    EP.IdProve = int.Parse(dtgDatos.CurrentRow.Cells[0].Value.ToString());
                    LNP.EliminarProveedores(EP);
                    ListarDatos();
                    contarRegistros();
                }
            }
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            ListarDatos();
           
        }

       

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PanelLista.Visible = false;
            PanelDatos.Visible = true;
            LimpiarTextBox();
            HabilitarTextbox(true);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCedulaRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        

    }
}
