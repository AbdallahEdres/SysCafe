
namespace SysCafé
{
    partial class menu_cashier_cont
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_cashier_cont));
            this.panel1 = new System.Windows.Forms.Panel();
            this.price_label = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.save_order_but = new Guna.UI2.WinForms.Guna2Button();
            this.orders_label = new System.Windows.Forms.Label();
            this.order_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.menu_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.menu_image = new System.Windows.Forms.ImageList(this.components);
            this.make_order_label = new System.Windows.Forms.Label();
            this.order_num_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_grid)).BeginInit();
            this.menu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.price_label);
            this.panel1.Controls.Add(this.total_label);
            this.panel1.Controls.Add(this.save_order_but);
            this.panel1.Controls.Add(this.orders_label);
            this.panel1.Controls.Add(this.order_grid);
            this.panel1.Location = new System.Drawing.Point(1134, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 933);
            this.panel1.TabIndex = 3;
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.price_label.Location = new System.Drawing.Point(453, 873);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(67, 25);
            this.price_label.TabIndex = 10;
            this.price_label.Text = "200$";
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.total_label.Location = new System.Drawing.Point(428, 829);
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
            this.save_order_but.Location = new System.Drawing.Point(80, 819);
            this.save_order_but.Name = "save_order_but";
            this.save_order_but.ShadowDecoration.Parent = this.save_order_but;
            this.save_order_but.Size = new System.Drawing.Size(206, 75);
            this.save_order_but.TabIndex = 8;
            this.save_order_but.Text = "Done!";
            // 
            // orders_label
            // 
            this.orders_label.AutoSize = true;
            this.orders_label.Font = new System.Drawing.Font("Inter Semi Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.orders_label.Location = new System.Drawing.Point(273, 32);
            this.orders_label.Name = "orders_label";
            this.orders_label.Size = new System.Drawing.Size(106, 39);
            this.orders_label.TabIndex = 7;
            this.orders_label.Text = "Order";
            // 
            // order_grid
            // 
            this.order_grid.AllowUserToAddRows = false;
            this.order_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.order_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.order_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.order_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.order_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.order_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.order_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.order_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.order_grid.ColumnHeadersHeight = 25;
            this.order_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.order_grid.DefaultCellStyle = dataGridViewCellStyle3;
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
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.Transparent;
            this.menu_panel.Controls.Add(this.flowLayoutPanel2);
            this.menu_panel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.menu_panel.Location = new System.Drawing.Point(1, 111);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Radius = 10;
            this.menu_panel.ShadowColor = System.Drawing.Color.Black;
            this.menu_panel.ShadowShift = 10;
            this.menu_panel.Size = new System.Drawing.Size(1127, 825);
            this.menu_panel.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(30, 27);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1077, 867);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // menu_image
            // 
            this.menu_image.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menu_image.ImageStream")));
            this.menu_image.TransparentColor = System.Drawing.Color.Transparent;
            this.menu_image.Images.SetKeyName(0, "coffee-cup.png");
            // 
            // make_order_label
            // 
            this.make_order_label.AutoSize = true;
            this.make_order_label.Font = new System.Drawing.Font("Inter Semi Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.make_order_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.make_order_label.Location = new System.Drawing.Point(243, 35);
            this.make_order_label.Name = "make_order_label";
            this.make_order_label.Size = new System.Drawing.Size(288, 39);
            this.make_order_label.TabIndex = 9;
            this.make_order_label.Text = "Make Order NO. ";
            // 
            // order_num_label
            // 
            this.order_num_label.AutoSize = true;
            this.order_num_label.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_num_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.order_num_label.Location = new System.Drawing.Point(522, 41);
            this.order_num_label.Name = "order_num_label";
            this.order_num_label.Size = new System.Drawing.Size(237, 33);
            this.order_num_label.TabIndex = 10;
            this.order_num_label.Text = "Make Order NO. ";
            // 
            // menu_cashier_cont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.order_num_label);
            this.Controls.Add(this.make_order_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu_panel);
            this.Location = new System.Drawing.Point(109, 88);
            this.Name = "menu_cashier_cont";
            this.Size = new System.Drawing.Size(1785, 939);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_grid)).EndInit();
            this.menu_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label total_label;
        private Guna.UI2.WinForms.Guna2Button save_order_but;
        private System.Windows.Forms.Label orders_label;
        private Guna.UI2.WinForms.Guna2DataGridView order_grid;
        private Guna.UI2.WinForms.Guna2ShadowPanel menu_panel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ImageList menu_image;
        private System.Windows.Forms.Label make_order_label;
        private System.Windows.Forms.Label order_num_label;
    }
}
