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
using LogicaNegocio.ClasesLN;

namespace PlatinumGym.Formularios
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }
        public bool Nuevo;
        LNCategorias LNC = new LNCategorias();
        LNPresentaciones LNP = new LNPresentaciones();
        LNProveedores LNPR = new LNProveedores();
        ECategorias C = new ECategorias();
        EPresentaciones P = new EPresentaciones();
        EProveedores PR = new EProveedores();
        LNArticulos LNA = new LNArticulos();
        EArticulos A = new EArticulos();



        public void LLenarComboCategoria()
        {
            cboCategoria.DataSource = LNC.ListarCategorias("");
            cboCategoria.DisplayMember = "NombreCate";
            cboCategoria.ValueMember = "IdCate";
            cboCategoria.SelectedIndex = -1;
            txtIdecat.Text = "0";
        }

        public void LLenarComboPresentaciones()
        {
            cboPresentacion.DataSource = LNP.ListarPresentaciones("");
            cboPresentacion.DisplayMember = "NombrePrese";
            cboPresentacion.ValueMember = "IdPrese";
            cboPresentacion.SelectedIndex = -1;
            txtIdePrese.Text = "0";
        }

        public void LLenarComboProveedores()
        {
            cboProveedores.DataSource = LNPR.ListarProveedores("");
            cboProveedores.DisplayMember = "Nombre";
            cboProveedores.ValueMember = "IdProve";
            cboProveedores.SelectedIndex = -1;
            txtIdeProve.Text = "0";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            A.NombreArti = txtNombre.Text;
            A.IdCate = int.Parse(txtIdecat.Text);
            A.IdPrese = int.Parse(txtIdePrese.Text);
            A.IdProve = int.Parse(txtIdeProve.Text);
            A.PresVenta = decimal.Parse(txtPreVenta.Text);
            A.PresCompra = decimal.Parse(txtPreCompra.Text);
            A.StockArti = int.Parse(txtStock.Text);
            if (Nuevo == true)
                LNA.InsertarArticulo(A);
            else
            {
                A.IdArti = int.Parse(txtIde.Text);
                LNA.ActualizarArticulo(A);
            }

            Close();
        }

        private void cboProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProveedores.Text != "")
                txtIdeProve.Text = cboProveedores.SelectedValue.ToString();
            else
                txtIdeProve.Text = "0";
        }

        private void cboPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPresentacion.Text != "")
                txtIdePrese.Text = cboPresentacion.SelectedValue.ToString();
            else
                txtIdePrese.Text = "0";
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategoria.Text != "")
                txtIdecat.Text = cboCategoria.SelectedValue.ToString();
            else
                txtIdecat.Text = "0";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            LLenarComboProveedores();
            LLenarComboCategoria();
            LLenarComboPresentaciones();
        }

       
    }
}
