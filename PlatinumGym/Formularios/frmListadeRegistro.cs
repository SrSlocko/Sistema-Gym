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
using CapaDatos.CDDatos;

namespace PlatinumGym.Formularios
{
    public partial class frmListadeRegistro : Form
    {
        public frmListadeRegistro()
        {
            InitializeComponent();
        }
        //LNRegistro LNR = new LNRegistro();
        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            //FrmRegistroDiario fr = new FrmRegistroDiario();
            //fr.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void ListarRegistros()
        {
            //dtgvDatos.DataSource = LNR.ListarMembresias(txtBuscar.Text);
        }

        private void frmListadeRegistro_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }
    }
}
