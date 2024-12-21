namespace ProyProgII
{
    public partial class portada : Form
    {
        private System.Windows.Forms.Timer timer;
        public portada()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void portada_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Actualizar cada segundo
            timer.Tick += Timer_Tick;
            timer.Start();

            // Mostrar la fecha y hora actual inicialmente
            labelFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Actualizar la hora cada segundo
            labelFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicio f2 = new inicio();
            f2.Show();
            this.Hide();
        }
    }
}
