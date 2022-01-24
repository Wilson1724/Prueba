using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloPrueba.Entidades
{
    public class store
    {
        public int storeId { get; set; }
        public int manager_staff_id { get; set; }
        public staff staffstore { get; set; }
        public string address_id { get; set; }
        public string last_update { get; set; }
    }
}
