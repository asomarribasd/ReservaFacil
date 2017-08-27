using System.Collections.Generic;

namespace ReservaFacil.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public IList<Professional>  Professionals { get; set; }
        public IList<OfferService>  Services { get; set; }
    }
}
