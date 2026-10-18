using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaClientes
{
    class Cliente
    {
        private string nombre;
        private string telefonoCli;
        private string empresa;
        private string email;

        public Cliente()
        {
        }

        public Cliente(string nombre, string telefonoCli, string empresa, string email)
        {
            this.nombre = nombre;
            this.telefonoCli = telefonoCli;
            this.empresa = empresa;
            this.email = email;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string TelefonoCli { get => telefonoCli; set => telefonoCli = value; }
        public string Empresa { get => empresa; set => empresa = value; }
        public string Email { get => email; set => email = value; }

        public string imprimirCliente()
        {
            string mensaje;
            mensaje = String.Format("Nombre:{0}  Telefono:{1}  Empresa:{2}  Email:{3} ",
            Nombre, TelefonoCli, Empresa, Email);
            return mensaje;
        }
    }
}