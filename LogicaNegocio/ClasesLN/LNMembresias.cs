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
    public class LNMembresias
    {
        public List<spListarMembresiasResult> ListarMembresias(string para)
        {
            return CDMembresias.obtenelistadeMembresias(para);
        }

        public bool InsertarMembresia(EMembresias D)
        {
            CDMembresias.Create(D);
            return false;
        }

        public bool ActualizarMembresia(EMembresias D)
        {
            CDMembresias.Update(D);
            return false;
        }

        public bool EliminarMembresia(EMembresias op)
        {
            CDMembresias.Delete(op);
            return false;
        }
    }
}
