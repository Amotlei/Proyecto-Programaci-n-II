using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyProgII
{
    public partial class Baja : Form
    {
        private string ConnectionString = "Server=127.0.0.1;Database=fit;User=root;Password=;SslMode=none;";

        public Baja()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtProductoID.Clear();
            lblDescripcion.Text = "Descripción:";
            lblPrecio.Text = "Precio:";
            lblExistencias.Text = "Existencias:";
            pbImagen.Image = null;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Verificar el número de registros restantes
                    string countQuery = "SELECT COUNT(*) FROM productos;";
                    using (MySqlCommand countCommand = new MySqlCommand(countQuery, connection))
                    {
                        int registrosRestantes = Convert.ToInt32(countCommand.ExecuteScalar());

                        // Si quedan 6 o menos registros, no permitir la eliminación
                        if (registrosRestantes <= 6)
                        {
                            MessageBox.Show(
                                "No se puede eliminar este producto porque quedan 6 o menos en la base de datos.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return;
                        }
                    }

                    // Eliminar el producto
                    string deleteQuery = "DELETE FROM productos WHERE id = @id;";
                    using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@id", txtProductoID.Text);
                        int filasAfectadas = deleteCommand.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show(
                                "Producto eliminado con éxito.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show(
                                "No se encontró el producto con el ID especificado.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al eliminar el producto: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM productos WHERE id = @id;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", txtProductoID.Text);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Actualizar etiquetas
                                lblDescripcion.Text = $"Descripción: {reader["descripcion"].ToString()}";
                                lblPrecio.Text = $"Precio: {Convert.ToDecimal(reader["precio"]).ToString("C2")}";
                                lblExistencias.Text = $"Existencias: {reader["existencias"].ToString()}";

                                // Mostrar la imagen desde la carpeta Resources
                                string nombreImagen = reader["imagen"].ToString();
                                string rutaImagen = Path.Combine(Application.StartupPath, "Resources", nombreImagen);

                                if (File.Exists(rutaImagen))
                                {
                                    pbImagen.Image = Image.FromFile(rutaImagen);
                                    pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                                else
                                {
                                    MessageBox.Show("La imagen no se encontró en la carpeta Resources.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    pbImagen.Image = null;
                                }

                                // Habilitar el botón Eliminar
                                btnEliminar.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Producto no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarCampos();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
