using CafeManagement.AllUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(String user)
        {
            InitializeComponent();

            if (user == "Guest")
            {
                btnPlaceOrder.Show();
                btnAddCategories.Hide();
                btnAddItems.Hide();
                btnUpdate.Hide();
                btnRemove.Hide();
            }
            else if (user == "Admin")
            {
                btnPlaceOrder.Show();
                btnAddCategories.Show();
                btnAddItems.Show();
                btnUpdate.Show();
                btnRemove.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();

        }

        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login fm = new Login();
            this.Hide();
            fm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            uC_Additems1.Visible = true;
            uC_Additems1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Additems1.Visible = false;
            uC_AddCategories1.Visible = false;
            uC_PlaceOrder1.Visible = false;
            uC_UpdateItems1.Visible = false;
            uC_RemoveItem1.Visible = false;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_AddCategories1.Visible = true;
            uC_AddCategories1.BringToFront();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            uC_UpdateItems1.Visible = true;
            uC_UpdateItems1.BringToFront();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            uC_RemoveItem1.Visible = true;
            uC_RemoveItem1.BringToFront();
        }
    }
}
