
namespace SysCafé
{
    partial class customers_cont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customers_cont));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customer_piclist = new System.Windows.Forms.ImageList(this.components);
            this.id_lbl = new System.Windows.Forms.Label();
            this.save_but = new Guna.UI2.WinForms.Guna2Button();
            this.email_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.phone_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.pin_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.name_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.adress_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.list_label = new System.Windows.Forms.Label();
            this.customer_list_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.edit_but = new FontAwesome.Sharp.IconButton();
            this.id_lable = new System.Windows.Forms.Label();
            this.pin_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.adress_label = new System.Windows.Forms.Label();
            this.customer_pic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.name_lable = new System.Windows.Forms.Label();
            this.info_lable = new System.Windows.Forms.Label();
            this.menu_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.new_customer_but = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.customer_list_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_pic)).BeginInit();
            this.menu_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customer_piclist
            // 
            this.customer_piclist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("customer_piclist.ImageStream")));
            this.customer_piclist.TransparentColor = System.Drawing.Color.Transparent;
            this.customer_piclist.Images.SetKeyName(0, "technician.png");
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.id_lbl.Font = new System.Drawing.Font("Inter Semi Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.id_lbl.Location = new System.Drawing.Point(520, 314);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(64, 33);
            this.id_lbl.TabIndex = 38;
            this.id_lbl.Text = "ID :";
            // 
            // save_but
            // 
            this.save_but.BackColor = System.Drawing.Color.Transparent;
            this.save_but.BorderRadius = 15;
            this.save_but.CheckedState.Parent = this.save_but;
            this.save_but.CustomImages.Parent = this.save_but;
            this.save_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.save_but.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_but.ForeColor = System.Drawing.Color.White;
            this.save_but.HoverState.Parent = this.save_but;
            this.save_but.ImageOffset = new System.Drawing.Point(0, -2);
            this.save_but.ImageSize = new System.Drawing.Size(30, 30);
            this.save_but.Location = new System.Drawing.Point(932, 235);
            this.save_but.Name = "save_but";
            this.save_but.ShadowDecoration.Parent = this.save_but;
            this.save_but.Size = new System.Drawing.Size(154, 63);
            this.save_but.TabIndex = 37;
            this.save_but.Text = "Save changes";
            this.save_but.Visible = false;
            this.save_but.Click += new System.EventHandler(this.save_but_Click);
            // 
            // email_txt
            // 
            this.email_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.email_txt.BorderRadius = 10;
            this.email_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_txt.DefaultText = "";
            this.email_txt.DisabledState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.email_txt.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.email_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.email_txt.DisabledState.Parent = this.email_txt;
            this.email_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.email_txt.Enabled = false;
            this.email_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_txt.FocusedState.Parent = this.email_txt;
            this.email_txt.Font = new System.Drawing.Font("Inter Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.email_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_txt.HoverState.Parent = this.email_txt;
            this.email_txt.Location = new System.Drawing.Point(418, 679);
            this.email_txt.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.email_txt.Name = "email_txt";
            this.email_txt.PasswordChar = '\0';
            this.email_txt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.email_txt.PlaceholderText = "";
            this.email_txt.SelectedText = "";
            this.email_txt.ShadowDecoration.Parent = this.email_txt;
            this.email_txt.Size = new System.Drawing.Size(400, 45);
            this.email_txt.TabIndex = 36;
            // 
            // phone_txt
            // 
            this.phone_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.phone_txt.BorderRadius = 10;
            this.phone_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone_txt.DefaultText = "";
            this.phone_txt.DisabledState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.phone_txt.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.phone_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.phone_txt.DisabledState.Parent = this.phone_txt;
            this.phone_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.phone_txt.Enabled = false;
            this.phone_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone_txt.FocusedState.Parent = this.phone_txt;
            this.phone_txt.Font = new System.Drawing.Font("Inter Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.phone_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone_txt.HoverState.Parent = this.phone_txt;
            this.phone_txt.Location = new System.Drawing.Point(418, 587);
            this.phone_txt.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.PasswordChar = '\0';
            this.phone_txt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.phone_txt.PlaceholderText = "";
            this.phone_txt.SelectedText = "";
            this.phone_txt.ShadowDecoration.Parent = this.phone_txt;
            this.phone_txt.Size = new System.Drawing.Size(400, 45);
            this.phone_txt.TabIndex = 34;
            // 
            // pin_txt
            // 
            this.pin_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pin_txt.BorderRadius = 10;
            this.pin_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pin_txt.DefaultText = "";
            this.pin_txt.DisabledState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.pin_txt.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pin_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.pin_txt.DisabledState.Parent = this.pin_txt;
            this.pin_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.pin_txt.Enabled = false;
            this.pin_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pin_txt.FocusedState.Parent = this.pin_txt;
            this.pin_txt.Font = new System.Drawing.Font("Inter Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.pin_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pin_txt.HoverState.Parent = this.pin_txt;
            this.pin_txt.Location = new System.Drawing.Point(418, 787);
            this.pin_txt.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.pin_txt.Name = "pin_txt";
            this.pin_txt.PasswordChar = '\0';
            this.pin_txt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.pin_txt.PlaceholderText = "";
            this.pin_txt.SelectedText = "";
            this.pin_txt.ShadowDecoration.Parent = this.pin_txt;
            this.pin_txt.Size = new System.Drawing.Size(400, 45);
            this.pin_txt.TabIndex = 33;
            // 
            // name_txt
            // 
            this.name_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.name_txt.BorderRadius = 10;
            this.name_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_txt.DefaultText = "";
            this.name_txt.DisabledState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.name_txt.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.name_txt.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.name_txt.DisabledState.Parent = this.name_txt;
            this.name_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.name_txt.Enabled = false;
            this.name_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_txt.FocusedState.Parent = this.name_txt;
            this.name_txt.Font = new System.Drawing.Font("Inter Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.name_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_txt.HoverState.Parent = this.name_txt;
            this.name_txt.Location = new System.Drawing.Point(418, 403);
            this.name_txt.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.name_txt.Name = "name_txt";
            this.name_txt.PasswordChar = '\0';
            this.name_txt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.name_txt.PlaceholderText = "";
            this.name_txt.SelectedText = "";
            this.name_txt.ShadowDecoration.Parent = this.name_txt;
            this.name_txt.Size = new System.Drawing.Size(400, 45);
            this.name_txt.TabIndex = 32;
            // 
            // adress_txt
            // 
            this.adress_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adress_txt.BorderRadius = 10;
            this.adress_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adress_txt.DefaultText = "";
            this.adress_txt.DisabledState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.adress_txt.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.adress_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.adress_txt.DisabledState.Parent = this.adress_txt;
            this.adress_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.adress_txt.Enabled = false;
            this.adress_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adress_txt.FocusedState.Parent = this.adress_txt;
            this.adress_txt.Font = new System.Drawing.Font("Inter Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adress_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.adress_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adress_txt.HoverState.Parent = this.adress_txt;
            this.adress_txt.Location = new System.Drawing.Point(418, 495);
            this.adress_txt.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.adress_txt.Name = "adress_txt";
            this.adress_txt.PasswordChar = '\0';
            this.adress_txt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.adress_txt.PlaceholderText = "";
            this.adress_txt.SelectedText = "";
            this.adress_txt.ShadowDecoration.Parent = this.adress_txt;
            this.adress_txt.Size = new System.Drawing.Size(400, 45);
            this.adress_txt.TabIndex = 31;
            // 
            // list_label
            // 
            this.list_label.AutoSize = true;
            this.list_label.Font = new System.Drawing.Font("Inter Semi Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.list_label.Location = new System.Drawing.Point(137, 38);
            this.list_label.Name = "list_label";
            this.list_label.Size = new System.Drawing.Size(257, 39);
            this.list_label.TabIndex = 7;
            this.list_label.Text = "Customers List";
            // 
            // customer_list_grid
            // 
            this.customer_list_grid.AllowUserToAddRows = false;
            this.customer_list_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.customer_list_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.customer_list_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customer_list_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.customer_list_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customer_list_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.customer_list_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customer_list_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.customer_list_grid.ColumnHeadersHeight = 25;
            this.customer_list_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customer_list_grid.DefaultCellStyle = dataGridViewCellStyle6;
            this.customer_list_grid.EnableHeadersVisualStyles = false;
            this.customer_list_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customer_list_grid.Location = new System.Drawing.Point(0, 108);
            this.customer_list_grid.Name = "customer_list_grid";
            this.customer_list_grid.ReadOnly = true;
            this.customer_list_grid.RowHeadersVisible = false;
            this.customer_list_grid.RowTemplate.Height = 20;
            this.customer_list_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customer_list_grid.Size = new System.Drawing.Size(530, 675);
            this.customer_list_grid.TabIndex = 6;
            this.customer_list_grid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.customer_list_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.customer_list_grid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_list_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.customer_list_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.customer_list_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.customer_list_grid.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customer_list_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customer_list_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.customer_list_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.customer_list_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Inter Semi Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_list_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.customer_list_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customer_list_grid.ThemeStyle.HeaderStyle.Height = 25;
            this.customer_list_grid.ThemeStyle.ReadOnly = true;
            this.customer_list_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customer_list_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.customer_list_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_list_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.customer_list_grid.ThemeStyle.RowsStyle.Height = 20;
            this.customer_list_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.customer_list_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.customer_list_grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_list_grid_CellDoubleClick);
            // 
            // edit_but
            // 
            this.edit_but.BackColor = System.Drawing.Color.WhiteSmoke;
            this.edit_but.FlatAppearance.BorderSize = 0;
            this.edit_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_but.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.edit_but.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.edit_but.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.edit_but.IconSize = 80;
            this.edit_but.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_but.Location = new System.Drawing.Point(1122, 235);
            this.edit_but.Name = "edit_but";
            this.edit_but.Size = new System.Drawing.Size(76, 63);
            this.edit_but.TabIndex = 16;
            this.edit_but.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_but.UseVisualStyleBackColor = false;
            this.edit_but.Click += new System.EventHandler(this.edit_but_Click);
            // 
            // id_lable
            // 
            this.id_lable.AutoSize = true;
            this.id_lable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.id_lable.Font = new System.Drawing.Font("Inter Semi Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.id_lable.Location = new System.Drawing.Point(590, 314);
            this.id_lable.Name = "id_lable";
            this.id_lable.Size = new System.Drawing.Size(0, 33);
            this.id_lable.TabIndex = 15;
            // 
            // pin_label
            // 
            this.pin_label.AutoSize = true;
            this.pin_label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pin_label.Font = new System.Drawing.Font("Inter Semi Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.pin_label.Location = new System.Drawing.Point(114, 799);
            this.pin_label.Name = "pin_label";
            this.pin_label.Size = new System.Drawing.Size(160, 33);
            this.pin_label.TabIndex = 14;
            this.pin_label.Text = "Pin Code :";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.email_label.Font = new System.Drawing.Font("Inter Semi Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.email_label.Location = new System.Drawing.Point(154, 691);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(120, 33);
            this.email_label.TabIndex = 13;
            this.email_label.Text = "E Mail :";
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.phone_label.Font = new System.Drawing.Font("Inter Semi Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.phone_label.Location = new System.Drawing.Point(153, 599);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(121, 33);
            this.phone_label.TabIndex = 12;
            this.phone_label.Text = "Phone :";
            // 
            // adress_label
            // 
            this.adress_label.AutoSize = true;
            this.adress_label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adress_label.Font = new System.Drawing.Font("Inter Semi Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adress_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.adress_label.Location = new System.Drawing.Point(144, 507);
            this.adress_label.Name = "adress_label";
            this.adress_label.Size = new System.Drawing.Size(130, 33);
            this.adress_label.TabIndex = 11;
            this.adress_label.Text = "Adress :";
            // 
            // customer_pic
            // 
            this.customer_pic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customer_pic.Location = new System.Drawing.Point(518, 98);
            this.customer_pic.Name = "customer_pic";
            this.customer_pic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.customer_pic.ShadowDecoration.Parent = this.customer_pic;
            this.customer_pic.Size = new System.Drawing.Size(200, 200);
            this.customer_pic.TabIndex = 10;
            this.customer_pic.TabStop = false;
            // 
            // name_lable
            // 
            this.name_lable.AutoSize = true;
            this.name_lable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.name_lable.Font = new System.Drawing.Font("Inter Semi Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.name_lable.Location = new System.Drawing.Point(159, 415);
            this.name_lable.Name = "name_lable";
            this.name_lable.Size = new System.Drawing.Size(115, 33);
            this.name_lable.TabIndex = 9;
            this.name_lable.Text = "Name :";
            // 
            // info_lable
            // 
            this.info_lable.AutoSize = true;
            this.info_lable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.info_lable.Font = new System.Drawing.Font("Inter Semi Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_lable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.info_lable.Location = new System.Drawing.Point(505, 28);
            this.info_lable.Name = "info_lable";
            this.info_lable.Size = new System.Drawing.Size(268, 39);
            this.info_lable.TabIndex = 8;
            this.info_lable.Text = "Customer\'s Info";
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.Transparent;
            this.menu_panel.Controls.Add(this.id_lbl);
            this.menu_panel.Controls.Add(this.save_but);
            this.menu_panel.Controls.Add(this.email_txt);
            this.menu_panel.Controls.Add(this.phone_txt);
            this.menu_panel.Controls.Add(this.pin_txt);
            this.menu_panel.Controls.Add(this.name_txt);
            this.menu_panel.Controls.Add(this.adress_txt);
            this.menu_panel.Controls.Add(this.edit_but);
            this.menu_panel.Controls.Add(this.id_lable);
            this.menu_panel.Controls.Add(this.pin_label);
            this.menu_panel.Controls.Add(this.email_label);
            this.menu_panel.Controls.Add(this.phone_label);
            this.menu_panel.Controls.Add(this.adress_label);
            this.menu_panel.Controls.Add(this.customer_pic);
            this.menu_panel.Controls.Add(this.name_lable);
            this.menu_panel.Controls.Add(this.info_lable);
            this.menu_panel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.menu_panel.Location = new System.Drawing.Point(548, 1);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Radius = 10;
            this.menu_panel.ShadowColor = System.Drawing.Color.Black;
            this.menu_panel.ShadowShift = 10;
            this.menu_panel.Size = new System.Drawing.Size(1237, 936);
            this.menu_panel.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.new_customer_but);
            this.panel1.Controls.Add(this.list_label);
            this.panel1.Controls.Add(this.customer_list_grid);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 933);
            this.panel1.TabIndex = 9;
            // 
            // new_customer_but
            // 
            this.new_customer_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.new_customer_but.BorderRadius = 5;
            this.new_customer_but.CheckedState.Parent = this.new_customer_but;
            this.new_customer_but.CustomImages.Parent = this.new_customer_but;
            this.new_customer_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.new_customer_but.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_customer_but.ForeColor = System.Drawing.Color.White;
            this.new_customer_but.HoverState.Parent = this.new_customer_but;
            this.new_customer_but.Image = ((System.Drawing.Image)(resources.GetObject("new_customer_but.Image")));
            this.new_customer_but.ImageOffset = new System.Drawing.Point(0, -3);
            this.new_customer_but.Location = new System.Drawing.Point(168, 861);
            this.new_customer_but.Name = "new_customer_but";
            this.new_customer_but.ShadowDecoration.Parent = this.new_customer_but;
            this.new_customer_but.Size = new System.Drawing.Size(166, 48);
            this.new_customer_but.TabIndex = 8;
            this.new_customer_but.Text = "New Customer";
            this.new_customer_but.Click += new System.EventHandler(this.new_customer_but_Click);
            // 
            // customers_cont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.panel1);
            this.Name = "customers_cont";
            this.Size = new System.Drawing.Size(1785, 939);
            ((System.ComponentModel.ISupportInitialize)(this.customer_list_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_pic)).EndInit();
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList customer_piclist;
        private System.Windows.Forms.Label id_lbl;
        private Guna.UI2.WinForms.Guna2Button save_but;
        private Guna.UI2.WinForms.Guna2TextBox email_txt;
        private Guna.UI2.WinForms.Guna2TextBox phone_txt;
        private Guna.UI2.WinForms.Guna2TextBox pin_txt;
        private Guna.UI2.WinForms.Guna2TextBox name_txt;
        private Guna.UI2.WinForms.Guna2TextBox adress_txt;
        private System.Windows.Forms.Label list_label;
        private Guna.UI2.WinForms.Guna2DataGridView customer_list_grid;
        private FontAwesome.Sharp.IconButton edit_but;
        private System.Windows.Forms.Label id_lable;
        private System.Windows.Forms.Label pin_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label adress_label;
        private Guna.UI2.WinForms.Guna2CirclePictureBox customer_pic;
        private System.Windows.Forms.Label name_lable;
        private System.Windows.Forms.Label info_lable;
        private Guna.UI2.WinForms.Guna2ShadowPanel menu_panel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button new_customer_but;
    }
}
