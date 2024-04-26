using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients_Birthday.Models
{
    public class customers
    {
        public int Id { get; set; }
        public string name { get; set; } = null!;
        public string email { get; set; }
        public bool malling_allowed { get; set; } = false;
        public DateTime birthday { get; set; }
    }
}
