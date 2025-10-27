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
                var connection = GetConnection();
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer conexión con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                using (connection)
                {
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command, connection);
                    dataAdapter.Fill(dataSet);
                }

                return dataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public int ExecuteInsertAndReturnId(string query)
        {
            int id = -1;
            try
            {
                using (NpgsqlConnection conn = GetConnection())
                {
                    if (conn == null)
                        return -1;

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int generatedId))
                        {
                            id = generatedId;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error SQL al insertar y obtener ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return id;
        }

        public String GetValue(string query)
        {
            try
            {
                NpgsqlCommand com = new NpgsqlCommand(query, GetConnection());
                object result = com.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el valor: " + ex.Message);
                return null;
            }
        }

    }
}
