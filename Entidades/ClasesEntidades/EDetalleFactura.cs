using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClasesEntidades
{
    public class EDetalleFactura
    {
         private int idDetalle;

        public int IdDetalle
        {
            get { return idDetalle; }
            set { idDetalle = value; }
        }
        private string nroFact;

        public string NroFact
        {
            get { return nroFact; }
            set { nroFact = value; }
        }
        private int idArti;

        public int IdArti
        {
            get { return idArti; }
            set { idArti = value; }
        }
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private decimal pVP;

        public decimal PVP
        {
            get { return pVP; }
            set { pVP = value; }
        }
        private decimal valor;

        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private int ideMembresia;

        public int IdeMembresia
        {
            get { return ideMembresia; }
            set { ideMembresia = value; }
        }
        //private string nombreMembr;

        //public string NombreMembr
        //{
        //    get { return nombreMembr; }
        //    set { nombreMembr = value; }
        //}
        //private string iniciMembr;

        //public string IniciMembr
        //{
        //    get { return iniciMembr; }
        //    set { iniciMembr = value; }
        //}
        //private string finalMembr;

        //public string FinalMembr
        //{
        //    get { return finalMembr; }
        //    set { finalMembr = value; }
        //}
        private decimal costoMembr;

        public decimal CostoMembr
        {
            get { return costoMembr; }
            set { costoMembr = value; }
        }

        public EDetalleFactura()
        {
        }

        public EDetalleFactura(int id, string nro, int idar, int can, decimal pv, decimal val, int idem, decimal costm)
            ////string nomm,string inicimen,string finalmem,decimal costm)
        {
            idDetalle = id;
            nroFact = nro;
            idArti = idar;
            cantidad = can;
            pVP = pv;
            valor = val;
            ideMembresia = idem;
            //nombreMembr = nomm;
            //iniciMembr = inicimen;
            //finalMembr = finalmem;
            costoMembr = costm;
        }

        ~EDetalleFactura() { }
    }
    }
