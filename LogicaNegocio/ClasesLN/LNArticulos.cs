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
    public class LNArticulos
    {
        public List<spListarArticulosResult> ListarArticulos(string para)
        {
            return CDArticulos.obteneListaArticulos(para);
        }

        public bool InsertarArticulo(EArticulos D)
        {
            CDArticulos.Create(D);
            return false;
        }

        public bool ActualizarArticulo(EArticulos D)
        {
            CDArticulos.Update(D);
            return false;
        }

        public bool DisminuirStockArticulo(EArticulos D)
        {
            CDArticulos.DisminuirStock(D);
            return false;
        }

        public bool EliminarArticulo(EArticulos op)
        {
            CDArticulos.Delete(op);
            return false;
        }
    }
}
