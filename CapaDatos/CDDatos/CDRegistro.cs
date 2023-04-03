using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ClasesEntidades;
using CapaDatos.Conexion;

namespace CapaDatos.CDDatos
{
    public class CDRegistro
    {
        public static List<SeleccionarRegistroResult> ListadeRegistros(string Para)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            return BD.SeleccionarRegistro(Para).ToList();
        }

        public static List<AccesoRegistroResult> ValidarIngresoRegistro(string C, bool Acti)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            return BD.AccesoRegistro(C, Acti).ToList();
        }



        public static ERegistro Create(ERegistro D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spInsertarRegistro(D.FechaRegist, D.HoraRegist, D.IdeMembresia, D.CodigoClie, D.IdeCasillero);
            BD.SubmitChanges();
            return D;
        }

        public static ERegistro Update(ERegistro D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spActualizarRegistro(D.IdeRegist,D.FechaRegist,D.HoraRegist,D.IdeMembresia,D.CodigoClie,D.IdeCasillero);
            BD.SubmitChanges();
            return D;
        }


        public static ERegistro Delete(ERegistro D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spEliminarRegistro(D.IdeRegist);
            BD.SubmitChanges();
            return D;
        }
    }
}
