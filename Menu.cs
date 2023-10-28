namespace TPagenciadeviajes
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Prereserva_Click(object sender, EventArgs e)
        {
          Prereserva formulario = new Prereserva();
            formulario.ShowDialog();
        }
    }
}