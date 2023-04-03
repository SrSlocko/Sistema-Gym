using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClasesEntidades
{
    public class ERoles
    {
        private int ideRol;

        public int IdeRol
        {
            get { return ideRol; }
            set { ideRol = value; }
        }
        private string nombreRol;

        public string NombreRol
        {
            get { return nombreRol; }
            set { nombreRol = value; }
        }
        private bool clientes;

        public bool Clientes
        {
            get { return clientes; }
            set { clientes = value; }
        }
        private bool usuarios;

        public bool Usuarios
        {
            get { return usuarios; }
            set { usuarios = value; }
        }
        private bool roles;

        public bool Roles
        {
            get { return roles; }
            set { roles = value; }
        }
        private bool casilleros;

        public bool Casilleros
        {
            get { return casilleros; }
            set { casilleros = value; }
        }
        private bool membresias;

        public bool Membresias
        {
            get { return membresias; }
            set { membresias = value; }
        }
        private bool productos;

        public bool Productos
        {
            get { return productos; }
            set { productos = value; }
        }
        private bool respaldo;

        public bool Respaldo
        {
            get { return respaldo; }
            set { respaldo = value; }
        }
        private bool registrarVisitas;

        public bool RegistrarVisitas
        {
            get { return registrarVisitas; }
            set { registrarVisitas = value; }
        }
        
        public ERoles() { }

        public ERoles(
int id, string nom, bool clie, bool usu, bool ro, bool casi, bool men, bool prod, bool resp, bool regis)
        {
            ideRol = id;
            nombreRol = nom;
            clientes = clie;
            casilleros = casi;
            productos = prod;
            membresias = men;
            usuarios = usu;
            roles = ro;
            respaldo = resp;
            registrarVisitas = regis;
            
        }
         ~ERoles() { }
    }
}
