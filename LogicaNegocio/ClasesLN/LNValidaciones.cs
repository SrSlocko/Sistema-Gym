using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LogicaNegocio.ClasesLN
{
   public class LNValidaciones
    {
        public static string usu;
        //clase  de alternar colores en datagrid
        /**************************************************************/
        public void AlternarColorDatagridView(DataGridView dgv)
        {
            dgv.RowsDefaultCellStyle.BackColor = Color.Honeydew;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.Lavender;
        }

        //clase  de Verification de Ingreso de valores numericos
        /**************************************************************/
        public void numerosReales(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 58) && (e.KeyChar != 44))
                if (e.KeyChar != 13 && e.KeyChar != 8 && e.KeyChar != 46)
                {
                    e.Handled = true;
                    return;
                }
        }


        //clase  de Verification de Ingreso de valores numericos
        /**************************************************************/
        public void numeros(KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 58)
                if (e.KeyChar != 13 && e.KeyChar != 8 && e.KeyChar != 45)
                {
                    e.Handled = true;
                    return;
                }

        }

        //clase  de Verification de Ingreso de letras
        /**************************************************************/
        public void Letras(KeyPressEventArgs e)
        {
            if (e.KeyChar < 65 || e.KeyChar > 90)
                if (e.KeyChar != 13 && e.KeyChar != 8 && e.KeyChar != 32)
                    if (!char.IsLetter(e.KeyChar))
                    {
                        e.Handled = true;
                        return;
                    }
        }


        //clase  de salto de control texbox
        /**************************************************************/
        public void Enter(KeyPressEventArgs e, TextBox txtcuadro)
        {
            if (e.KeyChar == 13)
                txtcuadro.Focus();
        }



        /***************************************************************/
        // clase para limpiar los texbox                               //
        /*************************************************************/
        public void Limpiartexbox(Control textos, Panel pnl)
        {
            foreach (var txt in textos.Controls)
            {
                if (txt is TextBox)
                    ((TextBox)txt).Clear();
                else
                    if (txt is ComboBox)
                        ((ComboBox)txt).SelectedIndex = -1;

            }

            foreach (var mipanel in pnl.Controls)
            {
                if (mipanel is TextBox)
                    ((TextBox)mipanel).Clear();
                else
                    if (mipanel is ComboBox)
                        ((ComboBox)mipanel).SelectedIndex = -1;

            }


            foreach (var mipanel in pnl.Controls)
            {
                if (mipanel is MaskedTextBox)
                    ((MaskedTextBox)mipanel).ResetText();

            }

        }


        /***************************************************************/
        // clase para cambiar colores los texbox                               //
        /*************************************************************/
        public void CambiarColorTexbox(Control textos, Panel pnl)
        {
            foreach (var txt in textos.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).BackColor = Color.PapayaWhip;
                    ((TextBox)txt).ForeColor = Color.Black;
                }

            }

            foreach (var mipanel in pnl.Controls)
            {
                if (mipanel is TextBox)
                {
                    ((TextBox)mipanel).BackColor = Color.PapayaWhip;
                    ((TextBox)mipanel).ForeColor = Color.Black;
                }
            }
        }

        /***************************************************************/
        // clase para Activar los texbox                               //
        /*************************************************************/
        public void Activartexbox(Control textos, bool op, Panel pnl)
        {
            foreach (var txt in textos.Controls)
            {
                if (txt is TextBox)
                    ((TextBox)txt).ReadOnly = op;

                else
                    if (txt is ComboBox)
                        ((ComboBox)txt).Enabled = !op;

            }

            foreach (var mipanel in pnl.Controls)
            {
                if (mipanel is TextBox)
                    ((TextBox)mipanel).ReadOnly = op;
                else
                    if (mipanel is ComboBox)
                        ((ComboBox)mipanel).Enabled = !op;

            }

            foreach (var mipanel in pnl.Controls)
            {
                if (mipanel is MaskedTextBox)
                    ((MaskedTextBox)mipanel).ReadOnly = op;


            }
        }





        /***************************************************************/
        // clase para habilitar o deshabilitar TOOLSTRIPBUTTON        //
        /*************************************************************/
        public void HabilitartoolBotones(ToolStripButton butonnuevo, ToolStripButton butonguardar, ToolStripButton butoncancelar, ToolStripButton butoneditar, ToolStripButton butoneliminar, ToolStripButton butoncerrar, ToolStripButton butonimprimirlista, ToolStripButton butonimprimirficha, bool opc)
        {
            ((ToolStripButton)butonnuevo).Enabled = opc;
            ((ToolStripButton)butonguardar).Enabled = !opc;
            ((ToolStripButton)butoncancelar).Enabled = !opc;
            ((ToolStripButton)butoneditar).Enabled = opc;
            ((ToolStripButton)butoneliminar).Enabled = opc;
            ((ToolStripButton)butoncerrar).Enabled = opc;
            ((ToolStripButton)butonimprimirlista).Enabled = opc;
            ((ToolStripButton)butonimprimirficha).Enabled = opc;
        }




        /***************************************************************/
        // clase para habilitar o deshabilitar todos los botones dentro de toolStrip //
        /*************************************************************/
        public void ActivarBotonesToolStrip(Control botones, bool op, ToolStrip toolS)
        {
            foreach (var b in toolS.Controls)
            {
                if (b is ToolStripButton)
                    ((ToolStripButton)b).Enabled = op;

            }
        }

        /***************************************************************/
        // clase para habilitar o deshabilitar todos los botones       //
        /*************************************************************/
        public void HabilitartodosBotones(Control botones, bool opc)
        {
            foreach (var btn in botones.Controls)
            {
                if (btn is Button)
                    ((Button)btn).Enabled = opc;
            }
        }




        public void Habilitartodoscheck(Control chk, bool opc)
        {
            foreach (Control b in chk.Controls)
            {
                if (b is CheckBox)
                    b.Enabled = opc;
            }
        }

        /***************************************************************/
        // clase para habilitar o deshabilitar grupos               //
        /*************************************************************/
        public void HabilitarGrupos(Control grupos, bool opc)
        {
            foreach (Control g in grupos.Controls)
            {
                if (g is GroupBox)
                    g.Enabled = opc;
            }
        }


        //clase  de Verificacion de Ruc
        /**************************************************************/
        public bool RucPersonaNatural(String Ruc)
        {
            long isNumeric;
            const int TamanoLongitudRuc = 13;
            const string establecimiento = "001";
            if (long.TryParse(Ruc, out isNumeric) && Ruc.Length.Equals(TamanoLongitudRuc))
            {
                var NumeroProvincia = Convert.ToInt32(string.Concat(Ruc[0] + string.Empty, Ruc[1] + string.Empty));
                var PersonaNatural = Convert.ToInt32(Ruc[2] + string.Empty);
                if ((NumeroProvincia >= 1 && NumeroProvincia <= 24) && (PersonaNatural >= 0 && PersonaNatural < 6))
                {
                    return Ruc.Substring(10, 3) == establecimiento && esCedulaValida(Ruc.Substring(0, 10));
                }
                return false;
            }
            return false;
        }

        //clase  de Verification de Cedula
        /**************************************************************/
        public bool esCedulaValida(String cedula)
        {
            //verifica que tenga 10 dígitos 
            if (!(cedula.Length == 10) || cedula == "2222222222")
            {
                return false;
            }
            //verifica que los dos primeros dígitos correspondan a un valor entre 1 y NUMERO_DE_PROVINCIAS
            int prov = int.Parse(cedula.Substring(0, 2));
            if (!((prov > 0) && (prov <= 24)))
            {
                return false;
            }
            //verifica que el último dígito de la cédula sea válido
            int[] d = new int[10];
            //Asignamos el string a un array
            for (int i = 0; i < d.Length; i++)
            {
                d[i] = int.Parse(cedula.Substring(i, 1) + "");
            }
            int imp = 0;
            int par = 0;
            //sumamos los duplos de posición impar
            for (int i = 0; i < d.Length; i += 2)
            {
                d[i] = ((d[i] * 2) > 9) ? ((d[i] * 2) - 9) : (d[i] * 2);
                imp += d[i];
            }
            //sumamos los digitos de posición par
            for (int i = 1; i < (d.Length - 1); i += 2)
            {
                par += d[i];
            }
            //Sumamos los dos resultados
            int suma = imp + par;
            //Restamos de la decena superior
            int d10 = int.Parse(Convert.ToString(suma + 10).Substring(0, 1) + "0") - suma;
            //Si es diez el décimo dígito es cero        
            d10 = (d10 == 10) ? 0 : d10;
            //si el décimo dígito calculado es igual al digitado la cédula es correcta
            return d10 == d[9];
        }


        /**
         * Clases para convertir numeros a letras
       */
        public static bool EmailIsValid(string email)
        {
            bool result = false;
            string[] parts = email.Split('@');
            // --------------------------------------
            if (parts.Length != 2)
                result = false;
            else
            {
                parts = email.Split('.');
                if (parts.Length != 2)
                    result = false;
                else
                {
                    if (parts[1] != "com")
                        result = false;
                    else
                    {
                        parts = email.Split('@');
                        string server = parts[1].Substring(0, parts[1].Length - 4);
                        switch (server.ToLower())
                        {
                            case "yahoo":
                                result = true;
                                break;
                            case "gmail":
                                result = true;
                                break;
                            case "hotmail":
                                result = true;
                                break;
                            case "msn":
                                result = true;
                                break;
                            default:
                                result = false;
                                break;
                        }
                    }
                }
            }
            // --------------------------------------
            return result;
        }

        public static int InvalidEmailErrorCode(string email)
        {
            int result = -1;
            string[] parts = email.Split('@');
            // --------------------------------------
            if (parts.Length != 2)
                result = 1;
            else
            {
                parts = email.Split('.');
                if (parts.Length != 2)
                    result = 2;
                else
                {
                    if (parts[1] != "com")
                        result = 3;
                    else
                    {
                        parts = email.Split('@');
                        string server = parts[1].Substring(0, parts[1].Length - 4);
                        switch (server.ToLower())
                        {
                            case "yahoo":
                                result = -1;
                                break;
                            case "gmail":
                                result = -1;
                                break;
                            case "hotmail":
                                result = -1;
                                break;
                            case "msn":
                                result = -1;
                                break;
                            default:
                                result = 4;
                                break;
                        }
                    }
                }
            }
            // --------------------------------------
            return result;
        }
        public string ConvertirCadena(string num)
        {

            string res, dec = "";

            Int64 entero;

            int decimales;

            double nro;

            try
            {

                nro = Convert.ToDouble(num);

            }

            catch
            {

                return "";

            }

            entero = Convert.ToInt64(Math.Truncate(nro));

            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));

            if (decimales > 0)
            {

                dec = " CON " + decimales.ToString() + "/100";

            }

            res = toText(Convert.ToDouble(entero)) + dec;

            return res;

        }

        private string toText(double value)
        {

            string Num2Text = "";

            value = Math.Truncate(value);

            if (value == 0) Num2Text = "CERO";

            else if (value == 1) Num2Text = "UNO";

            else if (value == 2) Num2Text = "DOS";

            else if (value == 3) Num2Text = "TRES";

            else if (value == 4) Num2Text = "CUATRO";

            else if (value == 5) Num2Text = "CINCO";

            else if (value == 6) Num2Text = "SEIS";

            else if (value == 7) Num2Text = "SIETE";

            else if (value == 8) Num2Text = "OCHO";

            else if (value == 9) Num2Text = "NUEVE";

            else if (value == 10) Num2Text = "DIEZ";

            else if (value == 11) Num2Text = "ONCE";

            else if (value == 12) Num2Text = "DOCE";

            else if (value == 13) Num2Text = "TRECE";

            else if (value == 14) Num2Text = "CATORCE";

            else if (value == 15) Num2Text = "QUINCE";

            else if (value < 20) Num2Text = "DIECI" + toText(value - 10);

            else if (value == 20) Num2Text = "VEINTE";

            else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);

            else if (value == 30) Num2Text = "TREINTA";

            else if (value == 40) Num2Text = "CUARENTA";

            else if (value == 50) Num2Text = "CINCUENTA";

            else if (value == 60) Num2Text = "SESENTA";

            else if (value == 70) Num2Text = "SETENTA";

            else if (value == 80) Num2Text = "OCHENTA";

            else if (value == 90) Num2Text = "NOVENTA";

            else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);

            else if (value == 100) Num2Text = "CIEN";

            else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);

            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";

            else if (value == 500) Num2Text = "QUINIENTOS";

            else if (value == 700) Num2Text = "SETECIENTOS";

            else if (value == 900) Num2Text = "NOVECIENTOS";

            else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);

            else if (value == 1000) Num2Text = "MIL";

            else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);

            else if (value < 1000000)
            {

                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";

                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);

            }

            else if (value == 1000000) Num2Text = "UN MILLON";

            else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);

            else if (value < 1000000000000)
            {

                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";

                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);

            }

            else if (value == 1000000000000) Num2Text = "UN BILLON";

            else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);

            else
            {

                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";

                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);

            }

            return Num2Text;

        }
    }
}
