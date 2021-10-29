
namespace SysCafé
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.username_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Pasword_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.username_lable = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.login_but = new Guna.UI2.WinForms.Guna2Button();
            this.exit_but = new Guna.UI2.WinForms.Guna2Button();
            this.Login_labl = new System.Windows.Forms.Label();
            this.mid_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mid_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username_txt
            // 
            this.username_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.username_txt.BorderRadius = 15;
            this.username_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_txt.DefaultText = "";
            this.username_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_txt.DisabledState.Parent = this.username_txt;
            this.username_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_txt.FocusedState.Parent = this.username_txt;
            this.username_txt.Font = new System.Drawing.Font("Inter Semi Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.username_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_txt.HoverState.Parent = this.username_txt;
            this.username_txt.Location = new System.Drawing.Point(591, 460);
            this.username_txt.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.username_txt.Name = "username_txt";
            this.username_txt.PasswordChar = '\0';
            this.username_txt.PlaceholderText = "";
            this.username_txt.SelectedText = "";
            this.username_txt.ShadowDecoration.Parent = this.username_txt;
            this.username_txt.Size = new System.Drawing.Size(418, 51);
            this.username_txt.TabIndex = 2;
            this.username_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_txt_KeyDown);
            // 
            // Pasword_txt
            // 
            this.Pasword_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.Pasword_txt.BorderRadius = 15;
            this.Pasword_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pasword_txt.DefaultText = "";
            this.Pasword_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Pasword_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Pasword_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pasword_txt.DisabledState.Parent = this.Pasword_txt;
            this.Pasword_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pasword_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pasword_txt.FocusedState.Parent = this.Pasword_txt;
            this.Pasword_txt.Font = new System.Drawing.Font("Inter Semi Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pasword_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.Pasword_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pasword_txt.HoverState.Parent = this.Pasword_txt;
            this.Pasword_txt.Location = new System.Drawing.Point(591, 572);
            this.Pasword_txt.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Pasword_txt.Name = "Pasword_txt";
            this.Pasword_txt.PasswordChar = '*';
            this.Pasword_txt.PlaceholderText = "";
            this.Pasword_txt.SelectedText = "";
            this.Pasword_txt.ShadowDecoration.Parent = this.Pasword_txt;
            this.Pasword_txt.Size = new System.Drawing.Size(418, 52);
            this.Pasword_txt.TabIndex = 3;
            this.Pasword_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pasword_txt_KeyDown);
            // 
            // username_lable
            // 
            this.username_lable.AutoSize = true;
            this.username_lable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.username_lable.Font = new System.Drawing.Font("Inter Semi Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.username_lable.Location = new System.Drawing.Point(696, 418);
            this.username_lable.Name = "username_lable";
            this.username_lable.Size = new System.Drawing.Size(208, 39);
            this.username_lable.TabIndex = 4;
            this.username_lable.Text = "User Name ";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.password_label.Font = new System.Drawing.Font("Inter Semi Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.password_label.Location = new System.Drawing.Point(708, 531);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(185, 39);
            this.password_label.TabIndex = 5;
            this.password_label.Text = "Password ";
            // 
            // login_but
            // 
            this.login_but.BorderRadius = 10;
            this.login_but.CheckedState.Parent = this.login_but;
            this.login_but.CustomImages.Parent = this.login_but;
            this.login_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.login_but.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_but.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.login_but.HoverState.Parent = this.login_but;
            this.login_but.Location = new System.Drawing.Point(648, 680);
            this.login_but.Name = "login_but";
            this.login_but.ShadowDecoration.Parent = this.login_but;
            this.login_but.Size = new System.Drawing.Size(304, 64);
            this.login_but.TabIndex = 7;
            this.login_but.Text = "Login";
            this.login_but.Click += new System.EventHandler(this.login_but_Click);
            // 
            // exit_but
            // 
            this.exit_but.BorderRadius = 10;
            this.exit_but.CheckedState.Parent = this.exit_but;
            this.exit_but.CustomImages.Parent = this.exit_but;
            this.exit_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.exit_but.Font = new System.Drawing.Font("Inter Semi Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_but.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exit_but.HoverState.Parent = this.exit_but;
            this.exit_but.Location = new System.Drawing.Point(685, 772);
            this.exit_but.Name = "exit_but";
            this.exit_but.ShadowDecoration.Parent = this.exit_but;
            this.exit_but.Size = new System.Drawing.Size(230, 64);
            this.exit_but.TabIndex = 8;
            this.exit_but.Text = "Exit";
            this.exit_but.Click += new System.EventHandler(this.exit_but_Click);
            // 
            // Login_labl
            // 
            this.Login_labl.AutoSize = true;
            this.Login_labl.Font = new System.Drawing.Font("Inter Semi Bold", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_labl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.Login_labl.Location = new System.Drawing.Point(729, 269);
            this.Login_labl.Name = "Login_labl";
            this.Login_labl.Size = new System.Drawing.Size(142, 54);
            this.Login_labl.TabIndex = 1;
            this.Login_labl.Text = "Login";
            // 
            // mid_panel
            // 
            this.mid_panel.BackColor = System.Drawing.Color.Transparent;
            this.mid_panel.Controls.Add(this.pictureBox1);
            this.mid_panel.Controls.Add(this.Login_labl);
            this.mid_panel.Controls.Add(this.exit_but);
            this.mid_panel.Controls.Add(this.login_but);
            this.mid_panel.Controls.Add(this.password_label);
            this.mid_panel.Controls.Add(this.username_lable);
            this.mid_panel.Controls.Add(this.Pasword_txt);
            this.mid_panel.Controls.Add(this.username_txt);
            this.mid_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mid_panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.mid_panel.Location = new System.Drawing.Point(0, 0);
            this.mid_panel.Margin = new System.Windows.Forms.Padding(2);
            this.mid_panel.Name = "mid_panel";
            this.mid_panel.Radius = 2;
            this.mid_panel.ShadowColor = System.Drawing.Color.Black;
            this.mid_panel.ShadowShift = 0;
            this.mid_panel.Size = new System.Drawing.Size(1600, 900);
            this.mid_panel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(549, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 262);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.mid_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.mid_panel.ResumeLayout(false);
            this.mid_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox username_txt;
        private Guna.UI2.WinForms.Guna2TextBox Pasword_txt;
        private System.Windows.Forms.Label username_lable;
        private System.Windows.Forms.Label password_label;
        private Guna.UI2.WinForms.Guna2Button login_but;
        private Guna.UI2.WinForms.Guna2Button exit_but;
        private System.Windows.Forms.Label Login_labl;
        private Guna.UI2.WinForms.Guna2ShadowPanel mid_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

