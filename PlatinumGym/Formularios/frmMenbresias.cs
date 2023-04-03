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
    public partial class frmMenbresias : Form
    {
        public frmMenbresias()
        {
            InitializeComponent();
        }
        public bool Nuevo;

        LNMembresias LNM = new LNMembresias();
        EMembresias EM = new EMembresias();

        private void HabilitarTextbox(bool op)
        {
            txtIdeMembresia.ReadOnly = !op;
            txtNombrMembr.ReadOnly = !op;
        }

        private void LimpiarTextBox()
        {
            txtIdeMembresia.Clear();
            txtNombrMembr.Clear();     
        }

       
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EM.NombreMembr = txtNombrMembr.Text;
            EM.IniciMembr = DateTime.Parse(dateinicio.Value.ToShortDateString());
            EM.FinalMembr = DateTime.Parse(datefinal.Value.ToShortDateString());
            EM.CostoMembr = decimal.Parse(txtCostoMem.Text);
            EM.PromoMembr = DateTime.Parse(dateMempromo.Value.ToShortDateString());


            if (Nuevo == true)
            {
                LNM.InsertarMembresia(EM);
                MessageBox.Show("Membresia Registrada con Exito");
            }

            else
            {

                EM.IdeMembresia = int.Parse(txtIdeMembresia.Text);
                LNM.ActualizarMembresia(EM);
                MessageBox.Show("Membresia Actualizada con Exito");
            }
        

            HabilitarTextbox(false);
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void activarpromo()

        {
            dateMempromo.Enabled = false;
        
        }
        private void chkMembresiaPromocional_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMembresiaPromocional.Checked == true)
            {
                dateMempromo.Enabled = true;

            }
            else
            {

                dateMempromo.Enabled = false;
            }
        }

        private void frmMenbresias_Load(object sender, EventArgs e)
        {
            activarpromo();
        }

        
    }
}
