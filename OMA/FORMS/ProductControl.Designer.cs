
namespace OMA.FORMS
{
    partial class ProductControl
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
            this.link = new System.Windows.Forms.Button();
            this.precio = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.foto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // link
            // 
            this.link.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.link.FlatAppearance.BorderSize = 0;
            this.link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.link.Font = new System.Drawing.Font("DM Sans", 14F);
            this.link.Location = new System.Drawing.Point(5, 226);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(210, 43);
            this.link.TabIndex = 0;
            this.link.Text = "Agregar al Carrito";
            this.link.UseVisualStyleBackColor = false;
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Font = new System.Drawing.Font("DM Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio.Location = new System.Drawing.Point(3, 192);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(66, 29);
            this.precio.TabIndex = 2;
            this.precio.Text = "$100";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("DM Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(3, 167);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(168, 25);
            this.nombre.TabIndex = 3;
            this.nombre.Text = "nombre producto";
            // 
            // foto
            // 
            this.foto.Location = new System.Drawing.Point(5, 6);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(210, 156);
            this.foto.TabIndex = 4;
            this.foto.TabStop = false;
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.foto);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.link);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(220, 278);
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button link;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.PictureBox foto;
    }
}
