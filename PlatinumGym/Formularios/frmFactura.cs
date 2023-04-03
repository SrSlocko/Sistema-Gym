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
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }

        LNCabeceraFactura LNC = new LNCabeceraFactura();
        ECabeceraFactura C = new ECabeceraFactura();
        LNDetalleFactura LND = new LNDetalleFactura();
        EDetalleFactura D = new EDetalleFactura();
        LNArticulos LNA = new LNArticulos();
        EArticulos A = new EArticulos();
        LNMembresias LNM = new LNMembresias();
        EMembresias M = new EMembresias();

        public void ListarDetalleFactura()
        {
            var consulta = LND.ListarDetalleFacturas(lblNroFact.Text);
            foreach (var D in consulta)
            {
                dtgDetalle.Rows.Add(D.IdDetalle, D.IdArti, D.NombreArti, D.Cantidad, D.PVP, D.Valor);

            }
        }

        private void btnBuscarClie_Click(object sender, EventArgs e)
        {
            frmListadeSocios fr = new frmListadeSocios();
            fr.ShowDialog();
            if (fr.Pasar == true)
            {
                //txtIdeClie.Text = fr.dtgvSocios.CurrentRow.Cells["CodigoClie"].Value.ToString();
                txtCedulaClie.Text = fr.dtgvSocios.CurrentRow.Cells["CedulaClie"].Value.ToString();
                txtNombreClie.Text = fr.dtgvSocios.CurrentRow.Cells["NombreClie"].Value.ToString();
                txtDireccionClie.Text = fr.dtgvSocios.CurrentRow.Cells["DireccionClie"].Value.ToString();
                txtTelefonoClie.Text = fr.dtgvSocios.CurrentRow.Cells["TelefonoClie"].Value.ToString();
         
                
            }
        }

        private void CalcularValor()
        {
            if (txtPVP.Text != "" && txtCantidad.Text != "")
            {

                txtValor.Text = (decimal.Parse(txtPVP.Text) * int.Parse(txtCantidad.Text)).ToString();
            }
        }

       

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtPVP.Text != "" && txtCantidad.Text != "")
            {
                if (int.Parse(txtCantidad.Text) > int.Parse(txtStock.Text))
                {
                    MessageBox.Show("Stock Insuficiente");
                    return;
                }
            }
            CalcularValor();
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            if (txtIdeArti.Text != "")
            {
                dtgDetalle.Rows.Add("", lblNroFact.Text, txtIdeArti.Text, txtNombreArticulo.Text, txtCantidad.Text, txtPVP.Text, txtValor.Text, txtIdeMembresia.Text, txtNombreMembresia.Text, txtFinalMembresia.Text, txtCosto.Text);
                txtIdeArti.Clear();
                txtNombreArticulo.Clear();
                txtCantidad.Clear();
                txtPVP.Clear();
                txtValor.Clear();
                txtStock.Clear();
                txtIdeMembresia.Clear();
                txtNombreMembresia.Clear();

                txtFinalMembresia.Clear();
                txtCosto.Clear();
                CalcularFactura();
            }
            else
                
                    {
                        MessageBox.Show("Debe buscar un articulo o una membresia");
                    }
        }
        private void CalcularFactura()
        {
            decimal Sub = 0, Iva, Total;
            foreach (DataGridViewRow row in dtgDetalle.Rows)
            {
                Sub = Sub + decimal.Parse(row.Cells["valor"].Value.ToString());
                Sub = Sub + decimal.Parse(row.Cells["CostoMembr"].Value.ToString());
            }
            Iva = Sub * 12 / 100;
            Total = Sub + Iva;
            txtSubtotalFact.Text = Sub.ToString();
            txtIvaFact.Text = Iva.ToString();
            txtTotalFact.Text = Total.ToString();
        }

      

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCedulaClie.Text == "")
            {
                MessageBox.Show("Debe seleccionar un cliente");
                return;
            }
            if (dtgDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar Items a la Venta");
                return;
            }

            //grabarCabecera
            C.NroFact = lblNroFact.Text;
            C.FechaFact = DateTime.Parse(lblFechaFact.Text);
            C.CodigoSocio = txtIdeClie.Text;
            C.SubtotalFact = Decimal.Parse(txtSubtotalFact.Text);
            C.IvaFact = Decimal.Parse(txtIvaFact.Text);
            C.TotalFact = Decimal.Parse(txtTotalFact.Text);
            LNC.InsertarCabeceraFactura(C);

            //GrabarDetalleFactura
            foreach (DataGridViewRow row in dtgDetalle.Rows)
            {
                D.NroFact = lblNroFact.Text;
                D.IdArti = int.Parse(row.Cells["IdeArti"].Value.ToString());
                D.Cantidad = int.Parse(row.Cells["Cantidad"].Value.ToString());
                D.PVP = Decimal.Parse(row.Cells["PVP"].Value.ToString());
                D.Valor = Decimal.Parse(row.Cells["Valor"].Value.ToString());
                D.IdeMembresia=int.Parse(row.Cells["IdeMembresia"].Value.ToString());
                D.CostoMembr = Decimal.Parse(row.Cells["CostoMembr"].Value.ToString());
                LND.InsertarDetalleFactura(D);

                A.Cantidad = int.Parse(row.Cells["Cantidad"].Value.ToString());
                A.IdArti = int.Parse(row.Cells["IdeArti"].Value.ToString());
                LNA.DisminuirStockArticulo(A);
            }

            MessageBox.Show("Factura se guardo con exito");
            btnBuscarClie.Enabled = false;
            //btnBuscarArticulo.Enabled = false;
            btnAgregarItem.Enabled = false;
            btnEliminarItem.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Text = "Salir";

        }

        private void frmFaactura_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

      

        private void btnAgregarMembresia_Click(object sender, EventArgs e)
        {
            frmListadeMembresias fr = new frmListadeMembresias();
            fr.btnPasar.Visible = true;
            fr.ShowDialog();
            if (fr.Pasar == true)
            {
                txtIdeMembresia.Text = fr.dtgvMembresias.CurrentRow.Cells["IdeMembresia"].Value.ToString();
                txtNombreMembresia.Text = fr.dtgvMembresias.CurrentRow.Cells["NombreMembr"].Value.ToString();
                txtFinalMembresia.Text = fr.dtgvMembresias.CurrentRow.Cells["FinalMembr"].Value.ToString();
                txtCosto.Text = fr.dtgvMembresias.CurrentRow.Cells["CostoMembr"].Value.ToString();
              
            }
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmListadeProductos fr = new frmListadeProductos();
            fr.btnPasar.Visible = true;
            fr.ShowDialog();
            if (fr.Pasar == true)
            {
                txtIdeArti.Text = fr.dtvgProductos.CurrentRow.Cells["IdArti"].Value.ToString();
                txtNombreArticulo.Text = fr.dtvgProductos.CurrentRow.Cells["NombreArti"].Value.ToString();
                txtPVP.Text = fr.dtvgProductos.CurrentRow.Cells["PreVenta"].Value.ToString();
                txtStock.Text = fr.dtvgProductos.CurrentRow.Cells["StockArti"].Value.ToString();
                txtCantidad.Text = "1";
                txtValor.Text = txtPVP.Text;
            }
        }

        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            if (dtgDetalle.Rows.Count > 0)
            {
                DialogResult R = MessageBox.Show("Esta Seguro", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == R)
                {
                    dtgDetalle.Rows.RemoveAt(dtgDetalle.CurrentRow.Index);
                    CalcularFactura();
                }
            }
        }

        private void txtSubtotalFact_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
            {

            }
        }
}
