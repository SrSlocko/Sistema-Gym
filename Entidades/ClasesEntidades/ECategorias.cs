using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClasesEntidades
{
    public class ECategorias
    {
        private int idCate;
        private string nombreCate;
        private string descripcionCate;

        public int IdCate
        {
            get { return idCate; }
            set { idCate = value; }
        }
        public string NombreCate
        {
            get { return nombreCate; }
            set { nombreCate = value; }
        }

        public string DescripcionCate
        {
            get { return descripcionCate; }
            set { descripcionCate = value; }
        }

        public ECategorias()
        {
        }

        public ECategorias(int id, string nom, string des)
        {
            idCate = id;
            nombreCate = nom;
            descripcionCate = des;
        }

        ~ECategorias() { }
    }
}
