namespace ProyectoMama
{
    partial class Form_Empleados_Listar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Empleados_Listar));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.dgv_empleadores = new System.Windows.Forms.DataGridView();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleadores)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lbl_subtitulo);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(740, 50);
            this.bunifuGradientPanel1.TabIndex = 19;
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.White;
            this.lbl_subtitulo.Location = new System.Drawing.Point(230, 6);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(239, 40);
            this.lbl_subtitulo.TabIndex = 6;
            this.lbl_subtitulo.Text = "Listar Empleados";
            // 
            // dgv_empleadores
            // 
            this.dgv_empleadores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.dgv_empleadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleadores.GridColor = System.Drawing.Color.White;
            this.dgv_empleadores.Location = new System.Drawing.Point(27, 120);
            this.dgv_empleadores.Name = "dgv_empleadores";
            this.dgv_empleadores.Size = new System.Drawing.Size(686, 468);
            this.dgv_empleadores.TabIndex = 20;
            // 
            // Form_Empleados_Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(740, 600);
            this.Controls.Add(this.dgv_empleadores);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Empleados_Listar";
            this.Text = "Form_Empleados_Listar";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.DataGridView dgv_empleadores;
    }
}