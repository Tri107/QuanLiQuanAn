using QLQuanAn.DAO;
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
    public partial class rAccount : Form
    {
        public rAccount()
        {
            InitializeComponent();
            LoadAccountList();
        }

        public void LoadAccountList()
        {
            string query = "SELECT Display_Name as [Tên Hiển Thị] from ACCOUNT";
            DataProvider provider = new DataProvider();
            dgvTaiKhoan.DataSource = provider.ExcuteQuery(query);
        }
    }
}
