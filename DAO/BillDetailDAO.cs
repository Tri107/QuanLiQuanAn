using QLQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanAn.DAO
{
    internal class BillDetailDAO
    {
        private static BillDetailDAO instance;
        public static BillDetailDAO Instance
        {
            get { if (instance == null) instance = new BillDetailDAO(); return instance; }
            private set => instance = value;
        }
        private BillDetailDAO() { }

        public List<BillDetail> GetListBillDetail(int id)
        {
            List<BillDetail> listBillDetail = new List<BillDetail>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM BILL_DETAIL WHERE ID = " + id);
            foreach (DataRow row in data.Rows)
            {
                BillDetail detail = new BillDetail(row);
                listBillDetail.Add(detail);
            }
            return listBillDetail;
        }
        public void InsertBillDetail(int id,int idFood,int idquantity)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillDetail @idBill , @idFood , @quantity ", new object[] { id,idFood,idquantity });
        }
    }
}
