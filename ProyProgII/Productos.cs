using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyProgII
{
    public partial class Productos : Form
    {
        private string nombreUsuario;
        private int perfilId;
        private System.Windows.Forms.Timer timer;
        private int productoSeleccionadoId;
        private string connectionString = "server=localhost;database=fit;uid=root;pwd=;"; // Ajusta el connection string según sea necesario

        public Productos(int perfilId, string nombreUsuario)
        {
            this.perfilId = perfilId;
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // Mostrar el nombre del usuario
            labelUsuario.Text = $"{nombreUsuario}";

            // Configurar el Timer para la hora actual
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Actualizar cada segundo
            timer.Tick += Timer_Tick;
            timer.Start();

            // Mostrar la fecha y hora actual inicialmente
            labelFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            // Cargar los productos al iniciar
            CargarProductos();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Actualizar la hora cada segundo
            labelFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            inicio cerrar = new inicio();
            cerrar.Show();
            this.Hide();
        }

        private void Productos_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }
        }

        private async void CargarProductos()
        {
            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.BringToFront();
            progressBar.Refresh(); // Forzar redibujado

            try
            {
                await Task.Run(() =>
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT id, imagen, descripcion, precio, existencias FROM productos LIMIT 10;";
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                            {
                                DataTable productos = new DataTable();
                                adapter.Fill(productos);

                                // Actualizar la UI en el hilo principal
                                this.Invoke(new Action(() =>
                                {
                                    AsignarProductos(productos);
                                }));
                            }
                        }
                    }
                });

                // Simular un pequeño retraso para que el ProgressBar sea más visible
                await Task.Delay(500); // 500 milisegundos (ajusta según lo que necesites)
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                progressBar.Visible = false;
            }
        }


        private void AsignarProductos(DataTable productos)
        {
            for (int i = 0; i < productos.Rows.Count; i++)
            {
                Panel panel = this.Controls.Find($"item{i + 1}", true).FirstOrDefault() as Panel;
                PictureBox img = this.Controls.Find($"img{i + 1}", true).FirstOrDefault() as PictureBox;
                Label lblNombre = this.Controls.Find($"nom{i + 1}", true).FirstOrDefault() as Label;
                Label lblPrecio = this.Controls.Find($"precio{i + 1}", true).FirstOrDefault() as Label;
                Label lblDescripcion = this.Controls.Find($"des{i + 1}", true).FirstOrDefault() as Label;
                Label lblExistencias = this.Controls.Find($"ex{i + 1}", true).FirstOrDefault() as Label;

                if (panel != null && img != null && lblNombre != null && lblPrecio != null && lblDescripcion != null && lblExistencias != null)
                {
                    lblNombre.Text = productos.Rows[i]["descripcion"].ToString();
                    lblPrecio.Text = $"${productos.Rows[i]["precio"]}";
                    lblDescripcion.Text = productos.Rows[i]["descripcion"].ToString();
                    lblExistencias.Text = productos.Rows[i]["existencias"].ToString();

                    string imageName = productos.Rows[i]["imagen"].ToString();
                    string fullPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources", imageName);
                    if (File.Exists(fullPath))
                    {
                        img.Image = System.Drawing.Image.FromFile(fullPath);
                        img.SizeMode = PictureBoxSizeMode.Zoom;
                    }

                    int id = Convert.ToInt32(productos.Rows[i]["id"]);
                    panel.Click += (sender, e) => AbrirPreviaProducto(id, lblNombre.Text, lblPrecio.Text, lblDescripcion.Text, imageName, lblExistencias.Text);

                    panel.Visible = true;
                }
            }
        }



        private void AbrirPreviaProducto(int id, string nombre, string precio, string descripcion, string imagen, string existencias)
        {
            try
            {
                Detalles detalleForm = new Detalles
                {
                    ProductoId = id
                };

                // Configurar los detalles del producto en el formulario
                detalleForm.SetProductDetails(nombre, precio, descripcion, imagen, existencias);

                // Mostrar el formulario de detalles y verificar si se realizó una compra
                if (detalleForm.ShowDialog() == DialogResult.OK)
                {
                    // Recargar la lista de productos
                    CargarProductos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void labelUsuario_Click(object sender, EventArgs e)
        {
            labelUsuario.Text = $"{nombreUsuario}";
        }

        private void labelFechaHora_Click(object sender, EventArgs e)
        {
            labelFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
