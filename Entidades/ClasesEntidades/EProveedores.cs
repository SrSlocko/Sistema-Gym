using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClasesEntidades
{
    public class EProveedores
    {
        private int idProve;

        public int IdProve
        {
            get { return idProve; }
            set { idProve = value; }
        }
        private string rucProve;

        public string RucProve
        {
            get { return rucProve; }
            set { rucProve = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string direccionProve;

        public string DireccionProve
        {
            get { return direccionProve; }
            set { direccionProve = value; }
        }
        private string telefonoProve;

        public string TelefonoProve
        {
            get { return telefonoProve; }
            set { telefonoProve = value; }
        }

        public EProveedores()
        {
        }

        public EProveedores(int id, string ruc, string nom, string dire, string tele)
        {
            idProve = id;
            rucProve = ruc;
            nombre = nom;
            direccionProve = dire;
            telefonoProve = tele;
        }

        ~EProveedores() { }
    }
}
