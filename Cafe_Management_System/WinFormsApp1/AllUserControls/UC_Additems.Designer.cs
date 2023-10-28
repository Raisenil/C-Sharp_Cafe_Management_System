namespace CafeManagement.AllUserControls
{
    partial class UC_Additems
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAddItems = new Guna.UI2.WinForms.Guna2Button();
            txtCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            txtItemName = new Guna.UI2.WinForms.Guna2TextBox();
            txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(312, 52);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 0;
            label1.Text = "Add New Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(223, 218);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 1;
            label2.Text = "Item Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(223, 307);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(223, 129);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 3;
            label4.Text = "Category";
            // 
            // btnAddItems
            // 
            btnAddItems.BorderRadius = 21;
            btnAddItems.CustomizableEdges = customizableEdges1;
            btnAddItems.DisabledState.BorderColor = Color.DarkGray;
            btnAddItems.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddItems.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddItems.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddItems.FillColor = Color.FromArgb(0, 118, 225);
            btnAddItems.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddItems.ForeColor = Color.White;
            btnAddItems.Location = new Point(300, 396);
            btnAddItems.Name = "btnAddItems";
            btnAddItems.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddItems.Size = new Size(180, 45);
            btnAddItems.TabIndex = 4;
            btnAddItems.Text = "Add Item";
            btnAddItems.Click += btnAddItems_Click;
            // 
            // txtCategory
            // 
            txtCategory.BackColor = Color.Transparent;
            txtCategory.CustomizableEdges = customizableEdges3;
            txtCategory.DrawMode = DrawMode.OwnerDrawFixed;
            txtCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            txtCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategory.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategory.ForeColor = Color.Black;
            txtCategory.ItemHeight = 30;
            txtCategory.Location = new Point(223, 168);
            txtCategory.Name = "txtCategory";
            txtCategory.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtCategory.Size = new Size(335, 36);
            txtCategory.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtCategory.TabIndex = 5;
            txtCategory.SelectedIndexChanged += txtCategory_SelectedIndexChanged;
            // 
            // txtItemName
            // 
            txtItemName.CustomizableEdges = customizableEdges5;
            txtItemName.DefaultText = "";
            txtItemName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtItemName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtItemName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtItemName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtItemName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtItemName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemName.ForeColor = Color.Black;
            txtItemName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtItemName.Location = new Point(223, 257);
            txtItemName.Margin = new Padding(4, 4, 4, 4);
            txtItemName.Name = "txtItemName";
            txtItemName.PasswordChar = '\0';
            txtItemName.PlaceholderText = "";
            txtItemName.SelectedText = "";
            txtItemName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtItemName.Size = new Size(335, 36);
            txtItemName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtItemName.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.CustomizableEdges = customizableEdges7;
            txtPrice.DefaultText = "";
            txtPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.ForeColor = Color.Black;
            txtPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Location = new Point(223, 346);
            txtPrice.Margin = new Padding(4, 4, 4, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PlaceholderText = "";
            txtPrice.SelectedText = "";
            txtPrice.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtPrice.Size = new Size(335, 36);
            txtPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtPrice.TabIndex = 7;
            txtPrice.TextChanged += guna2TextBox2_TextChanged;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // UC_Additems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtPrice);
            Controls.Add(txtItemName);
            Controls.Add(txtCategory);
            Controls.Add(btnAddItems);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_Additems";
            Size = new Size(781, 514);
            Load += UC_Additems_Load;
            Leave += UC_Additems_Leave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button btnAddItems;
        private Guna.UI2.WinForms.Guna2ComboBox txtCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtItemName;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
