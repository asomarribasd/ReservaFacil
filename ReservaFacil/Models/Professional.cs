using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaFacil.Models
{
    public class Professional
    {
        public int id { get; set; }
        public Company CompanyServicing { get; set; }
        public Person PersonalInformation { get; set; }
    }
}
