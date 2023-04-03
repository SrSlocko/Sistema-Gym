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
using Entidades.ClasesEntidades;

namespace PlatinumGym.Formularios
{
    public partial class frmChkIngresoRegistrado : Form
    {
        public frmChkIngresoRegistrado()
        {
            InitializeComponent();
        }

        LNRegistro LNR = new LNRegistro();
        ERegistro ER=new ERegistro();

       public frmListadeRegistro fr = new frmListadeRegistro();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {

                var consulta = LNR.ValidarIngresoSistemaUsuario(txtBuscar.Text, true);

            }
            else
            {
                MessageBox.Show("No se encuentra codigo o cedula");
            
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
