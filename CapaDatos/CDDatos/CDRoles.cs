using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Conexion;
using Entidades.ClasesEntidades;

namespace CapaDatos.CDDatos
{
   public class CDRoles
    {
        public static List<Seleccionar_RolesResult> ListadeRoles(string Para)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            return BD.Seleccionar_Roles(Para).ToList();
        }

        public static ERoles Create(ERoles D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.Insertar_Roles(D.NombreRol,D.Clientes,D.Usuarios,D.Roles,D.Respaldo,D.Membresias,D.Casilleros,D.Productos,D.RegistrarVisitas);
            BD.SubmitChanges();
            return D;
        }

        public static ERoles Update(ERoles D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.Actualizar_Roles(D.IdeRol, D.NombreRol, D.Clientes, D.Usuarios, D.Roles, D.Respaldo, D.Membresias, D.Casilleros, D.Productos, D.RegistrarVisitas);
            BD.SubmitChanges();
            return D;
        }


        public static ERoles Delete(ERoles D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.Eliminar_Roles(D.IdeRol);
            BD.SubmitChanges();
            return D;
        }
    }
}
