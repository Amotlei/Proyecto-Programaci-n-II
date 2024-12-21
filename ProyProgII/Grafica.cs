using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProyProgII
{
    public partial class Grafica : Form
    {
        private const string ConnectionString = "Server=127.0.0.1;Database=fit;User=root;Password=;SslMode=none;";
        private List<string> etiquetas; // Nombres de los productos
        private List<int> valores;     // Existencias de los productos

        public Grafica()
        {
            InitializeComponent();
            etiquetas = new List<string>();
            valores = new List<int>();
            CargarDatos();
            panel1.Paint += DibujarGrafico; // Asociar el evento Paint
        }

        private void CargarDatos()
        {
            try
            {
                // Conectar a la base de datos y obtener los datos
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT imagen, existencias FROM productos ORDER BY existencias DESC;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable productos = new DataTable();
                        adapter.Fill(productos);

                        // Llenar las listas de datos
                        foreach (DataRow row in productos.Rows)
                        {
                            etiquetas.Add(row["imagen"].ToString());
                            valores.Add(Convert.ToInt32(row["existencias"]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DibujarGrafico(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Brush brush = new SolidBrush(Color.DarkGoldenrod); // Color de las barras
            Brush textBrush = new SolidBrush(Color.White);     // Cambiado el color del texto a blanco

            // Tamaño y posición inicial del gráfico
            int margenIzquierdo = 50;
            int margenSuperior = 50;
            int anchoBarra = 40;
            int espacioEntreBarras = 20;

            // Calcular la escala de las barras
            int alturaMaxima = panel1.Height - 100;
            int maxValor = valores.Count > 0 ? valores.Max() : 1;
            float escala = (float)alturaMaxima / maxValor;

            // Dibujar cada barra
            for (int i = 0; i < valores.Count; i++)
            {
                int alturaBarra = (int)(valores[i] * escala);
                int x = margenIzquierdo + i * (anchoBarra + espacioEntreBarras);
                int y = panel1.Height - margenSuperior - alturaBarra;

                // Dibujar la barra
                graphics.FillRectangle(brush, x, y, anchoBarra, alturaBarra);

                // Dibujar la etiqueta
                string etiqueta = etiquetas[i];
                SizeF textSize = graphics.MeasureString(etiqueta, this.Font);
                graphics.DrawString(etiqueta, this.Font, textBrush, x + (anchoBarra - textSize.Width) / 2, panel1.Height - margenSuperior + 5);

                // Dibujar el valor
                string valorTexto = valores[i].ToString();
                textSize = graphics.MeasureString(valorTexto, this.Font);
                graphics.DrawString(valorTexto, this.Font, textBrush, x + (anchoBarra - textSize.Width) / 2, y - textSize.Height - 5);
            }
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
