using QLQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanAn.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return instance; }
            private set => instance = value;
        }
        private MenuDAO() { }
        public List<Menu> GetListMenu(int id)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "SELECT f.ITEM_NAME, bi.QUANTITY, f.PRICE, f.PRICE * bi.QUANTITY AS total_payment FROM dbo.BILL_DETAIL AS bi JOIN dbo.Bill AS b ON bi.BILL_ID = b.id JOIN dbo.MENU_ITEM AS f ON bi.ITEM_ID = f.id WHERE b.TABLE_ID =" + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Menu menu = new Menu(row);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
