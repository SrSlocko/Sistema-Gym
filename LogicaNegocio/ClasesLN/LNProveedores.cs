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
    public class LNProveedores
    {
        public List<spListarProveedoresResult> ListarProveedores(string para)
        {
            return CDProveedores.obteneListaProveedores(para);
        }

        public bool InsertarProveedor(EProveedores D)
        {
            CDProveedores.Create(D);
            return false;
        }

        public bool ActualizarPproveedor(EProveedores D)
        {
            CDProveedores.Update(D);
            return false;
        }

        public bool EliminarProveedores(EProveedores D)
        {
            CDProveedores.Delete(D);
            return false;
        }
    }
}
