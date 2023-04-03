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
    public class CDDetalleFactura
    {
        public static List<spListarDetalleFacturaResult> obteneListaDetalle(string Nro)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            return BD.spListarDetalleFactura(Nro).ToList();
        }

        public static EDetalleFactura Create(EDetalleFactura D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spInsertarDetalleFactura(D.NroFact,D.IdArti,D.Cantidad,D.PVP,D.Valor,D.IdeMembresia,D.CostoMembr);
            BD.SubmitChanges();
            return D;
        }
    }
}
