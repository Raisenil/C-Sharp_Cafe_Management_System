using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CafeManagement.AllUserControls
{
    public partial class UC_AddCategories : UserControl
    {
        function fn = new function();
        String query;

        public UC_AddCategories()
        {
            InitializeComponent();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            query = "insert into categories (category) values ('" + txtCategoryName.Text + "')";
            fn.setData(query);
            clearAll();
        }

        public void clearAll()
        {
            txtCategoryName.Clear();
        }

        private void UC_AddCategories_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_AddCategories_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            query = "select * from categories";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String category = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtEditCategory.Text = category;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = "update categories set category='" + txtEditCategory.Text + "' where id = " + id + "";
            fn.setData(query);
            loadData();

            txtEditCategory.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete item ?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                query = "delete from categories where category='" + txtEditCategory.Text + "' ";
                fn.setData(query);
                loadData();

                txtEditCategory.Clear();
            }
        }
    }
}
