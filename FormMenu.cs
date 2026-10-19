using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgendaClientes
{
    public partial class FormMenu : FormBase
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            labelPropietario.Text = ClaseEstatica.MiAgenda.Propietario;
            labelTelefono.Text = ClaseEstatica.MiAgenda.TelPropietario;
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            FormMostrar mostrar = new FormMostrar();
            mostrar.Show();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar agregar = new FormAgregar();
            agregar.Show();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            FormBuscar buscar = new FormBuscar();
            buscar.Show();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
