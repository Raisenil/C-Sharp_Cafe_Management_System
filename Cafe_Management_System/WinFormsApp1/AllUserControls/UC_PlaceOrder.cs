using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.AllUserControls
{
    public partial class UC_PlaceOrder : UserControl
    {
        function fn = new function();
        String query;

        public object Items { get; private set; }

        public UC_PlaceOrder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UC_PlaceOrder_Load(object sender, EventArgs e)
        {
            string query = "select category from categories";
            DataSet ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboCategory.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String category = comboCategory.Text;
            string query = "select name from items where category ='" + category + "' ";
            shoItemList(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
            String category = comboCategory.Text;
            string query = "select name from items where category ='" + category + "' and name like '%" + txtSearch.Text + "%' ";
            shoItemList(query);

        }

        private void shoItemList(String query)
        {
            listBox1.Items.Clear();

            DataSet ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }
    }
}
