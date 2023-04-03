using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocio.ClasesLN;
using Entidades.ClasesEntidades;
using CapaDatos.Conexion;
using CapaDatos.CDDatos;

namespace LogicaNegocio.ClasesLN
{
   public  class LNCasilleros
    {
        public List<spListarCasillerosResult> ListarCasilleros(string para)
        {
            return CDCasilleros.obtenerListaCasilleros(para);
        }

        public bool InsertarCasilleros(ECasilleros D)
        {
            CDCasilleros.Create(D);
            return false;
        }

        public bool ActualizarCasilleros(ECasilleros D)
        {
            CDCasilleros.Update(D);
            return false;
        }

        public bool EliminarCasilleros(ECasilleros op)
        {
            CDCasilleros.Delete(op);
            return false;
        }
    }
}
