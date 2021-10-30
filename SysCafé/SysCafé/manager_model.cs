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
        public static void fill_mat_combo(Guna.UI2.WinForms.Guna2ComboBox c)
        {
            c.Items.Clear();
            cn.Open();
            cmd = new SqlCommand("select material_name from material_list", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                c.Items.Add(dr[0]);
            }
            dr.Close();
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
            c.Items.Clear();
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
        public static int get_mat_id(string name)
        {
            int id;
            cn.Open();
            cmd = new SqlCommand("select material_id from material_list where material_name ='" + name + "'", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            id = Convert.ToInt32(dr[0]);
            dr.Close();
            cn.Close();
            return id;
        }
        public static void insert_materials(int mat_id, double price ,int supplier_id,double count,double wight,DateTime date,int receipt_id)
        {
            cn.Open();
            cmd = new SqlCommand("insert into materials values ('"+mat_id+"',"+count+","+wight+","+price+ ","+supplier_id+",'"+ date.ToString("yyyy-MM-dd")+"',"+receipt_id+")", cn);
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
            cmd = new SqlCommand("SELECT material_list.material_name,  materials.material_count,  materials.weight_unit,  materials.price_unit,  suppliers.sup_name,  materials.date_bought,  materials.receipt_id FROM  materials INNER JOIN suppliers ON  materials.sup_id =  suppliers.sup_id INNER JOIN material_list ON  materials.material_id =  material_list.material_id where receipt_id=" + id+"", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "receipts");
            cn.Close();
        }
        public static void add_inventor(int id,double new_count)
        {
            double count;
            cn.Open();
            cmd = new SqlCommand("select the_count from iventory where material_id=" + id + "",cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            count = (Convert.ToInt32(dr[0])+new_count);
            dr.Close();
            cn.Close();

            cn.Open();
            cmd = new SqlCommand("update iventory set the_count ="+count+"" +
                "where material_id ="+id+"",cn);
            cmd.ExecuteReader();
            cn.Close();
            
        }
        public static void delete_receipt (int receipt_id)
        {
            cn.Open();
            cmd = new SqlCommand("delete from materials where receipt_id="+receipt_id+"",cn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("delete from material_receipts where receipt_id=" + receipt_id + "", cn);
            cmd.ExecuteNonQuery();
            cn.Close();

        }
        public static void exit_delete_receipt()
        {
            int id =receipt_id();
            int num_receipt;
            int num_entered;
            cn.Open();
            cmd = new SqlCommand("select num_items from material_receipts where receipt_id ="+id+"",cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            num_receipt = Convert.ToInt32(dr[0]);
            dr.Close();
            cmd = new SqlCommand("select count (*) from materials where receipt_id ="+id+"", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            num_entered = Convert.ToInt32(dr[0]);
            dr.Close();
            cn.Close();
            if (num_entered != num_receipt)
            {
                delete_receipt(id);
            }
            

        }
        #endregion
        #region stock
        public static void fill_inven_grid(ref DataSet ds)
        {
            cn.Open();
            cmd = new SqlCommand("SELECT material_list.material_name,  iventory.the_count FROM iventory INNER JOIN material_list ON  iventory.material_id =  material_list.material_id", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "inventory");
            cn.Close();
        }
        public static void fill_kitchen_grid(ref DataSet ds)
        {
            cn.Open();
            cmd = new SqlCommand("SELECT material_list.material_name,  kitchen_stock.the_count FROM kitchen_stock INNER JOIN material_list ON  kitchen_stock.material_id =  material_list.material_id", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "kitchen");
            cn.Close();
        }
        public static void add_ketchin(int id, double new_count)
        {
            double count;
            cn.Open();
            cmd = new SqlCommand("select the_count from kitchen_stock where material_id=" + id + "", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            count = (Convert.ToInt32(dr[0]) + new_count);
            dr.Close();
            cn.Close();

            cn.Open();
            cmd = new SqlCommand("update kitchen_stock set the_count =" + count + "" +
                "where material_id =" + id + "", cn);
            cmd.ExecuteReader();
            cn.Close();

        }
        
        public static void remov_inventory(int id, double new_count)
        {
            double count;
            cn.Open();
            cmd = new SqlCommand("select the_count from iventory where material_id=" + id + "", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            count = (Convert.ToInt32(dr[0]) - new_count);
            dr.Close();
            cn.Close();

            cn.Open();
            cmd = new SqlCommand("update iventory set the_count =" + count + "" +
                "where material_id =" + id + "", cn);
            cmd.ExecuteReader();
            cn.Close();

        }
        public static void remov_kitchen(int id, double new_count)
        {
            double count;
            cn.Open();
            cmd = new SqlCommand("select the_count from kitchen_stock where material_id=" + id + "", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            count = (Convert.ToInt32(dr[0]) - new_count);
            dr.Close();
            cn.Close();

            cn.Open();
            cmd = new SqlCommand("update kitchen_stock set the_count =" + count + "" +
                "where material_id =" + id + "", cn);
            cmd.ExecuteReader();
            cn.Close();

        }
        #endregion
        #region orders
        public static int num_table()
        {
            int num;
            cn.Open();
            cmd = new SqlCommand("select count (*) from the_tables", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            num = Convert.ToInt32(dr[0]);
            dr.Close();
            cn.Close();
            return num;
        }
        public static int table_status(int id)
        {
            int status;
            cn.Open();
            cmd = new SqlCommand("select table_status from the_tables where table_number = "+id+"", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            status = Convert.ToInt32(dr[0]);
            dr.Close();
            cn.Close();
            return status;

        }
        public static void orders_grid_fill(ref DataSet ds,int table_num)
        {
            cn.Open();
            cmd = new SqlCommand("SELECT tickets.ticket_id,  tickets.table_num,  tickets.open_time,  tickets.close_time,  tickets.ticket_status,  tickets.ticket_type,  workers_info.worker_name FROM workers_info INNER JOIN tickets ON  workers_info.worker_id =  tickets.worker_id where table_num =" + table_num+"", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "orders");
            cn.Close();
        }
        public static void details_grid_fill(ref DataSet ds, int id)
        {
            cn.Open();
            cmd = new SqlCommand("SELECT ticket_content.ticket_id,  menu_items.item_name,  menu_items.item_size,  menu_items.item_price,  menu_category.category_name,  ticket_content.item_count FROM ticket_content INNER JOIN menu_items ON  ticket_content.item_id =  menu_items.item_id INNER JOIN menu_category ON  menu_items.category_id =  menu_category.category_id where ticket_id= " + id+"", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "details");
            cn.Close();
        }
        #endregion
    }
}
