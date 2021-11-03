
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.back_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.closed_tickets_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.closed_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.old_tickets_label = new System.Windows.Forms.Label();
            this.current_ticket_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.new_ticket_panel = new System.Windows.Forms.Panel();
            this.new_ticket_but = new Guna.UI2.WinForms.Guna2Button();
            this.no_oppen_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.open_time_label = new System.Windows.Forms.Label();
            this.waiter_label = new System.Windows.Forms.Label();
            this.orders_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.current_label = new System.Windows.Forms.Label();
            this.tables_orders_label = new System.Windows.Forms.Label();
            this.tabels_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.table_id_label = new System.Windows.Forms.Label();
            this.waiter_iname_label = new System.Windows.Forms.Label();
            this.open_time_value = new System.Windows.Forms.Label();
            this.back_panel.SuspendLayout();
            this.closed_tickets_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closed_grid)).BeginInit();
            this.current_ticket_panel.SuspendLayout();
            this.new_ticket_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_grid)).BeginInit();
            this.tabels_panel.SuspendLayout();
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
            // closed_tickets_panel
            // 
            this.closed_tickets_panel.BackColor = System.Drawing.Color.Transparent;
            this.closed_tickets_panel.Controls.Add(this.closed_grid);
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
            // closed_grid
            // 
            this.closed_grid.AllowUserToAddRows = false;
            this.closed_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.closed_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.closed_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.closed_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.closed_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.closed_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.closed_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.closed_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.closed_grid.ColumnHeadersHeight = 25;
            this.closed_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.closed_grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.closed_grid.EnableHeadersVisualStyles = false;
            this.closed_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.closed_grid.Location = new System.Drawing.Point(19, 61);
            this.closed_grid.Name = "closed_grid";
            this.closed_grid.ReadOnly = true;
            this.closed_grid.RowHeadersVisible = false;
            this.closed_grid.RowTemplate.Height = 20;
            this.closed_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.closed_grid.Size = new System.Drawing.Size(637, 537);
            this.closed_grid.TabIndex = 6;
            this.closed_grid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.closed_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.closed_grid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closed_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.closed_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.closed_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.closed_grid.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.closed_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.closed_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.closed_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.closed_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closed_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.closed_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.closed_grid.ThemeStyle.HeaderStyle.Height = 25;
            this.closed_grid.ThemeStyle.ReadOnly = true;
            this.closed_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.closed_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.closed_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closed_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.closed_grid.ThemeStyle.RowsStyle.Height = 20;
            this.closed_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.closed_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
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
            this.current_ticket_panel.Controls.Add(this.open_time_value);
            this.current_ticket_panel.Controls.Add(this.waiter_iname_label);
            this.current_ticket_panel.Controls.Add(this.table_id_label);
            this.current_ticket_panel.Controls.Add(this.new_ticket_panel);
            this.current_ticket_panel.Controls.Add(this.current_label);
            this.current_ticket_panel.Controls.Add(this.label4);
            this.current_ticket_panel.Controls.Add(this.waiter_label);
            this.current_ticket_panel.Controls.Add(this.open_time_label);
            this.current_ticket_panel.Controls.Add(this.orders_grid);
            this.current_ticket_panel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.current_ticket_panel.Location = new System.Drawing.Point(19, 312);
            this.current_ticket_panel.Name = "current_ticket_panel";
            this.current_ticket_panel.Radius = 5;
            this.current_ticket_panel.ShadowColor = System.Drawing.Color.Black;
            this.current_ticket_panel.ShadowShift = 10;
            this.current_ticket_panel.Size = new System.Drawing.Size(988, 622);
            this.current_ticket_panel.TabIndex = 4;
            // 
            // new_ticket_panel
            // 
            this.new_ticket_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.new_ticket_panel.Controls.Add(this.new_ticket_but);
            this.new_ticket_panel.Controls.Add(this.no_oppen_label);
            this.new_ticket_panel.Location = new System.Drawing.Point(17, 18);
            this.new_ticket_panel.Name = "new_ticket_panel";
            this.new_ticket_panel.Size = new System.Drawing.Size(948, 583);
            this.new_ticket_panel.TabIndex = 9;
            // 
            // new_ticket_but
            // 
            this.new_ticket_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.new_ticket_but.BackColor = System.Drawing.Color.Transparent;
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
            this.new_ticket_but.ShadowDecoration.BorderRadius = 0;
            this.new_ticket_but.ShadowDecoration.Parent = this.new_ticket_but;
            this.new_ticket_but.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.new_ticket_but.Size = new System.Drawing.Size(320, 143);
            this.new_ticket_but.TabIndex = 5;
            this.new_ticket_but.Text = "Open New Ticket";
            this.new_ticket_but.Click += new System.EventHandler(this.new_ticket_but_Click);
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
            // waiter_label
            // 
            this.waiter_label.AutoSize = true;
            this.waiter_label.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waiter_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.waiter_label.Location = new System.Drawing.Point(428, 15);
            this.waiter_label.Name = "waiter_label";
            this.waiter_label.Size = new System.Drawing.Size(88, 25);
            this.waiter_label.TabIndex = 6;
            this.waiter_label.Text = "Waiter :";
            // 
            // orders_grid
            // 
            this.orders_grid.AllowUserToAddRows = false;
            this.orders_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.orders_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.orders_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orders_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.orders_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orders_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orders_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orders_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.orders_grid.ColumnHeadersHeight = 25;
            this.orders_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orders_grid.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.current_label.Location = new System.Drawing.Point(12, 15);
            this.current_label.Name = "current_label";
            this.current_label.Size = new System.Drawing.Size(162, 25);
            this.current_label.TabIndex = 4;
            this.current_label.Text = "Current Ticket :";
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
            // table_id_label
            // 
            this.table_id_label.AutoSize = true;
            this.table_id_label.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_id_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.table_id_label.Location = new System.Drawing.Point(180, 15);
            this.table_id_label.Name = "table_id_label";
            this.table_id_label.Size = new System.Drawing.Size(17, 25);
            this.table_id_label.TabIndex = 6;
            this.table_id_label.Text = " ";
            // 
            // waiter_iname_label
            // 
            this.waiter_iname_label.AutoSize = true;
            this.waiter_iname_label.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waiter_iname_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.waiter_iname_label.Location = new System.Drawing.Point(522, 15);
            this.waiter_iname_label.Name = "waiter_iname_label";
            this.waiter_iname_label.Size = new System.Drawing.Size(17, 25);
            this.waiter_iname_label.TabIndex = 10;
            this.waiter_iname_label.Text = " ";
            // 
            // open_time_value
            // 
            this.open_time_value.AutoSize = true;
            this.open_time_value.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_time_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.open_time_value.Location = new System.Drawing.Point(182, 61);
            this.open_time_value.Name = "open_time_value";
            this.open_time_value.Size = new System.Drawing.Size(17, 25);
            this.open_time_value.TabIndex = 11;
            this.open_time_value.Text = " ";
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
            this.closed_tickets_panel.ResumeLayout(false);
            this.closed_tickets_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closed_grid)).EndInit();
            this.current_ticket_panel.ResumeLayout(false);
            this.current_ticket_panel.PerformLayout();
            this.new_ticket_panel.ResumeLayout(false);
            this.new_ticket_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_grid)).EndInit();
            this.tabels_panel.ResumeLayout(false);
            this.tabels_panel.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2DataGridView closed_grid;
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
        private System.Windows.Forms.Label table_id_label;
        private System.Windows.Forms.Label open_time_value;
        private System.Windows.Forms.Label waiter_iname_label;
    }
}
