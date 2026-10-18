using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaClientes
{
    static class ClaseEstatica
    {
        private static Agenda miAgenda = new Agenda();

        internal static Agenda MiAgenda { get => miAgenda; set => miAgenda = value; }
    }
}