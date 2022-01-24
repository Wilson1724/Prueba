using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloPrueba.Entidades
{
    public class staff
    {
        public int staff_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int address_id { get; set; }
        public string email { get; set; }
        public int store_id { get; set; }
        public store storestaff {get;set;}
        public string active { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string last_update { get; set; }
        public string picture { get; set; }

    }
}
