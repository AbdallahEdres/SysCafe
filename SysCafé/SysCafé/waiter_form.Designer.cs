
namespace SysCafé
{
    partial class waiter_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(waiter_form));
            this.nav_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.logout_but = new Guna.UI2.WinForms.Guna2Button();
            this.tickets_but = new Guna.UI2.WinForms.Guna2Button();
            this.menu_but = new Guna.UI2.WinForms.Guna2Button();
            this.Home_button = new Guna.UI2.WinForms.Guna2Button();
            this.top_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.refresh_but = new Guna.UI2.WinForms.Guna2CircleButton();
            this.select_table_but = new Guna.UI2.WinForms.Guna2Button();
            this.search_but = new Guna.UI2.WinForms.Guna2CircleButton();
            this.search_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.main_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.nav_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nav_panel
            // 
            this.nav_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nav_panel.AutoRoundedCorners = true;
            this.nav_panel.BackColor = System.Drawing.Color.White;
            this.nav_panel.BorderRadius = 49;
            this.nav_panel.Controls.Add(this.logout_but);
            this.nav_panel.Controls.Add(this.tickets_but);
            this.nav_panel.Controls.Add(this.menu_but);
            this.nav_panel.Controls.Add(this.Home_button);
            this.nav_panel.FillColor = System.Drawing.Color.White;
            this.nav_panel.Location = new System.Drawing.Point(-1, 79);
            this.nav_panel.Name = "nav_panel";
            this.nav_panel.ShadowDecoration.Parent = this.nav_panel;
            this.nav_panel.Size = new System.Drawing.Size(100, 960);
            this.nav_panel.TabIndex = 5;
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
            this.tickets_but.Location = new System.Drawing.Point(3, 155);
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
            this.menu_but.Location = new System.Drawing.Point(3, 276);
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
            this.Home_button.Location = new System.Drawing.Point(3, 34);
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
            this.top_panel.TabIndex = 4;
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
            this.select_table_but.Click += new System.EventHandler(this.select_table_but_Click);
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "chair.png");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(54, 65);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1689, 816);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.Transparent;
            this.main_panel.Controls.Add(this.flowLayoutPanel1);
            this.main_panel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.main_panel.Location = new System.Drawing.Point(109, 88);
            this.main_panel.Name = "main_panel";
            this.main_panel.Radius = 5;
            this.main_panel.ShadowColor = System.Drawing.Color.Black;
            this.main_panel.ShadowShift = 10;
            this.main_panel.Size = new System.Drawing.Size(1785, 939);
            this.main_panel.TabIndex = 7;
            // 
            // waiter_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1902, 1039);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.nav_panel);
            this.Controls.Add(this.top_panel);
            this.Name = "waiter_form";
            this.Text = "waiter_form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.waiter_form_FormClosed);
            this.nav_panel.ResumeLayout(false);
            this.top_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.main_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel nav_panel;
        private Guna.UI2.WinForms.Guna2Button logout_but;
        private Guna.UI2.WinForms.Guna2Button tickets_but;
        public  Guna.UI2.WinForms.Guna2Button menu_but;
        private Guna.UI2.WinForms.Guna2Button Home_button;
        private Guna.UI2.WinForms.Guna2Panel top_panel;
        private Guna.UI2.WinForms.Guna2CircleButton refresh_but;
        private Guna.UI2.WinForms.Guna2Button select_table_but;
        private Guna.UI2.WinForms.Guna2CircleButton search_but;
        private Guna.UI2.WinForms.Guna2TextBox search_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel main_panel;
    }
}