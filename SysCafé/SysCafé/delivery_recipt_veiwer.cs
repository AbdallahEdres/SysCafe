using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SysCafé
{
    public partial class delivery_recipt_veiwer : Form
    {
        string _order_id;
        string time;
        string order_typ;
        string cus_name;
        string cus_phone;
        string cus_adress;
        string delivery;
        List<order_print_class> list;
 
        public delivery_recipt_veiwer(int order_id)
        {
            InitializeComponent();
            _order_id = order_id.ToString();
            model.make_receipt_list(order_id);
            list = model.receiptd_list;
            model.get_customer_info(order_id, ref cus_name, ref cus_phone, ref cus_adress, ref time, ref order_typ,ref delivery);
        }

        private void recipt_veiwer_Load(object sender, EventArgs e)
        {
            ReportParameter[] p = new ReportParameter[]
            {
              new  ReportParameter("order_id",_order_id),
              new  ReportParameter("order_time",time),
              new  ReportParameter("order_typ",order_typ),
              new  ReportParameter("cust_name",cus_name),
              new  ReportParameter("cust_phone",cus_phone),
              new  ReportParameter("cust_adress",cus_adress),
              new  ReportParameter("delivery",delivery)
            };

            order_print_classBindingSource.DataSource = list;
           
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
           
        }
    }
}
