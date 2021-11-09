
namespace SysCafé
{
    partial class maneger_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(maneger_form));
            this.top_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.refresh_but = new Guna.UI2.WinForms.Guna2CircleButton();
            this.select_table_but = new Guna.UI2.WinForms.Guna2Button();
            this.search_but = new Guna.UI2.WinForms.Guna2CircleButton();
            this.search_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nav_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.workers_but = new Guna.UI2.WinForms.Guna2Button();
            this.logout_but = new Guna.UI2.WinForms.Guna2Button();
            this.orders_but = new Guna.UI2.WinForms.Guna2Button();
            this.stock_but = new Guna.UI2.WinForms.Guna2Button();
            this.suppliers_but = new Guna.UI2.WinForms.Guna2Button();
            this.materials_but = new Guna.UI2.WinForms.Guna2Button();
            this.Home_button = new Guna.UI2.WinForms.Guna2Button();
            this.main_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.new_supp_controler1 = new SysCafé.new_supp_controler();
            this.supplier_cont1 = new SysCafé.supplier_cont();
            this.stock_cont21 = new SysCafé.stock_cont2();
            this.workers_cont1 = new SysCafé.workers_cont();
            this.ticket_cont2 = new SysCafé.tickets_casier_cont();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.income_val = new System.Windows.Forms.Label();
            this.order_num_val = new System.Windows.Forms.Label();
            this.date_valu = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.num_order_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.nav_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.top_panel.AutoRoundedCorners = true;
            this.top_panel.BackColor = System.Drawing.Color.White;
            this.top_panel.BorderRadius = 40;
            this.top_panel.Controls.Add(this.refresh_but);
            this.top_panel.Controls.Add(this.select_table_but);
            this.top_panel.Controls.Add(this.search_but);
            this.top_panel.Controls.Add(this.search_txt);
            this.top_panel.Controls.Add(this.pictureBox1);
            this.top_panel.FillColor = System.Drawing.Color.White;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.ShadowDecoration.Parent = this.top_panel;
            this.top_panel.Size = new System.Drawing.Size(1904, 82);
            this.top_panel.TabIndex = 2;
            // 
            // refresh_but
            // 
            this.refresh_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh_but.CheckedState.Parent = this.refresh_but;
            this.refresh_but.CustomImages.Parent = this.refresh_but;
            this.refresh_but.FillColor = System.Drawing.Color.WhiteSmoke;
            this.refresh_but.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refresh_but.ForeColor = System.Drawing.Color.White;
            this.refresh_but.HoverState.Parent = this.refresh_but;
            this.refresh_but.Image = ((System.Drawing.Image)(resources.GetObject("refresh_but.Image")));
            this.refresh_but.Location = new System.Drawing.Point(1615, 18);
            this.refresh_but.Name = "refresh_but";
            this.refresh_but.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.refresh_but.ShadowDecoration.Parent = this.refresh_but;
            this.refresh_but.Size = new System.Drawing.Size(54, 47);
            this.refresh_but.TabIndex = 4;
            this.refresh_but.Click += new System.EventHandler(this.refresh_but_Click);
            // 
            // select_table_but
            // 
            this.select_table_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.select_table_but.BorderRadius = 5;
            this.select_table_but.CheckedState.Parent = this.select_table_but;
            this.select_table_but.CustomImages.Parent = this.select_table_but;
            this.select_table_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.select_table_but.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_table_but.ForeColor = System.Drawing.Color.White;
            this.select_table_but.HoverState.Parent = this.select_table_but;
            this.select_table_but.Image = ((System.Drawing.Image)(resources.GetObject("select_table_but.Image")));
            this.select_table_but.ImageSize = new System.Drawing.Size(40, 40);
            this.select_table_but.Location = new System.Drawing.Point(1710, 18);
            this.select_table_but.Name = "select_table_but";
            this.select_table_but.ShadowDecoration.Parent = this.select_table_but;
            this.select_table_but.Size = new System.Drawing.Size(166, 48);
            this.select_table_but.TabIndex = 3;
            this.select_table_but.Text = "Select table";
            // 
            // search_but
            // 
            this.search_but.CheckedState.Parent = this.search_but;
            this.search_but.CustomImages.Parent = this.search_but;
            this.search_but.FillColor = System.Drawing.Color.WhiteSmoke;
            this.search_but.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search_but.ForeColor = System.Drawing.Color.White;
            this.search_but.HoverState.Parent = this.search_but;
            this.search_but.Image = ((System.Drawing.Image)(resources.GetObject("search_but.Image")));
            this.search_but.Location = new System.Drawing.Point(739, 16);
            this.search_but.Name = "search_but";
            this.search_but.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.search_but.ShadowDecoration.Parent = this.search_but;
            this.search_but.Size = new System.Drawing.Size(54, 47);
            this.search_but.TabIndex = 2;
            // 
            // search_txt
            // 
            this.search_txt.BorderRadius = 10;
            this.search_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_txt.DefaultText = "";
            this.search_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_txt.DisabledState.Parent = this.search_txt;
            this.search_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_txt.FillColor = System.Drawing.Color.WhiteSmoke;
            this.search_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_txt.FocusedState.Parent = this.search_txt;
            this.search_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_txt.HoverState.Parent = this.search_txt;
            this.search_txt.Location = new System.Drawing.Point(299, 19);
            this.search_txt.Name = "search_txt";
            this.search_txt.PasswordChar = '\0';
            this.search_txt.PlaceholderText = "";
            this.search_txt.SelectedText = "";
            this.search_txt.ShadowDecoration.Parent = this.search_txt;
            this.search_txt.Size = new System.Drawing.Size(434, 44);
            this.search_txt.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nav_panel
            // 
            this.nav_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nav_panel.AutoRoundedCorners = true;
            this.nav_panel.BackColor = System.Drawing.Color.White;
            this.nav_panel.BorderRadius = 49;
            this.nav_panel.Controls.Add(this.workers_but);
            this.nav_panel.Controls.Add(this.logout_but);
            this.nav_panel.Controls.Add(this.orders_but);
            this.nav_panel.Controls.Add(this.stock_but);
            this.nav_panel.Controls.Add(this.suppliers_but);
            this.nav_panel.Controls.Add(this.materials_but);
            this.nav_panel.Controls.Add(this.Home_button);
            this.nav_panel.FillColor = System.Drawing.Color.White;
            this.nav_panel.Location = new System.Drawing.Point(-1, 79);
            this.nav_panel.Name = "nav_panel";
            this.nav_panel.ShadowDecoration.Parent = this.nav_panel;
            this.nav_panel.Size = new System.Drawing.Size(100, 960);
            this.nav_panel.TabIndex = 3;
            // 
            // workers_but
            // 
            this.workers_but.BorderRadius = 10;
            this.workers_but.CheckedState.Parent = this.workers_but;
            this.workers_but.CustomImages.Parent = this.workers_but;
            this.workers_but.FillColor = System.Drawing.Color.Transparent;
            this.workers_but.Font = new System.Drawing.Font("Inter Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workers_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.workers_but.HoverState.Parent = this.workers_but;
            this.workers_but.Image = ((System.Drawing.Image)(resources.GetObject("workers_but.Image")));
            this.workers_but.ImageOffset = new System.Drawing.Point(16, -12);
            this.workers_but.ImageSize = new System.Drawing.Size(40, 40);
            this.workers_but.Location = new System.Drawing.Point(-1, 636);
            this.workers_but.Name = "workers_but";
            this.workers_but.ShadowDecoration.Parent = this.workers_but;
            this.workers_but.Size = new System.Drawing.Size(94, 72);
            this.workers_but.TabIndex = 6;
            this.workers_but.Text = "Workers";
            this.workers_but.TextOffset = new System.Drawing.Point(-10, 20);
            this.workers_but.Click += new System.EventHandler(this.workers_but_Click);
            // 
            // logout_but
            // 
            this.logout_but.BorderRadius = 10;
            this.logout_but.CheckedState.Parent = this.logout_but;
            this.logout_but.CustomImages.Parent = this.logout_but;
            this.logout_but.FillColor = System.Drawing.Color.Transparent;
            this.logout_but.Font = new System.Drawing.Font("Inter Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.logout_but.HoverState.Parent = this.logout_but;
            this.logout_but.Image = ((System.Drawing.Image)(resources.GetObject("logout_but.Image")));
            this.logout_but.ImageOffset = new System.Drawing.Point(12, -12);
            this.logout_but.ImageSize = new System.Drawing.Size(40, 40);
            this.logout_but.Location = new System.Drawing.Point(-1, 885);
            this.logout_but.Name = "logout_but";
            this.logout_but.ShadowDecoration.Parent = this.logout_but;
            this.logout_but.Size = new System.Drawing.Size(94, 72);
            this.logout_but.TabIndex = 5;
            this.logout_but.Text = "Logout";
            this.logout_but.TextOffset = new System.Drawing.Point(-10, 20);
            this.logout_but.Click += new System.EventHandler(this.logout_but_Click);
            // 
            // orders_but
            // 
            this.orders_but.BorderRadius = 10;
            this.orders_but.CheckedState.Parent = this.orders_but;
            this.orders_but.CustomImages.Parent = this.orders_but;
            this.orders_but.FillColor = System.Drawing.Color.Transparent;
            this.orders_but.Font = new System.Drawing.Font("Inter Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.orders_but.HoverState.Parent = this.orders_but;
            this.orders_but.Image = ((System.Drawing.Image)(resources.GetObject("orders_but.Image")));
            this.orders_but.ImageOffset = new System.Drawing.Point(12, -12);
            this.orders_but.ImageSize = new System.Drawing.Size(40, 40);
            this.orders_but.Location = new System.Drawing.Point(1, 518);
            this.orders_but.Name = "orders_but";
            this.orders_but.ShadowDecoration.Parent = this.orders_but;
            this.orders_but.Size = new System.Drawing.Size(94, 72);
            this.orders_but.TabIndex = 4;
            this.orders_but.Text = "Orders";
            this.orders_but.TextOffset = new System.Drawing.Point(-10, 20);
            this.orders_but.Click += new System.EventHandler(this.orders_but_Click);
            // 
            // stock_but
            // 
            this.stock_but.BorderRadius = 10;
            this.stock_but.CheckedState.Parent = this.stock_but;
            this.stock_but.CustomImages.Parent = this.stock_but;
            this.stock_but.FillColor = System.Drawing.Color.Transparent;
            this.stock_but.Font = new System.Drawing.Font("Inter Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.stock_but.HoverState.Parent = this.stock_but;
            this.stock_but.Image = ((System.Drawing.Image)(resources.GetObject("stock_but.Image")));
            this.stock_but.ImageOffset = new System.Drawing.Point(12, -12);
            this.stock_but.ImageSize = new System.Drawing.Size(40, 40);
            this.stock_but.Location = new System.Drawing.Point(-1, 397);
            this.stock_but.Name = "stock_but";
            this.stock_but.ShadowDecoration.Parent = this.stock_but;
            this.stock_but.Size = new System.Drawing.Size(94, 72);
            this.stock_but.TabIndex = 3;
            this.stock_but.Text = "Stock";
            this.stock_but.TextOffset = new System.Drawing.Point(-10, 20);
            this.stock_but.Click += new System.EventHandler(this.stock_but_Click);
            // 
            // suppliers_but
            // 
            this.suppliers_but.BorderRadius = 10;
            this.suppliers_but.CheckedState.Parent = this.suppliers_but;
            this.suppliers_but.CustomImages.Parent = this.suppliers_but;
            this.suppliers_but.FillColor = System.Drawing.Color.Transparent;
            this.suppliers_but.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliers_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.suppliers_but.HoverState.Parent = this.suppliers_but;
            this.suppliers_but.Image = ((System.Drawing.Image)(resources.GetObject("suppliers_but.Image")));
            this.suppliers_but.ImageOffset = new System.Drawing.Point(20, -10);
            this.suppliers_but.ImageSize = new System.Drawing.Size(40, 40);
            this.suppliers_but.Location = new System.Drawing.Point(3, 155);
            this.suppliers_but.Name = "suppliers_but";
            this.suppliers_but.ShadowDecoration.Parent = this.suppliers_but;
            this.suppliers_but.Size = new System.Drawing.Size(94, 72);
            this.suppliers_but.TabIndex = 2;
            this.suppliers_but.Text = "Suppliers";
            this.suppliers_but.TextOffset = new System.Drawing.Point(-10, 20);
            this.suppliers_but.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // materials_but
            // 
            this.materials_but.BorderRadius = 10;
            this.materials_but.CheckedState.Parent = this.materials_but;
            this.materials_but.CustomImages.Parent = this.materials_but;
            this.materials_but.FillColor = System.Drawing.Color.Transparent;
            this.materials_but.Font = new System.Drawing.Font("Inter Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materials_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.materials_but.HoverState.Parent = this.materials_but;
            this.materials_but.Image = ((System.Drawing.Image)(resources.GetObject("materials_but.Image")));
            this.materials_but.ImageOffset = new System.Drawing.Point(23, -12);
            this.materials_but.ImageSize = new System.Drawing.Size(40, 40);
            this.materials_but.Location = new System.Drawing.Point(3, 276);
            this.materials_but.Name = "materials_but";
            this.materials_but.ShadowDecoration.Parent = this.materials_but;
            this.materials_but.Size = new System.Drawing.Size(94, 72);
            this.materials_but.TabIndex = 1;
            this.materials_but.Text = "New supplies";
            this.materials_but.TextOffset = new System.Drawing.Point(-10, 20);
            this.materials_but.Click += new System.EventHandler(this.materials_but_Click);
            // 
            // Home_button
            // 
            this.Home_button.BorderRadius = 10;
            this.Home_button.CheckedState.Parent = this.Home_button;
            this.Home_button.CustomImages.Parent = this.Home_button;
            this.Home_button.FillColor = System.Drawing.Color.Transparent;
            this.Home_button.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.Home_button.HoverState.Parent = this.Home_button;
            this.Home_button.Image = ((System.Drawing.Image)(resources.GetObject("Home_button.Image")));
            this.Home_button.ImageOffset = new System.Drawing.Point(13, -10);
            this.Home_button.ImageSize = new System.Drawing.Size(40, 40);
            this.Home_button.Location = new System.Drawing.Point(3, 34);
            this.Home_button.Name = "Home_button";
            this.Home_button.ShadowDecoration.Parent = this.Home_button;
            this.Home_button.Size = new System.Drawing.Size(94, 72);
            this.Home_button.TabIndex = 0;
            this.Home_button.Text = "Home";
            this.Home_button.TextOffset = new System.Drawing.Point(-10, 20);
            this.Home_button.Click += new System.EventHandler(this.Home_button_Click);
            // 
            // main_panel
            // 
            this.main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.main_panel.Controls.Add(this.new_supp_controler1);
            this.main_panel.Controls.Add(this.supplier_cont1);
            this.main_panel.Controls.Add(this.stock_cont21);
            this.main_panel.Controls.Add(this.workers_cont1);
            this.main_panel.Controls.Add(this.ticket_cont2);
            this.main_panel.Controls.Add(this.flowLayoutPanel1);
            this.main_panel.Controls.Add(this.guna2ShadowPanel1);
            this.main_panel.Location = new System.Drawing.Point(99, 82);
            this.main_panel.Name = "main_panel";
            this.main_panel.ShadowDecoration.Parent = this.main_panel;
            this.main_panel.Size = new System.Drawing.Size(1800, 960);
            this.main_panel.TabIndex = 5;
            // 
            // new_supp_controler1
            // 
            this.new_supp_controler1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.new_supp_controler1.Location = new System.Drawing.Point(0, 1);
            this.new_supp_controler1.Name = "new_supp_controler1";
            this.new_supp_controler1.Size = new System.Drawing.Size(1800, 960);
            this.new_supp_controler1.TabIndex = 5;
            this.new_supp_controler1.Visible = false;
            // 
            // supplier_cont1
            // 
            this.supplier_cont1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.supplier_cont1.Location = new System.Drawing.Point(0, 1);
            this.supplier_cont1.Name = "supplier_cont1";
            this.supplier_cont1.Size = new System.Drawing.Size(1800, 960);
            this.supplier_cont1.TabIndex = 4;
            this.supplier_cont1.Visible = false;
            // 
            // stock_cont21
            // 
            this.stock_cont21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stock_cont21.Location = new System.Drawing.Point(0, 0);
            this.stock_cont21.Name = "stock_cont21";
            this.stock_cont21.Size = new System.Drawing.Size(1800, 960);
            this.stock_cont21.TabIndex = 2;
            this.stock_cont21.Visible = false;
            // 
            // workers_cont1
            // 
            this.workers_cont1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.workers_cont1.Location = new System.Drawing.Point(0, 0);
            this.workers_cont1.Name = "workers_cont1";
            this.workers_cont1.Size = new System.Drawing.Size(1785, 939);
            this.workers_cont1.TabIndex = 6;
            // 
            // ticket_cont2
            // 
            this.ticket_cont2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ticket_cont2.Location = new System.Drawing.Point(0, 0);
            this.ticket_cont2.Name = "ticket_cont2";
            this.ticket_cont2.Size = new System.Drawing.Size(1800, 960);
            this.ticket_cont2.TabIndex = 3;
            this.ticket_cont2.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(56, 273);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1689, 615);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.income_val);
            this.guna2ShadowPanel1.Controls.Add(this.order_num_val);
            this.guna2ShadowPanel1.Controls.Add(this.date_valu);
            this.guna2ShadowPanel1.Controls.Add(this.total_label);
            this.guna2ShadowPanel1.Controls.Add(this.num_order_label);
            this.guna2ShadowPanel1.Controls.Add(this.date_label);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(11, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 8;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1785, 154);
            this.guna2ShadowPanel1.TabIndex = 9;
            // 
            // income_val
            // 
            this.income_val.AutoSize = true;
            this.income_val.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.income_val.Location = new System.Drawing.Point(1178, 89);
            this.income_val.Name = "income_val";
            this.income_val.Size = new System.Drawing.Size(0, 25);
            this.income_val.TabIndex = 11;
            // 
            // order_num_val
            // 
            this.order_num_val.AutoSize = true;
            this.order_num_val.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_num_val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.order_num_val.Location = new System.Drawing.Point(228, 89);
            this.order_num_val.Name = "order_num_val";
            this.order_num_val.Size = new System.Drawing.Size(0, 25);
            this.order_num_val.TabIndex = 9;
            // 
            // date_valu
            // 
            this.date_valu.AutoSize = true;
            this.date_valu.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_valu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.date_valu.Location = new System.Drawing.Point(97, 15);
            this.date_valu.Name = "date_valu";
            this.date_valu.Size = new System.Drawing.Size(0, 25);
            this.date_valu.TabIndex = 8;
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.total_label.Location = new System.Drawing.Point(984, 89);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(194, 25);
            this.total_label.TabIndex = 7;
            this.total_label.Text = "Day Total Income :";
            // 
            // num_order_label
            // 
            this.num_order_label.AutoSize = true;
            this.num_order_label.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_order_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.num_order_label.Location = new System.Drawing.Point(21, 89);
            this.num_order_label.Name = "num_order_label";
            this.num_order_label.Size = new System.Drawing.Size(201, 25);
            this.num_order_label.TabIndex = 6;
            this.num_order_label.Text = "Number Of Orders :";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.date_label.Location = new System.Drawing.Point(21, 15);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(70, 25);
            this.date_label.TabIndex = 4;
            this.date_label.Text = "Date :";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "chair.png");
            // 
            // maneger_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1902, 1039);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.nav_panel);
            this.Controls.Add(this.top_panel);
            this.MinimumSize = new System.Drawing.Size(1918, 1078);
            this.Name = "maneger_form";
            this.Text = "maneger_form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.maneger_form_FormClosed);
            this.top_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.nav_panel.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel top_panel;
        private Guna.UI2.WinForms.Guna2Panel nav_panel;
        private Guna.UI2.WinForms.Guna2TextBox search_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton search_but;
        private Guna.UI2.WinForms.Guna2Button select_table_but;
        private Guna.UI2.WinForms.Guna2Button suppliers_but;
        private Guna.UI2.WinForms.Guna2Button materials_but;
        private Guna.UI2.WinForms.Guna2Button Home_button;
        private Guna.UI2.WinForms.Guna2Panel main_panel;
        private Guna.UI2.WinForms.Guna2Button stock_but;
        private stock_cont2 stock_cont21;
        private Guna.UI2.WinForms.Guna2Button orders_but;
        private Guna.UI2.WinForms.Guna2Button logout_but;
        private supplier_cont supplier_cont1;
        private new_supp_controler new_supp_controler1;
        private Guna.UI2.WinForms.Guna2Button workers_but;
        private workers_cont workers_cont1;
        private tickets_casier_cont ticket_cont2;
        private Guna.UI2.WinForms.Guna2CircleButton refresh_but;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label income_val;
        private System.Windows.Forms.Label order_num_val;
        private System.Windows.Forms.Label date_valu;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label num_order_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.ImageList imageList1;
    }
}