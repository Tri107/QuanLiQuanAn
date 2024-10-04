using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanAn.DTO
{
    public class Food
    {
        private int id;
        private string name;
        private int idCategory;
        private float price;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public float Price { get => price; set => price = value; }
        public Food(int id,string name,int idCategory, float price) { 
            this.id = id;
            this.name = name;
            this.idCategory = idCategory;
            this.price = price;
        }
        public Food(DataRow row) 
        {
            this.id= (int )row["ID"];
            this.name = (string)row["ITEM_NAME"];
            this.idCategory = (int)row["CATEGORY_ID"];
            this.price = Convert.ToSingle(row["PRICE"]);
        }
    }
}
