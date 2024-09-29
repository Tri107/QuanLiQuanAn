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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            RestaurantManager r= new RestaurantManager();
            this.Hide();//ẩn form login
            r.ShowDialog();//hiện theo thứ tự
            this.Show();

        }
    }
}
