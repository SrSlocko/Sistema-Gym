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
using LogicaNegocio.ClasesLN;

namespace PlatinumGym.Formularios
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        LNSocios LNS = new LNSocios();

        private void btnNuevoSocio_Click(object sender, EventArgs e)
        {
            FrmSocios fr = new FrmSocios();
            fr.ShowDialog();
        }

        private void btnEditarSocio_Click(object sender, EventArgs e)
        {
            frmListadeSocios fr = new frmListadeSocios();
            fr.ShowDialog();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            frmListadeFacturas fr = new frmListadeFacturas();
            fr.ShowDialog();
        }

        private void btnNuevaMembresia_Click(object sender, EventArgs e)
        {
            frmMenbresias fr = new frmMenbresias();
            fr.ShowDialog();
        }

        private void btnEditarMembresia_Click(object sender, EventArgs e)
        {
            frmListadeMembresias fr = new frmListadeMembresias();
            fr.ShowDialog();
        }

        private void btnNuevaVisita_Click(object sender, EventArgs e)
        {
            frmListadeRegistro fr = new frmListadeRegistro();
            fr.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmListadeProductos fr = new frmListadeProductos();
            fr.ShowDialog();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            frmFactura fr = new frmFactura();
            fr.ShowDialog();
        }

        private void btnRespaldo_Click(object sender, EventArgs e)
        {
            frmRespaldo fr = new frmRespaldo();
            fr.ShowDialog();
        }

        private void ListarSocios() { dtgvSocio.DataSource = LNS.ListarSocios(txtBuscarSocio.Text); }

        private void administradorDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmPrueba_Load(object sender, EventArgs e)
        {
            ListarSocios();
        }

        private void txtBuscarSocio_TextChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            ListarSocios();
            return;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            txtBuscarSocio.Clear();
            panel1.Visible = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void asignacionDeCasiillerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCasilleros fr = new frmCasilleros();
            fr.ShowDialog();
        }

        private void listaDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadeProductos fr = new frmListadeProductos();
            fr.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores fr = new frmProveedores();
            fr.ShowDialog();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos fr = new frmProductos();
            fr.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias fr = new frmCategorias();
            fr.ShowDialog();
        }

        private void presentacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPresentanciones fr = new frmPresentanciones();
            fr.ShowDialog();
        }

        private void listaDeMembresiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadeMembresias fr = new frmListadeMembresias();
            fr.ShowDialog();
        }

        private void registrarNuevaMembresiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenbresias fr = new frmMenbresias();
            fr.ShowDialog();
        }

        private void listaDeSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadeSocios fr = new frmListadeSocios();
            fr.ShowDialog();
        }

        private void registrarNuevoSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSocios fr = new FrmSocios();
            fr.ShowDialog();
        }

        private void btnToolRoles_Click(object sender, EventArgs e)
        {
            frmRoles fr = new frmRoles();
            fr.ShowDialog();
        }

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios fr = new frmUsuarios();
            fr.ShowDialog();
        }

        private void listaDeRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmRegistroDiario fr = new FrmRegistroDiario();
            //fr.ShowDialog();
        }

        private void btnChecar_Click(object sender, EventArgs e)
        {
            frmChkIngresoRegistrado fr = new frmChkIngresoRegistrado();
            fr.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
            {

            }
        }
}
