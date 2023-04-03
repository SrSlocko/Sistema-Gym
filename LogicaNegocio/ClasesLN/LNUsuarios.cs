using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ClasesEntidades;
using CapaDatos.Conexion;
using CapaDatos.CDDatos;

namespace LogicaNegocio.ClasesLN
{
    public class LNUsuarios
    {
        public List<Seleccionar_UsuarioResult> ListadeUsuarios(string Para)
        {
            return CDUsuarios.ListadeUsuarios(Para).ToList();
        }

        public List<AccesoSistemaResult> ValidarIngresoSistemaUsuario(string L, string P, bool Acti)
        {
            return CDUsuarios.ValidarIngresoSistema(L, P, Acti).ToList();
        }



        public bool InsertarUsuarios(EUsuarios D)
        {
            CDUsuarios.Create(D);
            return false;
        }

        public bool ModificarUsuarios(EUsuarios D)
        {
            CDUsuarios.Update(D);
            return false;
        }

        public bool EliminarUsuarios(EUsuarios D)
        {
            CDUsuarios.Delete(D);
            return false;
        }
    }
}
