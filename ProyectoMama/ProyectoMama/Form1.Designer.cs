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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.panel_menuTop = new System.Windows.Forms.Panel();
            this.picb_restaurar = new System.Windows.Forms.PictureBox();
            this.picb_minimizar = new System.Windows.Forms.PictureBox();
            this.picb_maximizar = new System.Windows.Forms.PictureBox();
            this.picb__salir = new System.Windows.Forms.PictureBox();
            this.lbl_dashboard = new System.Windows.Forms.Label();
            this.picb_dashboard = new System.Windows.Forms.PictureBox();
            this.panel_sidebarWrapper = new System.Windows.Forms.Panel();
            this.panel_sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_agregarEmpleado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.separator_sidebar2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btn_verEmpleadores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_editarEmpleador = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_agregarEmpleador = new Bunifu.Framework.UI.BunifuFlatButton();
            this.separator_sideBar1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbl_formum = new System.Windows.Forms.Label();
            this.pcb_formum = new System.Windows.Forms.PictureBox();
            this.panel_central = new System.Windows.Forms.Panel();
            this.Elipse_CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.transition_sidebarCerrar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.transition_sidebarAbrir = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel_menuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb__salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_dashboard)).BeginInit();
            this.panel_sidebarWrapper.SuspendLayout();
            this.panel_sidebar.SuspendLayout();
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
            this.panel_menuTop.Controls.Add(this.picb_restaurar);
            this.panel_menuTop.Controls.Add(this.picb_minimizar);
            this.panel_menuTop.Controls.Add(this.picb_maximizar);
            this.panel_menuTop.Controls.Add(this.picb__salir);
            this.panel_menuTop.Controls.Add(this.lbl_dashboard);
            this.panel_menuTop.Controls.Add(this.picb_dashboard);
            this.transition_sidebarAbrir.SetDecoration(this.panel_menuTop, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarCerrar.SetDecoration(this.panel_menuTop, BunifuAnimatorNS.DecorationType.None);
            this.panel_menuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menuTop.Location = new System.Drawing.Point(0, 0);
            this.panel_menuTop.Name = "panel_menuTop";
            this.panel_menuTop.Size = new System.Drawing.Size(984, 80);
            this.panel_menuTop.TabIndex = 1;
            // 
            // picb_restaurar
            // 
            this.picb_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transition_sidebarCerrar.SetDecoration(this.picb_restaurar, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.picb_restaurar, BunifuAnimatorNS.DecorationType.None);
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
            this.transition_sidebarCerrar.SetDecoration(this.picb_minimizar, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.picb_minimizar, BunifuAnimatorNS.DecorationType.None);
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
            this.transition_sidebarCerrar.SetDecoration(this.picb_maximizar, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.picb_maximizar, BunifuAnimatorNS.DecorationType.None);
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
            this.transition_sidebarCerrar.SetDecoration(this.picb__salir, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.picb__salir, BunifuAnimatorNS.DecorationType.None);
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
            this.transition_sidebarCerrar.SetDecoration(this.lbl_dashboard, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.lbl_dashboard, BunifuAnimatorNS.DecorationType.None);
            this.lbl_dashboard.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dashboard.ForeColor = System.Drawing.Color.White;
            this.lbl_dashboard.Location = new System.Drawing.Point(59, 27);
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
            this.picb_dashboard.Location = new System.Drawing.Point(23, 25);
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
            this.panel_sidebarWrapper.Location = new System.Drawing.Point(0, 80);
            this.panel_sidebarWrapper.Name = "panel_sidebarWrapper";
            this.panel_sidebarWrapper.Size = new System.Drawing.Size(250, 581);
            this.panel_sidebarWrapper.TabIndex = 2;
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_sidebar.BackgroundImage")));
            this.panel_sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_sidebar.Controls.Add(this.bunifuFlatButton2);
            this.panel_sidebar.Controls.Add(this.bunifuFlatButton1);
            this.panel_sidebar.Controls.Add(this.btn_agregarEmpleado);
            this.panel_sidebar.Controls.Add(this.separator_sidebar2);
            this.panel_sidebar.Controls.Add(this.btn_verEmpleadores);
            this.panel_sidebar.Controls.Add(this.btn_editarEmpleador);
            this.panel_sidebar.Controls.Add(this.btn_agregarEmpleador);
            this.panel_sidebar.Controls.Add(this.separator_sideBar1);
            this.panel_sidebar.Controls.Add(this.lbl_formum);
            this.panel_sidebar.Controls.Add(this.pcb_formum);
            this.transition_sidebarAbrir.SetDecoration(this.panel_sidebar, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarCerrar.SetDecoration(this.panel_sidebar, BunifuAnimatorNS.DecorationType.None);
            this.panel_sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panel_sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panel_sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panel_sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel_sidebar.Location = new System.Drawing.Point(12, 15);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.Quality = 10;
            this.panel_sidebar.Size = new System.Drawing.Size(220, 554);
            this.panel_sidebar.TabIndex = 0;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "      Ver Empleados";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_sidebarCerrar.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 70D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(10, 343);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(206, 48);
            this.bunifuFlatButton2.TabIndex = 14;
            this.bunifuFlatButton2.Text = "      Ver Empleados";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Poppins", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "      Editar Empleado";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_sidebarCerrar.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(10, 289);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(206, 48);
            this.bunifuFlatButton1.TabIndex = 13;
            this.bunifuFlatButton1.Text = "      Editar Empleado";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Poppins", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_agregarEmpleado
            // 
            this.btn_agregarEmpleado.Activecolor = System.Drawing.Color.Transparent;
            this.btn_agregarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregarEmpleado.BorderRadius = 0;
            this.btn_agregarEmpleado.ButtonText = "      Agregar Empleado";
            this.btn_agregarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_sidebarCerrar.SetDecoration(this.btn_agregarEmpleado, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.btn_agregarEmpleado, BunifuAnimatorNS.DecorationType.None);
            this.btn_agregarEmpleado.DisabledColor = System.Drawing.Color.Gray;
            this.btn_agregarEmpleado.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_agregarEmpleado.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_agregarEmpleado.Iconimage")));
            this.btn_agregarEmpleado.Iconimage_right = null;
            this.btn_agregarEmpleado.Iconimage_right_Selected = null;
            this.btn_agregarEmpleado.Iconimage_Selected = null;
            this.btn_agregarEmpleado.IconMarginLeft = 0;
            this.btn_agregarEmpleado.IconMarginRight = 0;
            this.btn_agregarEmpleado.IconRightVisible = true;
            this.btn_agregarEmpleado.IconRightZoom = 0D;
            this.btn_agregarEmpleado.IconVisible = true;
            this.btn_agregarEmpleado.IconZoom = 70D;
            this.btn_agregarEmpleado.IsTab = false;
            this.btn_agregarEmpleado.Location = new System.Drawing.Point(10, 235);
            this.btn_agregarEmpleado.Name = "btn_agregarEmpleado";
            this.btn_agregarEmpleado.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_agregarEmpleado.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_agregarEmpleado.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_agregarEmpleado.selected = false;
            this.btn_agregarEmpleado.Size = new System.Drawing.Size(206, 48);
            this.btn_agregarEmpleado.TabIndex = 12;
            this.btn_agregarEmpleado.Text = "      Agregar Empleado";
            this.btn_agregarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregarEmpleado.Textcolor = System.Drawing.Color.White;
            this.btn_agregarEmpleado.TextFont = new System.Drawing.Font("Poppins", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // separator_sidebar2
            // 
            this.separator_sidebar2.BackColor = System.Drawing.Color.Transparent;
            this.transition_sidebarAbrir.SetDecoration(this.separator_sidebar2, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarCerrar.SetDecoration(this.separator_sidebar2, BunifuAnimatorNS.DecorationType.None);
            this.separator_sidebar2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.separator_sidebar2.LineThickness = 1;
            this.separator_sidebar2.Location = new System.Drawing.Point(7, 228);
            this.separator_sidebar2.Name = "separator_sidebar2";
            this.separator_sidebar2.Size = new System.Drawing.Size(206, 1);
            this.separator_sidebar2.TabIndex = 11;
            this.separator_sidebar2.Transparency = 255;
            this.separator_sidebar2.Vertical = false;
            // 
            // btn_verEmpleadores
            // 
            this.btn_verEmpleadores.Activecolor = System.Drawing.Color.Transparent;
            this.btn_verEmpleadores.BackColor = System.Drawing.Color.Transparent;
            this.btn_verEmpleadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_verEmpleadores.BorderRadius = 0;
            this.btn_verEmpleadores.ButtonText = "      Ver Empleadores";
            this.btn_verEmpleadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_sidebarCerrar.SetDecoration(this.btn_verEmpleadores, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.btn_verEmpleadores, BunifuAnimatorNS.DecorationType.None);
            this.btn_verEmpleadores.DisabledColor = System.Drawing.Color.Gray;
            this.btn_verEmpleadores.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_verEmpleadores.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_verEmpleadores.Iconimage")));
            this.btn_verEmpleadores.Iconimage_right = null;
            this.btn_verEmpleadores.Iconimage_right_Selected = null;
            this.btn_verEmpleadores.Iconimage_Selected = null;
            this.btn_verEmpleadores.IconMarginLeft = 0;
            this.btn_verEmpleadores.IconMarginRight = 0;
            this.btn_verEmpleadores.IconRightVisible = true;
            this.btn_verEmpleadores.IconRightZoom = 0D;
            this.btn_verEmpleadores.IconVisible = true;
            this.btn_verEmpleadores.IconZoom = 70D;
            this.btn_verEmpleadores.IsTab = false;
            this.btn_verEmpleadores.Location = new System.Drawing.Point(9, 170);
            this.btn_verEmpleadores.Name = "btn_verEmpleadores";
            this.btn_verEmpleadores.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_verEmpleadores.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_verEmpleadores.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_verEmpleadores.selected = false;
            this.btn_verEmpleadores.Size = new System.Drawing.Size(206, 48);
            this.btn_verEmpleadores.TabIndex = 10;
            this.btn_verEmpleadores.Text = "      Ver Empleadores";
            this.btn_verEmpleadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_verEmpleadores.Textcolor = System.Drawing.Color.White;
            this.btn_verEmpleadores.TextFont = new System.Drawing.Font("Poppins", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_editarEmpleador
            // 
            this.btn_editarEmpleador.Activecolor = System.Drawing.Color.Transparent;
            this.btn_editarEmpleador.BackColor = System.Drawing.Color.Transparent;
            this.btn_editarEmpleador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editarEmpleador.BorderRadius = 0;
            this.btn_editarEmpleador.ButtonText = "      Editar Empleador";
            this.btn_editarEmpleador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_sidebarCerrar.SetDecoration(this.btn_editarEmpleador, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.btn_editarEmpleador, BunifuAnimatorNS.DecorationType.None);
            this.btn_editarEmpleador.DisabledColor = System.Drawing.Color.Gray;
            this.btn_editarEmpleador.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_editarEmpleador.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_editarEmpleador.Iconimage")));
            this.btn_editarEmpleador.Iconimage_right = null;
            this.btn_editarEmpleador.Iconimage_right_Selected = null;
            this.btn_editarEmpleador.Iconimage_Selected = null;
            this.btn_editarEmpleador.IconMarginLeft = 0;
            this.btn_editarEmpleador.IconMarginRight = 0;
            this.btn_editarEmpleador.IconRightVisible = true;
            this.btn_editarEmpleador.IconRightZoom = 0D;
            this.btn_editarEmpleador.IconVisible = true;
            this.btn_editarEmpleador.IconZoom = 70D;
            this.btn_editarEmpleador.IsTab = false;
            this.btn_editarEmpleador.Location = new System.Drawing.Point(9, 116);
            this.btn_editarEmpleador.Name = "btn_editarEmpleador";
            this.btn_editarEmpleador.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_editarEmpleador.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_editarEmpleador.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_editarEmpleador.selected = false;
            this.btn_editarEmpleador.Size = new System.Drawing.Size(206, 48);
            this.btn_editarEmpleador.TabIndex = 9;
            this.btn_editarEmpleador.Text = "      Editar Empleador";
            this.btn_editarEmpleador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editarEmpleador.Textcolor = System.Drawing.Color.White;
            this.btn_editarEmpleador.TextFont = new System.Drawing.Font("Poppins", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_agregarEmpleador
            // 
            this.btn_agregarEmpleador.Activecolor = System.Drawing.Color.Transparent;
            this.btn_agregarEmpleador.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregarEmpleador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregarEmpleador.BorderRadius = 0;
            this.btn_agregarEmpleador.ButtonText = "      Agregar Empleador";
            this.btn_agregarEmpleador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition_sidebarCerrar.SetDecoration(this.btn_agregarEmpleador, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.btn_agregarEmpleador, BunifuAnimatorNS.DecorationType.None);
            this.btn_agregarEmpleador.DisabledColor = System.Drawing.Color.Gray;
            this.btn_agregarEmpleador.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_agregarEmpleador.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_agregarEmpleador.Iconimage")));
            this.btn_agregarEmpleador.Iconimage_right = null;
            this.btn_agregarEmpleador.Iconimage_right_Selected = null;
            this.btn_agregarEmpleador.Iconimage_Selected = null;
            this.btn_agregarEmpleador.IconMarginLeft = 0;
            this.btn_agregarEmpleador.IconMarginRight = 0;
            this.btn_agregarEmpleador.IconRightVisible = true;
            this.btn_agregarEmpleador.IconRightZoom = 0D;
            this.btn_agregarEmpleador.IconVisible = true;
            this.btn_agregarEmpleador.IconZoom = 70D;
            this.btn_agregarEmpleador.IsTab = false;
            this.btn_agregarEmpleador.Location = new System.Drawing.Point(9, 62);
            this.btn_agregarEmpleador.Name = "btn_agregarEmpleador";
            this.btn_agregarEmpleador.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_agregarEmpleador.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_agregarEmpleador.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_agregarEmpleador.selected = false;
            this.btn_agregarEmpleador.Size = new System.Drawing.Size(206, 48);
            this.btn_agregarEmpleador.TabIndex = 8;
            this.btn_agregarEmpleador.Text = "      Agregar Empleador";
            this.btn_agregarEmpleador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregarEmpleador.Textcolor = System.Drawing.Color.White;
            this.btn_agregarEmpleador.TextFont = new System.Drawing.Font("Poppins", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // separator_sideBar1
            // 
            this.separator_sideBar1.BackColor = System.Drawing.Color.Transparent;
            this.transition_sidebarAbrir.SetDecoration(this.separator_sideBar1, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarCerrar.SetDecoration(this.separator_sideBar1, BunifuAnimatorNS.DecorationType.None);
            this.separator_sideBar1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.separator_sideBar1.LineThickness = 1;
            this.separator_sideBar1.Location = new System.Drawing.Point(6, 55);
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
            this.lbl_formum.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formum.ForeColor = System.Drawing.Color.White;
            this.lbl_formum.Location = new System.Drawing.Point(69, 15);
            this.lbl_formum.Name = "lbl_formum";
            this.lbl_formum.Size = new System.Drawing.Size(84, 28);
            this.lbl_formum.TabIndex = 6;
            this.lbl_formum.Text = "FORMUM";
            // 
            // pcb_formum
            // 
            this.pcb_formum.BackColor = System.Drawing.Color.Transparent;
            this.transition_sidebarCerrar.SetDecoration(this.pcb_formum, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarAbrir.SetDecoration(this.pcb_formum, BunifuAnimatorNS.DecorationType.None);
            this.pcb_formum.Image = ((System.Drawing.Image)(resources.GetObject("pcb_formum.Image")));
            this.pcb_formum.Location = new System.Drawing.Point(17, 13);
            this.pcb_formum.Name = "pcb_formum";
            this.pcb_formum.Size = new System.Drawing.Size(30, 30);
            this.pcb_formum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_formum.TabIndex = 6;
            this.pcb_formum.TabStop = false;
            // 
            // panel_central
            // 
            this.panel_central.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.transition_sidebarAbrir.SetDecoration(this.panel_central, BunifuAnimatorNS.DecorationType.None);
            this.transition_sidebarCerrar.SetDecoration(this.panel_central, BunifuAnimatorNS.DecorationType.None);
            this.panel_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_central.Location = new System.Drawing.Point(250, 80);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(734, 581);
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
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 1F;
            this.transition_sidebarCerrar.DefaultAnimation = animation4;
            this.transition_sidebarCerrar.Interval = 15;
            // 
            // transition_sidebarAbrir
            // 
            this.transition_sidebarAbrir.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.transition_sidebarAbrir.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.transition_sidebarAbrir.DefaultAnimation = animation3;
            this.transition_sidebarAbrir.Interval = 15;
            // 
            // Form1
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
            this.panel_sidebarWrapper.ResumeLayout(false);
            this.panel_sidebar.ResumeLayout(false);
            this.panel_sidebar.PerformLayout();
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
        private System.Windows.Forms.PictureBox picb_restaurar;
        private System.Windows.Forms.PictureBox picb_minimizar;
        private System.Windows.Forms.PictureBox picb_maximizar;
        private System.Windows.Forms.PictureBox picb__salir;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_sidebar;
        private System.Windows.Forms.Label lbl_formum;
        private System.Windows.Forms.PictureBox pcb_formum;
        private Bunifu.Framework.UI.BunifuSeparator separator_sideBar1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_verEmpleadores;
        private Bunifu.Framework.UI.BunifuFlatButton btn_editarEmpleador;
        private Bunifu.Framework.UI.BunifuFlatButton btn_agregarEmpleador;
        private Bunifu.Framework.UI.BunifuSeparator separator_sidebar2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_agregarEmpleado;
        private Bunifu.Framework.UI.BunifuElipse Elipse_CurvaSidebar;
        private BunifuAnimatorNS.BunifuTransition transition_sidebarAbrir;
        private BunifuAnimatorNS.BunifuTransition transition_sidebarCerrar;
    }
}

