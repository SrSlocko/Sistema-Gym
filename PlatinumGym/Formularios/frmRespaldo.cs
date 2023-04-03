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
using CapaDatos.Conexion;

namespace PlatinumGym.Formularios
{
    public partial class frmRespaldo : Form
    {
        public frmRespaldo()
        {
            InitializeComponent();
        }

        LNRespaldoBD LNR = new LNRespaldoBD();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRespaldar_Click(object sender, EventArgs e)
        {
            if (txtNombreBase.Text != "" && txtRuta.Text != "")
            {
                LNR.Ruta = txtRuta.Text + "\\" + txtNombreBase.Text + ".bak";
                LNR.RespaldarBase();
                this.Close();

            }
            else
            {
                MessageBox.Show("Seleccione la ruta y el nombre del respaldo");
                return;
            
            
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                txtRuta.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
