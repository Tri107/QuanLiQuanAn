using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanAn.DTO
{
    public class Bill
    {
        private int iD;
        private DateTime? dateCheckin;
        private DateTime? dateCheckout;
        private int Status;
        
        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckin { get => dateCheckin; set => dateCheckin = value; }
        public DateTime? DateCheckout { get => dateCheckout; set => dateCheckout = value; }
        public int Status1 { get => Status; set => Status = value; }

        public Bill(int ID, DateTime? dateCheckin, DateTime? dateCheckout, int Status) 
        {
            this.ID = ID;   
            this.dateCheckin = dateCheckin;              
            this.dateCheckout = dateCheckout;
            this.Status = Status;
        }
        public Bill(DataRow row)
        {
            
            this.ID = (int)row["ID"];
            this.dateCheckin = (DateTime?)row["CHECKIN"];
            var dateCheckOut = row["CHECKOUT"];
            if(dateCheckOut.ToString() != "" )
            this.dateCheckout = (DateTime?)dateCheckOut; 
            
            this.Status = (int)row["STATUS"];
        }
    }
}
