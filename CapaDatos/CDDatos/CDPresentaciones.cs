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
    public class CDPresentaciones
    {
        public static List<spListarPresentacionesResult> obteneListaPresentacion(string Para)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            return BD.spListarPresentaciones(Para).ToList();
        }

        public static EPresentaciones Create(EPresentaciones D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spInsertarPresentaciones(D.NombrePrese, D.DescripcionPrese);
            BD.SubmitChanges();
            return D;
        }

        public static EPresentaciones Update(EPresentaciones D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spActualizaPresentaciones(D.IdPrese, D.NombrePrese, D.DescripcionPrese);
            BD.SubmitChanges();
            return D;
        }

        public static EPresentaciones Delete(EPresentaciones D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spEliminarPresentaciones(D.IdPrese);
            BD.SubmitChanges();
            return D;
        }
    }
}
