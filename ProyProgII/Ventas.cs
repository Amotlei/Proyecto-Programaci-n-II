using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProyProgII
{
    public partial class Ventas : Form
    {
        private string ConnectionString = "Server=127.0.0.1;Database=fit;User=root;Password=;SslMode=none;";

        public Ventas()
        {
            InitializeComponent();
            CalcularMontoTotal();
        }

        private void CalcularMontoTotal()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT SUM(monto) FROM perfiles;"; // Nombre corregido de la tabla
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        object resultado = command.ExecuteScalar();
                        decimal montoTotal = resultado != DBNull.Value ? Convert.ToDecimal(resultado) : 0;

                        lblMontoTotal.Text = $"Monto Total: ${montoTotal:F2}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular el monto total: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
