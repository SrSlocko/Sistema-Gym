using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClasesEntidades
{
    public class ECasilleros
    {
      
        private string ideCasillero;

        public string IdeCasillero
        {
            get { return ideCasillero; }
            set { ideCasillero = value; }
        }

        private string nombCasillero;

        public string NombCasillero
        {
            get { return nombCasillero; }
            set { nombCasillero = value; }
        }
        private bool estadoCasillero;

        public bool EstadoCasillero
        {
            get { return estadoCasillero; }
            set { estadoCasillero = value; }
        }

        public ECasilleros() { }
        public ECasilleros(string  ideca, string nombca, bool estaca)
        {
            ideCasillero = ideca;
            nombCasillero = nombca;
            estadoCasillero = estaca;
        
        }
            ~ECasilleros() { }
    }
}
