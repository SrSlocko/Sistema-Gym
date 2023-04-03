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
using CapaDatos.CDDatos;
using LogicaNegocio.ClasesLN;


namespace PlatinumGym.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        LNUsuarios LNU = new LNUsuarios();
        int i;
        int veces = 0;
        private const int intentos = 3;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Digite Usuario para Continuar", "Sistema Contol de Bodega", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Focus();
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Digite Clave para Continuar", "Sistema Contol de Bodega", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
            }


            var consulta = LNU.ValidarIngresoSistemaUsuario(txtUsuario.Text, txtPassword.Text, true);


            if (consulta.Count != 0)
            {
                TimerProgreso.Enabled = true;
                i = 0;
            }
            else
            {

                if (veces == 3)
                {
                    MessageBox.Show("         Excedio el Limite de Intentos al Sistema \n \nEspere unos Minutos y Ingrese Su Logueo Otra Vez");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Su Usuario o Contraseña o Tipo NO Coinciden o son Erroneas \n \n                        Le Quedan " + (intentos - veces) + " Intento(s)", "Sistema Contol de Gymnacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Clear();
                    txtPassword.Clear();
                    veces = veces + 1;
                }


            }
            
        }
        private void TmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void TimerProgreso_Tick(object sender, EventArgs e)
        {
            var consulta = LNU.ValidarIngresoSistemaUsuario(txtUsuario.Text, txtPassword.Text, true);

            i++;
            if (i < 50)
            {
                Progreso.Value = i;
                i = i + 1;
            }
            else
            {
                TimerProgreso.Enabled = false;
                MessageBox.Show("Su Ingreso Fue Ingresado Correctamente \n \n               Bienvenido al Sistema :  " + txtUsuario.Text);
                this.Hide();
                frmMenuPrincipal fr = new frmMenuPrincipal();
                foreach (var D in consulta)
                {

                    //fr.btnUsuarios.Enabled = D.Usuarios.Value;
                    //fr.btnSocios.Enabled = D.Clientes.Value;
                    //fr.btnMembresias.Enabled = D.Membresias.Value;
                    //fr.btnProductos.Enabled = D.Productos.Value;
                    //fr.btnToolRoles.Enabled = D.Roles.Value;
                    //fr.btnRespaldo.Enabled = D.Respaldo.Value;
                    LogicaNegocio.ClasesLN.LNValidaciones.usu = txtUsuario.Text;
                    fr.lblNombreUsuario.Text = LogicaNegocio.ClasesLN.LNValidaciones.usu;

                }
                this.Hide();
                fr.ShowDialog();
                this.Close();
            }
        }
    }
}
    

