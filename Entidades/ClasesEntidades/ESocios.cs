using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClasesEntidades
{
    public class ESocios
    {
        //private int idClie;

        //public int IdClie
        //{
        //    get { return idClie; }
        //    set { idClie = value; }
        //}

        private string codigoClie;

        public string CodigoClie
        {
            get { return codigoClie; }
            set { codigoClie = value; }
        }

        private string nombreClie;

        public string NombreClie
        {
            get { return nombreClie; }
            set { nombreClie = value; }
        }
        private string direccionClie;

        public string DireccionClie
        {
            get { return direccionClie; }
            set { direccionClie = value; }
        }
    
        private string cedulaClie;

        public string CedulaClie
        {
            get { return cedulaClie; }
            set { cedulaClie = value; }
        }
        private string telefonoClie;

        public string TelefonoClie
        {
            get { return telefonoClie; }
            set { telefonoClie = value; }
        }
        private bool estadoClie;

        public bool EstadoClie
        {
            get { return estadoClie; }
            set { estadoClie = value; }
        }
        private byte[] foto;

        public byte[] Foto
        {
            get { return foto; }
            set { foto = value; }
        }
        private DateTime cumpleClie;

        public DateTime CumpleClie
        {
            get { return cumpleClie; }
            set { cumpleClie = value; }
        }
        private DateTime socioClie;

        public DateTime SocioClie
        {
            get { return socioClie; }
            set { socioClie = value; }
        }

        private string emailClie;

        public string EmailClie
        {
            get { return emailClie; }
            set { emailClie = value; }
        }
       
        private string generoClie;

        public string GeneroClie
        {
            get { return generoClie; }
            set { generoClie = value; }
        }

        public ESocios()
        {
            
        }

        public ESocios(string codcl, string nomCli, string dire,string gen, string ced, string ema, DateTime soci,bool estacli, string tele, DateTime cumpl,int idem, byte[] fot)
        {

            codigoClie = codcl;
            nombreClie = nomCli;
            direccionClie = dire;
            generoClie = gen;
            cedulaClie = ced;
            emailClie = ema;
            socioClie = soci;
            foto = fot;
            estadoClie = estacli;
            telefonoClie = tele;
            cumpleClie = cumpl;

        }

          ~ESocios() { }
     }
}