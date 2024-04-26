using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients_Birthday.Models
{
    public class orders
    {
        public int Id { get; set; }
        public int position_id { get; set; }
        public int order_id { get; set;}
        public int count { get; set; }
        public DateTime order_date { get; set; }
        public int discount { get; set; }
        public customers customer { get; set; }
        public positions position { get; set; }
    }
}
