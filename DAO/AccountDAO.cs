using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanAn.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set => instance = value; 
        }
        private AccountDAO() { }
        public bool fLogin(string username,string password)
        {
            string query = "Select * from ACCOUNT Where USERNAME = N'"+username+"' AND PASSWORD =N'"+password+"' ";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            return result.Rows.Count > 0;
        }
    }
}
