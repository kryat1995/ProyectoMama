namespace ProyectoMama
{
    partial class Form_Empleados_Agregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Empleados_Agregar));
            this.panel_empleado_agregar = new System.Windows.Forms.Panel();
            this.txt_cuil = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_apellido = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_nombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ddl_empleador = new Bunifu.Framework.UI.BunifuDropdown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.date_Fechadeinicio = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ddl_Localidad = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ddl_Provincia = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.txt_obraSocial = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_legajo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_categoria = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel_empleado_agregar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_empleado_agregar
            // 
            this.panel_empleado_agregar.Controls.Add(this.txt_categoria);
            this.panel_empleado_agregar.Controls.Add(this.txt_legajo);
            this.panel_empleado_agregar.Controls.Add(this.txt_obraSocial);
            this.panel_empleado_agregar.Controls.Add(this.txt_cuil);
            this.panel_empleado_agregar.Controls.Add(this.txt_apellido);
            this.panel_empleado_agregar.Controls.Add(this.txt_nombre);
            this.panel_empleado_agregar.Controls.Add(this.label15);
            this.panel_empleado_agregar.Controls.Add(this.panel1);
            this.panel_empleado_agregar.Controls.Add(this.label14);
            this.panel_empleado_agregar.Controls.Add(this.label13);
            this.panel_empleado_agregar.Controls.Add(this.label12);
            this.panel_empleado_agregar.Controls.Add(this.panel4);
            this.panel_empleado_agregar.Controls.Add(this.label11);
            this.panel_empleado_agregar.Controls.Add(this.btn_confirmar);
            this.panel_empleado_agregar.Controls.Add(this.label6);
            this.panel_empleado_agregar.Controls.Add(this.label7);
            this.panel_empleado_agregar.Controls.Add(this.label8);
            this.panel_empleado_agregar.Controls.Add(this.label9);
            this.panel_empleado_agregar.Controls.Add(this.label10);
            this.panel_empleado_agregar.Controls.Add(this.panel2);
            this.panel_empleado_agregar.Controls.Add(this.panel3);
            this.panel_empleado_agregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_empleado_agregar.Location = new System.Drawing.Point(0, 0);
            this.panel_empleado_agregar.Name = "panel_empleado_agregar";
            this.panel_empleado_agregar.Size = new System.Drawing.Size(740, 600);
            this.panel_empleado_agregar.TabIndex = 13;
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
            this.txt_cuil.Location = new System.Drawing.Point(191, 222);
            this.txt_cuil.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cuil.Name = "txt_cuil";
            this.txt_cuil.Size = new System.Drawing.Size(258, 41);
            this.txt_cuil.TabIndex = 24;
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
            this.txt_apellido.Location = new System.Drawing.Point(191, 174);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(258, 41);
            this.txt_apellido.TabIndex = 23;
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
            this.txt_nombre.Location = new System.Drawing.Point(191, 125);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(258, 41);
            this.txt_nombre.TabIndex = 22;
            this.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label15.Location = new System.Drawing.Point(78, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 25);
            this.label15.TabIndex = 21;
            this.label15.Text = "Empleador:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.ddl_empleador);
            this.panel1.Location = new System.Drawing.Point(194, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 45);
            this.panel1.TabIndex = 20;
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label14.Location = new System.Drawing.Point(89, 423);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 25);
            this.label14.TabIndex = 19;
            this.label14.Text = "Categoria:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label13.Location = new System.Drawing.Point(118, 378);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 25);
            this.label13.TabIndex = 18;
            this.label13.Text = "Legajo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label12.Location = new System.Drawing.Point(75, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "Obra Social:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panel4.Controls.Add(this.date_Fechadeinicio);
            this.panel4.Location = new System.Drawing.Point(193, 270);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 42);
            this.panel4.TabIndex = 6;
            // 
            // date_Fechadeinicio
            // 
            this.date_Fechadeinicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.date_Fechadeinicio.BorderRadius = 0;
            this.date_Fechadeinicio.ForeColor = System.Drawing.Color.White;
            this.date_Fechadeinicio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_Fechadeinicio.FormatCustom = null;
            this.date_Fechadeinicio.Location = new System.Drawing.Point(3, 3);
            this.date_Fechadeinicio.Name = "date_Fechadeinicio";
            this.date_Fechadeinicio.Size = new System.Drawing.Size(248, 37);
            this.date_Fechadeinicio.TabIndex = 15;
            this.date_Fechadeinicio.Value = new System.DateTime(2020, 4, 25, 22, 39, 2, 385);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(45, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Fecha de Inicio:";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_confirmar.Location = new System.Drawing.Point(469, 259);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(250, 45);
            this.btn_confirmar.TabIndex = 11;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(92, 528);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Localidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(95, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Provincia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(137, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "CUIL:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label9.Location = new System.Drawing.Point(106, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Apellido:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.label10.Location = new System.Drawing.Point(107, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Nombre:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.ddl_Localidad);
            this.panel2.Location = new System.Drawing.Point(193, 518);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 45);
            this.panel2.TabIndex = 5;
            // 
            // ddl_Localidad
            // 
            this.ddl_Localidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.ddl_Localidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ddl_Localidad.BorderRadius = 0;
            this.ddl_Localidad.DisabledColor = System.Drawing.SystemColors.GrayText;
            this.ddl_Localidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.ddl_Localidad.Items = new string[0];
            this.ddl_Localidad.Location = new System.Drawing.Point(3, 3);
            this.ddl_Localidad.Name = "ddl_Localidad";
            this.ddl_Localidad.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ddl_Localidad.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ddl_Localidad.selectedIndex = -1;
            this.ddl_Localidad.Size = new System.Drawing.Size(248, 40);
            this.ddl_Localidad.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panel3.Controls.Add(this.ddl_Provincia);
            this.panel3.Location = new System.Drawing.Point(193, 465);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 45);
            this.panel3.TabIndex = 4;
            // 
            // ddl_Provincia
            // 
            this.ddl_Provincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.ddl_Provincia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ddl_Provincia.BorderRadius = 0;
            this.ddl_Provincia.DisabledColor = System.Drawing.SystemColors.GrayText;
            this.ddl_Provincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.ddl_Provincia.Items = new string[0];
            this.ddl_Provincia.Location = new System.Drawing.Point(3, 3);
            this.ddl_Provincia.Name = "ddl_Provincia";
            this.ddl_Provincia.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ddl_Provincia.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ddl_Provincia.selectedIndex = -1;
            this.ddl_Provincia.Size = new System.Drawing.Size(248, 40);
            this.ddl_Provincia.TabIndex = 3;
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
            this.bunifuGradientPanel1.TabIndex = 16;
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.White;
            this.lbl_subtitulo.Location = new System.Drawing.Point(228, 6);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(260, 40);
            this.lbl_subtitulo.TabIndex = 6;
            this.lbl_subtitulo.Text = "Agregar Empleado";
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
            this.txt_obraSocial.Location = new System.Drawing.Point(191, 319);
            this.txt_obraSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txt_obraSocial.Name = "txt_obraSocial";
            this.txt_obraSocial.Size = new System.Drawing.Size(258, 41);
            this.txt_obraSocial.TabIndex = 25;
            this.txt_obraSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txt_legajo.Location = new System.Drawing.Point(191, 367);
            this.txt_legajo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.Size = new System.Drawing.Size(258, 41);
            this.txt_legajo.TabIndex = 26;
            this.txt_legajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txt_categoria.Location = new System.Drawing.Point(191, 415);
            this.txt_categoria.Margin = new System.Windows.Forms.Padding(4);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(258, 41);
            this.txt_categoria.TabIndex = 27;
            this.txt_categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Form_Empleados_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(740, 600);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel_empleado_agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Empleados_Agregar";
            this.Text = "Form_Empleados_Agregar";
            this.panel_empleado_agregar.ResumeLayout(false);
            this.panel_empleado_agregar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_empleado_agregar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDropdown ddl_empleador;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuDatepicker date_Fechadeinicio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDropdown ddl_Localidad;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuDropdown ddl_Provincia;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lbl_subtitulo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_cuil;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_apellido;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_nombre;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_categoria;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_legajo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_obraSocial;
    }
}