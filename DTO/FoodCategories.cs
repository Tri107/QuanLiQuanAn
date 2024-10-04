using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanAn.DTO
{
    public class FoodCategories
    {
        private int id;
        private string name;


        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public FoodCategories(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public FoodCategories(DataRow row)
        {
            this.id = (int )row["ID"];
            this.name = (string)row["CATEGORY_NAME"];
        }
    }
}
