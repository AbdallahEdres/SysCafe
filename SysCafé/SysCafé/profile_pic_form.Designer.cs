
namespace SysCafé
{
    partial class profile_pic_form
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close_but = new Guna.UI2.WinForms.Guna2Button();
            this.edit_but = new FontAwesome.Sharp.IconButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this._pic_list = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 800);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // close_but
            // 
            this.close_but.BorderRadius = 24;
            this.close_but.CheckedState.Parent = this.close_but;
            this.close_but.CustomImages.Parent = this.close_but;
            this.close_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.close_but.Font = new System.Drawing.Font("Inter Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_but.ForeColor = System.Drawing.Color.White;
            this.close_but.HoverState.Parent = this.close_but;
            this.close_but.Location = new System.Drawing.Point(749, 0);
            this.close_but.Name = "close_but";
            this.close_but.ShadowDecoration.Parent = this.close_but;
            this.close_but.Size = new System.Drawing.Size(51, 43);
            this.close_but.TabIndex = 1;
            this.close_but.Text = "X";
            this.close_but.Click += new System.EventHandler(this.close_but_Click);
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
            this.edit_but.Location = new System.Drawing.Point(724, 737);
            this.edit_but.Name = "edit_but";
            this.edit_but.Size = new System.Drawing.Size(76, 63);
            this.edit_but.TabIndex = 17;
            this.edit_but.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_but.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_but.UseVisualStyleBackColor = false;
            this.edit_but.Click += new System.EventHandler(this.edit_but_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // _pic_list
            // 
            this._pic_list.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this._pic_list.ImageSize = new System.Drawing.Size(16, 16);
            this._pic_list.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // profile_pic_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.edit_but);
            this.Controls.Add(this.close_but);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "profile_pic_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "profile_pic_form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button close_but;
        private FontAwesome.Sharp.IconButton edit_but;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList _pic_list;
    }
}