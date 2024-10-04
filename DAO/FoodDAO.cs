using QLQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanAn.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return instance; }
            private set => instance = value;
        }
        private FoodDAO() { }
        public List<Food> GetListCategories(int id)
        {
            List<Food> listFood = new List<Food>();
            string query = "select * from MENU_ITEM where CATEGORY_ID  = "+id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Food food = new Food(row);
                listFood.Add(food);
            }
            return listFood;
        }
    }
}
