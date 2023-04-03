using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.CDDatos;
using CapaDatos.Conexion;
using Entidades.ClasesEntidades;


namespace CapaDatos.CDDatos
{
    public class CDArticulos
    {
        public static List<spListarArticulosResult> obteneListaArticulos(string Para)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            return BD.spListarArticulos(Para).ToList();
        }

        public static EArticulos Create(EArticulos D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spInsertarArticulo(D.NombreArti, D.IdCate, D.IdPrese, D.IdProve, D.PresCompra, D.PresVenta, D.StockArti);
            BD.SubmitChanges();
            return D;
        }

        public static EArticulos Update(EArticulos D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spActualizarArticulo(D.IdArti, D.NombreArti, D.IdCate, D.IdPrese, D.IdProve, D.PresCompra, D.PresVenta, D.StockArti);
            BD.SubmitChanges();
            return D;
        }

        public static EArticulos DisminuirStock(EArticulos D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spDisminuirStockArticulo(D.IdArti, D.Cantidad);
            BD.SubmitChanges();
            return D;
        }

        public static EArticulos Delete(EArticulos D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spEliminarArticulo(D.IdArti);
            BD.SubmitChanges();
            return D;
        }
    }
}
