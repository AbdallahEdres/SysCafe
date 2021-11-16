
namespace SysCafé
{
    partial class worker_profile_cont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(worker_profile_cont));
            this.menu_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.id_lbl = new System.Windows.Forms.Label();
            this.save_but = new Guna.UI2.WinForms.Guna2Button();
            this.type_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.phone_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.adress_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.name_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.age_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.edit_but = new FontAwesome.Sharp.IconButton();
            this.id_lable = new System.Windows.Forms.Label();
            this.adress_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.worker_pic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.name_lable = new System.Windows.Forms.Label();
            this.workers_pic = new System.Windows.Forms.ImageList(this.components);
            this.menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worker_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.Transparent;
            this.menu_panel.Controls.Add(this.id_lbl);
            this.menu_panel.Controls.Add(this.save_but);
            this.menu_panel.Controls.Add(this.type_txt);
            this.menu_panel.Controls.Add(this.phone_txt);
            this.menu_panel.Controls.Add(this.adress_txt);
            this.menu_panel.Controls.Add(this.name_txt);
            this.menu_panel.Controls.Add(this.age_txt);
            this.menu_panel.Controls.Add(this.edit_but);
            this.menu_panel.Controls.Add(this.id_lable);
            this.menu_panel.Controls.Add(this.adress_label);
            this.menu_panel.Controls.Add(this.type_label);
            this.menu_panel.Controls.Add(this.phone_label);
            this.menu_panel.Controls.Add(this.age_label);
            this.menu_panel.Controls.Add(this.worker_pic);
            this.menu_panel.Controls.Add(this.name_lable);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_panel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Radius = 10;
            this.menu_panel.ShadowColor = System.Drawing.Color.Black;
            this.menu_panel.ShadowShift = 10;
            this.menu_panel.Size = new System.Drawing.Size(1785, 939);
            this.menu_panel.TabIndex = 9;
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.id_lbl.Font = new System.Drawing.Font("Inter Semi Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.id_lbl.Location = new System.Drawing.Point(767, 321);
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
            this.save_but.Location = new System.Drawing.Point(1179, 242);
            this.save_but.Name = "save_but";
            this.save_but.ShadowDecoration.Parent = this.save_but;
            this.save_but.Size = new System.Drawing.Size(154, 63);
            this.save_but.TabIndex = 37;
            this.save_but.Text = "Save changes";
            this.save_but.Visible = false;
            this.save_but.Click += new System.EventHandler(this.save_but_Click);
            // 
            // type_txt
            // 
            this.type_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.type_txt.BorderRadius = 10;
            this.type_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.type_txt.DefaultText = "";
            this.type_txt.DisabledState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.type_txt.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.type_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.type_txt.DisabledState.Parent = this.type_txt;
            this.type_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.type_txt.Enabled = false;
            this.type_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.type_txt.FocusedState.Parent = this.type_txt;
            this.type_txt.Font = new System.Drawing.Font("Inter Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.type_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.type_txt.HoverState.Parent = this.type_txt;
            this.type_txt.Location = new System.Drawing.Point(665, 686);
            this.type_txt.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.type_txt.Name = "type_txt";
            this.type_txt.PasswordChar = '\0';
            this.type_txt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.type_txt.PlaceholderText = "";
            this.type_txt.SelectedText = "";
            this.type_txt.ShadowDecoration.Parent = this.type_txt;
            this.type_txt.Size = new System.Drawing.Size(400, 45);
            this.type_txt.TabIndex = 36;
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
            this.phone_txt.Location = new System.Drawing.Point(665, 594);
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
            this.adress_txt.Location = new System.Drawing.Point(665, 794);
            this.adress_txt.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.adress_txt.Name = "adress_txt";
            this.adress_txt.PasswordChar = '\0';
            this.adress_txt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.adress_txt.PlaceholderText = "";
            this.adress_txt.SelectedText = "";
            this.adress_txt.ShadowDecoration.Parent = this.adress_txt;
            this.adress_txt.Size = new System.Drawing.Size(400, 45);
            this.adress_txt.TabIndex = 33;
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
            this.name_txt.Location = new System.Drawing.Point(665, 410);
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
            // age_txt
            // 
            this.age_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.age_txt.BorderRadius = 10;
            this.age_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.age_txt.DefaultText = "";
            this.age_txt.DisabledState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.age_txt.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.age_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.age_txt.DisabledState.Parent = this.age_txt;
            this.age_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.age_txt.Enabled = false;
            this.age_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.age_txt.FocusedState.Parent = this.age_txt;
            this.age_txt.Font = new System.Drawing.Font("Inter Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.age_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.age_txt.HoverState.Parent = this.age_txt;
            this.age_txt.Location = new System.Drawing.Point(665, 502);
            this.age_txt.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.age_txt.Name = "age_txt";
            this.age_txt.PasswordChar = '\0';
            this.age_txt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.age_txt.PlaceholderText = "";
            this.age_txt.SelectedText = "";
            this.age_txt.ShadowDecoration.Parent = this.age_txt;
            this.age_txt.Size = new System.Drawing.Size(400, 45);
            this.age_txt.TabIndex = 31;
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
            this.edit_but.Location = new System.Drawing.Point(1369, 242);
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
            this.id_lable.Location = new System.Drawing.Point(837, 321);
            this.id_lable.Name = "id_lable";
            this.id_lable.Size = new System.Drawing.Size(0, 33);
            this.id_lable.TabIndex = 15;
            // 
            // adress_label
            // 
            this.adress_label.AutoSize = true;
            this.adress_label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adress_label.Font = new System.Drawing.Font("Inter Semi Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adress_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.adress_label.Location = new System.Drawing.Point(312, 800);
            this.adress_label.Name = "adress_label";
            this.adress_label.Size = new System.Drawing.Size(130, 33);
            this.adress_label.TabIndex = 14;
            this.adress_label.Text = "Adress :";
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.type_label.Font = new System.Drawing.Font("Inter Semi Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.type_label.Location = new System.Drawing.Point(340, 692);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(102, 33);
            this.type_label.TabIndex = 13;
            this.type_label.Text = "Type :";
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.phone_label.Font = new System.Drawing.Font("Inter Semi Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.phone_label.Location = new System.Drawing.Point(321, 600);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(121, 33);
            this.phone_label.TabIndex = 12;
            this.phone_label.Text = "Phone :";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.age_label.Font = new System.Drawing.Font("Inter Semi Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.age_label.Location = new System.Drawing.Point(355, 508);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(87, 33);
            this.age_label.TabIndex = 11;
            this.age_label.Text = "Age :";
            // 
            // worker_pic
            // 
            this.worker_pic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.worker_pic.Location = new System.Drawing.Point(765, 105);
            this.worker_pic.Name = "worker_pic";
            this.worker_pic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.worker_pic.ShadowDecoration.Parent = this.worker_pic;
            this.worker_pic.Size = new System.Drawing.Size(200, 200);
            this.worker_pic.TabIndex = 10;
            this.worker_pic.TabStop = false;
            // 
            // name_lable
            // 
            this.name_lable.AutoSize = true;
            this.name_lable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.name_lable.Font = new System.Drawing.Font("Inter Semi Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.name_lable.Location = new System.Drawing.Point(327, 416);
            this.name_lable.Name = "name_lable";
            this.name_lable.Size = new System.Drawing.Size(115, 33);
            this.name_lable.TabIndex = 9;
            this.name_lable.Text = "Name :";
            // 
            // workers_pic
            // 
            this.workers_pic.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("workers_pic.ImageStream")));
            this.workers_pic.TransparentColor = System.Drawing.Color.Transparent;
            this.workers_pic.Images.SetKeyName(0, "technician.png");
            // 
            // worker_profile_cont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.menu_panel);
            this.Location = new System.Drawing.Point(109, 88);
            this.Name = "worker_profile_cont";
            this.Size = new System.Drawing.Size(1785, 939);
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worker_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel menu_panel;
        private System.Windows.Forms.Label id_lbl;
        private Guna.UI2.WinForms.Guna2Button save_but;
        private Guna.UI2.WinForms.Guna2TextBox type_txt;
        private Guna.UI2.WinForms.Guna2TextBox phone_txt;
        private Guna.UI2.WinForms.Guna2TextBox adress_txt;
        private Guna.UI2.WinForms.Guna2TextBox name_txt;
        private Guna.UI2.WinForms.Guna2TextBox age_txt;
        private FontAwesome.Sharp.IconButton edit_but;
        private System.Windows.Forms.Label id_lable;
        private System.Windows.Forms.Label adress_label;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label age_label;
        private Guna.UI2.WinForms.Guna2CirclePictureBox worker_pic;
        private System.Windows.Forms.Label name_lable;
        private System.Windows.Forms.ImageList workers_pic;
    }
}
