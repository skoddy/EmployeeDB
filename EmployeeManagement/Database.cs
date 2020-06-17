using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace EmployeeManagement
{
    public class Database
    {
        private static string connectionString = GetConnectionString();

        public Database() { }

        public List<T> GetList<T>(string query) where T : new()
        {
            using (MySqlConnection connection =
                       new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(query, connection)
                {
                    CommandType = CommandType.Text
                };

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter
                {
                    SelectCommand = command
                };

                DataTable table = new DataTable
                {
                    Locale = System.Globalization.CultureInfo.InvariantCulture
                };

                // Tabelle über den Adapter mit Daten füllen
                dataAdapter.Fill(table);

                // Tabelle zur Liste konvertieren
                List<T> list = table.DataTableToList<T>();

                return list;
            }
        }

        public void Insert(string table, MySqlParameter[] data)
        {

            using (MySqlConnection connection = 
                new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = string.Format("INSERT INTO {0}({1}) values({2})", table,
                    InsertParams(data.Select(x => x.ParameterName.Substring(1))),
                    InsertParams(data.Select(x => x.ParameterName)));

                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddRange(data);

                cmd.Prepare();

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(string table, int id)
        {
            using (MySqlConnection connection = 
                new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = string.Format("DELETE FROM {0} WHERE id=@id", table);
                MySqlCommand cmd = connection.CreateCommand();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
        }



        public void Update(string table, MySqlParameter[] data, int id)
        {
            using (MySqlConnection connection =
                new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = 
                    string.Format("UPDATE {0} SET {1} WHERE id={2}", 
                    table, 
                    UpdateParams(data.Select(x => x.ParameterName.Substring(1))), id);
                // name=@value,

                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddRange(data);

                cmd.ExecuteNonQuery();
            }
        }

        public void Hide(string table, int id)
        {
            using (MySqlConnection connection =
                new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql =
                    string.Format("UPDATE {0} SET deleted=@deleted WHERE id={1}", table, id);
                // name=@value,

                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@deleted", true);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }

        static private string GetConnectionString()
        {
            return "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=management";
        }



        // Helper
        public static string InsertParams<T>(IEnumerable<T> enumerable)
        {
            List<T> list = new List<T>(enumerable);
            return string.Join(",", list);
        }

        public static string UpdateParams<T>(IEnumerable<T> enumerable)
        {
            // TODO: Namensvergabe
            List<T> list = new List<T>(enumerable);
            string[] arr = new string[list.Count];
            foreach(T i in list)
            {
                arr[list.IndexOf(i)] = i.ToString() + "=@" + i.ToString();
            }
            return string.Join(",", arr);
        }
    }
}
