namespace CafeManagement.AllUserControls
{
    partial class UC_AddCategories
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtCategoryName = new Guna.UI2.WinForms.Guna2TextBox();
            btnAddItems = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            label1 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnPrint = new Guna.UI2.WinForms.Guna2Button();
            btnRemove = new Guna.UI2.WinForms.Guna2Button();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtCategoryName
            // 
            txtCategoryName.CustomizableEdges = customizableEdges1;
            txtCategoryName.DefaultText = "";
            txtCategoryName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCategoryName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCategoryName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCategoryName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCategoryName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategoryName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoryName.ForeColor = Color.Black;
            txtCategoryName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategoryName.Location = new Point(43, 137);
            txtCategoryName.Margin = new Padding(4, 4, 4, 4);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.PasswordChar = '\0';
            txtCategoryName.PlaceholderText = "";
            txtCategoryName.SelectedText = "";
            txtCategoryName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtCategoryName.Size = new Size(335, 36);
            txtCategoryName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtCategoryName.TabIndex = 14;
            // 
            // btnAddItems
            // 
            btnAddItems.BorderRadius = 21;
            btnAddItems.CustomizableEdges = customizableEdges3;
            btnAddItems.DisabledState.BorderColor = Color.DarkGray;
            btnAddItems.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddItems.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddItems.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddItems.FillColor = Color.FromArgb(0, 118, 225);
            btnAddItems.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddItems.ForeColor = Color.White;
            btnAddItems.Location = new Point(552, 128);
            btnAddItems.Name = "btnAddItems";
            btnAddItems.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAddItems.Size = new Size(180, 45);
            btnAddItems.TabIndex = 12;
            btnAddItems.Text = "Add New Category";
            btnAddItems.Click += btnAddItems_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 108);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 9;
            label2.Text = "Category Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(338, 33);
            label1.Name = "label1";
            label1.Size = new Size(102, 30);
            label1.TabIndex = 8;
            label1.Text = "Category";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // btnPrint
            // 
            btnPrint.BorderRadius = 21;
            btnPrint.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            btnPrint.CheckedState.FillColor = Color.White;
            btnPrint.CheckedState.ForeColor = Color.FromArgb(0, 11, 225);
            btnPrint.CustomizableEdges = customizableEdges7;
            btnPrint.DisabledState.BorderColor = Color.DarkGray;
            btnPrint.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPrint.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPrint.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPrint.FillColor = Color.FromArgb(0, 118, 225);
            btnPrint.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(43, 333);
            btnPrint.Name = "btnPrint";
            btnPrint.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnPrint.Size = new Size(148, 45);
            btnPrint.TabIndex = 20;
            btnPrint.Text = "Edit";
            // 
            // btnRemove
            // 
            btnRemove.BorderRadius = 21;
            btnRemove.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            btnRemove.CheckedState.FillColor = Color.White;
            btnRemove.CheckedState.ForeColor = Color.FromArgb(0, 11, 225);
            btnRemove.CustomizableEdges = customizableEdges9;
            btnRemove.DisabledState.BorderColor = Color.DarkGray;
            btnRemove.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRemove.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRemove.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRemove.FillColor = Color.FromArgb(0, 118, 225);
            btnRemove.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(230, 333);
            btnRemove.Name = "btnRemove";
            btnRemove.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnRemove.Size = new Size(148, 45);
            btnRemove.TabIndex = 19;
            btnRemove.Text = "Remove";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 21;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(437, 216);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowTemplate.Height = 25;
            guna2DataGridView1.Size = new Size(295, 252);
            guna2DataGridView1.TabIndex = 18;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 21;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.CustomizableEdges = customizableEdges5;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox1.ForeColor = Color.Black;
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(43, 268);
            guna2TextBox1.Margin = new Padding(4, 4, 4, 4);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2TextBox1.Size = new Size(335, 36);
            guna2TextBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            guna2TextBox1.TabIndex = 22;
            guna2TextBox1.TextChanged += guna2TextBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 239);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 21;
            label3.Text = "Edit Category";
            label3.Click += label3_Click;
            // 
            // Column1
            // 
            Column1.HeaderText = "Category Name";
            Column1.Name = "Column1";
            // 
            // UC_AddCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2TextBox1);
            Controls.Add(label3);
            Controls.Add(btnPrint);
            Controls.Add(btnRemove);
            Controls.Add(guna2DataGridView1);
            Controls.Add(txtCategoryName);
            Controls.Add(btnAddItems);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_AddCategories";
            Size = new Size(781, 514);
            Leave += UC_AddCategories_Leave;
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtCategoryName;
        private Guna.UI2.WinForms.Guna2Button btnAddItems;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private DataGridViewTextBoxColumn Column1;
    }
}
