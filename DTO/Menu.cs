using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanAn.DTO
{
    public class Menu
    {
        private String food_Name;
        private int Quantity;
        private float price;
        private float total_payment;
        
        public string Food_Name { get => food_Name; set => food_Name = value; }
        public int Quantity1 { get => Quantity; set => Quantity = value; }
        public float Price { get => price; set => price = value; }
        public float Total_payment { get => total_payment; set => total_payment = value; }
        public Menu(String food_Name, int quantity1, float price1, float total_payment = 0)
        {
            this.food_Name = food_Name;
            this.Quantity1 = quantity1;
            this.Price = price1;
            this.Total_payment = total_payment;

        }
        public Menu(DataRow row)
        {
            this.food_Name = row["ITEM_NAME"].ToString();
            this.Quantity = (int)row["QUANTITY"];
            this.Price = Convert.ToSingle(row["PRICE"]);
            this.total_payment = Convert.ToSingle(row["TOTAL_PAYMENT"]);

        }
    }
}
