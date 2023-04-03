using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClasesEntidades
{
    public class ECabeceraFactura
    {
        private string nroFact;

        public string NroFact
        {
            get { return nroFact; }
            set { nroFact = value; }
        }

        private string codigoSocio;

        public string CodigoSocio
        {
            get { return codigoSocio; }
            set { codigoSocio = value; }
        }
      
        private DateTime fechaFact;

        public DateTime FechaFact
        {
            get { return fechaFact; }
            set { fechaFact = value; }
        }
        private decimal subtotalFact;

        public decimal SubtotalFact
        {
            get { return subtotalFact; }
            set { subtotalFact = value; }
        }
        private decimal ivaFact;

        public decimal IvaFact
        {
            get { return ivaFact; }
            set { ivaFact = value; }
        }
        private decimal totalFact;

        public decimal TotalFact
        {
            get { return totalFact; }
            set { totalFact = value; }
        }

        public ECabeceraFactura()
        {
        }

        public ECabeceraFactura(string nro, string cod, DateTime fecha, decimal sub, decimal iva, decimal total)
        {
            nroFact = nro;
            codigoSocio = cod;
            fechaFact = fecha;
            subtotalFact = sub;
            ivaFact = iva;
            totalFact = total;
        }

        ~ECabeceraFactura() { }

    }
}
