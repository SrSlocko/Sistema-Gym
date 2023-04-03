using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ClasesEntidades;
using CapaDatos.Conexion;

namespace CapaDatos.CDDatos
{
    public class CDUsuarios
    {
        public static List<Seleccionar_UsuarioResult> ListadeUsuarios(string Para)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            return BD.Seleccionar_Usuario(Para).ToList();
        }

        public static List<AccesoSistemaResult> ValidarIngresoSistema(string L, string P, bool Acti)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            return BD.AccesoSistema(L, P, Acti).ToList();
        }



        public static EUsuarios Create(EUsuarios D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.Insertar_Usuarios(D.NombreUsu,D.LoginUsu,D.PasswordUsu,D.IdeRol,D.ActivoUsu,D.CedulaUsu);
            BD.SubmitChanges();
            return D;
        }

        public static EUsuarios Update(EUsuarios D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.Actualizar_Usuarios(D.IdeUsu,D.NombreUsu,D.CedulaUsu,D.LoginUsu,D.PasswordUsu,D.IdeRol,D.ActivoUsu);
            BD.SubmitChanges();
            return D;
        }


        public static EUsuarios Delete(EUsuarios D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.Eliminar_Usuarios(D.IdeUsu);
            BD.SubmitChanges();
            return D;
        }
    }
}
