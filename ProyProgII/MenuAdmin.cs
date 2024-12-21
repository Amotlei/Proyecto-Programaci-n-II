using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyProgII
{
    public partial class MenuAdmin : Form
    {
        private string nombreUsuario;
        private System.Windows.Forms.Timer timer;

        public MenuAdmin(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Bienvenido al panel de administrador, {nombreUsuario}");

            // Mostrar el nombre del usuario
            labelUsuario.Text = $"{nombreUsuario}";

            // Configurar el Timer para la hora actual
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            inicio cerrar = new inicio();
            cerrar.Show ();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Alta alta = new Alta();
            alta.ShowDialog();
            
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Baja baja = new Baja();
            baja.ShowDialog();
            
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            Lista lista = new Lista();
            lista.ShowDialog();
        }

        private void btnTotalVenta_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.ShowDialog();
            
        }

        private void btnGraficaExist_Click(object sender, EventArgs e)
        {
            Grafica grafica = new Grafica();
            grafica.ShowDialog();
            
        }
    }
}
