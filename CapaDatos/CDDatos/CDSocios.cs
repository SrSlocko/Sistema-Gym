using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.CDDatos;
using CapaDatos.Conexion;
using Entidades.ClasesEntidades;
using System.Drawing;
using System.IO;

namespace CapaDatos.CDDatos
{
    public class CDSocios
    {
        public static List<spListarSociosResult> ListadeSocios(string Para)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            return BD.spListarSocios(Para).ToList();
        }
        public static ConexionBDDataContext BD = new ConexionBDDataContext();

        public static ESocios Create(ESocios D)
        {

            BD.spInsertarSocios(D.NombreClie, D.DireccionClie, D.GeneroClie, D.CedulaClie, D.TelefonoClie, D.EstadoClie, D.Foto, D.CumpleClie, D.SocioClie, D.EmailClie);
            BD.SubmitChanges();
            return D;
        }

        public static ESocios Update(ESocios D)
        {

            BD.spActualizaSocios(D.CodigoClie, D.NombreClie, D.DireccionClie, D.GeneroClie, D.CedulaClie, D.TelefonoClie, D.EstadoClie, D.Foto, D.CumpleClie, D.SocioClie, D.EmailClie);
            BD.SubmitChanges();
            return D;
        }

        public static ESocios Delete(ESocios D)
        {

            BD.spEliminarSocios(D.CodigoClie);
            BD.SubmitChanges();
            return D;
        }

        public static Image Cargarimagen(string Id)
        {
            var consulta = from Eje in BD.Socios where Eje.CodigoClie == Id select Eje;
            consulta.ToArray();
            Byte[] MyData = new byte[0];
            foreach (Socios eje in consulta)
            {
                if (eje.Foto != null)
                {
                    MyData = (byte[])consulta.ToArray().ElementAt(0).Foto.ToArray();
                    MemoryStream stream = new MemoryStream(MyData);
                    return Image.FromStream(stream);

                }
            }
            return null;
        }

        public static string GenerarCodigoSocio()
        {
            string Codigo = "";
            int NRO = 0;
            ConexionBDDataContext BD;
            try
            {
                using (BD = new ConexionBDDataContext())
                {
                    var MaxCodigo = BD.Socios.Select(add => add.CodigoClie.Substring(1, 4)).Max();
                    if (MaxCodigo == null)
                        NRO = 0;
                    else
                        NRO = int.Parse(MaxCodigo);
                }
                return Codigo = String.Format("C{0:0000}", NRO + 1);
            }
            catch (Exception)
            {
                return Codigo = "";
            }

        }








    }
}
