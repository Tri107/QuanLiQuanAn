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
        #endregion

    }
}
