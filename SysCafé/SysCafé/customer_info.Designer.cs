
namespace SysCafé
{
    partial class customer_info
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
            this.info_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.email_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.pin_label = new System.Windows.Forms.Label();
            this.adress_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.close_but = new Guna.UI2.WinForms.Guna2Button();
            this.add_but = new Guna.UI2.WinForms.Guna2Button();
            this.name__label = new System.Windows.Forms.Label();
            this.adress_label = new System.Windows.Forms.Label();
            this.customer_phone_label = new System.Windows.Forms.Label();
            this.pincode_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.phone_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.name_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saved_radio = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.another_radio = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.sub_adress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Font = new System.Drawing.Font("Inter Semi Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.info_label.Location = new System.Drawing.Point(202, 19);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(363, 39);
            this.info_label.TabIndex = 9;
            this.info_label.Text = "Customer Information";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Enabled = false;
            this.email_label.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(82, 496);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(151, 23);
            this.email_label.TabIndex = 24;
            this.email_label.Text = "Customer E Mail :";
            // 
            // email_txt
            // 
            this.email_txt.BorderRadius = 10;
            this.email_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_txt.DefaultText = "";
            this.email_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_txt.DisabledState.Parent = this.email_txt;
            this.email_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_txt.Enabled = false;
            this.email_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_txt.FocusedState.Parent = this.email_txt;
            this.email_txt.Font = new System.Drawing.Font("Inter Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.email_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_txt.HoverState.Parent = this.email_txt;
            this.email_txt.Location = new System.Drawing.Point(340, 484);
            this.email_txt.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.email_txt.Name = "email_txt";
            this.email_txt.PasswordChar = '\0';
            this.email_txt.PlaceholderText = "";
            this.email_txt.SelectedText = "";
            this.email_txt.ShadowDecoration.Parent = this.email_txt;
            this.email_txt.Size = new System.Drawing.Size(400, 45);
            this.email_txt.TabIndex = 23;
            // 
            // pin_label
            // 
            this.pin_label.AutoSize = true;
            this.pin_label.Enabled = false;
            this.pin_label.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin_label.Location = new System.Drawing.Point(144, 424);
            this.pin_label.Name = "pin_label";
            this.pin_label.Size = new System.Drawing.Size(89, 23);
            this.pin_label.TabIndex = 22;
            this.pin_label.Text = "PinCode :";
            // 
            // adress_txt
            // 
            this.adress_txt.BorderRadius = 10;
            this.adress_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adress_txt.DefaultText = "";
            this.adress_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adress_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adress_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adress_txt.DisabledState.Parent = this.adress_txt;
            this.adress_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adress_txt.Enabled = false;
            this.adress_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adress_txt.FocusedState.Parent = this.adress_txt;
            this.adress_txt.Font = new System.Drawing.Font("Inter Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adress_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.adress_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adress_txt.HoverState.Parent = this.adress_txt;
            this.adress_txt.Location = new System.Drawing.Point(340, 268);
            this.adress_txt.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.adress_txt.Name = "adress_txt";
            this.adress_txt.PasswordChar = '\0';
            this.adress_txt.PlaceholderText = "";
            this.adress_txt.SelectedText = "";
            this.adress_txt.ShadowDecoration.Parent = this.adress_txt;
            this.adress_txt.Size = new System.Drawing.Size(400, 45);
            this.adress_txt.TabIndex = 21;
            // 
            // close_but
            // 
            this.close_but.BackColor = System.Drawing.Color.Transparent;
            this.close_but.BorderRadius = 15;
            this.close_but.CheckedState.Parent = this.close_but;
            this.close_but.CustomImages.Parent = this.close_but;
            this.close_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.close_but.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_but.ForeColor = System.Drawing.Color.White;
            this.close_but.HoverState.Parent = this.close_but;
            this.close_but.ImageOffset = new System.Drawing.Point(0, -2);
            this.close_but.ImageSize = new System.Drawing.Size(30, 30);
            this.close_but.Location = new System.Drawing.Point(546, 586);
            this.close_but.Name = "close_but";
            this.close_but.ShadowDecoration.Parent = this.close_but;
            this.close_but.Size = new System.Drawing.Size(232, 70);
            this.close_but.TabIndex = 20;
            this.close_but.Text = "Close";
            this.close_but.Click += new System.EventHandler(this.close_but_Click);
            // 
            // add_but
            // 
            this.add_but.BackColor = System.Drawing.Color.Transparent;
            this.add_but.BorderRadius = 15;
            this.add_but.CheckedState.Parent = this.add_but;
            this.add_but.CustomImages.Parent = this.add_but;
            this.add_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.add_but.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_but.ForeColor = System.Drawing.Color.White;
            this.add_but.HoverState.Parent = this.add_but;
            this.add_but.ImageOffset = new System.Drawing.Point(0, -2);
            this.add_but.ImageSize = new System.Drawing.Size(30, 30);
            this.add_but.Location = new System.Drawing.Point(36, 586);
            this.add_but.Name = "add_but";
            this.add_but.ShadowDecoration.Parent = this.add_but;
            this.add_but.Size = new System.Drawing.Size(232, 70);
            this.add_but.TabIndex = 19;
            this.add_but.Text = "Done";
            this.add_but.Click += new System.EventHandler(this.add_but_Click);
            // 
            // name__label
            // 
            this.name__label.AutoSize = true;
            this.name__label.Enabled = false;
            this.name__label.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name__label.Location = new System.Drawing.Point(84, 208);
            this.name__label.Name = "name__label";
            this.name__label.Size = new System.Drawing.Size(149, 23);
            this.name__label.TabIndex = 18;
            this.name__label.Text = "Costomer Name :";
            // 
            // adress_label
            // 
            this.adress_label.AutoSize = true;
            this.adress_label.Enabled = false;
            this.adress_label.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adress_label.Location = new System.Drawing.Point(70, 280);
            this.adress_label.Name = "adress_label";
            this.adress_label.Size = new System.Drawing.Size(163, 23);
            this.adress_label.TabIndex = 17;
            this.adress_label.Text = "Customer Adress  :";
            // 
            // customer_phone_label
            // 
            this.customer_phone_label.AutoSize = true;
            this.customer_phone_label.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_phone_label.Location = new System.Drawing.Point(84, 136);
            this.customer_phone_label.Name = "customer_phone_label";
            this.customer_phone_label.Size = new System.Drawing.Size(154, 23);
            this.customer_phone_label.TabIndex = 16;
            this.customer_phone_label.Text = "Customer Phone :";
            // 
            // pincode_txt
            // 
            this.pincode_txt.BorderRadius = 10;
            this.pincode_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pincode_txt.DefaultText = "";
            this.pincode_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pincode_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pincode_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pincode_txt.DisabledState.Parent = this.pincode_txt;
            this.pincode_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pincode_txt.Enabled = false;
            this.pincode_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pincode_txt.FocusedState.Parent = this.pincode_txt;
            this.pincode_txt.Font = new System.Drawing.Font("Inter Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pincode_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.pincode_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pincode_txt.HoverState.Parent = this.pincode_txt;
            this.pincode_txt.Location = new System.Drawing.Point(340, 412);
            this.pincode_txt.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.pincode_txt.Name = "pincode_txt";
            this.pincode_txt.PasswordChar = '\0';
            this.pincode_txt.PlaceholderText = "";
            this.pincode_txt.SelectedText = "";
            this.pincode_txt.ShadowDecoration.Parent = this.pincode_txt;
            this.pincode_txt.Size = new System.Drawing.Size(400, 45);
            this.pincode_txt.TabIndex = 15;
            // 
            // phone_txt
            // 
            this.phone_txt.BorderRadius = 10;
            this.phone_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone_txt.DefaultText = "";
            this.phone_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phone_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phone_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phone_txt.DisabledState.Parent = this.phone_txt;
            this.phone_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phone_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone_txt.FocusedState.Parent = this.phone_txt;
            this.phone_txt.Font = new System.Drawing.Font("Inter Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.phone_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone_txt.HoverState.Parent = this.phone_txt;
            this.phone_txt.Location = new System.Drawing.Point(340, 124);
            this.phone_txt.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.PasswordChar = '\0';
            this.phone_txt.PlaceholderText = "";
            this.phone_txt.SelectedText = "";
            this.phone_txt.ShadowDecoration.Parent = this.phone_txt;
            this.phone_txt.Size = new System.Drawing.Size(400, 45);
            this.phone_txt.TabIndex = 14;
            this.phone_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phone_txt_KeyDown);
            // 
            // name_txt
            // 
            this.name_txt.BorderRadius = 10;
            this.name_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_txt.DefaultText = "";
            this.name_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_txt.DisabledState.Parent = this.name_txt;
            this.name_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_txt.Enabled = false;
            this.name_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_txt.FocusedState.Parent = this.name_txt;
            this.name_txt.Font = new System.Drawing.Font("Inter Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.name_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_txt.HoverState.Parent = this.name_txt;
            this.name_txt.Location = new System.Drawing.Point(340, 196);
            this.name_txt.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.name_txt.Name = "name_txt";
            this.name_txt.PasswordChar = '\0';
            this.name_txt.PlaceholderText = "";
            this.name_txt.SelectedText = "";
            this.name_txt.ShadowDecoration.Parent = this.name_txt;
            this.name_txt.Size = new System.Drawing.Size(400, 45);
            this.name_txt.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saved_radio
            // 
            this.saved_radio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saved_radio.CheckedState.BorderThickness = 0;
            this.saved_radio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.saved_radio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.saved_radio.CheckedState.Parent = this.saved_radio;
            this.saved_radio.Enabled = false;
            this.saved_radio.Location = new System.Drawing.Point(44, 283);
            this.saved_radio.Name = "saved_radio";
            this.saved_radio.ShadowDecoration.Parent = this.saved_radio;
            this.saved_radio.Size = new System.Drawing.Size(20, 20);
            this.saved_radio.TabIndex = 27;
            this.saved_radio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.saved_radio.UncheckedState.BorderThickness = 2;
            this.saved_radio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.saved_radio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.saved_radio.UncheckedState.Parent = this.saved_radio;
            // 
            // another_radio
            // 
            this.another_radio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.another_radio.CheckedState.BorderThickness = 0;
            this.another_radio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.another_radio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.another_radio.CheckedState.Parent = this.another_radio;
            this.another_radio.Enabled = false;
            this.another_radio.Location = new System.Drawing.Point(44, 355);
            this.another_radio.Name = "another_radio";
            this.another_radio.ShadowDecoration.Parent = this.another_radio;
            this.another_radio.Size = new System.Drawing.Size(20, 20);
            this.another_radio.TabIndex = 28;
            this.another_radio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.another_radio.UncheckedState.BorderThickness = 2;
            this.another_radio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.another_radio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.another_radio.UncheckedState.Parent = this.another_radio;
            this.another_radio.CheckedChanged += new System.EventHandler(this.another_radio_CheckedChanged);
            // 
            // sub_adress
            // 
            this.sub_adress.BorderRadius = 10;
            this.sub_adress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sub_adress.DefaultText = "";
            this.sub_adress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sub_adress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sub_adress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sub_adress.DisabledState.Parent = this.sub_adress;
            this.sub_adress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sub_adress.Enabled = false;
            this.sub_adress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sub_adress.FocusedState.Parent = this.sub_adress;
            this.sub_adress.Font = new System.Drawing.Font("Inter Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_adress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.sub_adress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sub_adress.HoverState.Parent = this.sub_adress;
            this.sub_adress.Location = new System.Drawing.Point(340, 340);
            this.sub_adress.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.sub_adress.Name = "sub_adress";
            this.sub_adress.PasswordChar = '\0';
            this.sub_adress.PlaceholderText = "";
            this.sub_adress.SelectedText = "";
            this.sub_adress.ShadowDecoration.Parent = this.sub_adress;
            this.sub_adress.Size = new System.Drawing.Size(400, 45);
            this.sub_adress.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Differnt Adress  :";
            // 
            // customer_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(800, 713);
            this.Controls.Add(this.sub_adress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.another_radio);
            this.Controls.Add(this.saved_radio);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.pin_label);
            this.Controls.Add(this.adress_txt);
            this.Controls.Add(this.close_but);
            this.Controls.Add(this.add_but);
            this.Controls.Add(this.name__label);
            this.Controls.Add(this.adress_label);
            this.Controls.Add(this.customer_phone_label);
            this.Controls.Add(this.pincode_txt);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.info_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "customer_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customer_info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Label email_label;
        private Guna.UI2.WinForms.Guna2TextBox email_txt;
        private System.Windows.Forms.Label pin_label;
        private Guna.UI2.WinForms.Guna2TextBox adress_txt;
        private Guna.UI2.WinForms.Guna2Button close_but;
        private Guna.UI2.WinForms.Guna2Button add_but;
        private System.Windows.Forms.Label name__label;
        private System.Windows.Forms.Label adress_label;
        private System.Windows.Forms.Label customer_phone_label;
        private Guna.UI2.WinForms.Guna2TextBox pincode_txt;
        private Guna.UI2.WinForms.Guna2TextBox phone_txt;
        private Guna.UI2.WinForms.Guna2TextBox name_txt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton saved_radio;
        private Guna.UI2.WinForms.Guna2CustomRadioButton another_radio;
        private Guna.UI2.WinForms.Guna2TextBox sub_adress;
        private System.Windows.Forms.Label label1;
    }
}