using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProyProgII
{
    public class FitDatabase : IDisposable
    {
        private MySqlConnection Connection;
        private readonly string ConnectionString;

        public FitDatabase()
        {
            ConnectionString = "Server=127.0.0.1;Database=fit;User=root;Password=;SslMode=none;";
            Connect();
        }

        public void Connect()
        {
            try
            {
                if (Connection == null)
                    Connection = new MySqlConnection(ConnectionString);

                if (Connection.State != ConnectionState.Open)
                {
                    Connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Perfiles VerifyAccount(string usuario, string contraseña)
        {
            Perfiles perfil = null;

            try
            {
                string query = "SELECT * FROM perfiles WHERE usuario = @usuario AND contraseña = @contraseña;";

                using (MySqlCommand command = new MySqlCommand(query, Connection))
                {
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contraseña", contraseña);

                    if (Connection.State != ConnectionState.Open)
                        Connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            perfil = new Perfiles
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Usuario = reader["usuario"].ToString(),
                                Contraseña = reader["contraseña"].ToString(),
                                Nombre = reader["nombre"].ToString()
                            };
                        }
                        else
                        {
                            MessageBox.Show("No existe el perfil, vuelve a ingresar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer la tabla de la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disconnect();
            }

            return perfil;
        }

        public void Disconnect()
        {
            if (Connection != null && Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        public void Dispose()
        {
            Disconnect();
            Connection?.Dispose();
        }
    }

    // Clase para representar los datos de la tabla "perfiles".
    public class Perfiles
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
    }
}
    