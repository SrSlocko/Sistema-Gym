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
    public partial class frmrptListadeProductos : Form
    {
        public frmrptListadeProductos()
        {
            InitializeComponent();
        }

        private void frmrptListadeProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaGimnasioDataSet.Articulos' Puede moverla o quitarla según sea necesario.
            this.articulosTableAdapter.Fill(this.sistemaGimnasioDataSet.Articulos);

            this.reportViewer1.RefreshReport();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
