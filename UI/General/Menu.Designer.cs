
namespace UI.General
{
    partial class Menu
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
            this.PanelOpciones = new System.Windows.Forms.Panel();
            this.PanelFuncion = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelOpciones
            // 
            this.PanelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(81)))), ((int)(((byte)(130)))));
            this.PanelOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelOpciones.Location = new System.Drawing.Point(0, 0);
            this.PanelOpciones.Name = "PanelOpciones";
            this.PanelOpciones.Size = new System.Drawing.Size(282, 703);
            this.PanelOpciones.TabIndex = 0;
            // 
            // PanelFuncion
            // 
            this.PanelFuncion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.PanelFuncion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFuncion.Location = new System.Drawing.Point(282, 0);
            this.PanelFuncion.Name = "PanelFuncion";
            this.PanelFuncion.Size = new System.Drawing.Size(902, 703);
            this.PanelFuncion.TabIndex = 1;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 703);
            this.Controls.Add(this.PanelFuncion);
            this.Controls.Add(this.PanelOpciones);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelOpciones;
        private System.Windows.Forms.Panel PanelFuncion;
    }
}