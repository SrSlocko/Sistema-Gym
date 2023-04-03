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
    public class LNCategorias
    {
        public List<spListarCategoriasResult> ListarCategorias(string para)
        {
            return CDCategorias.obteneListaCategoria(para);
        }

        public bool InsertarCategoria(ECategorias D)
        {
            CDCategorias.Create(D);
            return false;
        }

        public bool ActualizarCategoria(ECategorias D)
        {
            CDCategorias.Update(D);
            return false;
        }

        public bool EliminarCategoria(ECategorias op)
        {
            CDCategorias.Delete(op);
            return false;
        }
    }
}
