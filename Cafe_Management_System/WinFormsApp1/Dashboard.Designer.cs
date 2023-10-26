﻿namespace WinFormsApp1
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnLogOut = new LinkLabel();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            btnRemove = new Guna.UI2.WinForms.Guna2Button();
            btnAddItems = new Guna.UI2.WinForms.Guna2Button();
            btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            btnPlaceOrder = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(components);
            uC_Welcome1 = new CafeManagement.AllUserControls.UC_Welcome();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 118, 225);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(btnAddItems);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnPlaceOrder);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 514);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnLogOut
            // 
            btnLogOut.AutoSize = true;
            btnLogOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.LinkBehavior = LinkBehavior.NeverUnderline;
            btnLogOut.LinkColor = Color.White;
            btnLogOut.Location = new Point(79, 464);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(66, 21);
            btnLogOut.TabIndex = 7;
            btnLogOut.TabStop = true;
            btnLogOut.Text = "LogOut";
            btnLogOut.LinkClicked += btnLogOut_LinkClicked;
            // 
            // btnExit
            // 
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(3, 3);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(40, 34);
            btnExit.TabIndex = 4;
            btnExit.Text = "X";
            btnExit.Click += btnExit_Click;
            // 
            // btnRemove
            // 
            btnRemove.BorderRadius = 15;
            btnRemove.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnRemove.CheckedState.FillColor = Color.White;
            btnRemove.CheckedState.ForeColor = Color.FromArgb(0, 118, 225);
            btnRemove.CustomizableEdges = customizableEdges2;
            btnRemove.DisabledState.BorderColor = Color.DarkGray;
            btnRemove.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRemove.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRemove.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRemove.FillColor = Color.FromArgb(0, 118, 225);
            btnRemove.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(31, 312);
            btnRemove.Name = "btnRemove";
            btnRemove.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnRemove.Size = new Size(202, 41);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove Itmes";
            // 
            // btnAddItems
            // 
            btnAddItems.BorderRadius = 15;
            btnAddItems.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnAddItems.CheckedState.FillColor = Color.White;
            btnAddItems.CheckedState.ForeColor = Color.FromArgb(0, 118, 225);
            btnAddItems.CustomizableEdges = customizableEdges4;
            btnAddItems.DisabledState.BorderColor = Color.DarkGray;
            btnAddItems.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddItems.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddItems.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddItems.FillColor = Color.FromArgb(0, 118, 225);
            btnAddItems.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddItems.ForeColor = Color.White;
            btnAddItems.Location = new Point(31, 180);
            btnAddItems.Name = "btnAddItems";
            btnAddItems.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnAddItems.Size = new Size(202, 41);
            btnAddItems.TabIndex = 2;
            btnAddItems.Text = "Add Items";
            // 
            // btnUpdate
            // 
            btnUpdate.BorderRadius = 15;
            btnUpdate.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnUpdate.CheckedState.FillColor = Color.White;
            btnUpdate.CheckedState.ForeColor = Color.FromArgb(0, 118, 225);
            btnUpdate.CustomizableEdges = customizableEdges6;
            btnUpdate.DisabledState.BorderColor = Color.DarkGray;
            btnUpdate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpdate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpdate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpdate.FillColor = Color.FromArgb(0, 118, 225);
            btnUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(31, 246);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnUpdate.Size = new Size(202, 41);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update Item";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BorderRadius = 15;
            btnPlaceOrder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnPlaceOrder.CheckedState.FillColor = Color.White;
            btnPlaceOrder.CheckedState.ForeColor = Color.FromArgb(0, 118, 225);
            btnPlaceOrder.CustomizableEdges = customizableEdges8;
            btnPlaceOrder.DisabledState.BorderColor = Color.DarkGray;
            btnPlaceOrder.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPlaceOrder.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPlaceOrder.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPlaceOrder.FillColor = Color.FromArgb(0, 118, 225);
            btnPlaceOrder.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlaceOrder.ForeColor = Color.White;
            btnPlaceOrder.Location = new Point(31, 114);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.ShadowDecoration.CustomizableEdges = customizableEdges9;
            btnPlaceOrder.Size = new Size(202, 41);
            btnPlaceOrder.TabIndex = 0;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(uC_Welcome1);
            panel2.Location = new Point(211, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(781, 514);
            panel2.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 30;
            guna2Elipse2.TargetControl = panel2;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 30;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.BorderRadius = 30;
            // 
            // guna2Elipse5
            // 
            guna2Elipse5.BorderRadius = 30;
            // 
            // uC_Welcome1
            // 
            uC_Welcome1.BackColor = Color.White;
            uC_Welcome1.Location = new Point(-3, 0);
            uC_Welcome1.Name = "uC_Welcome1";
            uC_Welcome1.Size = new Size(781, 514);
            uC_Welcome1.TabIndex = 0;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 118, 225);
            ClientSize = new Size(1004, 538);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnAddItems;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnPlaceOrder;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private LinkLabel btnLogOut;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private CafeManagement.AllUserControls.UC_Welcome uC_Welcome1;
    }
}