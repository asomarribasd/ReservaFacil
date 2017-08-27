using System.Collections.Generic;

namespace ReservaFacil.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public IList<ApplicationUser> Users { get; set; }
        public IList<Professional>  Professionals { get; set; }
        public IList<OfferedService>  Services { get; set; }
    }
}
