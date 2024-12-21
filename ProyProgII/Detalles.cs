using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace ProyProgII
{
    public partial class Detalles : Form
    {
        private int existencias = 0; // Esta variable almacena el total de existencias del producto actual.
        private decimal precioProducto = 0; // Precio del producto actual.
        private int perfilId = 1;
        private int productoId;
        private string connectionString = "server=localhost;database=fit;uid=root;pwd=;";

        public Detalles()
        {
            InitializeComponent();
        }
        public int ProductoId
        {
            get { return productoId; }
            set { productoId = value; }
        }


        private void Detalles_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT id, imagen, descripcion, precio, existencias FROM productos WHERE id = @productoId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@productoId", productoId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Cargar datos del producto desde la base de datos.
                                existencias = reader.GetInt32("existencias");
                                precioProducto = reader.GetDecimal("precio");

                                // Mostrar los datos en los controles del formulario.
                                des.Text = reader.GetString("descripcion");
                                precio.Text = $"${precioProducto:0.00}";
                                ex.Text = $"Existencias: {existencias}";

                                // Cargar la imagen desde el archivo (ruta)
                                string imageName = reader.GetString("imagen");
                                string fullPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources", imageName);
                                if (File.Exists(fullPath))
                                {
                                    img.Image = System.Drawing.Image.FromFile(fullPath);
                                    img.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró la imagen del producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los datos del producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }

            textBox1.Text = "0"; // Inicializar el contador.
        }


        public void SetProductDetails(string nombre, string Precio, string descripcion, string imagen, string existencias)
        {
            // Configurar los valores en los controles correspondientes
            nom.Text = nombre; // Nombre del producto
            precio.Text = $"Precio: ${Precio}"; // Precio del producto
            des.Text = descripcion; // Descripción del producto
            ex.Text = $"Existencias: {existencias}"; // Existencias del producto

            // Cargar la imagen del producto
            string fullPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources", imagen);
            if (File.Exists(fullPath))
            {
                img.Image = System.Drawing.Image.FromFile(fullPath);
                img.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }


        public void btnVolver_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(textBox1.Text);

            // Incrementar solo si no supera el número de existencias.
            if (cantidad < existencias)
            {
                cantidad++;
                textBox1.Text = cantidad.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(textBox1.Text);

            // Decrementar solo si es mayor a 0.
            if (cantidad > 0)
            {
                cantidad--;
                textBox1.Text = cantidad.ToString();
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(textBox1.Text);

            if (cantidad > 0)
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Actualizar existencias del producto.
                        string queryUpdateProducto = "UPDATE productos SET existencias = existencias - @cantidad WHERE id = @productoId";
                        using (MySqlCommand cmdProducto = new MySqlCommand(queryUpdateProducto, connection))
                        {
                            cmdProducto.Parameters.AddWithValue("@cantidad", cantidad);
                            cmdProducto.Parameters.AddWithValue("@productoId", productoId);

                            cmdProducto.ExecuteNonQuery();
                        }

                        // Actualizar monto del perfil.
                        decimal totalMonto = cantidad * precioProducto;
                        string queryUpdatePerfil = "UPDATE perfiles SET monto = monto + @totalMonto WHERE id = @perfilId";
                        using (MySqlCommand cmdPerfil = new MySqlCommand(queryUpdatePerfil, connection))
                        {
                            cmdPerfil.Parameters.AddWithValue("@totalMonto", totalMonto);
                            cmdPerfil.Parameters.AddWithValue("@perfilId", perfilId);

                            cmdPerfil.ExecuteNonQuery();
                        }

                        MessageBox.Show($"¡Compra realizada con éxito!\nTotal pagado: ${totalMonto:0.00}", "Compra Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reiniciar el contador.
                        textBox1.Text = "0";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al realizar la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La cantidad debe ser mayor a 0 para realizar la compra.", "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0"; // Reiniciar el contador.
            MessageBox.Show("La compra ha sido cancelada.", "Compra Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
