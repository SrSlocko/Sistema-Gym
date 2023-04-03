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
using System.IO;
using Entidades.ClasesEntidades;


namespace PlatinumGym.Formularios
{
    public partial class FrmSocios : Form
    {
        public FrmSocios()
        {
            InitializeComponent();
        }
        public bool Nuevo;

        LNSocios LNA = new LNSocios();
        ESocios A = new ESocios();
        LNValidaciones LV = new LNValidaciones();
        LNMembresias LNM = new LNMembresias();
        EMembresias E = new EMembresias();
        LNValidaciones LNV = new LNValidaciones();
        string Cedula;
        int DVeri, Digi, SPares, SImp, DSup, Stotal;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {


            A.CodigoClie = txtIdeClie.Text;
            A.NombreClie = txtNombreClie.Text;
            A.DireccionClie = txtDireccionClie.Text;
            A.GeneroClie = cboGenero.Text;
            A.CedulaClie = txtCedula.Text;
            A.TelefonoClie = txtTelefonoClie.Text;
            A.EstadoClie = chkClienteActivo.Checked;
            A.CumpleClie = DateTime.Parse(datetimeCumple.Value.ToShortDateString());
            A.SocioClie = DateTime.Parse(datetimeSociodesde.Value.ToShortDateString());
            A.EmailClie = txtEmail.Text;
            //capturar Foto Mascota
            MemoryStream stream = new MemoryStream();
            ptbClie.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] Foto = stream.ToArray();
            //fin Captura
            A.Foto = Foto;


            if (Nuevo == true)
            {
                LNA.InsertarSocios(A);
                MessageBox.Show("Socio Registrado con Exito");
            }
            else
            {
                LNA.ActualizarSocios(A);
                MessageBox.Show("Socio Actualizado con Exito");

            }

            Close();
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {

            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos JPEG(*.jpg)|*.jpg";
            abrir.InitialDirectory = @"C:\EjemploVideo\Imagenes";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                String Dir = abrir.FileName;
                Bitmap Picture = new Bitmap(Dir);
                ptbClie.Image = (Image)Picture;
            }

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
        }



        private void FrmSocios_Load(object sender, EventArgs e)
        {

            LNA.ActualizarSocios(A);
        }
        //private void VerificarCedula() {

        //    if (txtCedula.Text.Length == 10)
        //    {

        //     ;SPares = 0; SImp = 0;
        //    Cedula = txtCedula.Text.Trim();
        //    if (Cedula == "2222222222" || Cedula == "4444444444" || Cedula == "5555555555" || Cedula == "7777777777" || Cedula == "9999999999")
        //    {
        //        MessageBox.Show("Cedula Incorrecta");
        //        return;
        //    }

        //    for (int I = 0; I <= 8; I++)
        //    {
        //        Digi = int.Parse(Cedula.Substring(I, 1));
        //        if ((I + 1) % 2 == 1)
        //        {
        //            Digi = Digi * 2;
        //            if (Digi > 9)
        //                Digi = Digi - 9;
        //            SImp = SImp + Digi;

        //        }

        //        else
        //            SPares = SPares + Digi;

        //    }
        //    Stotal = SPares + SImp;
        //    if (Stotal % 10 != 0)
        //        DSup = (Stotal / 10 + 1) * 10;
        //    else
        //        DSup = Stotal;
        //    DVeri = DSup - Stotal;
        //    if (DVeri == int.Parse(Cedula.Substring(9, 1)))
        //    {
        //        MessageBox.Show("Cedula correcta");

        //    }
        //    else
        //        MessageBox.Show("Cedula Incorrecta");
        //}

        //    }




        private void txtCedula_TextChanged_1(object sender, EventArgs e)
        {

            //VerificarCedula();
        }

        private void btnVerficar_Click(object sender, EventArgs e)
        {
            SPares = 0; SImp = 0;
            Cedula = txtCedula.Text.Trim();
            if (Cedula == "2222222222" || Cedula == "4444444444" || Cedula == "5555555555" || Cedula == "7777777777" || Cedula == "9999999999")
            {
                MessageBox.Show("Cedula Incorrecta");
                return;
            }

            for (int I = 0; I <= 8; I++)
            {
                Digi = int.Parse(Cedula.Substring(I, 1));
                if ((I + 1) % 2 == 1)
                {
                    Digi = Digi * 2;
                    if (Digi > 9)
                        Digi = Digi - 9;
                    SImp = SImp + Digi;

                }

                else
                    SPares = SPares + Digi;

            }
            Stotal = SPares + SImp;
            if (Stotal % 10 != 0)
                DSup = (Stotal / 10 + 1) * 10;
            else
                DSup = Stotal;
            DVeri = DSup - Stotal;
            if (DVeri == int.Parse(Cedula.Substring(9, 1)))
            {
                MessageBox.Show("Cedula correcta");

            }
            else
                MessageBox.Show("Cedula Incorrecta");
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTelefonoClie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGenero.Text != "Masculino")
            {
                txtGenero.Text = "Femenino";

            }
            else
            {
                txtGenero.Text = "Masculino";
            }
        }
        private void actuardatosadicionales()
        {

            txtapodo.ReadOnly = false;
            txtocupacion.ReadOnly = false;
            txttelefonodecasa.ReadOnly = false;
            txttelefonodeltrabajo.ReadOnly = false;

        }
        private void pesoideal()
        {
            txtPeso.ReadOnly = false;
            txtPesoidoneo.ReadOnly = false;
            txtAltura.ReadOnly = false;
            txtCondicion.ReadOnly = false;

        }

        private void chkDatosAdicionales_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDatosAdicionales.Checked == true)
            {
                actuardatosadicionales();
            }
            else
            {
                if (chkDatosAdicionales.Checked == false)
                {
                    txtapodo.ReadOnly = true;
                    txtocupacion.ReadOnly = true;
                    txttelefonodecasa.ReadOnly = true;
                    txttelefonodeltrabajo.ReadOnly = true;

                }
            }
        }

        private void chkPesoActual_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPesoActual.Checked == true)
            {
                pesoideal();
            }

            else

            {
                if (chkDatosAdicionales.Checked == false)
                {
                    txtPeso.ReadOnly = true;
                    txtPesoidoneo.ReadOnly = true;
                    txtAltura.ReadOnly = true;
                    txtCondicion.ReadOnly = true;


                }
            }

        }
    }
}