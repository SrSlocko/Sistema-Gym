using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClasesEntidades
{
    public class EMembresias
    {
        private int ideMembresia;

        public int IdeMembresia
        {
            get { return ideMembresia; }
            set { ideMembresia = value; }
        }
        private string nombreMembr;

        public string NombreMembr
        {
            get { return nombreMembr; }
            set { nombreMembr = value; }
        }
        private DateTime iniciMembr;

        public DateTime IniciMembr
        {
            get { return iniciMembr; }
            set { iniciMembr = value; }
        }
        private DateTime finalMembr;

        public DateTime FinalMembr
        {
            get { return finalMembr; }
            set { finalMembr = value; }
        }
        private decimal costoMembr;

        public decimal CostoMembr
        {
            get { return costoMembr; }
            set { costoMembr = value; }
        }
        private DateTime promoMembr;

        public DateTime PromoMembr
        {
            get { return promoMembr; }
            set { promoMembr = value; }
        }

        public EMembresias() { }

        public EMembresias(int ideMem,string nombrmen,DateTime iniciM,DateTime finalM,decimal costo,DateTime promo)
        {
            ideMembresia = ideMem;
            nombreMembr = nombrmen;
            iniciMembr = iniciM;
            finalMembr = finalM;
            costoMembr = costo;
            promoMembr = promo;
        }

        ~EMembresias() { }
    }
}
