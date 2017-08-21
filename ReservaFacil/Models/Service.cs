using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaFacil.Models
{
    public class Service
    {
        public int id { get; set; }
        public Company CompanyAssigned { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
    }
}
