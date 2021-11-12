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
    public static class model
    {
        public static SqlConnection cn = new SqlConnection("server=DESKTOP-2ROJPSN ;database=Sys_cafe ;integrated security=true");
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static int supp_id=-1;
        public static List<order_print_class> receiptd_list;
        public static int worker_id;

        /*        public static DataTable dt;
        */
        #region form1
        public static string login(string username ,string pasoword)
        {
            int id_user=-1;
            string type="wrong";
            cn.Open();
            cmd = new SqlCommand("select type_user,id_user from login_info where name_user ='"+username+"' and pass_user = '"+pasoword+"' " ,cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                type = dr[0].ToString();
                id_user =Convert.ToInt32( dr[1]);
               
            }
            dr.Close();
            worker_id= get_worker_id(id_user);
            cn.Close();
            return type;
        }

        public static int get_worker_id(int id_user)
        {
            int id = -1;
            
            cmd = new SqlCommand("select worker_id from workers_info where id_user ="+id_user+"", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            id = Convert.ToInt32(dr[0]);
            dr.Close();
            return id;
        }
        #endregion

        #region manager form
        #region suppliers
        public static void add_supplier(string name, string phone,string phone2,string adrees,string adress2)
        {
            cn.Open();
            cmd = new SqlCommand("insert into suppliers(sup_name,sup_phone,sup_phone2,sup_adress,sup_adress2) values (N'" + name+"',N'"+phone+"',N'"+phone2+"',N'"+adrees+"',N'" +adress2+"')", cn);
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
        public static void fill_inven_grid(ref DataSet ds ,string condtion)
        {
            cn.Open();
            cmd = new SqlCommand("SELECT material_list.material_name,  iventory.the_count FROM iventory INNER JOIN material_list ON  iventory.material_id =  material_list.material_id "+condtion, cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "inventory");
            cn.Close();
        }
        public static void fill_kitchen_grid(ref DataSet ds, string condtion)
        {
            cn.Open();
            cmd = new SqlCommand("SELECT material_list.material_name,  kitchen_stock.the_count FROM kitchen_stock INNER JOIN material_list ON  kitchen_stock.material_id =  material_list.material_id "+condtion, cn);
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

        // get table ids
        public static List<int>  get_table_id()
        {
            List<int> ids = new List<int>();
            cn.Open();
            cmd = new SqlCommand("select table_number from the_tables", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ids.Add(Convert.ToInt32(dr[0]));
            }
            dr.Close();
            cn.Close();
            return ids;
        }

        //get table status from database
        public static int table_status(int id)
        {
            int status=-1;
            if (id > 0)
            {
                cn.Open();
                cmd = new SqlCommand("select table_status from the_tables where table_number = " + id + "", cn);
                dr = cmd.ExecuteReader();
                dr.Read();
                status = Convert.ToInt32(dr[0]);
                dr.Close();
                cn.Close();
            }
           
            
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

        #region workers_info
        public static void get_workers_list(ref DataTable dt)
        {
            cmd = new SqlCommand("select worker_id,worker_name from workers_info", cn);
            
                dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            
        }

        public static void get_worker_info(int id, ref string name, ref string age, ref string adress, ref string type, ref string phone ,ref int pic_id)
        {
            cn.Open();
            cmd = new SqlCommand("select * from workers_info where worker_id = "+id+"", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                name = dr[1].ToString();
                phone = dr[2].ToString();
                age = dr[3].ToString();
                type = dr[4].ToString();
                adress = dr[5].ToString();
                pic_id = Convert.ToInt32(dr[6]);
            }
            dr.Close();
            cn.Close();

        }

        public static void edit_worker(int id,string name , string phone , string adress, string age ,string type)
        {
            cn.Open();
            cmd = new SqlCommand("update workers_info " +
                "set worker_name = N'" + name+"',worker_phone = N'"+phone+"',adress=N'"+adress+"',worker_age="+age+",worker_type=N'"+type+"' where worker_id="+id+"", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        #endregion
        #endregion

        #region waiter form

        #region tickets conroller
        // gets open ticket for specific table
        public static void fill_open_ticket_grid(ref DataSet ds , int table_num,ref string tkt_id,ref string worker ,ref string time, ref string value)
        {
            int ticket_id;
            ds = new DataSet();
            cn.Open();
            cmd = new SqlCommand("SELECT  tickets.ticket_id,  tickets.open_time,  workers_info.worker_name FROM workers_info INNER JOIN tickets ON  workers_info.worker_id =  tickets.worker_id where ticket_status = 'open' and table_num= " + table_num+"", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                tkt_id = dr[0].ToString();
                worker = dr[2].ToString();
                time = dr[1].ToString();
                ticket_id = Convert.ToInt32(dr[0]);
                dr.Close();
                cmd = new SqlCommand("SELECT menu_items.item_name,  menu_items.item_size,  ticket_content.item_count,  menu_items.item_price,  menu_category.category_name FROM menu_items INNER JOIN menu_category ON  menu_items.category_id =  menu_category.category_id INNER JOIN ticket_content ON  menu_items.item_id =  ticket_content.item_id INNER JOIN tickets ON  ticket_content.ticket_id =  tickets.ticket_id where tickets.ticket_id ="+ticket_id+"", cn);
                da = new SqlDataAdapter(cmd);
                
                da.Fill(ds, "open ticket content");
                cmd = new SqlCommand("select ticket_valu from tickets where ticket_id =" + ticket_id + "", cn);
                dr = cmd.ExecuteReader();
                dr.Read();
                value = dr[0].ToString() + "$";
                dr.Close();

            }
            cn.Close();
        }

        // gets closed tickets for specific table
        public static void fill_closed_tkt_grid(ref DataSet ds,int table)
        {
           
            cmd = new SqlCommand("SELECT * from cashier_home_view  where table_num =" + table+" and ticket_status = 'closed'and order_date= '"+DateTime.Now.ToString("yyyy-MM-dd")+"' ", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "closed");
        }

        // open new ticket 
        public static void new_tkt_table(int table)
        {
            cn.Open();
            cmd = new SqlCommand("insert into tickets values ("+table+",'"+DateTime.Now+"',null,'open','table',"+worker_id+",'"+DateTime.Now.ToString("yyyy-MM-dd")+"',0)", cn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("update the_tables set table_status =0 where table_number="+table+"", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        #endregion

        #region menu controller

        public static void fill_order_content(ref DataSet ds,int table_num)
        {
            ds = new DataSet();
            cn.Open();
            cmd = new SqlCommand("SELECT menu_items.item_name,  menu_items.item_size,  ticket_content.item_count,  menu_items.item_price,  menu_category.category_name FROM tickets INNER JOIN ticket_content ON  tickets.ticket_id =  ticket_content.ticket_id INNER JOIN  menu_items ON  ticket_content.item_id =  menu_items.item_id INNER JOIN  menu_category ON  menu_items.category_id =  menu_category.category_id where tickets.ticket_status='open' and tickets.table_num="+table_num+"", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "order_content");
            cn.Close();
        }
        public static List<int> get_item_id()
        {
            List<int> item_id=new List<int>();
            cn.Open();
            cmd = new SqlCommand("select item_id from menu_items", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                item_id.Add(Convert.ToInt32(dr[0]));
            }
            dr.Close();
            cn.Close();
            return item_id;
        }
        public static void panel_build(int item_id, ref string name ,ref string price , ref int pic_id)
        {
            cn.Open();
            cmd = new SqlCommand(" select * from menu_items where item_id="+item_id+"", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            name = dr[1].ToString()+" "+dr[2].ToString();
            price = dr[3].ToString();
            pic_id = Convert.ToInt32(dr[5]);
            dr.Close();
            cn.Close();
        }
        public static int get_tkt_id(int table)
        {
            int tkt_id;
            cn.Open();
            cmd = new SqlCommand("select ticket_id from tickets where table_num=" + table + " and ticket_status='open'", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            tkt_id = Convert.ToInt32(dr[0]);
            dr.Close();
            cn.Close();
            return tkt_id;
        }
        public static void add_order(int tkt_id,int item)
        {
            cn.Open();
            dr.Close();
            cmd = new SqlCommand("select item_count from ticket_content where ticket_id="+tkt_id+" and item_id="+item+"", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int count = Convert.ToInt32(dr[0]);
                dr.Close();
                cmd = new SqlCommand("update ticket_content set item_count=" + (count += 1) + " where item_id ="+item+"and ticket_id="+tkt_id+"", cn);
                cmd.ExecuteNonQuery();
            } else
            {
                dr.Close();
                cmd = new SqlCommand("insert into ticket_content values(" + tkt_id + " ," + item + ",1)", cn);
                cmd.ExecuteNonQuery();
            }
            
            cn.Close();           
        }
        public static string calc_total(int table)
        {
            string total = "";
            double total_price=0;
            int tkt_id;
            cn.Open();
            cmd = new SqlCommand("select ticket_id from tickets where table_num=" + table + " and ticket_status='open'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tkt_id = Convert.ToInt32(dr[0]);
                dr.Close();
                cmd = new SqlCommand("SELECT ticket_content.item_count,  menu_items.item_price FROM  menu_items INNER JOIN ticket_content ON  menu_items.item_id =  ticket_content.item_id where ticket_content.ticket_id=" + tkt_id + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    total_price += (Convert.ToDouble(dr[0]) * Convert.ToDouble(dr[1]));
                }
                dr.Close();
                cmd = new SqlCommand("update tickets set ticket_valu ="+total_price+" where ticket_id="+tkt_id+"", cn);
                cmd.ExecuteNonQuery();
            }
            total = total_price.ToString();
           
            cn.Close();
            return total;
        }

        // edit orders 
        public static void remove(int id, string item)
        {
            cn.Open();
            cmd = new SqlCommand("select item_count from payment_veiw where ticket_id =" + id + " and item_name='" + item + "'", cn);
            dr = cmd.ExecuteReader();
           if(dr.Read())
            {
                int count = (Convert.ToInt32(dr[0]) - 1);
                dr.Close();
                if (count > 0)
                {
                    cmd = new SqlCommand("update payment_veiw set item_count=" + count + "  where ticket_id =" + id + " and item_name='" + item + "'", cn);
                    cmd.ExecuteNonQuery();
                }
                else if (count == 0)
                {
                    cmd = new SqlCommand("delete from ticket_content where ticket_id =" + id + " and item_id=(select item_id from menu_items where item_name='" + item + "')", cn);
                    cmd.ExecuteNonQuery();
                }
            }
          
          
            cn.Close();
        }

        public static void delete(int id, string item)
        {
            cn.Open();
            cmd = new SqlCommand("delete from ticket_content where ticket_id =" + id + " and item_id=(select item_id from menu_items where item_name='" + item + "')", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        #endregion


        #endregion


        // methods for cashier form
        #region cashier form

        // cashier home page moethods
        #region home page
        // gits data for home page in cashier form from databse
        public static void fill_home_grid(ref DataSet ds)
        {
            ds = new DataSet();   
            cmd = new SqlCommand("select * from cashier_home_view where ticket_status= 'open' and order_date = '" + DateTime.Now.ToString("yyyy-MM-dd")+"'", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "open tickets");
            cmd = new SqlCommand("select * from cashier_home_view where ticket_status= 'closed' and order_date = '" + DateTime.Now.ToString("yyyy-MM-dd") +"'", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "closed tickets");
            cmd = new SqlCommand("select the_date ,total_calc from daily_profit", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "history");
        }


        //gets total income of the day until now and number of orders made
        public static void orders_income(ref string num_order, ref string income) 
        {
            cn.Open();
            cmd = new SqlCommand("select count (*) from tickets where order_date = '"+DateTime.Now.ToString("yyyy-MM-dd")+"'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                num_order = dr[0].ToString();
            }
           
            dr.Close();
            cmd = new SqlCommand(" select sum (ticket_valu) from tickets where order_date='" + DateTime.Now.ToString("yyyy-MM-dd") +"'", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr[0].ToString()!="")
            {
                income = dr[0].ToString();
            }
            dr.Close();
            cn.Close();
        }

        #endregion

        // payment page methods
        #region payment

        //gets data for tickets grid
        public static void fill_payment_open_tkt(ref DataSet ds , string tkt_status ,string typ)
        {
            ds = new DataSet();
            cmd = new SqlCommand("select * from cashier_home_view where order_date='"+DateTime.Now.ToString("yyyy-MM-dd")+"'"+tkt_status+typ, cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "payment tickets");

        }

        public static void fill_delivery(ref DataSet ds, string tkt_status,string typ)
        {
            ds = new DataSet();
            cmd = new SqlCommand("select * from delivery_veiw where order_date='"+DateTime.Now.ToString("yyyy-MM-dd")+"'"+tkt_status+typ, cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "payment tickets");

        }
    // gets the data for receipt content
    public static void fill_recipt(ref DataSet ds, int order_id)
        {
            ds = new DataSet();
            cmd = new SqlCommand("select * from payment_veiw where ticket_id ="+order_id+"", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "receipt");
        }
        // calculate the total value of receipt for payment
        public static double calc_payment(int receipt_id)
        {
            double total = 0;
            cn.Open();
            cmd = new SqlCommand(" select item_count , item_price from payment_veiw where ticket_id="+receipt_id+"", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                total += (Convert.ToDouble(dr[0]) * Convert.ToDouble(dr[1]));
            }
            dr.Close();
            cmd = new SqlCommand("update tickets set ticket_valu="+total+" where ticket_id="+receipt_id+"", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            return total;
        }

        //close ticket method

        public static void close_tkt(int tkt_id , double total_val,int table)
        {

            cn.Open();
            cmd = new SqlCommand("update tickets set close_time ='"+DateTime.Now.ToString()+"',ticket_status='closed' , ticket_valu="+total_val+" where ticket_id="+tkt_id+"", cn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("update the_tables set table_status=1 where table_number="+table+"", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static int new_tkt_delivry_takeaway(string typ)
        {
            string d = DateTime.Now.ToString();
            cn.Open();
            cmd = new SqlCommand("insert into tickets values (null,'" +d + "',null,'open','"+typ+"'," + worker_id + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "',0)", cn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("select ticket_id from tickets where open_time='"+d+"'", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            int order_id = Convert.ToInt32(dr[0]);
            dr.Close();
            cn.Close();
            return order_id;
            
        }

        //check ticket status 
        public static int check_ticket_status(int tkt_id)
        {
            int stat = 0;
            cn.Open();
            cmd = new SqlCommand("select ticket_status from tickets where ticket_id = "+tkt_id+"", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if(dr[0].ToString() == "open")
                {
                    stat = 1;
                }
            }
            dr.Close();
            cn.Close();
          
            return stat;
        }

        // take order in casheir form

        public static void add_order_casheir(int tkt_id, int item)
        {
            cn.Open();
            cmd = new SqlCommand("select item_count from ticket_content where ticket_id=" + tkt_id + " and item_id=" + item + "", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int count = Convert.ToInt32(dr[0]);
                dr.Close();
                cmd = new SqlCommand("update ticket_content set item_count=" + (count += 1) + " where item_id =" + item + "and ticket_id=" + tkt_id + "", cn);
                cmd.ExecuteNonQuery();
            }
            else
            {
                dr.Close();
                cmd = new SqlCommand("insert into ticket_content values(" + tkt_id + " ," + item + ",1)", cn);
                cmd.ExecuteNonQuery();
            }


            cn.Close();
            double valu= calc_payment(tkt_id);
            cn.Open();
            cmd = new SqlCommand("update tickets set ticket_valu="+valu+" where ticket_id="+tkt_id+"", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        #endregion

        #region Casheir Tickets
        /*  public static void fill_casheir_tkts_ds(ref DataSet ds )*/


        #endregion
        #endregion

        // delivery customers' information 

        #region customer info
        public static int check_customer(string phone)
        {
            int stat = 0;
            cn.Open();
            cmd = new SqlCommand("select * from customer_info where customer_phone='" + phone + "'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                stat = 1;
            }
            dr.Close();
            cn.Close();

                return stat;
        }

        public static void get_customer_info(string phone, ref string name , ref string adress, ref string pin, ref string email, ref int id)
        {
            cn.Open();
            cmd = new SqlCommand("select * from customer_info where customer_phone='"+phone+"'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                name = dr[1].ToString();
                id = Convert.ToInt32(dr[0]);
                adress = dr[3].ToString();
                email = dr[4].ToString();
                pin = dr[5].ToString();
            }
            dr.Close();
            cn.Close();
        }

        public static void add_delivery_order(int order_id, int customer_id,string adress)
        {
            cn.Open();
            cmd = new SqlCommand("insert into delivery values ("+order_id+","+customer_id+",35,1,'hold',N'"+adress+"')", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static int add_new_customer(string phone,  string name,  string adress,  string pin,  string email)
        {
            int id;
            cn.Open();
            cmd = new SqlCommand("insert into customer_info values(N'"+name+"',N'"+phone+"',N'"+adress+"',N'"+email+"',N'"+pin+"',1) ", cn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("select customer_id from customer_info where customer_phone = N'"+phone+"'", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            id = Convert.ToInt32(dr[0]);
            dr.Close();

            cn.Close();
            return id;
        }
        public static void get_customer_info(int id, ref string name, ref string adress, ref string pin, ref string email, ref string phone, ref int pic_id)
        {
            cn.Open();
            cmd = new SqlCommand("select * from customer_info where customer_id = " + id + "", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                name = dr[1].ToString();
                phone = dr[2].ToString();
                adress = dr[3].ToString();
                email = dr[4].ToString();
                pin = dr[5].ToString();
                pic_id = Convert.ToInt32(dr[6]);
            }
            dr.Close();
            cn.Close();

        }
        public static void get_customers_list(ref DataTable dt)
        {
            cmd = new SqlCommand("select customer_id,customer_name, customer_phone from customer_info", cn);

            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

        }
        public static void edit_customer(int id,   string name,   string adress,   string pin,   string email,   string phone,   int pic_id)
        {
            cn.Open();
            cmd = new SqlCommand("update customer_info set customer_name =N'"+name+"', customer_phone=N'"+phone+"',customer_adress=N'"+adress+"',customer_email=N'"+email+"'" +
                ",customer_pincode='"+pin+"',pic_id="+pic_id+" where customer_id="+id+"", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        #endregion



        #region prnt recipt 
        public static void make_receipt_list(int tkt_id )
        {
            cn.Open();
            cmd = new SqlCommand("select * from payment_veiw where ticket_id=" + tkt_id + "", cn);
            da = new SqlDataAdapter(cmd);
            dr = cmd.ExecuteReader();
            receiptd_list = new List<order_print_class>();
            while (dr.Read())
            {
                order_print_class item = new order_print_class();
                item.order_id = Convert.ToInt32(dr[0]);
                item.item_name = dr[1].ToString();
                item.item_size = dr[2].ToString();
                item.count = Convert.ToInt32(dr[3]);
                item.price = Convert.ToDouble(dr[4]);
                receiptd_list.Add(item);
            }
            dr.Close();
            cn.Close();
        }
        public static void get_customer_info(int tkt_id, ref string cus_name , ref string cus_phone , ref string  cus_adress , ref string time, ref string  type,ref string delivery_charge)
        {
            cn.Open();
            cmd = new SqlCommand("select * from recipt where ticket_id = "+tkt_id+"", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cus_name = dr[2].ToString();
                time = dr[1].ToString();
                cus_phone = dr[3].ToString();
                cus_adress = dr[4].ToString();
                type = dr[5].ToString();
                delivery_charge = dr[7].ToString();
            }
            dr.Close();
            cn.Close();

        }
        public static void get_takeaway_receipt(int tkt_id,ref string date,ref string typ)
        {
            cn.Open();
            cmd = new SqlCommand("select * from tickets where ticket_id ="+tkt_id+"", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            
                date = dr[2].ToString();
                typ = dr[5].ToString();
            
            dr.Close();
            cn.Close();
        }
        #endregion
    }
}
