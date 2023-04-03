using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Conexion;
using CapaDatos.CDDatos;
using Entidades.ClasesEntidades;
using System.Drawing;
using System.IO;

namespace LogicaNegocio.ClasesLN
{
    public class LNSocios
    {
        public List<spListarSociosResult>ListarSocios(string Para)
        {
            return CDSocios.ListadeSocios(Para).ToList();
        }

        public bool InsertarSocios(ESocios D)
        {
            CDSocios.Create(D);
            return false;
        }

        public bool ActualizarSocios(ESocios D)
        {
            CDSocios.Update(D);
            return false;
        }

        public bool EliminarSocios(ESocios D)
        {
            CDSocios.Delete(D);
            return false;
        }
        
        public Image Cargarimagen(string  id)
        {
            return CDSocios.Cargarimagen(id);
        }

        public String GenerarCodigo()
        {
            return CDSocios.GenerarCodigoSocio();
        }


    }
}
