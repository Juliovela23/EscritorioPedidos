
namespace UI.Productos
{
    partial class EditarProducto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupRegistro = new System.Windows.Forms.GroupBox();
            this.grupoInformacion = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_PrecioVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.But_eliminar = new System.Windows.Forms.Button();
            this.butEditar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupRegistro.SuspendLayout();
            this.grupoInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 23);
            this.panel1.TabIndex = 60;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(738, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(34, 23);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupRegistro
            // 
            this.groupRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupRegistro.Controls.Add(this.grupoInformacion);
            this.groupRegistro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(89)))), ((int)(((byte)(85)))));
            this.groupRegistro.Location = new System.Drawing.Point(25, 28);
            this.groupRegistro.Name = "groupRegistro";
            this.groupRegistro.Size = new System.Drawing.Size(703, 452);
            this.groupRegistro.TabIndex = 61;
            this.groupRegistro.TabStop = false;
            this.groupRegistro.Text = "Actualizar producto";
            // 
            // grupoInformacion
            // 
            this.grupoInformacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grupoInformacion.BackColor = System.Drawing.Color.Transparent;
            this.grupoInformacion.Controls.Add(this.But_eliminar);
            this.grupoInformacion.Controls.Add(this.butEditar);
            this.grupoInformacion.Controls.Add(this.pictureBox2);
            this.grupoInformacion.Controls.Add(this.label1);
            this.grupoInformacion.Controls.Add(this.comboBox1);
            this.grupoInformacion.Controls.Add(this.label3);
            this.grupoInformacion.Controls.Add(this.label4);
            this.grupoInformacion.Controls.Add(this.label6);
            this.grupoInformacion.Controls.Add(this.txt_PrecioVenta);
            this.grupoInformacion.Controls.Add(this.label5);
            this.grupoInformacion.Controls.Add(this.txt_producto);
            this.grupoInformacion.Controls.Add(this.label12);
            this.grupoInformacion.Controls.Add(this.txt_desc);
            this.grupoInformacion.Controls.Add(this.txt_Marca);
            this.grupoInformacion.Controls.Add(this.comboCategoria);
            this.grupoInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoInformacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(89)))), ((int)(((byte)(85)))));
            this.grupoInformacion.Location = new System.Drawing.Point(-43, 28);
            this.grupoInformacion.Name = "grupoInformacion";
            this.grupoInformacion.Size = new System.Drawing.Size(768, 418);
            this.grupoInformacion.TabIndex = 29;
            this.grupoInformacion.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(89)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(448, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nombre producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(89)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(121, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Precio venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(89)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(459, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Categoría producto";
            // 
            // txt_PrecioVenta
            // 
            this.txt_PrecioVenta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PrecioVenta.ForeColor = System.Drawing.Color.Black;
            this.txt_PrecioVenta.Location = new System.Drawing.Point(124, 140);
            this.txt_PrecioVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txt_PrecioVenta.Name = "txt_PrecioVenta";
            this.txt_PrecioVenta.Size = new System.Drawing.Size(170, 23);
            this.txt_PrecioVenta.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(89)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(448, 286);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Marca";
            // 
            // txt_producto
            // 
            this.txt_producto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_producto.ForeColor = System.Drawing.Color.Black;
            this.txt_producto.Location = new System.Drawing.Point(451, 55);
            this.txt_producto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(149, 23);
            this.txt_producto.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(89)))), ((int)(((byte)(85)))));
            this.label12.Location = new System.Drawing.Point(121, 198);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Descripcion del producto";
            // 
            // txt_desc
            // 
            this.txt_desc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.ForeColor = System.Drawing.Color.Black;
            this.txt_desc.Location = new System.Drawing.Point(124, 232);
            this.txt_desc.Margin = new System.Windows.Forms.Padding(2);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(263, 95);
            this.txt_desc.TabIndex = 2;
            // 
            // txt_Marca
            // 
            this.txt_Marca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Marca.ForeColor = System.Drawing.Color.Black;
            this.txt_Marca.Location = new System.Drawing.Point(462, 304);
            this.txt_Marca.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(138, 23);
            this.txt_Marca.TabIndex = 5;
            // 
            // comboCategoria
            // 
            this.comboCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCategoria.ForeColor = System.Drawing.Color.Black;
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(462, 224);
            this.comboCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(138, 25);
            this.comboCategoria.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 24);
            this.comboBox1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(89)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(121, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Bsqueda pedidos";
            // 
            // But_eliminar
            // 
            this.But_eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.But_eliminar.BackColor = System.Drawing.Color.Red;
            this.But_eliminar.FlatAppearance.BorderSize = 0;
            this.But_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.But_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.But_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_eliminar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_eliminar.ForeColor = System.Drawing.Color.White;
            this.But_eliminar.Location = new System.Drawing.Point(414, 359);
            this.But_eliminar.Name = "But_eliminar";
            this.But_eliminar.Size = new System.Drawing.Size(96, 29);
            this.But_eliminar.TabIndex = 68;
            this.But_eliminar.Text = "Eliminar";
            this.But_eliminar.UseVisualStyleBackColor = false;
            this.But_eliminar.Visible = false;
            this.But_eliminar.Click += new System.EventHandler(this.But_eliminar_Click);
            // 
            // butEditar
            // 
            this.butEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(89)))), ((int)(((byte)(85)))));
            this.butEditar.FlatAppearance.BorderSize = 0;
            this.butEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(89)))), ((int)(((byte)(85)))));
            this.butEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(124)))));
            this.butEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butEditar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEditar.ForeColor = System.Drawing.Color.Yellow;
            this.butEditar.Location = new System.Drawing.Point(273, 359);
            this.butEditar.Name = "butEditar";
            this.butEditar.Size = new System.Drawing.Size(96, 29);
            this.butEditar.TabIndex = 67;
            this.butEditar.Text = "Editar";
            this.butEditar.UseVisualStyleBackColor = false;
            this.butEditar.Visible = false;
            this.butEditar.Click += new System.EventHandler(this.butEditar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI.Properties.Resources.buscar;
            this.pictureBox2.Location = new System.Drawing.Point(343, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // EditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(772, 511);
            this.Controls.Add(this.groupRegistro);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarProducto";
            this.Text = "EditarProducto";
            this.Load += new System.EventHandler(this.EditarProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupRegistro.ResumeLayout(false);
            this.grupoInformacion.ResumeLayout(false);
            this.grupoInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupRegistro;
        private System.Windows.Forms.GroupBox grupoInformacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_PrecioVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button But_eliminar;
        private System.Windows.Forms.Button butEditar;
    }
}