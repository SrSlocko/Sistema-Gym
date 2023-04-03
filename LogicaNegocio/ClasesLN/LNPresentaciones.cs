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
    public class LNPresentaciones
    {
        public List<spListarPresentacionesResult> ListarPresentaciones(string para)
        {
            return CDPresentaciones.obteneListaPresentacion(para);
        }

        public bool InsertarPresentaciones(EPresentaciones D)
        {
            CDPresentaciones.Create(D);
            return false;
        }

        public bool ActualizarPresentaciones(EPresentaciones D)
        {
            CDPresentaciones.Update(D);
            return false;
        }

        public bool EliminarPresentaciones(EPresentaciones D)
        {
            CDPresentaciones.Delete(D);
            return false;
        }
    }
}
