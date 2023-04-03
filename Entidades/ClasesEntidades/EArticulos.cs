using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClasesEntidades
{
    public class EArticulos
    {
        private int idArti;

        public int IdArti
        {
            get { return idArti; }
            set { idArti = value; }
        }
        private string nombreArti;

        public string NombreArti
        {
            get { return nombreArti; }
            set { nombreArti = value; }
        }
        private int idCate;

        public int IdCate
        {
            get { return idCate; }
            set { idCate = value; }
        }
        private int idPrese;

        public int IdPrese
        {
            get { return idPrese; }
            set { idPrese = value; }
        }
        private int idProve;

        public int IdProve
        {
            get { return idProve; }
            set { idProve = value; }
        }
        private decimal presCompra;

        public decimal PresCompra
        {
            get { return presCompra; }
            set { presCompra = value; }
        }
        private decimal presVenta;

        public decimal PresVenta
        {
            get { return presVenta; }
            set { presVenta = value; }
        }

        private int stockArti;

        public int StockArti
        {
            get { return stockArti; }
            set { stockArti = value; }
        }

        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }


        public EArticulos()
        {
        }

        public EArticulos(int id, string nom, int cate, int prese, int prove, decimal pcom, decimal pventa, int sto, int cant)
        {
            idArti = id;
            nombreArti = nom;
            idCate = cate;
            idPrese = prese;
            idProve = prove;
            PresCompra = pcom;
            presVenta = pventa;
            stockArti = sto;
            cantidad = cant;
        }

        ~EArticulos() { }
    }
}
