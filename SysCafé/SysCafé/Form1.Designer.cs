
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
            this.mid_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.Pasword_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.username_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Login_labl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.username_lable = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mid_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mid_panel
            // 
            this.mid_panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mid_panel.BackColor = System.Drawing.Color.Transparent;
            this.mid_panel.Controls.Add(this.password_label);
            this.mid_panel.Controls.Add(this.username_lable);
            this.mid_panel.Controls.Add(this.Pasword_txt);
            this.mid_panel.Controls.Add(this.username_txt);
            this.mid_panel.Controls.Add(this.Login_labl);
            this.mid_panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.mid_panel.Location = new System.Drawing.Point(319, 179);
            this.mid_panel.Margin = new System.Windows.Forms.Padding(2);
            this.mid_panel.Name = "mid_panel";
            this.mid_panel.Radius = 50;
            this.mid_panel.ShadowColor = System.Drawing.Color.Black;
            this.mid_panel.ShadowShift = 20;
            this.mid_panel.Size = new System.Drawing.Size(1280, 720);
            this.mid_panel.TabIndex = 0;
            this.mid_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.mid_panel_Paint);
            // 
            // Pasword_txt
            // 
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
            this.Pasword_txt.Location = new System.Drawing.Point(432, 436);
            this.Pasword_txt.Name = "Pasword_txt";
            this.Pasword_txt.PasswordChar = '\0';
            this.Pasword_txt.PlaceholderText = "";
            this.Pasword_txt.SelectedText = "";
            this.Pasword_txt.ShadowDecoration.Parent = this.Pasword_txt;
            this.Pasword_txt.Size = new System.Drawing.Size(418, 52);
            this.Pasword_txt.TabIndex = 3;
            // 
            // username_txt
            // 
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
            this.username_txt.Location = new System.Drawing.Point(432, 269);
            this.username_txt.Name = "username_txt";
            this.username_txt.PasswordChar = '\0';
            this.username_txt.PlaceholderText = "";
            this.username_txt.SelectedText = "";
            this.username_txt.ShadowDecoration.Parent = this.username_txt;
            this.username_txt.Size = new System.Drawing.Size(418, 51);
            this.username_txt.TabIndex = 2;
            // 
            // Login_labl
            // 
            this.Login_labl.AutoSize = true;
            this.Login_labl.Font = new System.Drawing.Font("Inter Semi Bold", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_labl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.Login_labl.Location = new System.Drawing.Point(570, 51);
            this.Login_labl.Name = "Login_labl";
            this.Login_labl.Size = new System.Drawing.Size(142, 54);
            this.Login_labl.TabIndex = 1;
            this.Login_labl.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(727, -46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(465, 248);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // username_lable
            // 
            this.username_lable.AutoSize = true;
            this.username_lable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.username_lable.Font = new System.Drawing.Font("Inter Semi Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.username_lable.Location = new System.Drawing.Point(437, 227);
            this.username_lable.Name = "username_lable";
            this.username_lable.Size = new System.Drawing.Size(218, 39);
            this.username_lable.TabIndex = 4;
            this.username_lable.Text = "User Name :";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.password_label.Font = new System.Drawing.Font("Inter Semi Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.password_label.Location = new System.Drawing.Point(437, 395);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(195, 39);
            this.password_label.TabIndex = 5;
            this.password_label.Text = "Password :";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 1039);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1902, 1039);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mid_panel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1918, 1078);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mid_panel.ResumeLayout(false);
            this.mid_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel mid_panel;
        private System.Windows.Forms.Label Login_labl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox Pasword_txt;
        private Guna.UI2.WinForms.Guna2TextBox username_txt;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label username_lable;
        private System.Windows.Forms.Panel panel1;
    }
}

