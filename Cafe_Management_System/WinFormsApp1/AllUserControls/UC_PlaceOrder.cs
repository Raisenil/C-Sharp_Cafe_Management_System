using DGVPrinterHelper;
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantity.ResetText();
            txtTotal.Clear();

            String text = listBox1.GetItemText(listBox1.SelectedItem);
            txtItemName.Text = text;
            query = "select price from items where name = '" + text + "'";
            DataSet ds = fn.GetData(query);


            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            { }

        }

        private void txtQuantity_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txtQuantity.Value.ToString());
            Int64 price = Int64.Parse(txtPrice.Text);
            txtTotal.Text = (quan * price).ToString();
        }

        protected int n, total = 0;

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text != "0" && txtTotal.Text != "")
            {
                n = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[n].Cells[0].Value = txtItemName.Text;
                guna2DataGridView1.Rows[n].Cells[1].Value = txtPrice.Text;
                guna2DataGridView1.Rows[n].Cells[2].Value = txtQuantity.Text;
                guna2DataGridView1.Rows[n].Cells[3].Value = txtTotal.Text;

                total += int.Parse(txtTotal.Text);
                labelTotalAmount.Text = "$ " + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantuty need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int amount;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            {

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
            }
            catch { }
            total -= amount;
            labelTotalAmount.Text = "$ " + total;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter Printer = new DGVPrinter();
            Printer.Title = "Customer Bill";
            Printer.SubTitle = string.Format("Date; {0}", DateTime.Now.Date);
            Printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            Printer.PageNumbers = true;
            Printer.PageNumberInHeader = false;
            Printer.PorportionalColumns = true;
            Printer.HeaderCellAlignment = StringAlignment.Near;
            Printer.Footer = "Total Payable Amount : " + labelTotalAmount.Text;
            Printer.FooterSpacing = 15;
            Printer.PrintDataGridView(guna2DataGridView1);

            total = 0;
            guna2DataGridView1.Rows.Clear();
            labelTotalAmount.Text = "$ " + total;
        }
    }
}
