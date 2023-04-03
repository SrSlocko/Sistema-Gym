using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Conexion;
using Entidades.ClasesEntidades;

namespace CapaDatos.CDDatos
{
    public class CDCasilleros
    {
        public static List<spListarCasillerosResult>obtenerListaCasilleros(string Para)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            return BD.spListarCasilleros(Para).ToList();
        }

        public static ECasilleros Create(ECasilleros D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spInsertarCasillero(D.IdeCasillero, D.NombCasillero, D.EstadoCasillero);
            BD.SubmitChanges();
            return D;
        }

        public static ECasilleros Update(ECasilleros D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spActualizaCasilleros(D.IdeCasillero, D.NombCasillero, D.EstadoCasillero);
            BD.SubmitChanges();
            return D;
        }

        public static ECasilleros Delete(ECasilleros D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.EliminarCasilleros(D.IdeCasillero);
            BD.SubmitChanges();
            return D;
        }
    }
}
