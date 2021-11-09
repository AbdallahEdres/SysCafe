
namespace SysCafé
{
    partial class cashier_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashier_form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nav_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.customers_but = new Guna.UI2.WinForms.Guna2Button();
            this.payment_but = new Guna.UI2.WinForms.Guna2Button();
            this.logout_but = new Guna.UI2.WinForms.Guna2Button();
            this.tickets_but = new Guna.UI2.WinForms.Guna2Button();
            this.menu_but = new Guna.UI2.WinForms.Guna2Button();
            this.Home_button = new Guna.UI2.WinForms.Guna2Button();
            this.top_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.new_ticket = new Guna.UI2.WinForms.Guna2Button();
            this.refresh_but = new Guna.UI2.WinForms.Guna2CircleButton();
            this.select_table_but = new Guna.UI2.WinForms.Guna2Button();
            this.time_label = new System.Windows.Forms.Label();
            this.search_but = new Guna.UI2.WinForms.Guna2CircleButton();
            this.search_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.income_val = new System.Windows.Forms.Label();
            this.order_num_val = new System.Windows.Forms.Label();
            this.date_valu = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.num_order_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.history_label = new System.Windows.Forms.Label();
            this.history_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ShadowPanel4 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.closed_label = new System.Windows.Forms.Label();
            this.Closed_tkt_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.open_label = new System.Windows.Forms.Label();
            this.open_tkt_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.customer_cont1 = new SysCafé.customers_cont();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nav_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.history_grid)).BeginInit();
            this.guna2ShadowPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Closed_tkt_grid)).BeginInit();
            this.guna2ShadowPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.open_tkt_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // nav_panel
            // 
            this.nav_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nav_panel.AutoRoundedCorners = true;
            this.nav_panel.BackColor = System.Drawing.Color.White;
            this.nav_panel.BorderRadius = 49;
            this.nav_panel.Controls.Add(this.customers_but);
            this.nav_panel.Controls.Add(this.payment_but);
            this.nav_panel.Controls.Add(this.logout_but);
            this.nav_panel.Controls.Add(this.tickets_but);
            this.nav_panel.Controls.Add(this.menu_but);
            this.nav_panel.Controls.Add(this.Home_button);
            this.nav_panel.FillColor = System.Drawing.Color.White;
            this.nav_panel.Location = new System.Drawing.Point(-1, 79);
            this.nav_panel.Name = "nav_panel";
            this.nav_panel.ShadowDecoration.Parent = this.nav_panel;
            this.nav_panel.Size = new System.Drawing.Size(100, 960);
            this.nav_panel.TabIndex = 7;
            // 
            // customers_but
            // 
            this.customers_but.BorderRadius = 10;
            this.customers_but.CheckedState.Parent = this.customers_but;
            this.customers_but.CustomImages.Parent = this.customers_but;
            this.customers_but.FillColor = System.Drawing.Color.Transparent;
            this.customers_but.Font = new System.Drawing.Font("Inter Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.customers_but.HoverState.Parent = this.customers_but;
            this.customers_but.Image = ((System.Drawing.Image)(resources.GetObject("customers_but.Image")));
            this.customers_but.ImageOffset = new System.Drawing.Point(18, -12);
            this.customers_but.ImageSize = new System.Drawing.Size(40, 40);
            this.customers_but.Location = new System.Drawing.Point(1, 486);
            this.customers_but.Name = "customers_but";
            this.customers_but.ShadowDecoration.Parent = this.customers_but;
            this.customers_but.Size = new System.Drawing.Size(94, 72);
            this.customers_but.TabIndex = 7;
            this.customers_but.Text = "Customers";
            this.customers_but.TextOffset = new System.Drawing.Point(-12, 20);
            this.customers_but.Click += new System.EventHandler(this.customers_but_Click);
            // 
            // payment_but
            // 
            this.payment_but.BorderRadius = 10;
            this.payment_but.CheckedState.Parent = this.payment_but;
            this.payment_but.CustomImages.Parent = this.payment_but;
            this.payment_but.FillColor = System.Drawing.Color.Transparent;
            this.payment_but.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.payment_but.HoverState.Parent = this.payment_but;
            this.payment_but.Image = ((System.Drawing.Image)(resources.GetObject("payment_but.Image")));
            this.payment_but.ImageOffset = new System.Drawing.Point(22, -10);
            this.payment_but.ImageSize = new System.Drawing.Size(40, 40);
            this.payment_but.Location = new System.Drawing.Point(1, 138);
            this.payment_but.Name = "payment_but";
            this.payment_but.ShadowDecoration.Parent = this.payment_but;
            this.payment_but.Size = new System.Drawing.Size(94, 72);
            this.payment_but.TabIndex = 6;
            this.payment_but.Text = "Payment";
            this.payment_but.TextOffset = new System.Drawing.Point(-10, 20);
            this.payment_but.Click += new System.EventHandler(this.payment_but_Click);
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
            // 
            // tickets_but
            // 
            this.tickets_but.BorderRadius = 10;
            this.tickets_but.CheckedState.Parent = this.tickets_but;
            this.tickets_but.CustomImages.Parent = this.tickets_but;
            this.tickets_but.FillColor = System.Drawing.Color.Transparent;
            this.tickets_but.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickets_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.tickets_but.HoverState.Parent = this.tickets_but;
            this.tickets_but.Image = ((System.Drawing.Image)(resources.GetObject("tickets_but.Image")));
            this.tickets_but.ImageOffset = new System.Drawing.Point(15, -10);
            this.tickets_but.ImageSize = new System.Drawing.Size(35, 35);
            this.tickets_but.Location = new System.Drawing.Point(1, 249);
            this.tickets_but.Name = "tickets_but";
            this.tickets_but.ShadowDecoration.Parent = this.tickets_but;
            this.tickets_but.Size = new System.Drawing.Size(94, 72);
            this.tickets_but.TabIndex = 2;
            this.tickets_but.Text = "Tickets";
            this.tickets_but.TextOffset = new System.Drawing.Point(-10, 20);
            this.tickets_but.Click += new System.EventHandler(this.tickets_but_Click);
            // 
            // menu_but
            // 
            this.menu_but.BorderRadius = 10;
            this.menu_but.CheckedState.Parent = this.menu_but;
            this.menu_but.CustomImages.Parent = this.menu_but;
            this.menu_but.FillColor = System.Drawing.Color.Transparent;
            this.menu_but.Font = new System.Drawing.Font("Inter Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.menu_but.HoverState.Parent = this.menu_but;
            this.menu_but.Image = ((System.Drawing.Image)(resources.GetObject("menu_but.Image")));
            this.menu_but.ImageOffset = new System.Drawing.Point(11, -12);
            this.menu_but.ImageSize = new System.Drawing.Size(40, 40);
            this.menu_but.Location = new System.Drawing.Point(1, 372);
            this.menu_but.Name = "menu_but";
            this.menu_but.ShadowDecoration.Parent = this.menu_but;
            this.menu_but.Size = new System.Drawing.Size(94, 72);
            this.menu_but.TabIndex = 1;
            this.menu_but.Text = "Menu";
            this.menu_but.TextOffset = new System.Drawing.Point(-12, 20);
            this.menu_but.Click += new System.EventHandler(this.menu_but_Click);
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
            this.Home_button.Location = new System.Drawing.Point(1, 34);
            this.Home_button.Name = "Home_button";
            this.Home_button.ShadowDecoration.Parent = this.Home_button;
            this.Home_button.Size = new System.Drawing.Size(94, 72);
            this.Home_button.TabIndex = 0;
            this.Home_button.Text = "Home";
            this.Home_button.TextOffset = new System.Drawing.Point(-10, 20);
            this.Home_button.Click += new System.EventHandler(this.Home_button_Click);
            // 
            // top_panel
            // 
            this.top_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.top_panel.AutoRoundedCorners = true;
            this.top_panel.BackColor = System.Drawing.Color.White;
            this.top_panel.BorderRadius = 40;
            this.top_panel.Controls.Add(this.new_ticket);
            this.top_panel.Controls.Add(this.refresh_but);
            this.top_panel.Controls.Add(this.select_table_but);
            this.top_panel.Controls.Add(this.time_label);
            this.top_panel.Controls.Add(this.search_but);
            this.top_panel.Controls.Add(this.search_txt);
            this.top_panel.Controls.Add(this.pictureBox1);
            this.top_panel.FillColor = System.Drawing.Color.White;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.ShadowDecoration.Parent = this.top_panel;
            this.top_panel.Size = new System.Drawing.Size(1904, 82);
            this.top_panel.TabIndex = 6;
            // 
            // new_ticket
            // 
            this.new_ticket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.new_ticket.BorderRadius = 5;
            this.new_ticket.CheckedState.Parent = this.new_ticket;
            this.new_ticket.CustomImages.Parent = this.new_ticket;
            this.new_ticket.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.new_ticket.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_ticket.ForeColor = System.Drawing.Color.White;
            this.new_ticket.HoverState.Parent = this.new_ticket;
            this.new_ticket.Image = ((System.Drawing.Image)(resources.GetObject("new_ticket.Image")));
            this.new_ticket.ImageOffset = new System.Drawing.Point(0, -3);
            this.new_ticket.Location = new System.Drawing.Point(1400, 18);
            this.new_ticket.Name = "new_ticket";
            this.new_ticket.ShadowDecoration.Parent = this.new_ticket;
            this.new_ticket.Size = new System.Drawing.Size(166, 48);
            this.new_ticket.TabIndex = 6;
            this.new_ticket.Text = "New Ticket";
            this.new_ticket.Click += new System.EventHandler(this.new_ticket_Click);
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
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.time_label.Location = new System.Drawing.Point(1149, 28);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(62, 25);
            this.time_label.TabIndex = 5;
            this.time_label.Text = "Time";
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
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(15, 6);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 8;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1371, 154);
            this.guna2ShadowPanel1.TabIndex = 8;
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
            // main_panel
            // 
            this.main_panel.Controls.Add(this.guna2ShadowPanel2);
            this.main_panel.Controls.Add(this.guna2ShadowPanel4);
            this.main_panel.Controls.Add(this.guna2ShadowPanel1);
            this.main_panel.Controls.Add(this.guna2ShadowPanel3);
            this.main_panel.Location = new System.Drawing.Point(100, 82);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1801, 960);
            this.main_panel.TabIndex = 12;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.history_label);
            this.guna2ShadowPanel2.Controls.Add(this.history_grid);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(1389, 5);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 10;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.ShadowShift = 8;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(398, 948);
            this.guna2ShadowPanel2.TabIndex = 9;
            // 
            // history_label
            // 
            this.history_label.AutoSize = true;
            this.history_label.Font = new System.Drawing.Font("Inter Semi Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.history_label.Location = new System.Drawing.Point(106, 58);
            this.history_label.Name = "history_label";
            this.history_label.Size = new System.Drawing.Size(222, 39);
            this.history_label.TabIndex = 8;
            this.history_label.Text = "Daily History";
            // 
            // history_grid
            // 
            this.history_grid.AllowUserToAddRows = false;
            this.history_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.history_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.history_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.history_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.history_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.history_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.history_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.history_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.history_grid.ColumnHeadersHeight = 25;
            this.history_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.history_grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.history_grid.EnableHeadersVisualStyles = false;
            this.history_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.history_grid.Location = new System.Drawing.Point(44, 150);
            this.history_grid.Name = "history_grid";
            this.history_grid.ReadOnly = true;
            this.history_grid.RowHeadersVisible = false;
            this.history_grid.RowTemplate.Height = 20;
            this.history_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.history_grid.Size = new System.Drawing.Size(320, 778);
            this.history_grid.TabIndex = 7;
            this.history_grid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.history_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.history_grid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.history_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.history_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.history_grid.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.history_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.history_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.history_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.history_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.history_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.history_grid.ThemeStyle.HeaderStyle.Height = 25;
            this.history_grid.ThemeStyle.ReadOnly = true;
            this.history_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.history_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.history_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.history_grid.ThemeStyle.RowsStyle.Height = 20;
            this.history_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.history_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            // 
            // guna2ShadowPanel4
            // 
            this.guna2ShadowPanel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel4.Controls.Add(this.closed_label);
            this.guna2ShadowPanel4.Controls.Add(this.Closed_tkt_grid);
            this.guna2ShadowPanel4.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel4.Location = new System.Drawing.Point(728, 190);
            this.guna2ShadowPanel4.Name = "guna2ShadowPanel4";
            this.guna2ShadowPanel4.Radius = 10;
            this.guna2ShadowPanel4.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel4.ShadowShift = 8;
            this.guna2ShadowPanel4.Size = new System.Drawing.Size(658, 755);
            this.guna2ShadowPanel4.TabIndex = 11;
            // 
            // closed_label
            // 
            this.closed_label.AutoSize = true;
            this.closed_label.Font = new System.Drawing.Font("Inter Semi Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closed_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.closed_label.Location = new System.Drawing.Point(210, 44);
            this.closed_label.Name = "closed_label";
            this.closed_label.Size = new System.Drawing.Size(255, 39);
            this.closed_label.TabIndex = 8;
            this.closed_label.Text = "Closed Tickets";
            // 
            // Closed_tkt_grid
            // 
            this.Closed_tkt_grid.AllowUserToAddRows = false;
            this.Closed_tkt_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.Closed_tkt_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Closed_tkt_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Closed_tkt_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Closed_tkt_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Closed_tkt_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Closed_tkt_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Closed_tkt_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Closed_tkt_grid.ColumnHeadersHeight = 25;
            this.Closed_tkt_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Closed_tkt_grid.DefaultCellStyle = dataGridViewCellStyle6;
            this.Closed_tkt_grid.EnableHeadersVisualStyles = false;
            this.Closed_tkt_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Closed_tkt_grid.Location = new System.Drawing.Point(35, 109);
            this.Closed_tkt_grid.Name = "Closed_tkt_grid";
            this.Closed_tkt_grid.ReadOnly = true;
            this.Closed_tkt_grid.RowHeadersVisible = false;
            this.Closed_tkt_grid.RowTemplate.Height = 20;
            this.Closed_tkt_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Closed_tkt_grid.Size = new System.Drawing.Size(589, 605);
            this.Closed_tkt_grid.TabIndex = 7;
            this.Closed_tkt_grid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.Closed_tkt_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.Closed_tkt_grid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closed_tkt_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.Closed_tkt_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.Closed_tkt_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Closed_tkt_grid.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Closed_tkt_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Closed_tkt_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.Closed_tkt_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Closed_tkt_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closed_tkt_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Closed_tkt_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Closed_tkt_grid.ThemeStyle.HeaderStyle.Height = 25;
            this.Closed_tkt_grid.ThemeStyle.ReadOnly = true;
            this.Closed_tkt_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Closed_tkt_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Closed_tkt_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closed_tkt_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.Closed_tkt_grid.ThemeStyle.RowsStyle.Height = 20;
            this.Closed_tkt_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.Closed_tkt_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            // 
            // guna2ShadowPanel3
            // 
            this.guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel3.Controls.Add(this.open_label);
            this.guna2ShadowPanel3.Controls.Add(this.open_tkt_grid);
            this.guna2ShadowPanel3.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel3.Location = new System.Drawing.Point(15, 190);
            this.guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            this.guna2ShadowPanel3.Radius = 10;
            this.guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel3.ShadowShift = 8;
            this.guna2ShadowPanel3.Size = new System.Drawing.Size(659, 755);
            this.guna2ShadowPanel3.TabIndex = 10;
            // 
            // open_label
            // 
            this.open_label.AutoSize = true;
            this.open_label.Font = new System.Drawing.Font("Inter Semi Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.open_label.Location = new System.Drawing.Point(217, 47);
            this.open_label.Name = "open_label";
            this.open_label.Size = new System.Drawing.Size(229, 39);
            this.open_label.TabIndex = 8;
            this.open_label.Text = "Open Tickets";
            // 
            // open_tkt_grid
            // 
            this.open_tkt_grid.AllowUserToAddRows = false;
            this.open_tkt_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.open_tkt_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.open_tkt_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.open_tkt_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.open_tkt_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.open_tkt_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.open_tkt_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.open_tkt_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.open_tkt_grid.ColumnHeadersHeight = 25;
            this.open_tkt_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.open_tkt_grid.DefaultCellStyle = dataGridViewCellStyle9;
            this.open_tkt_grid.EnableHeadersVisualStyles = false;
            this.open_tkt_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.open_tkt_grid.Location = new System.Drawing.Point(26, 109);
            this.open_tkt_grid.Name = "open_tkt_grid";
            this.open_tkt_grid.ReadOnly = true;
            this.open_tkt_grid.RowHeadersVisible = false;
            this.open_tkt_grid.RowTemplate.Height = 20;
            this.open_tkt_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.open_tkt_grid.Size = new System.Drawing.Size(611, 626);
            this.open_tkt_grid.TabIndex = 7;
            this.open_tkt_grid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.open_tkt_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.open_tkt_grid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_tkt_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.open_tkt_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.open_tkt_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.open_tkt_grid.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.open_tkt_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.open_tkt_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.open_tkt_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.open_tkt_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_tkt_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.open_tkt_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.open_tkt_grid.ThemeStyle.HeaderStyle.Height = 25;
            this.open_tkt_grid.ThemeStyle.ReadOnly = true;
            this.open_tkt_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.open_tkt_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.open_tkt_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_tkt_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.open_tkt_grid.ThemeStyle.RowsStyle.Height = 20;
            this.open_tkt_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.open_tkt_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            // 
            // customer_cont1
            // 
            this.customer_cont1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customer_cont1.Location = new System.Drawing.Point(109, 88);
            this.customer_cont1.Name = "customer_cont1";
            this.customer_cont1.Size = new System.Drawing.Size(1785, 939);
            this.customer_cont1.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cashier_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1902, 1039);
            this.Controls.Add(this.nav_panel);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.customer_cont1);
            this.Name = "cashier_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "casheir_form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cashier_form_FormClosed);
            this.nav_panel.ResumeLayout(false);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.main_panel.ResumeLayout(false);
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.history_grid)).EndInit();
            this.guna2ShadowPanel4.ResumeLayout(false);
            this.guna2ShadowPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Closed_tkt_grid)).EndInit();
            this.guna2ShadowPanel3.ResumeLayout(false);
            this.guna2ShadowPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.open_tkt_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel nav_panel;
        private Guna.UI2.WinForms.Guna2Button logout_but;
        private Guna.UI2.WinForms.Guna2Button tickets_but;
        private Guna.UI2.WinForms.Guna2Button menu_but;
        private Guna.UI2.WinForms.Guna2Button Home_button;
        private Guna.UI2.WinForms.Guna2Panel top_panel;
        private Guna.UI2.WinForms.Guna2CircleButton refresh_but;
        private Guna.UI2.WinForms.Guna2Button select_table_but;
        private Guna.UI2.WinForms.Guna2CircleButton search_but;
        private Guna.UI2.WinForms.Guna2TextBox search_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button payment_but;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel4;
        private Guna.UI2.WinForms.Guna2DataGridView history_grid;
        private Guna.UI2.WinForms.Guna2DataGridView open_tkt_grid;
        private Guna.UI2.WinForms.Guna2DataGridView Closed_tkt_grid;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label num_order_label;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label history_label;
        private System.Windows.Forms.Label open_label;
        private System.Windows.Forms.Label closed_label;
        private System.Windows.Forms.Panel main_panel;
        private Guna.UI2.WinForms.Guna2Button new_ticket;
        private System.Windows.Forms.Label order_num_val;
        private System.Windows.Forms.Label date_valu;
        private System.Windows.Forms.Label income_val;
        private Guna.UI2.WinForms.Guna2Button customers_but;
        private customers_cont customer_cont1;
    }
}