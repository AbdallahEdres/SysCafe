

namespace SysCafé
{
    partial class menu_cont
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_cont));
            this.panel1 = new System.Windows.Forms.Panel();
            this.delete_but = new Guna.UI2.WinForms.Guna2Button();
            this.remove_but = new Guna.UI2.WinForms.Guna2Button();
            this.price_label = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.save_order_but = new Guna.UI2.WinForms.Guna2Button();
            this.tables_orders_label = new System.Windows.Forms.Label();
            this.order_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabel_image = new System.Windows.Forms.ImageList(this.components);
            this.menu_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.menu_image = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_grid)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.menu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.delete_but);
            this.panel1.Controls.Add(this.remove_but);
            this.panel1.Controls.Add(this.price_label);
            this.panel1.Controls.Add(this.total_label);
            this.panel1.Controls.Add(this.save_order_but);
            this.panel1.Controls.Add(this.tables_orders_label);
            this.panel1.Controls.Add(this.order_grid);
            this.panel1.Location = new System.Drawing.Point(1136, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 933);
            this.panel1.TabIndex = 0;
            // 
            // delete_but
            // 
            this.delete_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_but.BorderRadius = 15;
            this.delete_but.CheckedState.Parent = this.delete_but;
            this.delete_but.CustomImages.Parent = this.delete_but;
            this.delete_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.delete_but.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_but.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.delete_but.HoverState.Parent = this.delete_but;
            this.delete_but.ImageSize = new System.Drawing.Size(40, 40);
            this.delete_but.Location = new System.Drawing.Point(329, 790);
            this.delete_but.Name = "delete_but";
            this.delete_but.ShadowDecoration.Parent = this.delete_but;
            this.delete_but.Size = new System.Drawing.Size(30, 28);
            this.delete_but.TabIndex = 12;
            this.delete_but.Text = "X";
            this.delete_but.TextOffset = new System.Drawing.Point(-1, 1);
            this.delete_but.Click += new System.EventHandler(this.delete_but_Click);
            // 
            // remove_but
            // 
            this.remove_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.remove_but.BorderRadius = 15;
            this.remove_but.CheckedState.Parent = this.remove_but;
            this.remove_but.CustomImages.Parent = this.remove_but;
            this.remove_but.FillColor = System.Drawing.Color.Red;
            this.remove_but.Font = new System.Drawing.Font("Inter Semi Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_but.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.remove_but.HoverState.Parent = this.remove_but;
            this.remove_but.ImageSize = new System.Drawing.Size(40, 40);
            this.remove_but.Location = new System.Drawing.Point(293, 790);
            this.remove_but.Name = "remove_but";
            this.remove_but.ShadowDecoration.Parent = this.remove_but;
            this.remove_but.Size = new System.Drawing.Size(30, 28);
            this.remove_but.TabIndex = 11;
            this.remove_but.Text = "-";
            this.remove_but.Click += new System.EventHandler(this.remove_but_Click);
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.price_label.Location = new System.Drawing.Point(454, 898);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(0, 25);
            this.price_label.TabIndex = 10;
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.total_label.Location = new System.Drawing.Point(429, 854);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(116, 25);
            this.total_label.TabIndex = 9;
            this.total_label.Text = "Total Price";
            // 
            // save_order_but
            // 
            this.save_order_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save_order_but.BorderRadius = 20;
            this.save_order_but.CheckedState.Parent = this.save_order_but;
            this.save_order_but.CustomImages.Parent = this.save_order_but;
            this.save_order_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.save_order_but.Font = new System.Drawing.Font("Inter Semi Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_order_but.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.save_order_but.HoverState.Parent = this.save_order_but;
            this.save_order_but.ImageSize = new System.Drawing.Size(40, 40);
            this.save_order_but.Location = new System.Drawing.Point(80, 848);
            this.save_order_but.Name = "save_order_but";
            this.save_order_but.ShadowDecoration.Parent = this.save_order_but;
            this.save_order_but.Size = new System.Drawing.Size(206, 75);
            this.save_order_but.TabIndex = 8;
            this.save_order_but.Text = "Done!";
            // 
            // tables_orders_label
            // 
            this.tables_orders_label.AutoSize = true;
            this.tables_orders_label.Font = new System.Drawing.Font("Inter Semi Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_orders_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.tables_orders_label.Location = new System.Drawing.Point(199, 32);
            this.tables_orders_label.Name = "tables_orders_label";
            this.tables_orders_label.Size = new System.Drawing.Size(234, 39);
            this.tables_orders_label.TabIndex = 7;
            this.tables_orders_label.Text = "Table\'s Order";
            // 
            // order_grid
            // 
            this.order_grid.AllowUserToAddRows = false;
            this.order_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.order_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.order_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.order_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.order_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.order_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.order_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.order_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.order_grid.ColumnHeadersHeight = 25;
            this.order_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.order_grid.DefaultCellStyle = dataGridViewCellStyle6;
            this.order_grid.EnableHeadersVisualStyles = false;
            this.order_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.order_grid.Location = new System.Drawing.Point(17, 108);
            this.order_grid.Name = "order_grid";
            this.order_grid.ReadOnly = true;
            this.order_grid.RowHeadersVisible = false;
            this.order_grid.RowTemplate.Height = 20;
            this.order_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.order_grid.Size = new System.Drawing.Size(619, 676);
            this.order_grid.TabIndex = 6;
            this.order_grid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.order_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.order_grid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.order_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.order_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.order_grid.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.order_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.order_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.order_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.order_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.order_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.order_grid.ThemeStyle.HeaderStyle.Height = 25;
            this.order_grid.ThemeStyle.ReadOnly = true;
            this.order_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.order_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.order_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.order_grid.ThemeStyle.RowsStyle.Height = 20;
            this.order_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.order_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.order_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.order_grid_CellClick);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.flowLayoutPanel1);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 5;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 10;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1127, 160);
            this.guna2ShadowPanel1.TabIndex = 1;
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(98, 32);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1003, 110);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tabel_image
            // 
            this.tabel_image.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabel_image.ImageStream")));
            this.tabel_image.TransparentColor = System.Drawing.Color.Transparent;
            this.tabel_image.Images.SetKeyName(0, "chair.png");
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.Transparent;
            this.menu_panel.Controls.Add(this.flowLayoutPanel2);
            this.menu_panel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.menu_panel.Location = new System.Drawing.Point(3, 182);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Radius = 10;
            this.menu_panel.ShadowColor = System.Drawing.Color.Black;
            this.menu_panel.ShadowShift = 10;
            this.menu_panel.Size = new System.Drawing.Size(1127, 754);
            this.menu_panel.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(30, 27);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1077, 700);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // menu_image
            // 
            this.menu_image.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menu_image.ImageStream")));
            this.menu_image.TransparentColor = System.Drawing.Color.Transparent;
            this.menu_image.Images.SetKeyName(0, "coffee-cup.png");
            this.menu_image.Images.SetKeyName(1, "tea.jpg");
            this.menu_image.Images.SetKeyName(2, "5f18454f2f2914121973102fa0f9692b.jpg");
            // 
            // menu_cont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(109, 88);
            this.Name = "menu_cont";
            this.Size = new System.Drawing.Size(1785, 939);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_grid)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.menu_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ImageList tabel_image;
        private Guna.UI2.WinForms.Guna2ShadowPanel menu_panel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ImageList menu_image;
        private Guna.UI2.WinForms.Guna2DataGridView order_grid;
        private System.Windows.Forms.Label tables_orders_label;
        public Guna.UI2.WinForms.Guna2Button save_order_but;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label total_label;
        public Guna.UI2.WinForms.Guna2Button delete_but;
        public Guna.UI2.WinForms.Guna2Button remove_but;
    }
}
