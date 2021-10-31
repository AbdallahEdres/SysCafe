
namespace SysCafé
{
    partial class tickets_cont
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tickets_cont));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.back_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tabels_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tables_orders_label = new System.Windows.Forms.Label();
            this.closed_tickets_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.details_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.old_tickets_label = new System.Windows.Forms.Label();
            this.current_ticket_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.orders_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.current_label = new System.Windows.Forms.Label();
            this.waiter_label = new System.Windows.Forms.Label();
            this.open_time_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.new_ticket_panel = new System.Windows.Forms.Panel();
            this.no_oppen_label = new System.Windows.Forms.Label();
            this.new_ticket_but = new Guna.UI2.WinForms.Guna2Button();
            this.back_panel.SuspendLayout();
            this.tabels_panel.SuspendLayout();
            this.closed_tickets_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.details_grid)).BeginInit();
            this.current_ticket_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_grid)).BeginInit();
            this.new_ticket_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "chair.png");
            // 
            // back_panel
            // 
            this.back_panel.BackColor = System.Drawing.Color.Transparent;
            this.back_panel.Controls.Add(this.closed_tickets_panel);
            this.back_panel.Controls.Add(this.current_ticket_panel);
            this.back_panel.Controls.Add(this.tables_orders_label);
            this.back_panel.Controls.Add(this.tabels_panel);
            this.back_panel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.back_panel.Location = new System.Drawing.Point(10, 5);
            this.back_panel.Name = "back_panel";
            this.back_panel.Radius = 5;
            this.back_panel.ShadowColor = System.Drawing.Color.Black;
            this.back_panel.ShadowShift = 10;
            this.back_panel.Size = new System.Drawing.Size(1780, 950);
            this.back_panel.TabIndex = 2;
            // 
            // tabels_panel
            // 
            this.tabels_panel.BackColor = System.Drawing.Color.Transparent;
            this.tabels_panel.Controls.Add(this.flowLayoutPanel1);
            this.tabels_panel.Controls.Add(this.label1);
            this.tabels_panel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tabels_panel.Location = new System.Drawing.Point(25, 19);
            this.tabels_panel.Name = "tabels_panel";
            this.tabels_panel.Radius = 5;
            this.tabels_panel.ShadowColor = System.Drawing.Color.Black;
            this.tabels_panel.ShadowShift = 10;
            this.tabels_panel.Size = new System.Drawing.Size(1730, 220);
            this.tabels_panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tables :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(98, 26);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1597, 170);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tables_orders_label
            // 
            this.tables_orders_label.AutoSize = true;
            this.tables_orders_label.Font = new System.Drawing.Font("Inter Semi Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_orders_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.tables_orders_label.Location = new System.Drawing.Point(749, 260);
            this.tables_orders_label.Name = "tables_orders_label";
            this.tables_orders_label.Size = new System.Drawing.Size(258, 39);
            this.tables_orders_label.TabIndex = 3;
            this.tables_orders_label.Text = "Table\'s Tickets";
            // 
            // closed_tickets_panel
            // 
            this.closed_tickets_panel.BackColor = System.Drawing.Color.Transparent;
            this.closed_tickets_panel.Controls.Add(this.details_grid);
            this.closed_tickets_panel.Controls.Add(this.old_tickets_label);
            this.closed_tickets_panel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.closed_tickets_panel.Location = new System.Drawing.Point(1064, 312);
            this.closed_tickets_panel.Name = "closed_tickets_panel";
            this.closed_tickets_panel.Radius = 5;
            this.closed_tickets_panel.ShadowColor = System.Drawing.Color.Black;
            this.closed_tickets_panel.ShadowShift = 10;
            this.closed_tickets_panel.Size = new System.Drawing.Size(686, 622);
            this.closed_tickets_panel.TabIndex = 5;
            // 
            // details_grid
            // 
            this.details_grid.AllowUserToAddRows = false;
            this.details_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.details_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.details_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.details_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.details_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.details_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.details_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.details_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.details_grid.ColumnHeadersHeight = 25;
            this.details_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.details_grid.DefaultCellStyle = dataGridViewCellStyle33;
            this.details_grid.EnableHeadersVisualStyles = false;
            this.details_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.details_grid.Location = new System.Drawing.Point(19, 61);
            this.details_grid.Name = "details_grid";
            this.details_grid.ReadOnly = true;
            this.details_grid.RowHeadersVisible = false;
            this.details_grid.RowTemplate.Height = 20;
            this.details_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.details_grid.Size = new System.Drawing.Size(637, 537);
            this.details_grid.TabIndex = 6;
            this.details_grid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.details_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.details_grid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.details_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.details_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.details_grid.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.details_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.details_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.details_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.details_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.details_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.details_grid.ThemeStyle.HeaderStyle.Height = 25;
            this.details_grid.ThemeStyle.ReadOnly = true;
            this.details_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.details_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.details_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.details_grid.ThemeStyle.RowsStyle.Height = 20;
            this.details_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.details_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            // 
            // old_tickets_label
            // 
            this.old_tickets_label.AutoSize = true;
            this.old_tickets_label.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.old_tickets_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.old_tickets_label.Location = new System.Drawing.Point(14, 15);
            this.old_tickets_label.Name = "old_tickets_label";
            this.old_tickets_label.Size = new System.Drawing.Size(169, 25);
            this.old_tickets_label.TabIndex = 3;
            this.old_tickets_label.Text = "Closed Tickets :";
            // 
            // current_ticket_panel
            // 
            this.current_ticket_panel.BackColor = System.Drawing.Color.Transparent;
            this.current_ticket_panel.Controls.Add(this.new_ticket_panel);
            this.current_ticket_panel.Controls.Add(this.label4);
            this.current_ticket_panel.Controls.Add(this.open_time_label);
            this.current_ticket_panel.Controls.Add(this.waiter_label);
            this.current_ticket_panel.Controls.Add(this.orders_grid);
            this.current_ticket_panel.Controls.Add(this.current_label);
            this.current_ticket_panel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.current_ticket_panel.Location = new System.Drawing.Point(19, 312);
            this.current_ticket_panel.Name = "current_ticket_panel";
            this.current_ticket_panel.Radius = 5;
            this.current_ticket_panel.ShadowColor = System.Drawing.Color.Black;
            this.current_ticket_panel.ShadowShift = 10;
            this.current_ticket_panel.Size = new System.Drawing.Size(988, 622);
            this.current_ticket_panel.TabIndex = 4;
            // 
            // orders_grid
            // 
            this.orders_grid.AllowUserToAddRows = false;
            this.orders_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.orders_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
            this.orders_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orders_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.orders_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orders_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orders_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orders_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.orders_grid.ColumnHeadersHeight = 25;
            this.orders_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orders_grid.DefaultCellStyle = dataGridViewCellStyle36;
            this.orders_grid.EnableHeadersVisualStyles = false;
            this.orders_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orders_grid.Location = new System.Drawing.Point(38, 125);
            this.orders_grid.Name = "orders_grid";
            this.orders_grid.ReadOnly = true;
            this.orders_grid.RowHeadersVisible = false;
            this.orders_grid.RowTemplate.Height = 20;
            this.orders_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orders_grid.Size = new System.Drawing.Size(917, 476);
            this.orders_grid.TabIndex = 5;
            this.orders_grid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.orders_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.orders_grid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.orders_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.orders_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.orders_grid.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.orders_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orders_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.orders_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.orders_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.orders_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.orders_grid.ThemeStyle.HeaderStyle.Height = 25;
            this.orders_grid.ThemeStyle.ReadOnly = true;
            this.orders_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.orders_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orders_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.orders_grid.ThemeStyle.RowsStyle.Height = 20;
            this.orders_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.orders_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            // 
            // current_label
            // 
            this.current_label.AutoSize = true;
            this.current_label.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.current_label.Location = new System.Drawing.Point(14, 18);
            this.current_label.Name = "current_label";
            this.current_label.Size = new System.Drawing.Size(162, 25);
            this.current_label.TabIndex = 4;
            this.current_label.Text = "Current Ticket :";
            // 
            // waiter_label
            // 
            this.waiter_label.AutoSize = true;
            this.waiter_label.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waiter_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.waiter_label.Location = new System.Drawing.Point(438, 18);
            this.waiter_label.Name = "waiter_label";
            this.waiter_label.Size = new System.Drawing.Size(88, 25);
            this.waiter_label.TabIndex = 6;
            this.waiter_label.Text = "Waiter :";
            // 
            // open_time_label
            // 
            this.open_time_label.AutoSize = true;
            this.open_time_label.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_time_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.open_time_label.Location = new System.Drawing.Point(44, 61);
            this.open_time_label.Name = "open_time_label";
            this.open_time_label.Size = new System.Drawing.Size(132, 25);
            this.open_time_label.TabIndex = 7;
            this.open_time_label.Text = "Open Time :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.label4.Location = new System.Drawing.Point(449, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Content";
            // 
            // new_ticket_panel
            // 
            this.new_ticket_panel.Controls.Add(this.new_ticket_but);
            this.new_ticket_panel.Controls.Add(this.no_oppen_label);
            this.new_ticket_panel.Location = new System.Drawing.Point(19, 18);
            this.new_ticket_panel.Name = "new_ticket_panel";
            this.new_ticket_panel.Size = new System.Drawing.Size(948, 583);
            this.new_ticket_panel.TabIndex = 9;
            // 
            // no_oppen_label
            // 
            this.no_oppen_label.AutoSize = true;
            this.no_oppen_label.Font = new System.Drawing.Font("Inter Semi Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_oppen_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.no_oppen_label.Location = new System.Drawing.Point(341, 104);
            this.no_oppen_label.Name = "no_oppen_label";
            this.no_oppen_label.Size = new System.Drawing.Size(305, 39);
            this.no_oppen_label.TabIndex = 4;
            this.no_oppen_label.Text = "No Oppen Tickets";
            // 
            // new_ticket_but
            // 
            this.new_ticket_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.new_ticket_but.BorderRadius = 20;
            this.new_ticket_but.CheckedState.Parent = this.new_ticket_but;
            this.new_ticket_but.CustomImages.Parent = this.new_ticket_but;
            this.new_ticket_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.new_ticket_but.Font = new System.Drawing.Font("Inter Semi Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_ticket_but.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.new_ticket_but.HoverState.Parent = this.new_ticket_but;
            this.new_ticket_but.ImageSize = new System.Drawing.Size(40, 40);
            this.new_ticket_but.Location = new System.Drawing.Point(333, 258);
            this.new_ticket_but.Name = "new_ticket_but";
            this.new_ticket_but.ShadowDecoration.Parent = this.new_ticket_but;
            this.new_ticket_but.Size = new System.Drawing.Size(320, 143);
            this.new_ticket_but.TabIndex = 5;
            this.new_ticket_but.Text = "Open New Ticket";
            this.new_ticket_but.Click += new System.EventHandler(this.new_ticket_but_Click);
            // 
            // tickets_cont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.back_panel);
            this.Location = new System.Drawing.Point(109, 88);
            this.Name = "tickets_cont";
            this.Size = new System.Drawing.Size(1800, 960);
            this.back_panel.ResumeLayout(false);
            this.back_panel.PerformLayout();
            this.tabels_panel.ResumeLayout(false);
            this.tabels_panel.PerformLayout();
            this.closed_tickets_panel.ResumeLayout(false);
            this.closed_tickets_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.details_grid)).EndInit();
            this.current_ticket_panel.ResumeLayout(false);
            this.current_ticket_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_grid)).EndInit();
            this.new_ticket_panel.ResumeLayout(false);
            this.new_ticket_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private Guna.UI2.WinForms.Guna2ShadowPanel back_panel;
        private Guna.UI2.WinForms.Guna2ShadowPanel tabels_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label tables_orders_label;
        private Guna.UI2.WinForms.Guna2ShadowPanel closed_tickets_panel;
        private Guna.UI2.WinForms.Guna2DataGridView details_grid;
        private System.Windows.Forms.Label old_tickets_label;
        private Guna.UI2.WinForms.Guna2ShadowPanel current_ticket_panel;
        private Guna.UI2.WinForms.Guna2DataGridView orders_grid;
        private System.Windows.Forms.Label current_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label open_time_label;
        private System.Windows.Forms.Label waiter_label;
        private System.Windows.Forms.Panel new_ticket_panel;
        private System.Windows.Forms.Label no_oppen_label;
        private Guna.UI2.WinForms.Guna2Button new_ticket_but;
    }
}
