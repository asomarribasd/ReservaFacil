using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaFacil.Models
{
    public class Appointment
    {
        public int id { get; set; }
        public Company AssistingCompany { get; set; }
        public Client ClientScheduled { get; set; }
        public Professional ProfesionalVisited { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int AppointmentLong { get; set; }

    }
}
