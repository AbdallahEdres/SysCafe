using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysCafé
{
    public partial class menu_cont : UserControl
    {
        int num_tables = model.num_table();

        private void creat_table(int id)
        {
            Guna.UI2.WinForms.Guna2Button freetabla = new Guna.UI2.WinForms.Guna2Button();
            freetabla.Image = tabel_image.Images[0];
            freetabla.ImageSize = new Size(45, 45);
            freetabla.Text = id.ToString();
            freetabla.Font = new Font("Inter Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            freetabla.BorderRadius = 10;
            freetabla.Name = "table1";
            freetabla.Location = new Point(20, 20);
            freetabla.Size = new Size(135, 70);
            freetabla.TextOffset = new Point(0, 20);
            freetabla.ImageOffset = new Point(35, -10);
            freetabla.Margin = new Padding(10);
            freetabla.ImageAlign = HorizontalAlignment.Right;

/*            freetabla.Click += new EventHandler(table_Click);
*/
              if (model.table_status(id) == 0)
            {
                freetabla.FillColor = Color.FromArgb(159, 159, 158);

            }
            else if (model.table_status(id) == 1)
            {
                freetabla.FillColor = Color.FromArgb(9, 170, 41);

            }

            flowLayoutPanel1.Controls.Add(freetabla);

        }
        private void create_item_menu()
        {
            Guna.UI2.WinForms.Guna2ShadowPanel item_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            item_panel.BackColor = Color.Transparent;
            Label label3 = new Label();
            create_price(label3);
            item_panel.Controls.Add(label3);
            Label label2 = new Label();
            crate_item_name(label2);
            item_panel.Controls.Add(label2);
            Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            create_picbox(guna2CirclePictureBox1);
            item_panel.Controls.Add(guna2CirclePictureBox1);
            item_panel.FillColor = Color.White;
            item_panel.Location = new Point(13, 13);
            item_panel.Name = "item_panel";
            item_panel.Radius = 15;
            item_panel.ShadowColor =Color.Black;
            item_panel.Size = new Size(200, 200);
            item_panel.TabIndex = 0;
            item_panel.Cursor = Cursors.Hand;
            flowLayoutPanel2.Controls.Add(item_panel);

        }
        private void create_picbox(Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1)
        {
            
            guna2CirclePictureBox1.Image =menu_image.Images[0];
            guna2CirclePictureBox1.Location = new System.Drawing.Point(41, 14);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.ShadowDecoration.Parent = guna2CirclePictureBox1;
            guna2CirclePictureBox1.Size = new Size(120, 120);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2CirclePictureBox1.TabIndex = 0;
            guna2CirclePictureBox1.TabStop = false;
        }
        private void create_price(Label label3)
        {
            label3.AutoSize = true;
            label3.Font = new Font("Inter Medium", 12F,FontStyle.Bold,GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new Point(75, 170);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 2;
            label3.Text = "label3";
        }
        private void crate_item_name(Label label2)
        {
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new Point(76, 137);
            label2.Name = "label2";
            label2.Size = new Size(55, 19);
            label2.TabIndex = 1;
            label2.Text = "label2";
        }
        public menu_cont()
        {
            InitializeComponent(); 
            for (int i = 1; i <= num_tables; i++)
            {
                creat_table(i);
            }
            for(int i=0; i < 50; i++)
            {
                create_item_menu();
            }
        }

        private void guna2ShadowPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
