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
    public class CDProveedores
    {
        public static List<spListarProveedoresResult> obteneListaProveedores(string Para)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            return BD.spListarProveedores(Para).ToList();
        }

        public static EProveedores Create(EProveedores D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spInsertaProveedores(D.RucProve, D.Nombre, D.DireccionProve, D.TelefonoProve);
            BD.SubmitChanges();
            return D;
        }

        public static EProveedores Update(EProveedores D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spActualizaProveedores(D.IdProve, D.RucProve, D.Nombre, D.DireccionProve, D.TelefonoProve);
            BD.SubmitChanges();
            return D;
        }

        public static EProveedores Delete(EProveedores D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spEliminarProveedores(D.IdProve);
            BD.SubmitChanges();
            return D;
        }
    }
}
