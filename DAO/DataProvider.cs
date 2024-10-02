using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanAn.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set => DataProvider.instance = value;
        }
        private DataProvider() { }

        private string connectionSTR = @"Data Source=.\;Initial Catalog=QUANLIQUANAN;Integrated Security=True";
        public DataTable ExcuteQuery(string query,object[] parameter=null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null) { 
                    string[] listParemeter = query.Split(' ');
                    int i = 0;
                    foreach (string s in listParemeter)
                    {
                        if(s.Contains('@'))
                        {
                            command.Parameters.AddWithValue(s, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}
