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
    public partial class frmListadeFacturas : Form
    {
        public frmListadeFacturas()
        {
            InitializeComponent();
        }


        LNCabeceraFactura LNC = new LNCabeceraFactura();
        ECabeceraFactura C = new ECabeceraFactura();
        LNDetalleFactura LND = new LNDetalleFactura();

        private void ListarFacturas()
        {
            dtgvListaFacturas.DataSource = LNC.ListarCabeceraFacturas(txtBuscar.Text);
            //dtgvListaFacturas.DataSource = LND.ListarDetalleFacturas(txtBuscar.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
        
           
        }

        private void frmListaFacturas_Load(object sender, EventArgs e)
        {
            ListarFacturas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgvListaFacturas.Rows.Count > 0)
            {
                frmFactura fr = new frmFactura();

                fr.lblNroFact.Text = dtgvListaFacturas.CurrentRow.Cells["NroFact"].Value.ToString();
                fr.lblFechaFact.Text = dtgvListaFacturas.CurrentRow.Cells["FechaFact"].Value.ToString();
                fr.txtIdeClie.Text = dtgvListaFacturas.CurrentRow.Cells["CodigoClie"].Value.ToString();
                fr.txtCedulaClie.Text = dtgvListaFacturas.CurrentRow.Cells["CedulaClie"].Value.ToString();
                fr.txtNombreClie.Text = dtgvListaFacturas.CurrentRow.Cells["NombreClie"].Value.ToString();
                fr.txtDireccionClie.Text = dtgvListaFacturas.CurrentRow.Cells["DireccionClie"].Value.ToString();
                fr.txtTelefonoClie.Text = dtgvListaFacturas.CurrentRow.Cells["TelefonoClie"].Value.ToString();
                fr.txtSubtotalFact.Text = dtgvListaFacturas.CurrentRow.Cells["SubTotalFact"].Value.ToString();
                fr.txtIvaFact.Text = dtgvListaFacturas.CurrentRow.Cells["IvaFact"].Value.ToString();
                fr.txtTotalFact.Text = dtgvListaFacturas.CurrentRow.Cells["TotalFact"].Value.ToString();

                fr.ListarDetalleFactura();

                fr.btnBuscarClie.Enabled = false;
                //fr.btnBuscarArticulo.Enabled = false;
                fr.btnAgregarItem.Enabled = false;
                fr.btnEliminarItem.Enabled = false;
                fr.btnGuardar.Enabled = false;
                fr.btnCancelar.Text = "Salir";
                fr.ShowDialog();

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmFactura fr = new frmFactura();
            fr.lblNroFact.Text = LNC.GenerarNroFactura();
            fr.lblFechaFact.Text = DateTime.Now.ToShortDateString();
            fr.ShowDialog();
            ListarFacturas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void frmListadeFacturas_Load(object sender, EventArgs e)
        {
            ListarFacturas();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
