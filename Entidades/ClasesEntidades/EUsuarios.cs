using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClasesEntidades
{
    public class EUsuarios
    {
        private int ideUsu;

        public int IdeUsu
        {
            get { return ideUsu; }
            set { ideUsu = value; }
        }
        private string nombreUsu;

        public string NombreUsu
        {
            get { return nombreUsu; }
            set { nombreUsu = value; }
        }
        private string cedulaUsu;

        public string CedulaUsu
        {
            get { return cedulaUsu; }
            set { cedulaUsu = value; }
        }
        private string loginUsu;

        public string LoginUsu
        {
            get { return loginUsu; }
            set { loginUsu = value; }
        }
        private string passwordUsu;

        public string PasswordUsu
        {
            get { return passwordUsu; }
            set { passwordUsu = value; }
        }
        private int ideRol;

        public int IdeRol
        {
            get { return ideRol; }
            set { ideRol = value; }
        }
        private bool activoUsu;

        public bool ActivoUsu
        {
            get { return activoUsu; }
            set { activoUsu = value; }
        }

       public EUsuarios() { }

       public EUsuarios(int id, string nom,string ced, string log, string pas, int idr, bool acti)
       {
           nombreUsu = nom;
           cedulaUsu = ced;
           loginUsu = log;
           passwordUsu = pas;
           ideRol = idr;
           activoUsu = acti;
       }

       ~EUsuarios() { }
    }
}
