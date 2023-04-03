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
   public class CDMembresias
    {
        public static List<spListarMembresiasResult> obtenelistadeMembresias(string Para)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            return BD.spListarMembresias(Para).ToList();
        }

        public static EMembresias Create(EMembresias D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spInsertarMembresia(D.NombreMembr,D.IniciMembr,D.FinalMembr,D.CostoMembr,D.PromoMembr);
            BD.SubmitChanges();
            return D;
        }

        public static EMembresias Update(EMembresias D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spActualizarMembresias(D.IdeMembresia, D.NombreMembr, D.IniciMembr, D.FinalMembr, D.CostoMembr, D.PromoMembr);
            BD.SubmitChanges();
            return D;
        }

        public static EMembresias Delete(EMembresias D)
        {
            ConexionBDDataContext BD = new ConexionBDDataContext();
            BD.spEliminarMembresia(D.IdeMembresia);
            BD.SubmitChanges();
            return D;
        }

    }
}
