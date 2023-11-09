using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.AllUserControls
{
    public partial class UC_Additems : UserControl
    {
        function fn = new function();
        String query;

        public UC_Additems()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            query = "insert into items (name,category,price) values ('" + txtItemName.Text + "', '" + txtCategory.Text + "', '" + txtPrice.Text + "')";
            fn.setData(query);
            clearAll();
        }

        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();
        }

        private void UC_Additems_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_Additems_Load(object sender, EventArgs e)
        {
            string query = "select category from categories";
            DataSet ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                txtCategory.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
