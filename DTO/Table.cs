using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanAn.DTO
{
    public class Table
    {
        private string sTATUS;
        private string nAME;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public string NAME { get => nAME; set => nAME = value; }
        public string STATUS { get => sTATUS; set => sTATUS = value; }
        public Table(int id,string name,string status) { 

            this.ID = id;
            this.NAME = name;
            this.STATUS = status;
        }
        public Table(DataRow row) { 
            this.ID = (int )row["ID"];
            this.NAME = (string)row["TABLE_NAME"];
            this.STATUS = (string)row["STATUS"];
        }
    }
}
