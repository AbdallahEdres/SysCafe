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
    public partial class menu_cont : UserControl
    {
        List<int> tables_id;
        public int table_id;
        DataSet ds;
        public List<Guna2Button> table_but_list = new List<Guna2Button>();
        public List<Guna2ShadowPanel> menu_but_list = new List<Guna2ShadowPanel>();
        List<int> item_id = model.get_item_id();
        string total_p;

        // refresh tables status
        public void refresh()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < tables_id.Count; i++)
            {
                creat_table(tables_id[i]);

            }
            flowLayoutPanel2.Controls.Clear();
            foreach (int id in item_id)
            {
                create_item_menu(id);
            }
            fill_order_grid();
            foreach(Guna2Button but in table_but_list)
            {
                if (Convert.ToInt32(but.Text) == table_id)
                {
                    check_but(but);
                }
            }
            tables_orders_label.Text = "Table " + table_id + " Order";
        }

        //creat tables buttons
        private void creat_table(int id)
        {
            Guna2Button freetabla = new Guna2Button();
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
            freetabla.Click += new EventHandler(grid_fill);
            if (model.table_status(id) == 0)
            {
                freetabla.FillColor = Color.FromArgb(159, 159, 158);

            }
            else if (model.table_status(id) == 1)
            {
                freetabla.FillColor = Color.FromArgb(9, 170, 41);

            }

            flowLayoutPanel1.Controls.Add(freetabla);
            table_but_list.Add(freetabla);
 
        }

        // check /uncheck buttons
        private void unchek_but()
        {
            foreach (Guna2Button but in table_but_list)
            {
                but.Checked = false;
                but.BorderThickness = 0;
            }
        }
        public void check_but(Guna2Button but)
        {


            unchek_but();
            but.Checked = true;
            but.CheckedState.BorderColor = Color.FromArgb(252, 128, 25);
            but.BorderThickness = 5;
        }

        // create menu items buttons
        #region Create Menue
        private void create_item_menu(int item_id)
        {
            
            string name=" ",price=" ";
            int pic_id=-1;
            model.panel_build( item_id, ref name, ref price,ref pic_id);
            Guna2ShadowPanel item_panel = new Guna2ShadowPanel();
            item_panel.BackColor = Color.Transparent;
            item_panel.Controls.Add(create_price(price));            
            item_panel.Controls.Add(create_item_name(name));
            item_panel.Controls.Add(create_picbox(pic_id));
            item_panel.FillColor = Color.White;
            item_panel.Location = new Point(13, 13);
            item_panel.Name = item_id.ToString() ;
            item_panel.Radius = 15;
            item_panel.ShadowColor =Color.Black;
            item_panel.Size = new Size(200, 200);
            item_panel.TabIndex = 0;
            item_panel.Cursor = Cursors.Hand;
            menu_but_list.Add(item_panel);
            flowLayoutPanel2.Controls.Add(item_panel);
            item_panel.MouseDown += new MouseEventHandler(take_order);
           
        }
        private Guna2CirclePictureBox create_picbox(int id)
        {
            Guna2CirclePictureBox guna2CirclePictureBox1 = new Guna2CirclePictureBox();
            guna2CirclePictureBox1.Image =menu_image.Images[id];
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
            label3.Font = new Font("Inter Medium", 12F,FontStyle.Bold,GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new Point(75, 170);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 2;
            label3.Text = price+"$";
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
        #endregion


        public void grid_fill(object sender, EventArgs e)
        {

            ds = new DataSet();
            Guna2Button clickedButton = sender as Guna2Button;
            table_id = Convert.ToInt32(clickedButton.Text);
            fill_order_grid();
            check_but(clickedButton);

        }
        private void fill_order_grid()
        {
            model.fill_order_content(ref ds, table_id);
            if (ds.Tables.Count > 0)
            {
                order_grid.DataSource = ds.Tables["order_content"].DefaultView;
                name_grid();
                total_p = model.calc_total(table_id) + "$";
                price_label.Text = total_p;
            }
        }
        private void name_grid()
        {
            order_grid.Columns[0].HeaderText = "Item";
            order_grid.Columns[1].HeaderText = "Size";
            order_grid.Columns[2].HeaderText = "Count";
            order_grid.Columns[3].HeaderText = "Price/1";
            order_grid.Columns[4].HeaderText = "Category";

        }

        private void take_order(object sender, EventArgs e)
        {
            int status = model.table_status(table_id);
            if (status == 0)
            {
                Guna2ShadowPanel clickedButton = sender as Guna2ShadowPanel;
                int id = Convert.ToInt32(clickedButton.Name);
                model.add_order(table_id, id);
                model.fill_order_content(ref ds, table_id);
                if (ds.Tables.Count > 0)
                {
                    price_label.Text = model.calc_total(table_id) + "$";
                    order_grid.DataSource = ds.Tables["order_content"].DefaultView;
                    name_grid();
                    total_p = model.calc_total(table_id) + "$";
                    price_label.Text = total_p;
                }

            }
            else if (status == 1)
            {
                DialogResult dialog = MessageBox.Show("Do you want to open new ticket??", "No Open Tickets", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    model.new_tkt_table(table_id, 1);
                    Guna2ShadowPanel clickedButton = sender as Guna2ShadowPanel;
                    int id = Convert.ToInt32(clickedButton.Name);
                    model.add_order(table_id, id);
                    model.fill_order_content(ref ds, table_id);
                    if (ds.Tables.Count > 0)
                    {
                        order_grid.DataSource = ds.Tables["order_content"].DefaultView;
                        name_grid();
                        total_p = model.calc_total(table_id) + "$";
                        price_label.Text = total_p;
                    }
                    flowLayoutPanel1.Controls.Clear();
                    for (int i = 0; i < tables_id.Count; i++)
                    {
                        creat_table(tables_id[i]);
                    }
                }


            }
            else if (status == -1)
            {
                MessageBox.Show("choose table!");
            }

        }


        #region buttons
        public menu_cont()
        {
            InitializeComponent();
            tables_id = model.get_table_id();
            for (int i = 0; i < tables_id.Count; i++)
            {
                creat_table(tables_id[i]);

            }
            foreach (int id in item_id)
            {
                create_item_menu(id);
            }
        }

        #endregion

      
    }
}
