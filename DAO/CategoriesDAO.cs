using QLQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanAn.DAO
{
    public class CategoriesDAO
    {
        private static CategoriesDAO instance;
        public static CategoriesDAO Instance
        {
            get { if (instance == null) instance = new CategoriesDAO(); return instance; }
            private set => instance = value;
        }
        private CategoriesDAO() { }
        public List<FoodCategories> GetListCategories()
        {
            List<FoodCategories> listCategories = new List<FoodCategories>();
            string query = "select * from MENU_CATEGORY ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                 FoodCategories foodCategories = new FoodCategories(row);
                listCategories.Add(foodCategories);
            }
            return listCategories;
        }

    }
}
