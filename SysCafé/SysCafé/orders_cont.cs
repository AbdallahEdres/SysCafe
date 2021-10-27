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
    public partial class orders_cont : UserControl
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orders_cont));
        private void creat_free_table()
        {
            Guna.UI2.WinForms.Guna2Button freetabla = new Guna.UI2.WinForms.Guna2Button();
            freetabla.Image =imageList1.Images[0];
            freetabla.ImageSize = new Size(130, 130);
            freetabla.Text = "1";
            freetabla.Font = new Font("Inter Semi Bold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            freetabla.FillColor = Color.FromArgb(159, 159, 158);
            freetabla.BorderRadius = 50;
            freetabla.Name = "table1";
            freetabla.Location =new Point(19, 45);
            freetabla.Size = new Size (285, 150);
            freetabla.TextOffset = new Point(-33, 40);
            freetabla.ImageOffset = new Point(5,-20);
            freetabla.Margin = new Padding(10);

            flowLayoutPanel1.Controls.Add(freetabla);

        }
        private void creat_ocupied_table()
        {
            Guna.UI2.WinForms.Guna2Button freetabla = new Guna.UI2.WinForms.Guna2Button();
            freetabla.Image = imageList1.Images[0];
            freetabla.ImageSize = new Size(130, 130);
            freetabla.Text = "1";
            freetabla.Font = new Font("Inter Semi Bold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            freetabla.FillColor = Color.FromArgb(9, 170, 41);
            freetabla.BorderRadius = 50;
            freetabla.Name = "table1";
            freetabla.Location = new Point(19, 45);
            freetabla.Size = new Size(285, 150);
            freetabla.TextOffset = new Point(-33, 40);
            freetabla.ImageOffset = new Point(5, -20);
            freetabla.Margin = new Padding(10);

            flowLayoutPanel1.Controls.Add(freetabla);

        }
        public orders_cont()
        {
            InitializeComponent();
            for(int i =0; i < 5; i++)
            {

                creat_free_table();

            }
            for (int i = 0; i < 5; i++)
            {

                creat_ocupied_table();

            }
        }
    }
}
