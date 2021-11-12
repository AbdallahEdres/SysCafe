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
    public partial class table_receipt_veiwer : Form
    {
        string _order_id;
        string time;
        string order_typ;
        string table_num;
        List<order_print_class> list;
        public table_receipt_veiwer(int order_id, int table_id)
        {
            InitializeComponent();
            _order_id = order_id.ToString();
            table_num = table_id.ToString();
            model.make_receipt_list(order_id);
            list = model.receiptd_list;
            model.get_takeaway_receipt(order_id, ref time, ref order_typ);
            MessageBox.Show(time + "   " + order_typ);
        }

        private void table_receipt_veiwer_Load(object sender, EventArgs e)
        {

            ReportParameter[] p = new ReportParameter[]
            {
              new  ReportParameter("order_id",_order_id),
              new  ReportParameter("time",time),
              new  ReportParameter("order_type",order_typ),
              new  ReportParameter("table_num",table_num)

            };

            order_print_class_BindingSource.DataSource = list;
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
