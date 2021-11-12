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
    public partial class takeaway_receipt_viewer : Form
    {
        string _order_id;
        string time;
        string order_typ;
        List<order_print_class> list;
        public takeaway_receipt_viewer(int order_id)
        {
            
            InitializeComponent();
            _order_id = order_id.ToString();
            model.make_receipt_list(order_id);
            list = model.receiptd_list;
            model.get_takeaway_receipt(order_id, ref time, ref order_typ);
            MessageBox.Show(time + "   " + order_typ);
        }

        private void takeaway_receipt_viewer_Load(object sender, EventArgs e)
        {
           ReportParameter[] p = new ReportParameter[]
           {
              new  ReportParameter("order_id",_order_id),
              new  ReportParameter("order_time",time),
              new  ReportParameter("order_type",order_typ)
           };

            order_print_classBindingSource.DataSource = list;
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
