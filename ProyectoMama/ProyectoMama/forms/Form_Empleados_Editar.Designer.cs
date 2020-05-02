namespace ProyectoMama
{
    partial class Form_Empleados_Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Empleados_Editar));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.panel_empleado_editar = new System.Windows.Forms.Panel();
            this.txt_categoria = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_legajo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_obraSocial = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_cuil = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_apellido = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_nombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label26 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.ddl_empleado = new Bunifu.Framework.UI.BunifuDropdown();
            this.label22 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.ddl_empleador = new Bunifu.Framework.UI.BunifuDropdown();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.ddl_localidad = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel12 = new System.Windows.Forms.Panel();
            this.ddl_provincia = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel_empleado_editar.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
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
            this.bunifuGradientPanel1.TabIndex = 17;
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.White;
            this.lbl_subtitulo.Location = new System.Drawing.Point(251, 6);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(230, 40);
            this.lbl_subtitulo.TabIndex = 6;
            this.lbl_subtitulo.Text = "Editar Empleado";
            // 
            // panel_empleado_editar
            // 
            this.panel_empleado_editar.Controls.Add(this.txt_categoria);
            this.panel_empleado_editar.Controls.Add(this.txt_legajo);
            this.panel_empleado_editar.Controls.Add(this.txt_obraSocial);
            this.panel_empleado_editar.Controls.Add(this.txt_cuil);
            this.panel_empleado_editar.Controls.Add(this.txt_apellido);
            this.panel_empleado_editar.Controls.Add(this.txt_nombre);
            this.panel_empleado_editar.Controls.Add(this.label26);
            this.panel_empleado_editar.Controls.Add(this.panel8);
            this.panel_empleado_editar.Controls.Add(this.label22);
            this.panel_empleado_editar.Controls.Add(this.panel9);
            this.panel_empleado_editar.Controls.Add(this.label23);
            this.panel_empleado_editar.Controls.Add(this.label24);
            this.panel_empleado_editar.Controls.Add(this.label25);
            this.panel_empleado_editar.Controls.Add(this.btn_confirmar);
            this.panel_empleado_editar.Controls.Add(this.label27);
            this.panel_empleado_editar.Controls.Add(this.label28);
            this.panel_empleado_editar.Controls.Add(this.label29);
            this.panel_empleado_editar.Controls.Add(this.label30);
            this.panel_empleado_editar.Controls.Add(this.label31);
            this.panel_empleado_editar.Controls.Add(this.panel11);
            this.panel_empleado_editar.Controls.Add(this.panel12);
            this.panel_empleado_editar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_empleado_editar.Location = new System.Drawing.Point(0, 50);
            this.panel_empleado_editar.Name = "panel_empleado_editar";
            this.panel_empleado_editar.Size = new System.Drawing.Size(740, 550);
            this.panel_empleado_editar.TabIndex = 23;
            // 
            // txt_categoria
            // 
            this.txt_categoria.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_categoria.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_categoria.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_categoria.BorderThickness = 3;
            this.txt_categoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_categoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categoria.ForeColor = System.Drawing.Color.White;
            this.txt_categoria.isPassword = false;
            this.txt_categoria.Location = new System.Drawing.Point(189, 372);
            this.txt_categoria.Margin = new System.Windows.Forms.Padding(4);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(258, 41);
            this.txt_categoria.TabIndex = 29;
            this.txt_categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_legajo
            // 
            this.txt_legajo.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_legajo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_legajo.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_legajo.BorderThickness = 3;
            this.txt_legajo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_legajo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_legajo.ForeColor = System.Drawing.Color.White;
            this.txt_legajo.isPassword = false;
            this.txt_legajo.Location = new System.Drawing.Point(189, 324);
            this.txt_legajo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.Size = new System.Drawing.Size(258, 41);
            this.txt_legajo.TabIndex = 28;
            this.txt_legajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_obraSocial
            // 
            this.txt_obraSocial.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_obraSocial.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_obraSocial.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_obraSocial.BorderThickness = 3;
            this.txt_obraSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_obraSocial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_obraSocial.ForeColor = System.Drawing.Color.White;
            this.txt_obraSocial.isPassword = false;
            this.txt_obraSocial.Location = new System.Drawing.Point(189, 275);
            this.txt_obraSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txt_obraSocial.Name = "txt_obraSocial";
            this.txt_obraSocial.Size = new System.Drawing.Size(258, 41);
            this.txt_obraSocial.TabIndex = 27;
            this.txt_obraSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_cuil
            // 
            this.txt_cuil.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_cuil.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_cuil.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_cuil.BorderThickness = 3;
            this.txt_cuil.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cuil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuil.ForeColor = System.Drawing.Color.White;
            this.txt_cuil.isPassword = false;
            this.txt_cuil.Location = new System.Drawing.Point(190, 225);
            this.txt_cuil.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cuil.Name = "txt_cuil";
            this.txt_cuil.Size = new System.Drawing.Size(258, 41);
            this.txt_cuil.TabIndex = 26;
            this.txt_cuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_cuil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_cuil_KeyPress);
            // 
            // txt_apellido
            // 
            this.txt_apellido.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_apellido.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_apellido.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_apellido.BorderThickness = 3;
            this.txt_apellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_apellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.ForeColor = System.Drawing.Color.White;
            this.txt_apellido.isPassword = false;
            this.txt_apellido.Location = new System.Drawing.Point(190, 176);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(258, 41);
            this.txt_apellido.TabIndex = 25;
            this.txt_apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_nombre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_nombre.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.txt_nombre.BorderThickness = 3;
            this.txt_nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.White;
            this.txt_nombre.isPassword = false;
            this.txt_nombre.Location = new System.Drawing.Point(190, 127);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(258, 41);
            this.txt_nombre.TabIndex = 24;
            this.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label26.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label26.Location = new System.Drawing.Point(16, 29);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(175, 25);
            this.label26.TabIndex = 23;
            this.label26.Text = "Empleado a editar:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panel8.Controls.Add(this.ddl_empleado);
            this.panel8.Location = new System.Drawing.Point(193, 19);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(253, 45);
            this.panel8.TabIndex = 22;
            // 
            // ddl_empleado
            // 
            this.ddl_empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.ddl_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ddl_empleado.BorderRadius = 0;
            this.ddl_empleado.DisabledColor = System.Drawing.SystemColors.GrayText;
            this.ddl_empleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.ddl_empleado.Items = new string[0];
            this.ddl_empleado.Location = new System.Drawing.Point(3, 3);
            this.ddl_empleado.Name = "ddl_empleado";
            this.ddl_empleado.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ddl_empleado.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ddl_empleado.selectedIndex = -1;
            this.ddl_empleado.Size = new System.Drawing.Size(248, 40);
            this.ddl_empleado.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label22.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label22.Location = new System.Drawing.Point(82, 87);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(110, 25);
            this.label22.TabIndex = 21;
            this.label22.Text = "Empleador:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panel9.Controls.Add(this.ddl_empleador);
            this.panel9.Location = new System.Drawing.Point(193, 76);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(253, 45);
            this.panel9.TabIndex = 20;
            // 
            // ddl_empleador
            // 
            this.ddl_empleador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.ddl_empleador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ddl_empleador.BorderRadius = 0;
            this.ddl_empleador.DisabledColor = System.Drawing.SystemColors.GrayText;
            this.ddl_empleador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.ddl_empleador.Items = new string[0];
            this.ddl_empleador.Location = new System.Drawing.Point(3, 3);
            this.ddl_empleador.Name = "ddl_empleador";
            this.ddl_empleador.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ddl_empleador.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ddl_empleador.selectedIndex = -1;
            this.ddl_empleador.Size = new System.Drawing.Size(248, 40);
            this.ddl_empleador.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label23.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label23.Location = new System.Drawing.Point(87, 379);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(104, 25);
            this.label23.TabIndex = 19;
            this.label23.Text = "Categoria:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label24.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label24.Location = new System.Drawing.Point(116, 334);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 25);
            this.label24.TabIndex = 18;
            this.label24.Text = "Legajo:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label25.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label25.Location = new System.Drawing.Point(73, 285);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(117, 25);
            this.label25.TabIndex = 17;
            this.label25.Text = "Obra Social:";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_confirmar.Location = new System.Drawing.Point(463, 256);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(250, 45);
            this.btn_confirmar.TabIndex = 11;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label27.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label27.Location = new System.Drawing.Point(90, 484);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(101, 25);
            this.label27.TabIndex = 10;
            this.label27.Text = "Localidad:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label28.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label28.Location = new System.Drawing.Point(93, 430);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(98, 25);
            this.label28.TabIndex = 9;
            this.label28.Text = "Provincia:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label29.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label29.Location = new System.Drawing.Point(136, 232);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(55, 25);
            this.label29.TabIndex = 8;
            this.label29.Text = "CUIL:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label30.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label30.Location = new System.Drawing.Point(105, 185);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(87, 25);
            this.label30.TabIndex = 7;
            this.label30.Text = "Apellido:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label31.Location = new System.Drawing.Point(106, 137);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(86, 25);
            this.label31.TabIndex = 6;
            this.label31.Text = "Nombre:";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panel11.Controls.Add(this.ddl_localidad);
            this.panel11.Location = new System.Drawing.Point(191, 474);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(253, 45);
            this.panel11.TabIndex = 5;
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
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panel12.Controls.Add(this.ddl_provincia);
            this.panel12.Location = new System.Drawing.Point(191, 421);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(253, 45);
            this.panel12.TabIndex = 4;
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
            // Form_Empleados_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(740, 600);
            this.Controls.Add(this.panel_empleado_editar);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Empleados_Editar";
            this.Text = "Form_Empleados_Editar";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.panel_empleado_editar.ResumeLayout(false);
            this.panel_empleado_editar.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.Panel panel_empleado_editar;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel8;
        private Bunifu.Framework.UI.BunifuDropdown ddl_empleado;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel9;
        private Bunifu.Framework.UI.BunifuDropdown ddl_empleador;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel panel11;
        private Bunifu.Framework.UI.BunifuDropdown ddl_localidad;
        private System.Windows.Forms.Panel panel12;
        private Bunifu.Framework.UI.BunifuDropdown ddl_provincia;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_categoria;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_legajo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_obraSocial;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_cuil;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_apellido;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_nombre;
    }
}