using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.CDDatos;
using CapaDatos.Conexion;
using Entidades.ClasesEntidades;

namespace LogicaNegocio.ClasesLN
{
    public class LNCabeceraFactura
    {
        public List<spListarCabeceraFacturaResult> ListarCabeceraFacturas(string para)
        {
            return CDCabeceraFactura.obteneListaFactura(para);
        }

        public bool InsertarCabeceraFactura(ECabeceraFactura D)
        {
            CDCabeceraFactura.Create(D);
            return false;
        }

        public String GenerarNroFactura()
        {
            return CDCabeceraFactura.GenerarNroFact();
        }
    }
}
