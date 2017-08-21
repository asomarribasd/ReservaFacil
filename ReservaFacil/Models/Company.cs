using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaFacil.Models
{
    public class Company
    {
        public int id { get; set; }
        public List<Professional>  Professionals { get; set; }
        public List<Professional>  Services { get; set; }
    }
}
