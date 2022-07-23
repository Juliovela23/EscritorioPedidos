
namespace UI.Reportes
{
    partial class Reporte2
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
            this.Grupo_empleado = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ChekSinF = new System.Windows.Forms.CheckBox();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.butoncrear = new System.Windows.Forms.Button();
            this.Grupo_empleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grupo_empleado
            // 
            this.Grupo_empleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Grupo_empleado.Controls.Add(this.butoncrear);
            this.Grupo_empleado.Controls.Add(this.label2);
            this.Grupo_empleado.Controls.Add(this.txtCiudad);
            this.Grupo_empleado.Controls.Add(this.comboBox1);
            this.Grupo_empleado.Controls.Add(this.ChekSinF);
            this.Grupo_empleado.Controls.Add(this.date2);
            this.Grupo_empleado.Controls.Add(this.label1);
            this.Grupo_empleado.Controls.Add(this.date1);
            this.Grupo_empleado.Controls.Add(this.btnEnter);
            this.Grupo_empleado.Controls.Add(this.label3);
            this.Grupo_empleado.Controls.Add(this.dataGridView1);
            this.Grupo_empleado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo_empleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(89)))), ((int)(((byte)(85)))));
            this.Grupo_empleado.Location = new System.Drawing.Point(84, 61);
            this.Grupo_empleado.Name = "Grupo_empleado";
            this.Grupo_empleado.Size = new System.Drawing.Size(660, 361);
            this.Grupo_empleado.TabIndex = 76;
            this.Grupo_empleado.TabStop = false;
            this.Grupo_empleado.Text = "Información del reporte";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(89)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(336, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(393, 79);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(111, 22);
            this.txtCiudad.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Completado",
            "En proceso",
            "Anulado",
            "Todos"});
            this.comboBox1.Location = new System.Drawing.Point(158, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // ChekSinF
            // 
            this.ChekSinF.AutoSize = true;
            this.ChekSinF.Location = new System.Drawing.Point(443, 37);
            this.ChekSinF.Name = "ChekSinF";
            this.ChekSinF.Size = new System.Drawing.Size(80, 20);
            this.ChekSinF.TabIndex = 13;
            this.ChekSinF.Text = "Sin fecha";
            this.ChekSinF.UseVisualStyleBackColor = true;
            this.ChekSinF.CheckedChanged += new System.EventHandler(this.ChekSinF_CheckedChanged);
            // 
            // date2
            // 
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(303, 37);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(117, 22);
            this.date2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(89)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(65, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rango de fechas";
            // 
            // date1
            // 
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(158, 37);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(106, 22);
            this.date1.TabIndex = 9;
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btnEnter.BackgroundImage = global::UI.Properties.Resources.buscar;
            this.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(124)))));
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.Yellow;
            this.btnEnter.Location = new System.Drawing.Point(517, 72);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(49, 32);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(89)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(60, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado pedido";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(526, 235);
            this.dataGridView1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(357, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 30);
            this.label7.TabIndex = 75;
            this.label7.Text = "Reporte 2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 23);
            this.panel1.TabIndex = 77;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(766, 0);
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
            // butoncrear
            // 
            this.butoncrear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butoncrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(89)))), ((int)(((byte)(85)))));
            this.butoncrear.FlatAppearance.BorderSize = 0;
            this.butoncrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.butoncrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.butoncrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butoncrear.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butoncrear.ForeColor = System.Drawing.Color.YellowGreen;
            this.butoncrear.Location = new System.Drawing.Point(572, 66);
            this.butoncrear.Name = "butoncrear";
            this.butoncrear.Size = new System.Drawing.Size(77, 42);
            this.butoncrear.TabIndex = 88;
            this.butoncrear.Text = "Crear Reporte";
            this.butoncrear.UseVisualStyleBackColor = false;
            this.butoncrear.Click += new System.EventHandler(this.butoncrear_Click);
            // 
            // Reporte2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grupo_empleado);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporte2";
            this.Text = "Reporte2";
            this.Grupo_empleado.ResumeLayout(false);
            this.Grupo_empleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grupo_empleado;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox ChekSinF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Button butoncrear;
    }
}