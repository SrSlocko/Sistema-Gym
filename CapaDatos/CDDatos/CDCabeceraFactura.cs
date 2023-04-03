using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.CDDatos;
using CapaDatos.Conexion;
using Entidades.ClasesEntidades;

namespace CapaDatos.CDDatos
{
    public class CDCabeceraFactura
    {
        public static List<spListarCabeceraFacturaResult> obteneListaFactura(string Para)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            return BD.spListarCabeceraFactura(Para).ToList();
        }

        public static ECabeceraFactura Create(ECabeceraFactura D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spInsertarCabeceraFactura(D.NroFact, D.CodigoSocio, D.FechaFact, D.SubtotalFact, D.IvaFact, D.TotalFact);
            BD.SubmitChanges();
            return D;
        }

        public static String GenerarNroFact()
        {
            string Numero = "";
            int NRO = 0;
            ConexionBDDataContext bd = new ConexionBDDataContext();
            try
            {
                var MaxCodigo = bd.CabeceraFactura.Select(add => add.NroFact).Max();
                if (MaxCodigo == null)
                    NRO = 0;
                else
                    NRO = int.Parse(MaxCodigo);
                return Numero = String.Format("{0:0000000000}", NRO + 1);
            }
            catch (Exception)
            {
                return Numero = "";
            }
        }
    }
}
