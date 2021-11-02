
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
            this.menu_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tickets_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.recipt_label = new System.Windows.Forms.Label();
            this.open_tkts_label = new System.Windows.Forms.Label();
            this.delivery_radio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.takeaway_radio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.tabels_radio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.closed_label = new System.Windows.Forms.Label();
            this.open_label = new System.Windows.Forms.Label();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.close_tkt_but = new Guna.UI2.WinForms.Guna2Button();
            this.menu_panel.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tickets_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.Transparent;
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
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.closed_label);
            this.guna2ShadowPanel1.Controls.Add(this.open_label);
            this.guna2ShadowPanel1.Controls.Add(this.guna2ToggleSwitch1);
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
            // tickets_grid
            // 
            this.tickets_grid.AllowUserToAddRows = false;
            this.tickets_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.tickets_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tickets_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tickets_grid.BackgroundColor = System.Drawing.Color.White;
            this.tickets_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tickets_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tickets_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tickets_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tickets_grid.ColumnHeadersHeight = 25;
            this.tickets_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tickets_grid.DefaultCellStyle = dataGridViewCellStyle3;
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
            // delivery_radio
            // 
            this.delivery_radio.AutoSize = true;
            this.delivery_radio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.delivery_radio.CheckedState.BorderThickness = 0;
            this.delivery_radio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.delivery_radio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.delivery_radio.CheckedState.InnerOffset = -4;
            this.delivery_radio.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivery_radio.Location = new System.Drawing.Point(383, 108);
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
            this.takeaway_radio.Location = new System.Drawing.Point(571, 108);
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
            this.tabels_radio.Location = new System.Drawing.Point(178, 108);
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
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(383, 143);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.ShadowDecoration.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(58, 21);
            this.guna2ToggleSwitch1.TabIndex = 26;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.Parent = this.guna2ToggleSwitch1;
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
            this.close_tkt_but.Location = new System.Drawing.Point(312, 854);
            this.close_tkt_but.Name = "close_tkt_but";
            this.close_tkt_but.ShadowDecoration.Parent = this.close_tkt_but;
            this.close_tkt_but.Size = new System.Drawing.Size(232, 70);
            this.close_tkt_but.TabIndex = 20;
            this.close_tkt_but.Text = "Close Ticket";
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
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private Guna.UI2.WinForms.Guna2Button close_tkt_but;
    }
}
