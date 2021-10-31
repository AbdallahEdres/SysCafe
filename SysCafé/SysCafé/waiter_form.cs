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
    public partial class waiter_form : Form
    {
        tickets_cont tickets_cont1 = new tickets_cont();

        private void hid_cont()
        {
            tickets_cont1.Hide();
        }
        private void creat_table(int id)
        {
            Guna.UI2.WinForms.Guna2Button freetabla = new Guna.UI2.WinForms.Guna2Button();
            freetabla.Image = imageList1.Images[0];
            freetabla.ImageSize = new Size(130, 130);
            freetabla.Text = id.ToString();
            freetabla.Font = new Font("Inter Medium", 20.25F, FontStyle.Bold,GraphicsUnit.Point, ((byte)(0)));
            freetabla.BorderRadius = 50;
            freetabla.Name = "table1";
            freetabla.Location = new Point(19, 45);
            freetabla.Size = new Size(380, 250);
            freetabla.TextOffset = new Point(-33, 40);
            freetabla.ImageOffset = new Point(5, -20);
            freetabla.Margin = new Padding(80);
/*            freetabla.Click += new EventHandler(table_Click);
*/            if (manager_model.table_status(id) == 0)
            {
                freetabla.FillColor = Color.FromArgb(159, 159, 158);

            }
            else if (manager_model.table_status(id) == 1)
            {
                freetabla.FillColor = Color.FromArgb(9, 170, 41);

            }

            flowLayoutPanel1.Controls.Add(freetabla);

        }
        int num_tables = manager_model.num_table();

        private void button_reset(Guna.UI2.WinForms.Guna2Button b)
        {
            b.FillColor = Color.Transparent;
            b.BorderColor = Color.FromArgb(252, 128, 25);
            b.BorderThickness = 0;
        }
        private void button_select(Guna.UI2.WinForms.Guna2Button b)
        {
            b.FillColor = Color.FromArgb(100, 252, 128, 25);
            b.BorderColor = Color.FromArgb(252, 128, 25);
            b.BorderThickness = 2;

        }
        public waiter_form()
        {
            InitializeComponent();
            button_select(Home_button);
            this.Controls.Add(tickets_cont1);
            tickets_cont1.Hide();
            for (int i = 1; i <= num_tables; i++)
            {
                creat_table(i);
            }
            menu_cont me = new menu_cont();
            me.Show();
            this.Controls.Add(me);
            me.BringToFront();
        }

        private void tickets_but_Click(object sender, EventArgs e)
        {
            tickets_cont1.Show();
            tickets_cont1.BringToFront();
            button_select(tickets_but);
            button_reset(Home_button);
            main_panel.Hide();
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            hid_cont();
            button_select(Home_button);
            button_reset(tickets_but);
            main_panel.Show();
        }

        private void menu_but_Click(object sender, EventArgs e)
        {
           
        }
    }
}
