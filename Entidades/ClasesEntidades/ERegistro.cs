using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClasesEntidades
{
    public class ERegistro
    {
          private int ideRegist;

        public int IdeRegist
        {
            get { return ideRegist; }
            set { ideRegist = value; }
        }
        private DateTime fechaRegist;

        public DateTime FechaRegist
        {
            get { return fechaRegist; }
            set { fechaRegist = value; }
        }
        private DateTime horaRegist;

        public DateTime HoraRegist
        {
            get { return horaRegist; }
            set { horaRegist = value; }
        }
        private int ideMembresia;

        public int IdeMembresia
        {
            get { return ideMembresia; }
            set { ideMembresia = value; }
        }
   
        private string codigoClie;

        public string CodigoClie
        {
            get { return codigoClie; }
            set { codigoClie = value; }
        }

        private int ideCasillero;

        public int IdeCasillero
        {
            get { return ideCasillero; }
            set { ideCasillero = value; }
        }



        public ERegistro() { }
        public ERegistro(int idere, DateTime fechr, DateTime hora, int idem, string idec,int ideca)
        {
            ideRegist = idere;
            fechaRegist = fechr;
            horaRegist = hora;
            ideMembresia = idem;
            codigoClie = idec;
            ideCasillero = ideca;
            
        
        }
         ~ERegistro() { }
    }
}
