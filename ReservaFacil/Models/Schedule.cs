using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaFacil.Models
{
    public class Schedule
    {
        public int id { get; set; }
        public Professional ProfesionalAssigned { get; set; }
        public int BucketSizeInMinutes { get; set; }

    }
}
