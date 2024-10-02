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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hiện thông báo khi nhấn "Thoát" 
            if(MessageBox.Show("Bạn muốn thoát chương trình ? ","Thông Báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK) 
                e.Cancel = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            if (fLogin(username, password))
            {
                RestaurantManager r = new RestaurantManager();
                this.Hide();//ẩn form login
                r.ShowDialog();//hiện theo thứ tự
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
            

        }
        bool fLogin(string username,string password)
        {
            return AccountDAO.Instance.fLogin(username, password);
        }
    }
}
