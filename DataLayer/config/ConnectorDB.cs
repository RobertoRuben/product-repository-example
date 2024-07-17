using System;
using Npgsql;

namespace DataLayer.config
{
    public class ConnectorDB
    {
        private string dataBase;
        private string server;
        private string user;
        private string password;
        private string port;
        private bool seguridad;

        private static ConnectorDB instance = null;

        // Constructor privado para evitar la instanciación directa
        private ConnectorDB()
        {
            this.dataBase = "pruebadb";
            this.server = "localhost";
            this.user = "postgres";
            this.password = "oracle";
            this.port = "5432"; // Asume 5432 como puerto predeterminado, cambia según sea necesario
            this.seguridad = false;
        }

        // Método público estático para obtener la instancia
        public static ConnectorDB GetInstance()
        {
            if (instance == null)
            {
                instance = new ConnectorDB();
            }

            return instance;
        }

        // Método para crear la conexión
        public NpgsqlConnection CrearConexion()
        {
            NpgsqlConnection cadena = new NpgsqlConnection();
            try
            {
                cadena.ConnectionString = $"Host={this.server}; Port={this.port}; Database={this.dataBase};";
                if (this.seguridad)
                {
                    cadena.ConnectionString += "Integrated Security=true;";
                }
                else
                {
                    cadena.ConnectionString += $"Username={this.user}; Password={this.password};";
                }
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }

            return cadena;
        }
    }
}