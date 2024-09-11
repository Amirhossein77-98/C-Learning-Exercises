using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curiousity.Models
{
    public class AppDbContext : Db
    {
        public string name { get; set; }
        public int phone { get; set; }
        public int stuNum { get; set; }
        public int score { get; set; }
    }
}
