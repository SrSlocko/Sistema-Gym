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
    public partial class frmListadeMembresias : Form
    {
        public frmListadeMembresias()
        {
            InitializeComponent();
        }

        LNMembresias LNM = new LNMembresias();
        public bool Pasar = false;
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmMenbresias fr = new frmMenbresias();
            fr.ShowDialog();
        }

        private void ListarDatos()
        {
            dtgvMembresias.DataSource = LNM.ListarMembresias(txtBuscarNombre.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgvMembresias.Rows.Count > 0)
            {
                
                frmMenbresias fr = new frmMenbresias();
            
                fr.txtIdeMembresia.Text = dtgvMembresias.CurrentRow.Cells["IdeMembresia"].Value.ToString();
                fr.txtNombrMembr.Text = dtgvMembresias.CurrentRow.Cells["NombreMembr"].Value.ToString();
                fr.dateinicio.Text = dtgvMembresias.CurrentRow.Cells["IniciMembr"].Value.ToString();
                fr.datefinal.Text = dtgvMembresias.CurrentRow.Cells["FinalMembr"].Value.ToString();
                fr.txtCostoMem.Text = dtgvMembresias.CurrentRow.Cells["CostoMembr"].Value.ToString();
                fr.dateMempromo.Text = dtgvMembresias.CurrentRow.Cells["PromoMembr"].Value.ToString();
                fr.Nuevo = false;
                fr.ShowDialog();
                ListarDatos();
            }
        }

        private void frmListadeMembresias_Load(object sender, EventArgs e)
        {
            ListarDatos();
        }

        private void btnPasar_Click(object sender, EventArgs e)
        {
            Pasar = true;
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
