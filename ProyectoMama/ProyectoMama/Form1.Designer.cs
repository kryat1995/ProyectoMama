namespace ProyectoMama
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.panel_menuTop = new System.Windows.Forms.Panel();
            this.picb_restaurar = new System.Windows.Forms.PictureBox();
            this.picb_minimizar = new System.Windows.Forms.PictureBox();
            this.picb_maximizar = new System.Windows.Forms.PictureBox();
            this.picb__salir = new System.Windows.Forms.PictureBox();
            this.lbl_dashboard = new System.Windows.Forms.Label();
            this.picb_dashboard = new System.Windows.Forms.PictureBox();
            this.panel_sideBar = new System.Windows.Forms.Panel();
            this.panel_central = new System.Windows.Forms.Panel();
            this.panel_menuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb__salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_dashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(749, 95);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(8, 8);
            this.doubleBitmapControl1.TabIndex = 0;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // panel_menuTop
            // 
            this.panel_menuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel_menuTop.Controls.Add(this.picb_restaurar);
            this.panel_menuTop.Controls.Add(this.picb_minimizar);
            this.panel_menuTop.Controls.Add(this.picb_maximizar);
            this.panel_menuTop.Controls.Add(this.picb__salir);
            this.panel_menuTop.Controls.Add(this.lbl_dashboard);
            this.panel_menuTop.Controls.Add(this.picb_dashboard);
            this.panel_menuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menuTop.Location = new System.Drawing.Point(0, 0);
            this.panel_menuTop.Name = "panel_menuTop";
            this.panel_menuTop.Size = new System.Drawing.Size(984, 80);
            this.panel_menuTop.TabIndex = 1;
            // 
            // picb_restaurar
            // 
            this.picb_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_restaurar.Image = ((System.Drawing.Image)(resources.GetObject("picb_restaurar.Image")));
            this.picb_restaurar.Location = new System.Drawing.Point(897, 25);
            this.picb_restaurar.Name = "picb_restaurar";
            this.picb_restaurar.Size = new System.Drawing.Size(30, 30);
            this.picb_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_restaurar.TabIndex = 5;
            this.picb_restaurar.TabStop = false;
            this.picb_restaurar.Visible = false;
            this.picb_restaurar.Click += new System.EventHandler(this.Picb_restaurar_Click);
            // 
            // picb_minimizar
            // 
            this.picb_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("picb_minimizar.Image")));
            this.picb_minimizar.Location = new System.Drawing.Point(861, 25);
            this.picb_minimizar.Name = "picb_minimizar";
            this.picb_minimizar.Size = new System.Drawing.Size(30, 30);
            this.picb_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_minimizar.TabIndex = 4;
            this.picb_minimizar.TabStop = false;
            this.picb_minimizar.Click += new System.EventHandler(this.Picb_minimizar_Click);
            // 
            // picb_maximizar
            // 
            this.picb_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_maximizar.Image = ((System.Drawing.Image)(resources.GetObject("picb_maximizar.Image")));
            this.picb_maximizar.Location = new System.Drawing.Point(897, 25);
            this.picb_maximizar.Name = "picb_maximizar";
            this.picb_maximizar.Size = new System.Drawing.Size(30, 30);
            this.picb_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_maximizar.TabIndex = 3;
            this.picb_maximizar.TabStop = false;
            this.picb_maximizar.Click += new System.EventHandler(this.Picb_maximizar_Click);
            // 
            // picb__salir
            // 
            this.picb__salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb__salir.Image = ((System.Drawing.Image)(resources.GetObject("picb__salir.Image")));
            this.picb__salir.Location = new System.Drawing.Point(933, 25);
            this.picb__salir.Name = "picb__salir";
            this.picb__salir.Size = new System.Drawing.Size(30, 30);
            this.picb__salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb__salir.TabIndex = 2;
            this.picb__salir.TabStop = false;
            this.picb__salir.Click += new System.EventHandler(this.Picb__salir_Click);
            // 
            // lbl_dashboard
            // 
            this.lbl_dashboard.AutoSize = true;
            this.lbl_dashboard.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dashboard.ForeColor = System.Drawing.Color.White;
            this.lbl_dashboard.Location = new System.Drawing.Point(59, 27);
            this.lbl_dashboard.Name = "lbl_dashboard";
            this.lbl_dashboard.Size = new System.Drawing.Size(115, 28);
            this.lbl_dashboard.TabIndex = 1;
            this.lbl_dashboard.Text = "DASHBOARD";
            // 
            // picb_dashboard
            // 
            this.picb_dashboard.Image = ((System.Drawing.Image)(resources.GetObject("picb_dashboard.Image")));
            this.picb_dashboard.Location = new System.Drawing.Point(23, 25);
            this.picb_dashboard.Name = "picb_dashboard";
            this.picb_dashboard.Size = new System.Drawing.Size(30, 30);
            this.picb_dashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_dashboard.TabIndex = 0;
            this.picb_dashboard.TabStop = false;
            // 
            // panel_sideBar
            // 
            this.panel_sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel_sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sideBar.Location = new System.Drawing.Point(0, 80);
            this.panel_sideBar.Name = "panel_sideBar";
            this.panel_sideBar.Size = new System.Drawing.Size(250, 581);
            this.panel_sideBar.TabIndex = 2;
            // 
            // panel_central
            // 
            this.panel_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_central.Location = new System.Drawing.Point(250, 80);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(734, 581);
            this.panel_central.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.panel_sideBar);
            this.Controls.Add(this.panel_menuTop);
            this.Controls.Add(this.doubleBitmapControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_menuTop.ResumeLayout(false);
            this.panel_menuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb__salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_dashboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        private System.Windows.Forms.Panel panel_menuTop;
        private System.Windows.Forms.Panel panel_sideBar;
        private System.Windows.Forms.Panel panel_central;
        private System.Windows.Forms.PictureBox picb_dashboard;
        private System.Windows.Forms.Label lbl_dashboard;
        private System.Windows.Forms.PictureBox picb_restaurar;
        private System.Windows.Forms.PictureBox picb_minimizar;
        private System.Windows.Forms.PictureBox picb_maximizar;
        private System.Windows.Forms.PictureBox picb__salir;
    }
}

