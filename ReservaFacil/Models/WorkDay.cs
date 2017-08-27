using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaFacil.Models
{
    public class WorkDay
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool HasOffTime { get; set; }
        public DateTime StartOffTime { get; set; }
        public DateTime EndOffTime { get; set; }
    }
}
