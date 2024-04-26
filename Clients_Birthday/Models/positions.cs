using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients_Birthday.Models
{
    public class positions
    {
        public int Id { get; set; }
        public string name { get; set; } = null!;
        public SqlMoney price { get; set; }
    }
}
