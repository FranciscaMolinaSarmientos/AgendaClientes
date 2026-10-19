using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgendaClientes
{
    public partial class FormMostrar : FormBase
    {
        public FormMostrar()
        {
            InitializeComponent();
        }

        private void FormMostrar_Load(object sender, EventArgs e)
        {
            foreach (Object cli in ClaseEstatica.MiAgenda.ListaCli)
            {
                Cliente y = (Cliente)cli;
                dataGridViewClientes.Rows.Add(y.Nombre, y.TelefonoCli, y.Empresa, y.Email);
            }
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
