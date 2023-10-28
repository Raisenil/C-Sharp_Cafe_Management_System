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
            query = "insert into categories (category) values ('"+txtCategoryName.Text+"')";
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
    }
}
