﻿
namespace OMA.FORMS
{
    partial class AdminUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUserControl));
            this.header = new System.Windows.Forms.Panel();
            this.btnControl = new System.Windows.Forms.Button();
            this.adminLbl = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.settings = new System.Windows.Forms.Button();
            this.account = new System.Windows.Forms.Button();
            this.OMA = new System.Windows.Forms.Button();
            this.regulation = new System.Windows.Forms.Button();
            this.shop = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.header.Controls.Add(this.btnControl);
            this.header.Controls.Add(this.adminLbl);
            this.header.Controls.Add(this.iconButton2);
            this.header.Controls.Add(this.iconButton1);
            this.header.Controls.Add(this.settings);
            this.header.Controls.Add(this.account);
            this.header.Controls.Add(this.OMA);
            this.header.Controls.Add(this.regulation);
            this.header.Controls.Add(this.shop);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(800, 118);
            this.header.TabIndex = 4;
            // 
            // btnControl
            // 
            this.btnControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnControl.BackColor = System.Drawing.Color.Transparent;
            this.btnControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControl.FlatAppearance.BorderSize = 0;
            this.btnControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControl.Font = new System.Drawing.Font("DM Sans", 10F, System.Drawing.FontStyle.Bold);
            this.btnControl.Location = new System.Drawing.Point(165, 3);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(196, 33);
            this.btnControl.TabIndex = 32;
            this.btnControl.Text = "Accede al panel de control";
            this.btnControl.UseVisualStyleBackColor = false;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // adminLbl
            // 
            this.adminLbl.AutoSize = true;
            this.adminLbl.Font = new System.Drawing.Font("DM Sans", 10F);
            this.adminLbl.Location = new System.Drawing.Point(9, 9);
            this.adminLbl.Name = "adminLbl";
            this.adminLbl.Size = new System.Drawing.Size(152, 18);
            this.adminLbl.TabIndex = 31;
            this.adminLbl.Text = "Usuario Administrador";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.Location = new System.Drawing.Point(727, -1);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(35, 41);
            this.iconButton2.TabIndex = 26;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(767, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(33, 40);
            this.iconButton1.TabIndex = 25;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // settings
            // 
            this.settings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settings.BackColor = System.Drawing.Color.Transparent;
            this.settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings.FlatAppearance.BorderSize = 0;
            this.settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.Font = new System.Drawing.Font("DM Sans", 14F);
            this.settings.Location = new System.Drawing.Point(639, 54);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(153, 31);
            this.settings.TabIndex = 11;
            this.settings.Text = "Cerrar Sesion";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // account
            // 
            this.account.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.account.BackColor = System.Drawing.Color.Transparent;
            this.account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.account.FlatAppearance.BorderSize = 0;
            this.account.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.account.Font = new System.Drawing.Font("DM Sans", 14F);
            this.account.Location = new System.Drawing.Point(491, 51);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(129, 38);
            this.account.TabIndex = 10;
            this.account.Text = "Mi Cuenta";
            this.account.UseVisualStyleBackColor = false;
            this.account.Click += new System.EventHandler(this.account_Click);
            // 
            // OMA
            // 
            this.OMA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OMA.BackColor = System.Drawing.Color.Transparent;
            this.OMA.BackgroundImage = global::OMA.Properties.Resources.OMA_removebg_preview;
            this.OMA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OMA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OMA.FlatAppearance.BorderSize = 0;
            this.OMA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.OMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OMA.Location = new System.Drawing.Point(356, 12);
            this.OMA.Name = "OMA";
            this.OMA.Size = new System.Drawing.Size(103, 99);
            this.OMA.TabIndex = 9;
            this.OMA.UseVisualStyleBackColor = false;
            this.OMA.Click += new System.EventHandler(this.OMA_Click);
            // 
            // regulation
            // 
            this.regulation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regulation.BackColor = System.Drawing.Color.Transparent;
            this.regulation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regulation.FlatAppearance.BorderSize = 0;
            this.regulation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.regulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regulation.Font = new System.Drawing.Font("DM Sans", 14F);
            this.regulation.Location = new System.Drawing.Point(165, 51);
            this.regulation.Name = "regulation";
            this.regulation.Size = new System.Drawing.Size(119, 38);
            this.regulation.TabIndex = 7;
            this.regulation.Text = "Regulacion";
            this.regulation.UseVisualStyleBackColor = false;
            this.regulation.Click += new System.EventHandler(this.regulation_Click);
            // 
            // shop
            // 
            this.shop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shop.BackColor = System.Drawing.Color.Transparent;
            this.shop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shop.FlatAppearance.BorderSize = 0;
            this.shop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.shop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shop.Font = new System.Drawing.Font("DM Sans", 14F);
            this.shop.Location = new System.Drawing.Point(12, 54);
            this.shop.Name = "shop";
            this.shop.Size = new System.Drawing.Size(130, 33);
            this.shop.TabIndex = 5;
            this.shop.Text = "Tienda";
            this.shop.UseVisualStyleBackColor = false;
            this.shop.Click += new System.EventHandler(this.shop_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 175);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(780, 322);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DM Sans", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(293, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 30);
            this.label1.TabIndex = 34;
            this.label1.Text = "Gestion de Usuarios:";
            // 
            // AdminUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminUserControl";
            this.Text = "AdminUserControl";
            this.Load += new System.EventHandler(this.AdminUserControl_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Label adminLbl;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button account;
        private System.Windows.Forms.Button OMA;
        private System.Windows.Forms.Button regulation;
        private System.Windows.Forms.Button shop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}