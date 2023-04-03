using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatinumGym.Reportes
{
    public partial class frmrptListadeMembresias : Form
    {
        public frmrptListadeMembresias()
        {
            InitializeComponent();
        }

        private void frmrptListadeMembresias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaGimnasioDataSet.Membresias' Puede moverla o quitarla según sea necesario.
            this.membresiasTableAdapter.Fill(this.sistemaGimnasioDataSet.Membresias);

            this.reportViewer1.RefreshReport();
        }
    }
}
