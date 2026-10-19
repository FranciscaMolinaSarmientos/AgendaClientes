namespace AgendaClientes
{
    public partial class FormInicio : FormBase
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            ClaseEstatica.MiAgenda.Propietario = textBoxPropietario.Text;
            ClaseEstatica.MiAgenda.TelPropietario = textBoxTelefono.Text;
            FormMenu menu = new FormMenu();
            menu.Show();
        }
    }
}
