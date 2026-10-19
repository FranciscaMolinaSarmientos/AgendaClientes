using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgendaClientes
{
    public partial class FormBuscar : FormBase
    {
        int posicion = -1;

        public FormBuscar()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            posicion = ClaseEstatica.MiAgenda.BuscarCliente(textBoxBuscar.Text);
            if (posicion == -1)
            {
                MessageBox.Show("Cliente no encontrado");
                textBoxNombre.Clear();
                textBoxTelefono.Clear();
                textBoxEmpresa.Clear();
                textBoxEmail.Clear();
            }
            else
            {
                Cliente c = (Cliente)ClaseEstatica.MiAgenda.ListaCli[posicion];
                textBoxNombre.Text = c.Nombre;
                textBoxTelefono.Text = c.TelefonoCli;
                textBoxEmpresa.Text = c.Empresa;
                textBoxEmail.Text = c.Email;
            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (posicion == -1)
            {
                MessageBox.Show("Primero busca un cliente");
            }
            else
            {
                ClaseEstatica.MiAgenda.BorrarCliente(posicion);
                posicion = -1;
                MessageBox.Show("Cliente borrado");
                textBoxBuscar.Clear();
                textBoxNombre.Clear();
                textBoxTelefono.Clear();
                textBoxEmpresa.Clear();
                textBoxEmail.Clear();
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (posicion == -1)
            {
                MessageBox.Show("Primero busca un cliente");
            }
            else
            {
                Cliente c = new Cliente();
                c.Nombre = textBoxNombre.Text;
                c.TelefonoCli = textBoxTelefono.Text;
                c.Empresa = textBoxEmpresa.Text;
                c.Email = textBoxEmail.Text;
                ClaseEstatica.MiAgenda.ActualizarCliente(posicion, c);
                MessageBox.Show("Cliente actualizado");
            }
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
