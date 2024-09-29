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
        }

        private void RestaurantManager_Load(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            rAccount rAccount = new rAccount();
            rAccount.ShowDialog();
            rAccount.Hide();
            this.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            rTable rTable = new rTable();
            rTable.ShowDialog();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            rStaff rStaff = new rStaff();
            rStaff.ShowDialog();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            rFood rFood = new rFood();
            rFood.ShowDialog();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            rFoodCategories rFoodCategories = new rFoodCategories();
            rFoodCategories.ShowDialog();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            rReports rReports = new rReports();
            rReports.ShowDialog();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            
        }
    }
}
