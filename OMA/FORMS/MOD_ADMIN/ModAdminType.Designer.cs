﻿
namespace OMA.FORMS.MOD_ADMIN
{
    partial class ModAdminType
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adm = new System.Windows.Forms.RadioButton();
            this.usr = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("DM Sans", 15F);
            this.button1.Location = new System.Drawing.Point(24, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 39);
            this.button1.TabIndex = 51;
            this.button1.Text = "Confirmar Cambios";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DM Sans", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 35);
            this.label1.TabIndex = 48;
            this.label1.Text = "Cambiar Jerarquia:";
            // 
            // adm
            // 
            this.adm.AutoSize = true;
            this.adm.Font = new System.Drawing.Font("DM Sans", 12F);
            this.adm.ForeColor = System.Drawing.Color.White;
            this.adm.Location = new System.Drawing.Point(24, 56);
            this.adm.Name = "adm";
            this.adm.Size = new System.Drawing.Size(134, 25);
            this.adm.TabIndex = 52;
            this.adm.TabStop = true;
            this.adm.Text = "Administrador";
            this.adm.UseVisualStyleBackColor = true;
            // 
            // usr
            // 
            this.usr.AutoSize = true;
            this.usr.Font = new System.Drawing.Font("DM Sans", 12F);
            this.usr.ForeColor = System.Drawing.Color.White;
            this.usr.Location = new System.Drawing.Point(24, 96);
            this.usr.Name = "usr";
            this.usr.Size = new System.Drawing.Size(84, 25);
            this.usr.TabIndex = 53;
            this.usr.TabStop = true;
            this.usr.Text = "Usuario";
            this.usr.UseVisualStyleBackColor = true;
            // 
            // ModAdminType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(331, 206);
            this.Controls.Add(this.usr);
            this.Controls.Add(this.adm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ModAdminType";
            this.Text = "ModAdminType";
            this.Load += new System.EventHandler(this.ModAdminType_Load);
            this.LocationChanged += new System.EventHandler(this.ModAdminType_LocationChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton adm;
        private System.Windows.Forms.RadioButton usr;
    }
}