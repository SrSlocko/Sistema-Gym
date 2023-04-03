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
using CapaDatos.Conexion;
using Entidades.ClasesEntidades;

namespace PlatinumGym.Formularios
{
    public partial class frmCasilleros : Form
    {
        public frmCasilleros()
        {
            InitializeComponent();
        }
        ECasilleros EC = new ECasilleros();
        LNCasilleros LNC = new LNCasilleros();
        bool Nuevo;
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            LimpiarCasilleros();
            Activartextos(); 
 
        }

        private void LimpiarCasilleros() {
            txtNombreCasillero.Clear();
            txtNumeroCasillero.Clear();
            chkCasilleroDañado.Checked = false;
        
        }
        private void Activartextos()
        {
            txtNombreCasillero.ReadOnly=false;
            txtNumeroCasillero.ReadOnly = false;
            chkCasilleroDañado.Checked = false;
        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listardatos() { 
         
            dtgvDatos.DataSource = LNC.ListarCasilleros(txtBuscar.Text);
      
        }

        private void frmCasilleros_Load(object sender, EventArgs e)
        {
            listardatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

                EC.NombCasillero = txtNombreCasillero.Text;
                EC.EstadoCasillero = chkCasilleroDañado.Checked;
                EC.IdeCasillero = txtNumeroCasillero.Text;

             if (Nuevo == true)
            {
                  LNC.InsertarCasilleros(EC);
                  MessageBox.Show("Casillero Insertado con exito");
               
            }
                else
                {
                    LNC.ActualizarCasilleros(EC);
                    MessageBox.Show("Casillero Actualizado con exito");
                   
                }

             Close();

           }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgvDatos.Rows.Count > 0)
            {
                txtNumeroCasillero.Text = dtgvDatos.CurrentRow.Cells["IdeCasillero"].Value.ToString();
                txtNombreCasillero.Text = dtgvDatos.CurrentRow.Cells["NombCasillero"].Value.ToString();
                chkCasilleroDañado.Checked = bool.Parse(dtgvDatos.CurrentRow.Cells["EstadoCasillero"].Value.ToString());

            }
        }

        private void dtgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvDatos.Rows.Count > 0)
            {
                txtNumeroCasillero.Text = dtgvDatos.CurrentRow.Cells["IdeCasillero"].Value.ToString();
                txtNombreCasillero.Text = dtgvDatos.CurrentRow.Cells["NombCasillero"].Value.ToString();
                chkCasilleroDañado.Checked = bool.Parse(dtgvDatos.CurrentRow.Cells["EstadoCasillero"].Value.ToString());

            }
        }
        }
    }

