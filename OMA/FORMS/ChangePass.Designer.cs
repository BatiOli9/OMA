
namespace OMA.FORMS
{
    partial class ChangePass
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
            this.label1 = new System.Windows.Forms.Label();
            this.oldPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DM Sans", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 35);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cambiar Contraseña";
            // 
            // oldPass
            // 
            this.oldPass.Font = new System.Drawing.Font("DM Sans", 12F);
            this.oldPass.Location = new System.Drawing.Point(24, 88);
            this.oldPass.Name = "oldPass";
            this.oldPass.Size = new System.Drawing.Size(234, 28);
            this.oldPass.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DM Sans", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Vieja contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DM Sans", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Nueva contraseña:";
            // 
            // newPass
            // 
            this.newPass.Font = new System.Drawing.Font("DM Sans", 12F);
            this.newPass.Location = new System.Drawing.Point(24, 153);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(234, 28);
            this.newPass.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DM Sans", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Confirmar contraseña:";
            // 
            // confPass
            // 
            this.confPass.Font = new System.Drawing.Font("DM Sans", 12F);
            this.confPass.Location = new System.Drawing.Point(24, 225);
            this.confPass.Name = "confPass";
            this.confPass.Size = new System.Drawing.Size(234, 28);
            this.confPass.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("DM Sans", 15F);
            this.button1.Location = new System.Drawing.Point(24, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 39);
            this.button1.TabIndex = 38;
            this.button1.Text = "Confirmar Cambios";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.Black;
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.iconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 25;
            this.iconButton3.Location = new System.Drawing.Point(264, 91);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(33, 23);
            this.iconButton3.TabIndex = 39;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Black;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(264, 156);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(33, 23);
            this.iconButton1.TabIndex = 40;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Black;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.Location = new System.Drawing.Point(264, 228);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(33, 23);
            this.iconButton2.TabIndex = 41;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(331, 345);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.confPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldPass);
            this.Controls.Add(this.label1);
            this.Name = "ChangePass";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oldPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confPass;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}