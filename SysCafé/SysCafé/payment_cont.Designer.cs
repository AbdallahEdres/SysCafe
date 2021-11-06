
namespace SysCafé
{
    partial class payment_cont
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menu_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.price_label = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.recipt_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.close_tkt_but = new Guna.UI2.WinForms.Guna2Button();
            this.recipt_label = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.all_radio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.closed_label = new System.Windows.Forms.Label();
            this.open_label = new System.Windows.Forms.Label();
            this.open_close_togel = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.tabels_radio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.takeaway_radio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.delivery_radio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.open_tkts_label = new System.Windows.Forms.Label();
            this.tickets_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipt_grid)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tickets_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.Transparent;
            this.menu_panel.Controls.Add(this.price_label);
            this.menu_panel.Controls.Add(this.total_label);
            this.menu_panel.Controls.Add(this.recipt_grid);
            this.menu_panel.Controls.Add(this.close_tkt_but);
            this.menu_panel.Controls.Add(this.recipt_label);
            this.menu_panel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.menu_panel.Location = new System.Drawing.Point(958, 3);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Radius = 10;
            this.menu_panel.ShadowColor = System.Drawing.Color.Black;
            this.menu_panel.ShadowShift = 10;
            this.menu_panel.Size = new System.Drawing.Size(828, 954);
            this.menu_panel.TabIndex = 4;
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.price_label.Location = new System.Drawing.Point(610, 882);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(26, 25);
            this.price_label.TabIndex = 23;
            this.price_label.Text = "$";
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.total_label.Location = new System.Drawing.Point(585, 838);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(116, 25);
            this.total_label.TabIndex = 22;
            this.total_label.Text = "Total Price";
            // 
            // recipt_grid
            // 
            this.recipt_grid.AllowUserToAddRows = false;
            this.recipt_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.recipt_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.recipt_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recipt_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.recipt_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recipt_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.recipt_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recipt_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.recipt_grid.ColumnHeadersHeight = 25;
            this.recipt_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.recipt_grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.recipt_grid.EnableHeadersVisualStyles = false;
            this.recipt_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.recipt_grid.Location = new System.Drawing.Point(52, 139);
            this.recipt_grid.Name = "recipt_grid";
            this.recipt_grid.ReadOnly = true;
            this.recipt_grid.RowHeadersVisible = false;
            this.recipt_grid.RowTemplate.Height = 20;
            this.recipt_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recipt_grid.Size = new System.Drawing.Size(724, 617);
            this.recipt_grid.TabIndex = 21;
            this.recipt_grid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.recipt_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.recipt_grid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipt_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.recipt_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.recipt_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.recipt_grid.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.recipt_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.recipt_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.recipt_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.recipt_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipt_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.recipt_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.recipt_grid.ThemeStyle.HeaderStyle.Height = 25;
            this.recipt_grid.ThemeStyle.ReadOnly = true;
            this.recipt_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.recipt_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.recipt_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipt_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.recipt_grid.ThemeStyle.RowsStyle.Height = 20;
            this.recipt_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.recipt_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            // 
            // close_tkt_but
            // 
            this.close_tkt_but.BackColor = System.Drawing.Color.Transparent;
            this.close_tkt_but.BorderRadius = 15;
            this.close_tkt_but.CheckedState.Parent = this.close_tkt_but;
            this.close_tkt_but.CustomImages.Parent = this.close_tkt_but;
            this.close_tkt_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.close_tkt_but.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_tkt_but.ForeColor = System.Drawing.Color.White;
            this.close_tkt_but.HoverState.Parent = this.close_tkt_but;
            this.close_tkt_but.ImageOffset = new System.Drawing.Point(0, -2);
            this.close_tkt_but.ImageSize = new System.Drawing.Size(30, 30);
            this.close_tkt_but.Location = new System.Drawing.Point(70, 851);
            this.close_tkt_but.Name = "close_tkt_but";
            this.close_tkt_but.ShadowDecoration.Parent = this.close_tkt_but;
            this.close_tkt_but.Size = new System.Drawing.Size(232, 70);
            this.close_tkt_but.TabIndex = 20;
            this.close_tkt_but.Text = "Close Ticket";
            this.close_tkt_but.Click += new System.EventHandler(this.close_tkt_but_Click);
            // 
            // recipt_label
            // 
            this.recipt_label.AutoSize = true;
            this.recipt_label.Font = new System.Drawing.Font("Inter Semi Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipt_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.recipt_label.Location = new System.Drawing.Point(350, 22);
            this.recipt_label.Name = "recipt_label";
            this.recipt_label.Size = new System.Drawing.Size(134, 39);
            this.recipt_label.TabIndex = 9;
            this.recipt_label.Text = "Receipt";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.all_radio);
            this.guna2ShadowPanel1.Controls.Add(this.closed_label);
            this.guna2ShadowPanel1.Controls.Add(this.open_label);
            this.guna2ShadowPanel1.Controls.Add(this.open_close_togel);
            this.guna2ShadowPanel1.Controls.Add(this.tabels_radio);
            this.guna2ShadowPanel1.Controls.Add(this.takeaway_radio);
            this.guna2ShadowPanel1.Controls.Add(this.delivery_radio);
            this.guna2ShadowPanel1.Controls.Add(this.open_tkts_label);
            this.guna2ShadowPanel1.Controls.Add(this.tickets_grid);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 10;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(902, 954);
            this.guna2ShadowPanel1.TabIndex = 5;
            // 
            // all_radio
            // 
            this.all_radio.AutoSize = true;
            this.all_radio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.all_radio.CheckedState.BorderThickness = 0;
            this.all_radio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.all_radio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.all_radio.CheckedState.InnerOffset = -4;
            this.all_radio.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_radio.Location = new System.Drawing.Point(80, 108);
            this.all_radio.Name = "all_radio";
            this.all_radio.Size = new System.Drawing.Size(55, 29);
            this.all_radio.TabIndex = 29;
            this.all_radio.TabStop = true;
            this.all_radio.Text = "All";
            this.all_radio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.all_radio.UncheckedState.BorderThickness = 2;
            this.all_radio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.all_radio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.all_radio.UseVisualStyleBackColor = true;
            // 
            // closed_label
            // 
            this.closed_label.AutoSize = true;
            this.closed_label.BackColor = System.Drawing.Color.Transparent;
            this.closed_label.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closed_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.closed_label.Location = new System.Drawing.Point(447, 143);
            this.closed_label.Name = "closed_label";
            this.closed_label.Size = new System.Drawing.Size(124, 19);
            this.closed_label.TabIndex = 28;
            this.closed_label.Text = "Open and Closed";
            // 
            // open_label
            // 
            this.open_label.AutoSize = true;
            this.open_label.BackColor = System.Drawing.Color.Transparent;
            this.open_label.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.open_label.Location = new System.Drawing.Point(328, 143);
            this.open_label.Name = "open_label";
            this.open_label.Size = new System.Drawing.Size(49, 19);
            this.open_label.TabIndex = 27;
            this.open_label.Text = "Open";
            // 
            // open_close_togel
            // 
            this.open_close_togel.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.open_close_togel.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.open_close_togel.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.open_close_togel.CheckedState.InnerColor = System.Drawing.Color.White;
            this.open_close_togel.CheckedState.Parent = this.open_close_togel;
            this.open_close_togel.Location = new System.Drawing.Point(383, 143);
            this.open_close_togel.Name = "open_close_togel";
            this.open_close_togel.ShadowDecoration.Parent = this.open_close_togel;
            this.open_close_togel.Size = new System.Drawing.Size(58, 21);
            this.open_close_togel.TabIndex = 26;
            this.open_close_togel.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.open_close_togel.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.open_close_togel.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.open_close_togel.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.open_close_togel.UncheckedState.Parent = this.open_close_togel;
            this.open_close_togel.CheckedChanged += new System.EventHandler(this.open_close_togel_CheckedChanged);
            // 
            // tabels_radio
            // 
            this.tabels_radio.AutoSize = true;
            this.tabels_radio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.tabels_radio.CheckedState.BorderThickness = 0;
            this.tabels_radio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.tabels_radio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tabels_radio.CheckedState.InnerOffset = -4;
            this.tabels_radio.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabels_radio.Location = new System.Drawing.Point(242, 108);
            this.tabels_radio.Name = "tabels_radio";
            this.tabels_radio.Size = new System.Drawing.Size(96, 29);
            this.tabels_radio.TabIndex = 25;
            this.tabels_radio.TabStop = true;
            this.tabels_radio.Text = "Tables";
            this.tabels_radio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tabels_radio.UncheckedState.BorderThickness = 2;
            this.tabels_radio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.tabels_radio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.tabels_radio.UseVisualStyleBackColor = true;
            this.tabels_radio.CheckedChanged += new System.EventHandler(this.tabels_radio_CheckedChanged);
            // 
            // takeaway_radio
            // 
            this.takeaway_radio.AutoSize = true;
            this.takeaway_radio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.takeaway_radio.CheckedState.BorderThickness = 0;
            this.takeaway_radio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.takeaway_radio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.takeaway_radio.CheckedState.InnerOffset = -4;
            this.takeaway_radio.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeaway_radio.Location = new System.Drawing.Point(663, 108);
            this.takeaway_radio.Name = "takeaway_radio";
            this.takeaway_radio.Size = new System.Drawing.Size(132, 29);
            this.takeaway_radio.TabIndex = 24;
            this.takeaway_radio.TabStop = true;
            this.takeaway_radio.Text = "Takeaway";
            this.takeaway_radio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.takeaway_radio.UncheckedState.BorderThickness = 2;
            this.takeaway_radio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.takeaway_radio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.takeaway_radio.UseVisualStyleBackColor = true;
            this.takeaway_radio.CheckedChanged += new System.EventHandler(this.takeaway_radio_CheckedChanged);
            // 
            // delivery_radio
            // 
            this.delivery_radio.AutoSize = true;
            this.delivery_radio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.delivery_radio.CheckedState.BorderThickness = 0;
            this.delivery_radio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.delivery_radio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.delivery_radio.CheckedState.InnerOffset = -4;
            this.delivery_radio.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivery_radio.Location = new System.Drawing.Point(445, 108);
            this.delivery_radio.Name = "delivery_radio";
            this.delivery_radio.Size = new System.Drawing.Size(111, 29);
            this.delivery_radio.TabIndex = 23;
            this.delivery_radio.TabStop = true;
            this.delivery_radio.Text = "Delivery";
            this.delivery_radio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.delivery_radio.UncheckedState.BorderThickness = 2;
            this.delivery_radio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.delivery_radio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.delivery_radio.UseVisualStyleBackColor = true;
            this.delivery_radio.CheckedChanged += new System.EventHandler(this.delivery_radio_CheckedChanged);
            // 
            // open_tkts_label
            // 
            this.open_tkts_label.AutoSize = true;
            this.open_tkts_label.Font = new System.Drawing.Font("Inter Semi Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_tkts_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.open_tkts_label.Location = new System.Drawing.Point(315, 22);
            this.open_tkts_label.Name = "open_tkts_label";
            this.open_tkts_label.Size = new System.Drawing.Size(246, 39);
            this.open_tkts_label.TabIndex = 21;
            this.open_tkts_label.Text = "Table\'s tickets";
            // 
            // tickets_grid
            // 
            this.tickets_grid.AllowUserToAddRows = false;
            this.tickets_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.tickets_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tickets_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tickets_grid.BackgroundColor = System.Drawing.Color.White;
            this.tickets_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tickets_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tickets_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tickets_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tickets_grid.ColumnHeadersHeight = 25;
            this.tickets_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tickets_grid.DefaultCellStyle = dataGridViewCellStyle6;
            this.tickets_grid.EnableHeadersVisualStyles = false;
            this.tickets_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tickets_grid.Location = new System.Drawing.Point(34, 250);
            this.tickets_grid.Name = "tickets_grid";
            this.tickets_grid.ReadOnly = true;
            this.tickets_grid.RowHeadersVisible = false;
            this.tickets_grid.RowTemplate.Height = 20;
            this.tickets_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tickets_grid.Size = new System.Drawing.Size(829, 689);
            this.tickets_grid.TabIndex = 20;
            this.tickets_grid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.tickets_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.tickets_grid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickets_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.tickets_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.tickets_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tickets_grid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tickets_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tickets_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.tickets_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tickets_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickets_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tickets_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tickets_grid.ThemeStyle.HeaderStyle.Height = 25;
            this.tickets_grid.ThemeStyle.ReadOnly = true;
            this.tickets_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tickets_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tickets_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickets_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.tickets_grid.ThemeStyle.RowsStyle.Height = 20;
            this.tickets_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.tickets_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.tickets_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tickets_grid_CellClick);
            // 
            // payment_cont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.menu_panel);
            this.Location = new System.Drawing.Point(109, 88);
            this.Name = "payment_cont";
            this.Size = new System.Drawing.Size(1800, 960);
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipt_grid)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tickets_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel menu_panel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView tickets_grid;
        private System.Windows.Forms.Label recipt_label;
        private System.Windows.Forms.Label open_tkts_label;
        private Guna.UI2.WinForms.Guna2RadioButton tabels_radio;
        private Guna.UI2.WinForms.Guna2RadioButton takeaway_radio;
        private Guna.UI2.WinForms.Guna2RadioButton delivery_radio;
        private System.Windows.Forms.Label closed_label;
        private System.Windows.Forms.Label open_label;
        private Guna.UI2.WinForms.Guna2ToggleSwitch open_close_togel;
        private Guna.UI2.WinForms.Guna2Button close_tkt_but;
        private Guna.UI2.WinForms.Guna2RadioButton all_radio;
        private Guna.UI2.WinForms.Guna2DataGridView recipt_grid;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label total_label;
    }
}
