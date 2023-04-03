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
     public  class LNDetalleFactura
    {
        public List<spListarDetalleFacturaResult> ListarDetalleFacturas(string Nro)
        {
            return CDDetalleFactura.obteneListaDetalle(Nro);
        }

        public bool InsertarDetalleFactura(EDetalleFactura D)
        {
            CDDetalleFactura.Create(D);
            return false;
        }
    }
}
