using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaFacil.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public List<Professional>  Professionals { get; set; }
        public List<Service>  Services { get; set; }
    }
}
