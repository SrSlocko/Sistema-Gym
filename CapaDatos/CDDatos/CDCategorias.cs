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
    public class CDCategorias
    {
        public static List<spListarCategoriasResult> obteneListaCategoria(string Para)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            return BD.spListarCategorias(Para).ToList();
        }

        public static ECategorias Create(ECategorias D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spInsertarCategoria(D.NombreCate, D.DescripcionCate);
            BD.SubmitChanges();
            return D;
        }

        public static ECategorias Update(ECategorias D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spActualizaCategoria(D.IdCate, D.NombreCate, D.DescripcionCate);
            BD.SubmitChanges();
            return D;
        }

        public static ECategorias Delete(ECategorias D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spEliminarCategoria(D.IdCate);
            BD.SubmitChanges();
            return D;
        }
    }
}
