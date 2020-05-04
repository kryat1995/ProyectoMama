namespace ProyectoMama
{
    partial class Form_Empleadores_Agregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Empleadores_Agregar));
            this.panel_empleador_agregar = new System.Windows.Forms.Panel();
            this.cmb_localidades = new System.Windows.Forms.ComboBox();
            this.cmb_provincias = new System.Windows.Forms.ComboBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.txt_razonSocial = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_cuit = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_domicilio = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_empleador_agregar.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_empleador_agregar
            // 
            this.panel_empleador_agregar.Controls.Add(this.cmb_localidades);
            this.panel_empleador_agregar.Controls.Add(this.cmb_provincias);
            this.panel_empleador_agregar.Controls.Add(this.bunifuGradientPanel1);
            this.panel_empleador_agregar.Controls.Add(this.txt_razonSocial);
            this.panel_empleador_agregar.Controls.Add(this.txt_cuit);
            this.panel_empleador_agregar.Controls.Add(this.txt_domicilio);
            this.panel_empleador_agregar.Controls.Add(this.btn_confirmar);
            this.panel_empleador_agregar.Controls.Add(this.label5);
            this.panel_empleador_agregar.Controls.Add(this.label4);
            this.panel_empleador_agregar.Controls.Add(this.label3);
            this.panel_empleador_agregar.Controls.Add(this.label2);
            this.panel_empleador_agregar.Controls.Add(this.label1);
            this.panel_empleador_agregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_empleador_agregar.Location = new System.Drawing.Point(0, 0);
            this.panel_empleador_agregar.Name = "panel_empleador_agregar";
            this.panel_empleador_agregar.Size = new System.Drawing.Size(740, 600);
            this.panel_empleador_agregar.TabIndex = 2;
            // 
            // cmb_localidades
            // 
            this.cmb_localidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.cmb_localidades.DropDownHeight = 150;
            this.cmb_localidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_localidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_localidades.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_localidades.ForeColor = System.Drawing.Color.White;
            this.cmb_localidades.FormattingEnabled = true;
            this.cmb_localidades.IntegralHeight = false;
            this.cmb_localidades.Location = new System.Drawing.Point(232, 253);
            this.cmb_localidades.Name = "cmb_localidades";
            this.cmb_localidades.Size = new System.Drawing.Size(258, 29);
            this.cmb_localidades.TabIndex = 17;
            // 
            // cmb_provincias
            // 
            this.cmb_provincias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.cmb_provincias.DropDownHeight = 150;
            this.cmb_provincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_provincias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_provincias.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_provincias.ForeColor = System.Drawing.Color.White;
            this.cmb_provincias.FormattingEnabled = true;
            this.cmb_provincias.IntegralHeight = false;
            this.cmb_provincias.Location = new System.Drawing.Point(232, 218);
            this.cmb_provincias.Name = "cmb_provincias";
            this.cmb_provincias.Size = new System.Drawing.Size(258, 29);
            this.cmb_provincias.TabIndex = 16;
            this.cmb_provincias.SelectedIndexChanged += new System.EventHandler(this.Cmb_provincias_SelectedIndexChanged);
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
            this.bunifuGradientPanel1.TabIndex = 15;
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.White;
            this.lbl_subtitulo.Location = new System.Drawing.Point(228, 6);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(270, 40);
            this.lbl_subtitulo.TabIndex = 6;
            this.lbl_subtitulo.Text = "Agregar Empleador";
            // 
            // txt_razonSocial
            // 
            this.txt_razonSocial.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_razonSocial.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_razonSocial.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_razonSocial.BorderThickness = 3;
            this.txt_razonSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_razonSocial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_razonSocial.ForeColor = System.Drawing.Color.White;
            this.txt_razonSocial.isPassword = false;
            this.txt_razonSocial.Location = new System.Drawing.Point(232, 75);
            this.txt_razonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txt_razonSocial.Name = "txt_razonSocial";
            this.txt_razonSocial.Size = new System.Drawing.Size(258, 41);
            this.txt_razonSocial.TabIndex = 14;
            this.txt_razonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_cuit
            // 
            this.txt_cuit.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_cuit.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_cuit.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_cuit.BorderThickness = 3;
            this.txt_cuit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cuit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuit.ForeColor = System.Drawing.Color.White;
            this.txt_cuit.isPassword = false;
            this.txt_cuit.Location = new System.Drawing.Point(232, 123);
            this.txt_cuit.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(258, 41);
            this.txt_cuit.TabIndex = 13;
            this.txt_cuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_cuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BunifuMetroTextbox2_KeyPress);
            // 
            // txt_domicilio
            // 
            this.txt_domicilio.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_domicilio.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_domicilio.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_domicilio.BorderThickness = 3;
            this.txt_domicilio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_domicilio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_domicilio.ForeColor = System.Drawing.Color.White;
            this.txt_domicilio.isPassword = false;
            this.txt_domicilio.Location = new System.Drawing.Point(232, 170);
            this.txt_domicilio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_domicilio.Name = "txt_domicilio";
            this.txt_domicilio.Size = new System.Drawing.Size(258, 41);
            this.txt_domicilio.TabIndex = 12;
            this.txt_domicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_confirmar.Location = new System.Drawing.Point(235, 341);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(250, 45);
            this.btn_confirmar.TabIndex = 11;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(130, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Localidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(131, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Provincia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(130, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Domicilio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(173, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "CUIT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(98, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Razon Social: ";
            // 
            // Form_Empleadores_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(740, 600);
            this.Controls.Add(this.panel_empleador_agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Empleadores_Agregar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form_Empledores_Agregar";
            this.Load += new System.EventHandler(this.Form_Empleadores_Agregar_Load);
            this.panel_empleador_agregar.ResumeLayout(false);
            this.panel_empleador_agregar.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_empleador_agregar;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_razonSocial;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_cuit;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_domicilio;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.ComboBox cmb_provincias;
        private System.Windows.Forms.ComboBox cmb_localidades;
    }
}