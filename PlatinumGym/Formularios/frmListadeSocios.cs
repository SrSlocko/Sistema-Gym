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
    public partial class frmListadeSocios : Form
    {
        public frmListadeSocios()
        {
            InitializeComponent();
        }

        LNSocios LNS = new LNSocios();
        public FrmSocios fr = new FrmSocios();
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ListarArticulos() { dtgvSocios.DataSource = LNS.ListarSocios(txtBuscar.Text); }

        private void frmListadeSocios_Load(object sender, EventArgs e)
        {
            ListarArticulos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmSocios fr = new FrmSocios();
            fr.ShowDialog();
            fr.txtIdeClie.Text = LNS.GenerarCodigo();
            fr.datetimeSociodesde.Text = DateTime.Now.ToShortDateString();
           
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgvSocios.Rows.Count > 0)
            {

                fr.txtIdeClie.Text = dtgvSocios.CurrentRow.Cells[0].Value.ToString();
                fr.txtNombreClie.Text = dtgvSocios.CurrentRow.Cells[1].Value.ToString();
                fr.txtDireccionClie.Text = dtgvSocios.CurrentRow.Cells[2].Value.ToString();
                fr.cboGenero.Text = dtgvSocios.CurrentRow.Cells["GeneroClie"].Value.ToString();
                fr.txtCedula.Text = dtgvSocios.CurrentRow.Cells["CedulaClie"].Value.ToString();
                fr.txtTelefonoClie.Text = dtgvSocios.CurrentRow.Cells["TelefonoClie"].Value.ToString();
                fr.chkClienteActivo.Checked = bool.Parse(dtgvSocios.CurrentRow.Cells["EstadoClie"].Value.ToString());
                fr.ptbClie.Image = LNS.Cargarimagen(fr.txtIdeClie.Text);
                fr.datetimeCumple.Text = dtgvSocios.CurrentRow.Cells["CumpleClie"].Value.ToString();
                fr.datetimeSociodesde.Text = dtgvSocios.CurrentRow.Cells["SocioClie"].Value.ToString();
                fr.txtEmail.Text = dtgvSocios.CurrentRow.Cells["EmailClie"].Value.ToString();
                fr.Nuevo = false;
                fr.ShowDialog();
               
            }
        }
        public bool Pasar = false;
        private void btnPasar_Click(object sender, EventArgs e)
        {
            Pasar = true;
            Close();
        }

        private void dtgvSocios_SelectionChanged(object sender, EventArgs e)
        {
            fr.txtIdeClie.Text = dtgvSocios.CurrentRow.Cells[0].Value.ToString();
            fr.txtNombreClie.Text = dtgvSocios.CurrentRow.Cells[1].Value.ToString();
            fr.txtDireccionClie.Text = dtgvSocios.CurrentRow.Cells[2].Value.ToString();
            fr.cboGenero.Text = dtgvSocios.CurrentRow.Cells["GeneroClie"].Value.ToString();
            fr.txtCedula.Text = dtgvSocios.CurrentRow.Cells["CedulaClie"].Value.ToString();
            fr.txtTelefonoClie.Text = dtgvSocios.CurrentRow.Cells["TelefonoClie"].Value.ToString();
            fr.chkClienteActivo.Checked = bool.Parse(dtgvSocios.CurrentRow.Cells["EstadoClie"].Value.ToString());
            fr.ptbClie.Image = LNS.Cargarimagen(fr.txtIdeClie.Text);
            fr.datetimeCumple.Text = dtgvSocios.CurrentRow.Cells["CumpleClie"].Value.ToString();
            fr.datetimeSociodesde.Text = dtgvSocios.CurrentRow.Cells["SocioClie"].Value.ToString();
            fr.txtEmail.Text = dtgvSocios.CurrentRow.Cells["EmailClie"].Value.ToString();
           
        }
    }
}
