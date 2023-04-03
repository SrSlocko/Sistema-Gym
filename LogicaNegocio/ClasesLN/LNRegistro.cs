using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.CDDatos;
using CapaDatos.Conexion;
using Entidades.ClasesEntidades;

namespace LogicaNegocio.ClasesLN
{
    public class LNRegistro
    {
       public List<SeleccionarRegistroResult> ListadeRegistros(string Para)
        {
            return CDRegistro.ListadeRegistros(Para).ToList();
        }

       public List<AccesoRegistroResult> ValidarIngresoSistemaUsuario(string C, bool Acti)
        {
            return CDRegistro.ValidarIngresoRegistro(C, Acti).ToList();
        }

        public bool InsertarRegistro(ERegistro D)
        {
            CDRegistro.Create(D);
            return false;
        }

        public bool ModificarRegistro(ERegistro D)
        {
            CDRegistro.Update(D);
            return false;
        }

        public bool EliminarRegistro(ERegistro D)
        {
            CDRegistro.Delete(D);
            return false;
        }


        }
    }
