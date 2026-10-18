using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace AgendaClientes
{
    class Agenda
    {
        private string propietario;
        private string telPropietario;
        private ArrayList listaCli;

        public Agenda()
        {
            listaCli = new ArrayList();
        }

        public Agenda(string propietario, string telPropietario, ArrayList listaCli)
        {
            this.propietario = propietario;
            this.telPropietario = telPropietario;
            this.listaCli = listaCli;
        }

        public string Propietario { get => propietario; set => propietario = value; }
        public string TelPropietario { get => telPropietario; set => telPropietario = value; }
        public ArrayList ListaCli { get => listaCli; set => listaCli = value; }

        public void AgregarCliente(Cliente cli)
        {
            listaCli.Add(cli);
        }

        public int BuscarCliente(string nombre)
        {
            int posicion = -1;
            for (int i = 0; i < listaCli.Count; i++)
            {
                Cliente c = (Cliente)listaCli[i];
                if (c.Nombre == nombre)
                {
                    posicion = i;
                }
            }
            return posicion;
        }

        public void BorrarCliente(int posicion)
        {
            listaCli.RemoveAt(posicion);
        }

        public void ActualizarCliente(int posicion, Cliente cli)
        {
            listaCli[posicion] = cli;
        }
    }
}