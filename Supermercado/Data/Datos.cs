using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Supermercado.Data
{
    internal class Datos
    {
        private string connectionString = "Host = localhost; Username = admin; Password = admin; Database = Supermercado";

        public NpgsqlConnection GetConnection()
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                conn.Open();
                return conn;
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error al" + "conectar a la base de datos: " + ex.Message);
                return null;
            }
        }

        public bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    {
                        Console.WriteLine("Conexión exitosa a la base de datos.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Error al conectar a la base de datos.");
                        return false;
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error al probar la conexión: " + ex.Message);
                return false;
            }

        }

        public bool ExecuteQuery(string query)
        {
            try
            {
                NpgsqlCommand conn = new NpgsqlCommand(query, GetConnection());
                conn.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error SQL: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public DataSet getAllData(string command)
        {
            DataSet dataSet = new DataSet();
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command, GetConnection());
                dataAdapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error al obtener los datos: " + Ex.Message);
                return null;
            }
        }
    }
}
