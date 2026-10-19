using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgendaClientes
{
    public partial class FormAgregar : FormBase
    {
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Nombre = textBoxNombre.Text;
            c.TelefonoCli = textBoxTelefono.Text;
            c.Empresa = textBoxEmpresa.Text;
            c.Email = textBoxEmail.Text;
            ClaseEstatica.MiAgenda.AgregarCliente(c);
            MessageBox.Show("Cliente agregado");
            textBoxNombre.Clear();
            textBoxTelefono.Clear();
            textBoxEmpresa.Clear();
            textBoxEmail.Clear();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Clear();
            textBoxTelefono.Clear();
            textBoxEmpresa.Clear();
            textBoxEmail.Clear();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
