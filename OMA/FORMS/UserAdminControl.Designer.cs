
namespace OMA.FORMS
{
    partial class UserAdminControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombre = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.Label();
            this.jerarquia = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("DM Sans", 15F, System.Drawing.FontStyle.Bold);
            this.nombre.Location = new System.Drawing.Point(136, 7);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(88, 26);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "nombre";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Font = new System.Drawing.Font("DM Sans", 15F);
            this.mail.Location = new System.Drawing.Point(136, 35);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(50, 26);
            this.mail.TabIndex = 1;
            this.mail.Text = "mail";
            // 
            // contraseña
            // 
            this.contraseña.AutoSize = true;
            this.contraseña.Font = new System.Drawing.Font("DM Sans", 15F);
            this.contraseña.Location = new System.Drawing.Point(136, 62);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(115, 26);
            this.contraseña.TabIndex = 2;
            this.contraseña.Text = "contraseña";
            // 
            // jerarquia
            // 
            this.jerarquia.AutoSize = true;
            this.jerarquia.Font = new System.Drawing.Font("DM Sans", 15F);
            this.jerarquia.Location = new System.Drawing.Point(136, 90);
            this.jerarquia.Name = "jerarquia";
            this.jerarquia.Size = new System.Drawing.Size(93, 26);
            this.jerarquia.TabIndex = 3;
            this.jerarquia.Text = "jerarquia";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 122;
            this.iconPictureBox1.Location = new System.Drawing.Point(2, 7);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(122, 125);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(562, 18);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(176, 33);
            this.button2.TabIndex = 37;
            this.button2.Text = "Modificar Usuario";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(562, 74);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(176, 33);
            this.button1.TabIndex = 38;
            this.button1.Text = "Eliminar Usuario";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // UserAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.jerarquia);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.nombre);
            this.Name = "UserAdminControl";
            this.Size = new System.Drawing.Size(750, 125);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.Label jerarquia;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
