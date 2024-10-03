using QLQuanAn.DAO;
using QLQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = QLQuanAn.DTO.Menu;

namespace QLQuanAn
{
    
    public partial class RestaurantManager : Form
    {
        
        public RestaurantManager()
        {
            InitializeComponent();
            LoadTable();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            rTable rTable = new rTable();
            this.Hide();
            rTable.ShowDialog();
            this.Show();
        }

        private void btnMonAn_Click(object sender, EventArgs e)
        {
            rFood rFood = new rFood();
            this.Hide(); rFood.ShowDialog();
            this.Show();
        }

        private void btnLoaiMonAn_Click(object sender, EventArgs e)
        {
            rFoodCategories rFoodCategories = new rFoodCategories();
            rFoodCategories.Hide(); rFoodCategories.ShowDialog();
            this.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            rReports rReports = new rReports();
            rReports.Hide(); rReports.ShowDialog();
            this.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            rAccount rAccount = new rAccount();
            this.Hide(); rAccount.ShowDialog();
            this.Show();

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.ShowDialog();
            
        }
        #region Method
        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table table in tableList) { 
                Button btn = new Button() {Width = TableDAO.TableChieuRong,Height = TableDAO.TableChieuDai};
                btn.Text = table.NAME + Environment.NewLine+ table.STATUS;
                btn.Click += button_Click;
                btn.Tag = table;
                switch (table.STATUS)
                {
                    case "Trống":
                            btn.BackColor = Color.Aqua;
                            break;
                    default:
                        btn.BackColor = Color.Red;
                        break;
                }
                flpBan.Controls.Add(btn);
            }

        }
        void showBill(int id)
        {
            lsvDanhMuc.Items.Clear();
            List<Menu> listMenu = MenuDAO.Instance.GetListMenu(id);
            float totalPrice = 0;
            foreach (Menu menu in listMenu)
            {
                ListViewItem lsvItem = new ListViewItem(menu.Food_Name.ToString());
                lsvItem.SubItems.Add(menu.Quantity1.ToString());
                lsvItem.SubItems.Add(menu.Price.ToString());
                lsvItem.SubItems.Add(menu.Total_payment.ToString());
                totalPrice += menu.Total_payment;
                lsvDanhMuc.Items.Add(lsvItem);
            }
            txtTongTien.Text=totalPrice.ToString("c");
        }
        #endregion
        #region Events
        void button_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            showBill(tableID);
        }
        #endregion


    }
}

