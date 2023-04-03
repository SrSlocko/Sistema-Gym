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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        LNCategorias LNC = new LNCategorias();
        ECategorias EC = new ECategorias();

        bool Nuevo;

        private void HabilitarBotones(bool opc)
        {
            btnNuevo.Enabled = opc;
            btnEditar.Enabled = opc;
            btnCancelar.Enabled = opc;
            btnGuardar.Enabled = opc;
            btnEliminar.Enabled = opc;
        }

        private void contarRegistros()
        {
            if (dtgvDatos.Rows.Count == 0)
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
            txtDescripcion.ReadOnly = !op;
        }

        private void LimpiarTextBox()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtIdentidad.Clear();
        }

        private void ListarDatos()
        {
            dtgvDatos.DataSource = LNC.ListarCategorias(txtBuscar.Text);
        }
        private void frmCategorias_Load(object sender, EventArgs e)
        {
            ListarDatos();
            contarRegistros();
            HabilitarTextbox(false);
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ListarDatos();
        }
        private void btnTodos_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
        }

        private void dtgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            txtIdentidad.Text = dtgvDatos.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dtgvDatos.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dtgvDatos.CurrentRow.Cells[2].Value.ToString();
        }

      
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ListarDatos();
            contarRegistros();
            HabilitarTextbox(false);
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            HabilitarTextbox(true);
            HabilitarBotones(false);
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtNombre.Focus();
            Nuevo = false;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("Esta Seguro", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (R == DialogResult.Yes)
            {
                EC.IdCate = int.Parse(txtIdentidad.Text);
                LNC.EliminarCategoria(EC);
                ListarDatos();
                contarRegistros();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            ListarDatos();
            contarRegistros();
            HabilitarTextbox(false);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarTextbox(true);
            LimpiarTextBox();
            HabilitarBotones(false);
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtNombre.Focus();
            Nuevo = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCategorias_Load_1(object sender, EventArgs e)
        {
            ListarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EC.NombreCate = txtNombre.Text;
            EC.DescripcionCate = txtDescripcion.Text;
            if (Nuevo == true)
                LNC.InsertarCategoria(EC);
            else
            {
                EC.IdCate = int.Parse(txtIdentidad.Text);
                LNC.ActualizarCategoria(EC);
            }

            ListarDatos();
            contarRegistros();
            HabilitarTextbox(false);
        }

        

      

       
      

        
    }
}