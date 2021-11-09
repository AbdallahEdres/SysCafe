using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace SysCafé
{
    public partial class menu_cashier_cont : UserControl
    {
        DataSet ds;
        List<Guna2ShadowPanel> menu_but_list = new List<Guna2ShadowPanel>();
        List<int> item_id = model.get_item_id();
        string total_p = "";

        // create menu items buttons
        private void create_item_menu(int item_id)
        {
            string name = " ", price = " ";
            int pic_id = -1;
            model.panel_build(item_id, ref name, ref price, ref pic_id);
            Guna2ShadowPanel item_panel = new Guna2ShadowPanel();
            item_panel.BackColor = Color.Transparent;
            item_panel.Controls.Add(create_price(price));
            item_panel.Controls.Add(create_item_name(name));
            item_panel.Controls.Add(create_picbox(pic_id));
            item_panel.FillColor = Color.White;
            item_panel.Location = new Point(13, 13);
            item_panel.Name = item_id.ToString();
            item_panel.Radius = 15;
            item_panel.ShadowColor = Color.Black;
            item_panel.Size = new Size(200, 200);
            item_panel.TabIndex = 0;
            item_panel.Cursor = Cursors.Hand;
            menu_but_list.Add(item_panel);
            flowLayoutPanel2.Controls.Add(item_panel);
            item_panel.Click += new EventHandler(take_order);
            
        }
        private Guna2CirclePictureBox create_picbox(int id)
        {
            Guna2CirclePictureBox guna2CirclePictureBox1 = new Guna2CirclePictureBox();
            guna2CirclePictureBox1.Image = menu_image.Images[id];
            guna2CirclePictureBox1.Location = new Point(41, 14);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.Parent = guna2CirclePictureBox1;
            guna2CirclePictureBox1.Size = new Size(120, 120);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2CirclePictureBox1.TabIndex = 0;
            guna2CirclePictureBox1.TabStop = false;
/*            guna2CirclePictureBox1.Click += new EventHandler(take_order);
*/
            return guna2CirclePictureBox1;
        }
        private Label create_price(string price)
        {
            Label label3 = new Label();
            label3.AutoSize = true;
            label3.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new Point(75, 170);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 2;
            label3.Text = price + "$";
/*            label3.Click += new EventHandler(take_order);
*/
            return label3;
        }
        private Label create_item_name(string name)
        {
            Label label2 = new Label();
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new Point(76, 137);
            label2.Name = "name";
            label2.Size = new Size(55, 19);
            label2.TabIndex = 1;
            label2.Text = name;
/*            label2.Click += new EventHandler(take_order);
*/
            return label2;
        }

        private void creat()
        {
            foreach (int id in item_id)
            {
                create_item_menu(id);
            }
        }

        // filling order content grid 
        public void fill_grid()
        {
            model.fill_recipt(ref ds, Convert.ToInt32(order_num_label.Text));
            order_grid.DataSource = ds.Tables["receipt"].DefaultView;
            receipt_grid_naming();
            total_p = model.calc_payment(Convert.ToInt32(order_num_label.Text)).ToString();
            price_label.Text = total_p +" $";
        }
        private void receipt_grid_naming()
        {
            order_grid.Columns[0].HeaderText = "Ticket ID";
            order_grid.Columns[1].HeaderText = "Item";
            order_grid.Columns[2].HeaderText = "Size";
            order_grid.Columns[3].HeaderText = "Count";
            order_grid.Columns[4].HeaderText = "Price/1";


        }

        // method for menu buttons
        private void take_order(object sender, EventArgs e)
        {
            Guna2ShadowPanel clickedButton = sender as Guna2ShadowPanel;
            int id = Convert.ToInt32(clickedButton.Name);
            int tkt_id = Convert.ToInt32(order_num_label.Text);
            if (tkt_id > 0)
            {
                model.add_order_casheir(tkt_id, id);
                fill_grid();
            }else if (tkt_id == 0)
            {
               DialogResult d=( MessageBox.Show("Do ypu want to choose ticket?","No ticket selected",MessageBoxButtons.YesNo));
                if (d == DialogResult.Yes)
                {
                    chang_but.PerformClick();
                }
            }
           
        }


        // gets order_id
        public void set_order_id(int order_id)
        {
            order_num_label.Text = order_id.ToString();
        }
        public menu_cashier_cont()
        {
            InitializeComponent();
            creat();
            
        }

        private void order_num_label_TextChanged(object sender, EventArgs e)
        {
            fill_grid();
        }

        private void chang_but_Click(object sender, EventArgs e)
        {
            order_num_label.Text = "0";
        }
    }
}
