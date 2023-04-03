using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlatinumGym.Formularios;
using Entidades.ClasesEntidades;
using CapaDatos.Conexion;
using LogicaNegocio.ClasesLN;
namespace PlatinumGym.Formularios
{
    public partial class frmListadeProductos : Form
    {
        public frmListadeProductos()
        {
            InitializeComponent();
        }
        LNArticulos LNA = new LNArticulos();
        EArticulos A = new EArticulos();
        public bool Pasar = false;


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProductos fr = new frmProductos();
            fr.LLenarComboCategoria();
            fr.LLenarComboPresentaciones();
            fr.LLenarComboProveedores();
            fr.Nuevo = true;
            fr.ShowDialog();
            ListarArticulos();
        }
        private void ListarArticulos()
        {
            dtvgProductos.DataSource = LNA.ListarArticulos(txtBuscar.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtvgProductos_SelectionChanged(object sender, EventArgs e)
        {
            

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtvgProductos.Rows.Count > 0)
            {
                frmProductos fr = new frmProductos();
                fr.LLenarComboCategoria();
                fr.LLenarComboPresentaciones();
                fr.LLenarComboProveedores();
                fr.txtIde.Text = dtvgProductos.CurrentRow.Cells["IdArti"].Value.ToString();
                fr.txtNombre.Text = dtvgProductos.CurrentRow.Cells["NombreArti"].Value.ToString();
                fr.txtIdecat.Text = dtvgProductos.CurrentRow.Cells["IdCate"].Value.ToString();
                fr.txtIdePrese.Text = dtvgProductos.CurrentRow.Cells["IdPrese"].Value.ToString();
                fr.txtIdeProve.Text = dtvgProductos.CurrentRow.Cells["IdProve"].Value.ToString();
                fr.cboCategoria.Text = dtvgProductos.CurrentRow.Cells["NombreCate"].Value.ToString();
                fr.cboPresentacion.Text = dtvgProductos.CurrentRow.Cells["NombrePrese"].Value.ToString();
                fr.cboProveedores.Text = dtvgProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                fr.txtPreCompra.Text = dtvgProductos.CurrentRow.Cells["PresCompra"].Value.ToString();
                fr.txtPreVenta.Text = dtvgProductos.CurrentRow.Cells["PreVenta"].Value.ToString();
                fr.txtStock.Text = dtvgProductos.CurrentRow.Cells["StockArti"].Value.ToString();
                fr.Nuevo = false;
                fr.ShowDialog();
                ListarArticulos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtvgProductos.Rows.Count > 0)
            {
                DialogResult R = MessageBox.Show("Esta Seguro", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (R == DialogResult.Yes)
                {
                    A.IdArti = int.Parse(dtvgProductos.CurrentRow.Cells[0].Value.ToString());
                    LNA.EliminarArticulo(A);
                    ListarArticulos();
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ListarArticulos();
        }

        private void frmListadeProductos_Load(object sender, EventArgs e)
        {
            ListarArticulos();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnPasar_Click(object sender, EventArgs e)
        {
            Pasar = true;
            Close();
        }

    }
}
    

