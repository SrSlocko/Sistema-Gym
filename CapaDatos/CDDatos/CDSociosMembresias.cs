using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ClasesEntidades;
using CapaDatos.Conexion;

namespace CapaDatos.CDDatos
{
   public class CDSociosMembresias
    {
        public static List<spListarMembresiasSociosResult> ListadeMembresiasSocios(string Para)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            return BD.spListarMembresiasSocios(Para).ToList();
        }

        public static ESocios Create(ESocios D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spInsertarSocios(D.CodigoClie, D.NombreClie, D.DireccionClie, D.GeneroClie, D.CedulaClie, D.TelefonoClie, D.EstadoClie, D.Foto, D.CumpleClie, D.SocioClie, D.EmailClie, D.IdeMembresia);
            BD.SubmitChanges();
            return D;
        }
        public static ConexionBDDataContext BD = new ConexionBDDataContext();
    }
}
