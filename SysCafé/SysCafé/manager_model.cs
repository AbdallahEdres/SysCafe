using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace SysCafé
{
    public static class manager_model
    {
        public static SqlConnection cn = new SqlConnection("server=DESKTOP-2ROJPSN ;database=Sys_cafe ;integrated security=true");
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static int supp_id=1;

        #region form1
        public static string login(string username ,string pasoword)
        {
            string type="wrong";
            cn.Open();
            cmd = new SqlCommand("select type_user from login_info where name_user ='"+username+"' and pass_user = '"+pasoword+"' " ,cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                type = dr[0].ToString();
                dr.Close();
                cn.Close();
            }
            dr.Close();
            cn.Close();
            return type;
        }
        #endregion

        #region suppliers
        public static void add_supplier(string name, string phone,string phone2,string adrees,string adress2)
        {
            cn.Open();
            cmd = new SqlCommand("insert into suppliers(sup_name,sup_phone,sup_phone2,sup_adress,sup_adress2) values ('" + name+"','"+phone+"','"+phone2+"','"+adrees+"','"+adress2+"')", cn);
            cmd.ExecuteNonQuery();
            cn.Close();

        }
        public static void get_supplier_info(ref string name,ref  string phone,ref string phone2,ref string adrees,ref string adress2)
        {
            cn.Open();
            cmd = new SqlCommand("select * from suppliers where sup_id ="+supp_id+"",cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            name = dr[1].ToString();
            phone = dr[2].ToString();
            phone2 = dr[3].ToString();
            adrees = dr[4].ToString();
            adress2 = dr[5].ToString();
            dr.Close();
            cn.Close();
        }
        public static void edit_sup_info(string name, string phone, string phone2, string adrees, string adress2)
        {
            cn.Open();
            cmd = new SqlCommand("update suppliers set sup_name ='"+name+"',sup_phone='"+phone+"',sup_phone2='"+phone2+"',sup_adress='"+adrees+"',sup_adress2='"+adress2+"'" +
                "where sup_id = "+supp_id+"", cn);
            cmd.ExecuteNonQuery();
            cn.Close();

        }
        public static void fill_grid( ref DataSet ds,string name)
        {
            cn.Open();
            cmd = new SqlCommand("select * from suppliers where sup_name like '%"+name+"%'", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "sup_info");
            cn.Close();
        }


        #endregion

        #region materials
        public static void add_receipt(DateTime date ,double price ,int num)
        {
            cn.Open();
            cmd = new SqlCommand("insert into material_receipts values ('"+date.ToString("yyyy-MM-dd")+"',"+num+","+price+")", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static int receipt_id()
        {
            int id;
            cn.Open();
            cmd = new SqlCommand("select max(receipt_id) from material_receipts", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            id = Convert.ToInt32(dr[0]);
            dr.Close();
            cn.Close();
            return id;
        }
        public static void fill_suppliers_combo(Guna.UI2.WinForms.Guna2ComboBox c)
        {
            cn.Open();
            cmd = new SqlCommand("select sup_name from suppliers",cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                c.Items.Add(dr[0]);
            }
            dr.Close();
            cn.Close();
        }
        public static int get_supplier_id(string name)
        {
            int id;
            cn.Open();
            cmd = new SqlCommand("select sup_id from suppliers where sup_name ='"+name+"'",cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            id = Convert.ToInt32(dr[0]);
            dr.Close();
            cn.Close();
            return id;
        }
        public static void insert_materials(string name, double price ,int supplier_id,double count,double wight,DateTime date,int receipt_id)
        {
            
            cn.Open();
            cmd = new SqlCommand("insert into materials values ('"+name+"',"+count+","+wight+","+price+ ","+supplier_id+",'"+ date.ToString("yyyy-MM-dd")+"',"+receipt_id+")", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static void fill_pre_receipt_grid(ref DataSet ds)
        {
            cn.Open();
            cmd = new SqlCommand("select * from material_receipts", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "receipts");
            cn.Close();
        }
        public static void fill_content_grid(ref DataSet ds,int id)
        {
            cn.Open();
            cmd = new SqlCommand("select * from materials where receipt_id ="+id+"", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "receipts");
            cn.Close();
        }
        #endregion
    }
}
