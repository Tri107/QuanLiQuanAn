using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanAn.DTO
{
    public class BillDetail
    {
        private int iD;
        private int bill_iD;
        private int item_iD;
        private int quantity;
        private float totalPayment;

        public int ID { get => iD; set => iD = value; }
        public int Bill_iD { get => bill_iD; set => bill_iD = value; }
        public int Item_iD { get => item_iD; set => item_iD = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float TotalPayment { get => totalPayment; set => totalPayment = value; }

        public BillDetail(int iD, int bill_iD, int item_iD, int quantity, float totalPayment) 
        {   
            this.iD = iD;
            this.bill_iD = bill_iD;
            this.item_iD = item_iD;
            this.quantity = quantity;
            this.totalPayment = totalPayment;
        }
        public BillDetail(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.bill_iD = (int)row["BILL_ID"];
            this.item_iD = (int)row["ITEM_ID"];
            this.quantity = (int)row["QUANTITY"];
            //this.totalPayment = (float)row["TOTAL_PAYMENT"];
            this.totalPayment = Convert.ToSingle(row["TOTAL_PAYMENT"]);
        }
    }
}
