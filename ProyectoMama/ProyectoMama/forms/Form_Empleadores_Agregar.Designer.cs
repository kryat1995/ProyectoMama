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
            this.panel_empleadorPanelDdlLoc = new System.Windows.Forms.Panel();
            this.ddl_localidad = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel_empleadorDdlProv = new System.Windows.Forms.Panel();
            this.ddl_provincia = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel_empleador_agregar.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel_empleadorPanelDdlLoc.SuspendLayout();
            this.panel_empleadorDdlProv.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_empleador_agregar
            // 
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
            this.panel_empleador_agregar.Controls.Add(this.panel_empleadorPanelDdlLoc);
            this.panel_empleador_agregar.Controls.Add(this.panel_empleadorDdlProv);
            this.panel_empleador_agregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_empleador_agregar.Location = new System.Drawing.Point(0, 0);
            this.panel_empleador_agregar.Name = "panel_empleador_agregar";
            this.panel_empleador_agregar.Size = new System.Drawing.Size(740, 600);
            this.panel_empleador_agregar.TabIndex = 2;
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
            this.label5.Location = new System.Drawing.Point(131, 275);
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
            this.label4.Location = new System.Drawing.Point(130, 228);
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
            // panel_empleadorPanelDdlLoc
            // 
            this.panel_empleadorPanelDdlLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panel_empleadorPanelDdlLoc.Controls.Add(this.ddl_localidad);
            this.panel_empleadorPanelDdlLoc.Location = new System.Drawing.Point(235, 266);
            this.panel_empleadorPanelDdlLoc.Name = "panel_empleadorPanelDdlLoc";
            this.panel_empleadorPanelDdlLoc.Size = new System.Drawing.Size(253, 45);
            this.panel_empleadorPanelDdlLoc.TabIndex = 5;
            // 
            // ddl_localidad
            // 
            this.ddl_localidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.ddl_localidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ddl_localidad.BorderRadius = 0;
            this.ddl_localidad.DisabledColor = System.Drawing.SystemColors.GrayText;
            this.ddl_localidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.ddl_localidad.Items = new string[0];
            this.ddl_localidad.Location = new System.Drawing.Point(3, 3);
            this.ddl_localidad.Name = "ddl_localidad";
            this.ddl_localidad.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ddl_localidad.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ddl_localidad.selectedIndex = -1;
            this.ddl_localidad.Size = new System.Drawing.Size(248, 40);
            this.ddl_localidad.TabIndex = 3;
            // 
            // panel_empleadorDdlProv
            // 
            this.panel_empleadorDdlProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panel_empleadorDdlProv.Controls.Add(this.ddl_provincia);
            this.panel_empleadorDdlProv.Location = new System.Drawing.Point(235, 218);
            this.panel_empleadorDdlProv.Name = "panel_empleadorDdlProv";
            this.panel_empleadorDdlProv.Size = new System.Drawing.Size(253, 45);
            this.panel_empleadorDdlProv.TabIndex = 4;
            // 
            // ddl_provincia
            // 
            this.ddl_provincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.ddl_provincia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ddl_provincia.BorderRadius = 0;
            this.ddl_provincia.DisabledColor = System.Drawing.SystemColors.GrayText;
            this.ddl_provincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.ddl_provincia.Items = new string[0];
            this.ddl_provincia.Location = new System.Drawing.Point(3, 3);
            this.ddl_provincia.Name = "ddl_provincia";
            this.ddl_provincia.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ddl_provincia.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ddl_provincia.selectedIndex = -1;
            this.ddl_provincia.Size = new System.Drawing.Size(248, 40);
            this.ddl_provincia.TabIndex = 3;
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
            this.panel_empleador_agregar.ResumeLayout(false);
            this.panel_empleador_agregar.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.panel_empleadorPanelDdlLoc.ResumeLayout(false);
            this.panel_empleadorDdlProv.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel_empleadorPanelDdlLoc;
        private Bunifu.Framework.UI.BunifuDropdown ddl_localidad;
        private System.Windows.Forms.Panel panel_empleadorDdlProv;
        private Bunifu.Framework.UI.BunifuDropdown ddl_provincia;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_razonSocial;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_cuit;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_domicilio;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lbl_subtitulo;
    }
}