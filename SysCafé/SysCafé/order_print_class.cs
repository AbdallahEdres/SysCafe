using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysCafé
{
    public class order_print_class
    {
        public int order_id { get; set; }
        public string item_name { get; set; }
        public int count { get; set; }
        public double price { get; set; }
       
        public string item_size { get; set; }
        public double total
        {
            get
            {
                return count * price;
            }
        }
        
    }
}
