using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Conexion;
using CapaDatos.CDDatos;
using Entidades.ClasesEntidades;

namespace LogicaNegocio.ClasesLN
{
    public class LNRoles
    {
         public List<Seleccionar_RolesResult> ListadeRoles(string Para)
        {
            return CDRoles.ListadeRoles(Para).ToList();
        }

        public bool InsertarRoles(ERoles D)
        {
            CDRoles.Create(D);
            return false;
        }

        public bool ModificarRoles(ERoles D)
        {
            CDRoles.Update(D);
            return false;
        }

        public bool EliminarRoles(ERoles D)
        {
            CDRoles.Delete(D);
            return false;
        }
    }
}
