using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.CDDatos
{
    public class DatosExceptiones : ApplicationException
    {
        public DatosExceptiones(string mensaje, Exception original)
            : base(mensaje, original)
        {
        }

        public DatosExceptiones(string mensaje)
            : base(mensaje)
        {
        }
    }
}
