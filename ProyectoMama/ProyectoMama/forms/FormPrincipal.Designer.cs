namespace ProyectoMama
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.panel_menuTop = new System.Windows.Forms.Panel();
            this.minimizar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.lbl_dashboard = new System.Windows.Forms.Label();
            this.picb_dashboard = new System.Windows.Forms.PictureBox();
            this.panel_sidebarWrapper = new System.Windows.Forms.Panel();
            this.panel_sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel_menuEmpleados = new System.Windows.Forms.Panel();
            this.btn_listarEmpleados = new System.Windows.Forms.Button();
            this.btn_editarEmpleados = new System.Windows.Forms.Button();
            this.btn_agregarEmpleados = new System.Windows.Forms.Button();
            this.panel_empleados = new System.Windows.Forms.Panel();
            this.btn_Empleados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_menuEmpleadores = new System.Windows.Forms.Panel();
            this.btn_listarEmpleador = new System.Windows.Forms.Button();
            this.btn_editarEmpleador = new System.Windows.Forms.Button();
            this.btn_agregarEmpleador = new System.Windows.Forms.Button();
            this.panel_empleador = new System.Windows.Forms.Panel();
            this.btn_Empleadores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pcb_formum = new System.Windows.Forms.PictureBox();
            this.separator_sideBar1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbl_formum = new System.Windows.Forms.Label();
            this.panel_central = new System.Windows.Forms.Panel();
            this.Elipse_CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.transition_sidebarCerrar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.transition_sidebarAbrir = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.MoverVentana = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.elipse_subtitulo = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipse_empleadorPanelDdlProv = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipse_empleadorDdlProv = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipse_empleadorPanelDdlLoc = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipse_empleadorDdlLoc = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_menuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_dashboard)).BeginInit();
            this.panel_sidebarWrapper.SuspendLayout();
            this.panel_sidebar.SuspendLayout();
            this.panel_menuEmpleados.SuspendLayout();
            this.panel_empleados.SuspendLayout();
            this.panel_menuEmpleadores.SuspendLayout();
            this.panel_empleador.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_formum)).BeginInit();
            this.SuspendLayout();
            // 
            // doubleBitmapControl1
            // 
            this.transition_sidebarAbrir.SetDecoration(this.doubleBitmapControl1, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarCerrar.SetDecoration(this.doubleBitmapControl1, BunifuAnimatorNS.DecorationType.None);
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
            this.panel_menuTop.Controls.Add(this.minimizar);
            this.panel_menuTop.Controls.Add(this.salir);
            this.panel_menuTop.Controls.Add(this.lbl_dashboard);
            this.panel_menuTop.Controls.Add(this.picb_dashboard);
            this.transition_sidebarAbrir.SetDecoration(this.panel_menuTop, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarCerrar.SetDecoration(this.panel_menuTop, BunifuAnimatorNS.DecorationType.None);
            this.panel_menuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menuTop.Location = new System.Drawing.Point(0, 0);
            this.panel_menuTop.Name = "panel_menuTop";
            this.panel_menuTop.Size = new System.Drawing.Size(984, 60);
            this.panel_menuTop.TabIndex = 1;
            // 
            // minimizar
            // 
            this.transition_sidebarCerrar.SetDecoration(this.minimizar, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.minimizar, BunifuAnimatorNS.DecorationType.None);
            this.minimizar.FlatAppearance.BorderSize = 0;
            this.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(906, 12);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(30, 30);
            this.minimizar.TabIndex = 13;
            this.minimizar.UseVisualStyleBackColor = true;
            this.minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // salir
            // 
            this.transition_sidebarCerrar.SetDecoration(this.salir, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.salir, BunifuAnimatorNS.DecorationType.None);
            this.salir.FlatAppearance.BorderSize = 0;
            this.salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Location = new System.Drawing.Point(942, 12);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(30, 30);
            this.salir.TabIndex = 12;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // lbl_dashboard
            // 
            this.lbl_dashboard.AutoSize = true;
            this.transition_sidebarCerrar.SetDecoration(this.lbl_dashboard, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.lbl_dashboard, BunifuAnimatorNS.DecorationType.None);
            this.lbl_dashboard.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dashboard.ForeColor = System.Drawing.Color.White;
            this.lbl_dashboard.Location = new System.Drawing.Point(54, 14);
            this.lbl_dashboard.Name = "lbl_dashboard";
            this.lbl_dashboard.Size = new System.Drawing.Size(79, 28);
            this.lbl_dashboard.TabIndex = 1;
            this.lbl_dashboard.Text = "M E N U ";
            // 
            // picb_dashboard
            // 
            this.transition_sidebarCerrar.SetDecoration(this.picb_dashboard, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.picb_dashboard, BunifuAnimatorNS.DecorationType.None);
            this.picb_dashboard.Image = ((System.Drawing.Image)(resources.GetObject("picb_dashboard.Image")));
            this.picb_dashboard.Location = new System.Drawing.Point(18, 12);
            this.picb_dashboard.Name = "picb_dashboard";
            this.picb_dashboard.Size = new System.Drawing.Size(30, 30);
            this.picb_dashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_dashboard.TabIndex = 0;
            this.picb_dashboard.TabStop = false;
            this.picb_dashboard.Click += new System.EventHandler(this.Picb_dashboard_Click);
            // 
            // panel_sidebarWrapper
            // 
            this.panel_sidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel_sidebarWrapper.Controls.Add(this.panel_sidebar);
            this.transition_sidebarAbrir.SetDecoration(this.panel_sidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarCerrar.SetDecoration(this.panel_sidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.panel_sidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sidebarWrapper.Location = new System.Drawing.Point(0, 60);
            this.panel_sidebarWrapper.Name = "panel_sidebarWrapper";
            this.panel_sidebarWrapper.Size = new System.Drawing.Size(244, 601);
            this.panel_sidebarWrapper.TabIndex = 2;
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_sidebar.BackgroundImage")));
            this.panel_sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_sidebar.Controls.Add(this.panel_menuEmpleados);
            this.panel_sidebar.Controls.Add(this.panel_empleados);
            this.panel_sidebar.Controls.Add(this.panel_menuEmpleadores);
            this.panel_sidebar.Controls.Add(this.panel_empleador);
            this.panel_sidebar.Controls.Add(this.panel_logo);
            this.transition_sidebarAbrir.SetDecoration(this.panel_sidebar, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarCerrar.SetDecoration(this.panel_sidebar, BunifuAnimatorNS.DecorationType.None);
            this.panel_sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panel_sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panel_sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panel_sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel_sidebar.Location = new System.Drawing.Point(12, 0);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.Quality = 10;
            this.panel_sidebar.Size = new System.Drawing.Size(220, 589);
            this.panel_sidebar.TabIndex = 0;
            // 
            // panel_menuEmpleados
            // 
            this.panel_menuEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.panel_menuEmpleados.Controls.Add(this.btn_listarEmpleados);
            this.panel_menuEmpleados.Controls.Add(this.btn_editarEmpleados);
            this.panel_menuEmpleados.Controls.Add(this.btn_agregarEmpleados);
            this.transition_sidebarAbrir.SetDecoration(this.panel_menuEmpleados, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarCerrar.SetDecoration(this.panel_menuEmpleados, BunifuAnimatorNS.DecorationType.None);
            this.panel_menuEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menuEmpleados.Location = new System.Drawing.Point(0, 321);
            this.panel_menuEmpleados.Name = "panel_menuEmpleados";
            this.panel_menuEmpleados.Size = new System.Drawing.Size(220, 150);
            this.panel_menuEmpleados.TabIndex = 1;
            // 
            // btn_listarEmpleados
            // 
            this.transition_sidebarCerrar.SetDecoration(this.btn_listarEmpleados, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.btn_listarEmpleados, BunifuAnimatorNS.DecorationType.None);
            this.btn_listarEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_listarEmpleados.FlatAppearance.BorderSize = 0;
            this.btn_listarEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn_listarEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btn_listarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listarEmpleados.Font = new System.Drawing.Font("Poppins", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listarEmpleados.ForeColor = System.Drawing.Color.White;
            this.btn_listarEmpleados.Location = new System.Drawing.Point(0, 90);
            this.btn_listarEmpleados.Name = "btn_listarEmpleados";
            this.btn_listarEmpleados.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btn_listarEmpleados.Size = new System.Drawing.Size(220, 45);
            this.btn_listarEmpleados.TabIndex = 14;
            this.btn_listarEmpleados.Text = "LISTAR";
            this.btn_listarEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_listarEmpleados.UseVisualStyleBackColor = true;
            this.btn_listarEmpleados.Click += new System.EventHandler(this.Btn_listarEmpleados_Click);
            // 
            // btn_editarEmpleados
            // 
            this.btn_editarEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.transition_sidebarCerrar.SetDecoration(this.btn_editarEmpleados, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.btn_editarEmpleados, BunifuAnimatorNS.DecorationType.None);
            this.btn_editarEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_editarEmpleados.FlatAppearance.BorderSize = 0;
            this.btn_editarEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn_editarEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btn_editarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editarEmpleados.Font = new System.Drawing.Font("Poppins", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarEmpleados.ForeColor = System.Drawing.Color.White;
            this.btn_editarEmpleados.Location = new System.Drawing.Point(0, 45);
            this.btn_editarEmpleados.Name = "btn_editarEmpleados";
            this.btn_editarEmpleados.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btn_editarEmpleados.Size = new System.Drawing.Size(220, 45);
            this.btn_editarEmpleados.TabIndex = 12;
            this.btn_editarEmpleados.Text = "EDITAR";
            this.btn_editarEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editarEmpleados.UseVisualStyleBackColor = false;
            this.btn_editarEmpleados.Click += new System.EventHandler(this.Btn_editarEmpleados_Click);
            // 
            // btn_agregarEmpleados
            // 
            this.transition_sidebarCerrar.SetDecoration(this.btn_agregarEmpleados, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.btn_agregarEmpleados, BunifuAnimatorNS.DecorationType.None);
            this.btn_agregarEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_agregarEmpleados.FlatAppearance.BorderSize = 0;
            this.btn_agregarEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn_agregarEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btn_agregarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarEmpleados.Font = new System.Drawing.Font("Poppins", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarEmpleados.ForeColor = System.Drawing.Color.White;
            this.btn_agregarEmpleados.Location = new System.Drawing.Point(0, 0);
            this.btn_agregarEmpleados.Name = "btn_agregarEmpleados";
            this.btn_agregarEmpleados.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btn_agregarEmpleados.Size = new System.Drawing.Size(220, 45);
            this.btn_agregarEmpleados.TabIndex = 13;
            this.btn_agregarEmpleados.Text = "AGREGAR";
            this.btn_agregarEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregarEmpleados.UseVisualStyleBackColor = true;
            this.btn_agregarEmpleados.Click += new System.EventHandler(this.Btn_agregarEmpleados_Click);
            // 
            // panel_empleados
            // 
            this.panel_empleados.BackColor = System.Drawing.Color.Transparent;
            this.panel_empleados.Controls.Add(this.btn_Empleados);
            this.transition_sidebarAbrir.SetDecoration(this.panel_empleados, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarCerrar.SetDecoration(this.panel_empleados, BunifuAnimatorNS.DecorationType.None);
            this.panel_empleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_empleados.Location = new System.Drawing.Point(0, 268);
            this.panel_empleados.Name = "panel_empleados";
            this.panel_empleados.Size = new System.Drawing.Size(220, 53);
            this.panel_empleados.TabIndex = 1;
            // 
            // btn_Empleados
            // 
            this.btn_Empleados.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Empleados.BackColor = System.Drawing.Color.Transparent;
            this.btn_Empleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Empleados.BorderRadius = 0;
            this.btn_Empleados.ButtonText = "      Empleados";
            this.btn_Empleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_sidebarCerrar.SetDecoration(this.btn_Empleados, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.btn_Empleados, BunifuAnimatorNS.DecorationType.None);
            this.btn_Empleados.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Empleados.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Empleados.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Empleados.Iconimage")));
            this.btn_Empleados.Iconimage_right = null;
            this.btn_Empleados.Iconimage_right_Selected = null;
            this.btn_Empleados.Iconimage_Selected = null;
            this.btn_Empleados.IconMarginLeft = 0;
            this.btn_Empleados.IconMarginRight = 0;
            this.btn_Empleados.IconRightVisible = true;
            this.btn_Empleados.IconRightZoom = 0D;
            this.btn_Empleados.IconVisible = true;
            this.btn_Empleados.IconZoom = 70D;
            this.btn_Empleados.IsTab = false;
            this.btn_Empleados.Location = new System.Drawing.Point(6, 1);
            this.btn_Empleados.Name = "btn_Empleados";
            this.btn_Empleados.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Empleados.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Empleados.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Empleados.selected = false;
            this.btn_Empleados.Size = new System.Drawing.Size(206, 48);
            this.btn_Empleados.TabIndex = 15;
            this.btn_Empleados.Text = "      Empleados";
            this.btn_Empleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Empleados.Textcolor = System.Drawing.Color.White;
            this.btn_Empleados.TextFont = new System.Drawing.Font("Poppins", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Empleados.Click += new System.EventHandler(this.Btn_Empleados_Click);
            // 
            // panel_menuEmpleadores
            // 
            this.panel_menuEmpleadores.BackColor = System.Drawing.Color.Transparent;
            this.panel_menuEmpleadores.Controls.Add(this.btn_listarEmpleador);
            this.panel_menuEmpleadores.Controls.Add(this.btn_editarEmpleador);
            this.panel_menuEmpleadores.Controls.Add(this.btn_agregarEmpleador);
            this.transition_sidebarAbrir.SetDecoration(this.panel_menuEmpleadores, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarCerrar.SetDecoration(this.panel_menuEmpleadores, BunifuAnimatorNS.DecorationType.None);
            this.panel_menuEmpleadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menuEmpleadores.Location = new System.Drawing.Point(0, 118);
            this.panel_menuEmpleadores.Name = "panel_menuEmpleadores";
            this.panel_menuEmpleadores.Size = new System.Drawing.Size(220, 150);
            this.panel_menuEmpleadores.TabIndex = 1;
            // 
            // btn_listarEmpleador
            // 
            this.transition_sidebarCerrar.SetDecoration(this.btn_listarEmpleador, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.btn_listarEmpleador, BunifuAnimatorNS.DecorationType.None);
            this.btn_listarEmpleador.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_listarEmpleador.FlatAppearance.BorderSize = 0;
            this.btn_listarEmpleador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn_listarEmpleador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btn_listarEmpleador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listarEmpleador.Font = new System.Drawing.Font("Poppins", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listarEmpleador.ForeColor = System.Drawing.Color.White;
            this.btn_listarEmpleador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_listarEmpleador.ImageKey = "(ninguno)";
            this.btn_listarEmpleador.Location = new System.Drawing.Point(0, 90);
            this.btn_listarEmpleador.Name = "btn_listarEmpleador";
            this.btn_listarEmpleador.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btn_listarEmpleador.Size = new System.Drawing.Size(220, 45);
            this.btn_listarEmpleador.TabIndex = 14;
            this.btn_listarEmpleador.Text = "LISTAR";
            this.btn_listarEmpleador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_listarEmpleador.UseVisualStyleBackColor = true;
            this.btn_listarEmpleador.Click += new System.EventHandler(this.Btn_listarEmpleador_Click);
            // 
            // btn_editarEmpleador
            // 
            this.btn_editarEmpleador.BackColor = System.Drawing.Color.Transparent;
            this.transition_sidebarCerrar.SetDecoration(this.btn_editarEmpleador, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.btn_editarEmpleador, BunifuAnimatorNS.DecorationType.None);
            this.btn_editarEmpleador.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_editarEmpleador.FlatAppearance.BorderSize = 0;
            this.btn_editarEmpleador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn_editarEmpleador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btn_editarEmpleador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editarEmpleador.Font = new System.Drawing.Font("Poppins", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarEmpleador.ForeColor = System.Drawing.Color.White;
            this.btn_editarEmpleador.Location = new System.Drawing.Point(0, 45);
            this.btn_editarEmpleador.Name = "btn_editarEmpleador";
            this.btn_editarEmpleador.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btn_editarEmpleador.Size = new System.Drawing.Size(220, 45);
            this.btn_editarEmpleador.TabIndex = 12;
            this.btn_editarEmpleador.Text = "EDITAR";
            this.btn_editarEmpleador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editarEmpleador.UseVisualStyleBackColor = false;
            this.btn_editarEmpleador.Click += new System.EventHandler(this.Btn_editarEmpleador_Click);
            // 
            // btn_agregarEmpleador
            // 
            this.transition_sidebarCerrar.SetDecoration(this.btn_agregarEmpleador, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.btn_agregarEmpleador, BunifuAnimatorNS.DecorationType.None);
            this.btn_agregarEmpleador.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_agregarEmpleador.FlatAppearance.BorderSize = 0;
            this.btn_agregarEmpleador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btn_agregarEmpleador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btn_agregarEmpleador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarEmpleador.Font = new System.Drawing.Font("Poppins", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarEmpleador.ForeColor = System.Drawing.Color.White;
            this.btn_agregarEmpleador.Location = new System.Drawing.Point(0, 0);
            this.btn_agregarEmpleador.Name = "btn_agregarEmpleador";
            this.btn_agregarEmpleador.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btn_agregarEmpleador.Size = new System.Drawing.Size(220, 45);
            this.btn_agregarEmpleador.TabIndex = 13;
            this.btn_agregarEmpleador.Text = "AGREGAR";
            this.btn_agregarEmpleador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregarEmpleador.UseVisualStyleBackColor = true;
            this.btn_agregarEmpleador.Click += new System.EventHandler(this.Btn_agregarEmpleador_Click);
            // 
            // panel_empleador
            // 
            this.panel_empleador.BackColor = System.Drawing.Color.Transparent;
            this.panel_empleador.Controls.Add(this.btn_Empleadores);
            this.transition_sidebarAbrir.SetDecoration(this.panel_empleador, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarCerrar.SetDecoration(this.panel_empleador, BunifuAnimatorNS.DecorationType.None);
            this.panel_empleador.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_empleador.Location = new System.Drawing.Point(0, 65);
            this.panel_empleador.Name = "panel_empleador";
            this.panel_empleador.Size = new System.Drawing.Size(220, 53);
            this.panel_empleador.TabIndex = 1;
            // 
            // btn_Empleadores
            // 
            this.btn_Empleadores.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Empleadores.BackColor = System.Drawing.Color.Transparent;
            this.btn_Empleadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Empleadores.BorderRadius = 0;
            this.btn_Empleadores.ButtonText = "      Empleadores";
            this.btn_Empleadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_sidebarCerrar.SetDecoration(this.btn_Empleadores, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.btn_Empleadores, BunifuAnimatorNS.DecorationType.None);
            this.btn_Empleadores.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Empleadores.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Empleadores.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Empleadores.Iconimage")));
            this.btn_Empleadores.Iconimage_right = null;
            this.btn_Empleadores.Iconimage_right_Selected = null;
            this.btn_Empleadores.Iconimage_Selected = null;
            this.btn_Empleadores.IconMarginLeft = 0;
            this.btn_Empleadores.IconMarginRight = 0;
            this.btn_Empleadores.IconRightVisible = true;
            this.btn_Empleadores.IconRightZoom = 0D;
            this.btn_Empleadores.IconVisible = true;
            this.btn_Empleadores.IconZoom = 70D;
            this.btn_Empleadores.IsTab = false;
            this.btn_Empleadores.Location = new System.Drawing.Point(6, 3);
            this.btn_Empleadores.Name = "btn_Empleadores";
            this.btn_Empleadores.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Empleadores.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Empleadores.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Empleadores.selected = false;
            this.btn_Empleadores.Size = new System.Drawing.Size(206, 48);
            this.btn_Empleadores.TabIndex = 15;
            this.btn_Empleadores.Text = "      Empleadores";
            this.btn_Empleadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Empleadores.Textcolor = System.Drawing.Color.White;
            this.btn_Empleadores.TextFont = new System.Drawing.Font("Poppins", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Empleadores.Click += new System.EventHandler(this.Btn_Empleadores_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.Transparent;
            this.panel_logo.Controls.Add(this.pcb_formum);
            this.panel_logo.Controls.Add(this.separator_sideBar1);
            this.panel_logo.Controls.Add(this.lbl_formum);
            this.transition_sidebarAbrir.SetDecoration(this.panel_logo, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarCerrar.SetDecoration(this.panel_logo, BunifuAnimatorNS.DecorationType.None);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(220, 65);
            this.panel_logo.TabIndex = 0;
            // 
            // pcb_formum
            // 
            this.pcb_formum.BackColor = System.Drawing.Color.Transparent;
            this.transition_sidebarCerrar.SetDecoration(this.pcb_formum, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.pcb_formum, BunifuAnimatorNS.DecorationType.None);
            this.pcb_formum.Image = ((System.Drawing.Image)(resources.GetObject("pcb_formum.Image")));
            this.pcb_formum.Location = new System.Drawing.Point(14, 19);
            this.pcb_formum.Name = "pcb_formum";
            this.pcb_formum.Size = new System.Drawing.Size(30, 30);
            this.pcb_formum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_formum.TabIndex = 6;
            this.pcb_formum.TabStop = false;
            // 
            // separator_sideBar1
            // 
            this.separator_sideBar1.BackColor = System.Drawing.Color.Transparent;
            this.transition_sidebarAbrir.SetDecoration(this.separator_sideBar1, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarCerrar.SetDecoration(this.separator_sideBar1, BunifuAnimatorNS.DecorationType.None);
            this.separator_sideBar1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.separator_sideBar1.LineThickness = 1;
            this.separator_sideBar1.Location = new System.Drawing.Point(6, 61);
            this.separator_sideBar1.Name = "separator_sideBar1";
            this.separator_sideBar1.Size = new System.Drawing.Size(206, 1);
            this.separator_sideBar1.TabIndex = 7;
            this.separator_sideBar1.Transparency = 255;
            this.separator_sideBar1.Vertical = false;
            // 
            // lbl_formum
            // 
            this.lbl_formum.AutoSize = true;
            this.lbl_formum.BackColor = System.Drawing.Color.Transparent;
            this.transition_sidebarCerrar.SetDecoration(this.lbl_formum, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.lbl_formum, BunifuAnimatorNS.DecorationType.None);
            this.lbl_formum.Font = new System.Drawing.Font("Poppins Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formum.ForeColor = System.Drawing.Color.White;
            this.lbl_formum.Location = new System.Drawing.Point(66, 21);
            this.lbl_formum.Name = "lbl_formum";
            this.lbl_formum.Size = new System.Drawing.Size(93, 28);
            this.lbl_formum.TabIndex = 6;
            this.lbl_formum.Text = "FORMUM";
            // 
            // panel_central
            // 
            this.panel_central.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.transition_sidebarAbrir.SetDecoration(this.panel_central, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarCerrar.SetDecoration(this.panel_central, BunifuAnimatorNS.DecorationType.None);
            this.panel_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_central.Location = new System.Drawing.Point(244, 60);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(740, 601);
            this.panel_central.TabIndex = 3;
            // 
            // Elipse_CurvaSidebar
            // 
            this.Elipse_CurvaSidebar.ElipseRadius = 7;
            this.Elipse_CurvaSidebar.TargetControl = this.panel_sidebar;
            // 
            // transition_sidebarCerrar
            // 
            this.transition_sidebarCerrar.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.transition_sidebarCerrar.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.transition_sidebarCerrar.DefaultAnimation = animation3;
            this.transition_sidebarCerrar.Interval = 15;
            // 
            // transition_sidebarAbrir
            // 
            this.transition_sidebarAbrir.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.transition_sidebarAbrir.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.transition_sidebarAbrir.DefaultAnimation = animation4;
            this.transition_sidebarAbrir.Interval = 15;
            // 
            // MoverVentana
            // 
            this.MoverVentana.Fixed = true;
            this.MoverVentana.Horizontal = true;
            this.MoverVentana.TargetControl = this.panel_menuTop;
            this.MoverVentana.Vertical = true;
            // 
            // elipse_subtitulo
            // 
            this.elipse_subtitulo.ElipseRadius = 7;
            this.elipse_subtitulo.TargetControl = this;
            // 
            // elipse_empleadorPanelDdlProv
            // 
            this.elipse_empleadorPanelDdlProv.ElipseRadius = 10;
            this.elipse_empleadorPanelDdlProv.TargetControl = this;
            // 
            // elipse_empleadorDdlProv
            // 
            this.elipse_empleadorDdlProv.ElipseRadius = 10;
            this.elipse_empleadorDdlProv.TargetControl = this;
            // 
            // elipse_empleadorPanelDdlLoc
            // 
            this.elipse_empleadorPanelDdlLoc.ElipseRadius = 7;
            this.elipse_empleadorPanelDdlLoc.TargetControl = this;
            // 
            // elipse_empleadorDdlLoc
            // 
            this.elipse_empleadorDdlLoc.ElipseRadius = 7;
            this.elipse_empleadorDdlLoc.TargetControl = this;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.panel_sidebarWrapper);
            this.Controls.Add(this.panel_menuTop);
            this.Controls.Add(this.doubleBitmapControl1);
            this.transition_sidebarAbrir.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarCerrar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_menuTop.ResumeLayout(false);
            this.panel_menuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_dashboard)).EndInit();
            this.panel_sidebarWrapper.ResumeLayout(false);
            this.panel_sidebar.ResumeLayout(false);
            this.panel_menuEmpleados.ResumeLayout(false);
            this.panel_empleados.ResumeLayout(false);
            this.panel_menuEmpleadores.ResumeLayout(false);
            this.panel_empleador.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_formum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        private System.Windows.Forms.Panel panel_menuTop;
        private System.Windows.Forms.Panel panel_sidebarWrapper;
        private System.Windows.Forms.Panel panel_central;
        private System.Windows.Forms.PictureBox picb_dashboard;
        private System.Windows.Forms.Label lbl_dashboard;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_sidebar;
        private Bunifu.Framework.UI.BunifuElipse Elipse_CurvaSidebar;
        private BunifuAnimatorNS.BunifuTransition transition_sidebarAbrir;
        private BunifuAnimatorNS.BunifuTransition transition_sidebarCerrar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Empleadores;
        private System.Windows.Forms.Button btn_listarEmpleador;
        private System.Windows.Forms.Button btn_agregarEmpleador;
        private System.Windows.Forms.Button btn_editarEmpleador;
        private System.Windows.Forms.Button btn_listarEmpleados;
        private System.Windows.Forms.Button btn_agregarEmpleados;
        private System.Windows.Forms.Button btn_editarEmpleados;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Empleados;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button minimizar;
        private System.Windows.Forms.PictureBox pcb_formum;
        private Bunifu.Framework.UI.BunifuSeparator separator_sideBar1;
        private System.Windows.Forms.Label lbl_formum;
        private System.Windows.Forms.Panel panel_menuEmpleados;
        private System.Windows.Forms.Panel panel_empleados;
        private System.Windows.Forms.Panel panel_menuEmpleadores;
        private System.Windows.Forms.Panel panel_empleador;
        private System.Windows.Forms.Panel panel_logo;
        private Bunifu.Framework.UI.BunifuDragControl MoverVentana;
        private Bunifu.Framework.UI.BunifuElipse elipse_subtitulo;
        private Bunifu.Framework.UI.BunifuElipse elipse_empleadorPanelDdlProv;
        private Bunifu.Framework.UI.BunifuElipse elipse_empleadorDdlProv;
        private Bunifu.Framework.UI.BunifuElipse elipse_empleadorPanelDdlLoc;
        private Bunifu.Framework.UI.BunifuElipse elipse_empleadorDdlLoc;
    }
}

