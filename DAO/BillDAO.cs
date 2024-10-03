using QLQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanAn.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set => instance = value;
        }
        private BillDAO() { }
        public int GetUnChecBillIDByTableID(int ID)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM BILL WHERE ID = " + ID + " AND STATUS = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
    }
   
}
