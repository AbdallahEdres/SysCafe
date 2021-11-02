
namespace SysCafé
{
    partial class delivery_takeaway_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delivery_takeaway_form));
            this.takeaway_but = new Guna.UI2.WinForms.Guna2Button();
            this.delievry_but = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // takeaway_but
            // 
            this.takeaway_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.takeaway_but.BorderRadius = 5;
            this.takeaway_but.CheckedState.Parent = this.takeaway_but;
            this.takeaway_but.CustomImages.Parent = this.takeaway_but;
            this.takeaway_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(41)))));
            this.takeaway_but.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeaway_but.ForeColor = System.Drawing.Color.White;
            this.takeaway_but.HoverState.Parent = this.takeaway_but;
            this.takeaway_but.Image = ((System.Drawing.Image)(resources.GetObject("takeaway_but.Image")));
            this.takeaway_but.ImageOffset = new System.Drawing.Point(0, -3);
            this.takeaway_but.ImageSize = new System.Drawing.Size(40, 40);
            this.takeaway_but.Location = new System.Drawing.Point(12, 127);
            this.takeaway_but.Name = "takeaway_but";
            this.takeaway_but.ShadowDecoration.Parent = this.takeaway_but;
            this.takeaway_but.Size = new System.Drawing.Size(166, 48);
            this.takeaway_but.TabIndex = 8;
            this.takeaway_but.Text = "Takaway";
            this.takeaway_but.Click += new System.EventHandler(this.takeaway_but_Click);
            // 
            // delievry_but
            // 
            this.delievry_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delievry_but.BorderRadius = 5;
            this.delievry_but.CheckedState.Parent = this.delievry_but;
            this.delievry_but.CustomImages.Parent = this.delievry_but;
            this.delievry_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.delievry_but.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delievry_but.ForeColor = System.Drawing.Color.White;
            this.delievry_but.HoverState.Parent = this.delievry_but;
            this.delievry_but.Image = ((System.Drawing.Image)(resources.GetObject("delievry_but.Image")));
            this.delievry_but.ImageSize = new System.Drawing.Size(40, 40);
            this.delievry_but.Location = new System.Drawing.Point(328, 127);
            this.delievry_but.Name = "delievry_but";
            this.delievry_but.ShadowDecoration.Parent = this.delievry_but;
            this.delievry_but.Size = new System.Drawing.Size(166, 48);
            this.delievry_but.TabIndex = 7;
            this.delievry_but.Text = "Delivery";
            this.delievry_but.Click += new System.EventHandler(this.delievry_but_Click);
            // 
            // delivery_takeaway_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(508, 299);
            this.Controls.Add(this.takeaway_but);
            this.Controls.Add(this.delievry_but);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "delivery_takeaway_form";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "delivery_takeaway_form";
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button takeaway_but;
        public Guna.UI2.WinForms.Guna2Button delievry_but;
    }
}