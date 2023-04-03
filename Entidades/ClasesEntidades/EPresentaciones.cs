using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClasesEntidades
{
    public class EPresentaciones
    {
        private int idPrese;

        public int IdPrese
        {
            get { return idPrese; }
            set { idPrese = value; }
        }
        private string nombrePrese;

        public string NombrePrese
        {
            get { return nombrePrese; }
            set { nombrePrese = value; }
        }
        private string descripcionPrese;

        public string DescripcionPrese
        {
            get { return descripcionPrese; }
            set { descripcionPrese = value; }
        }

        public EPresentaciones()
        {
        }

        public EPresentaciones(int id, string nom, string des)
        {
            idPrese = id;
            nombrePrese = nom;
            descripcionPrese = des;
        }

        ~EPresentaciones() { }
    }
}
