using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y2K_WMS
{
    public class PersonModel
    {
        public int id{ get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string isAdmin { get; set; }
        public string password { get; set; }
    }
}
