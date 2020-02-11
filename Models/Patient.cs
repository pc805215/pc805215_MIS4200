using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pc805215_MIS4200.Models
{
    public class Patient
    {
        public int patientId { get; set; }

        public string patientAddress { get; set; }
        public string patientFirstName { get; set; }
        public string patientLastName { get; set; }

        public string patientEmail { get; set; }
        public string patientPhone { get; set; }
        public DateTime patientDOB { get; set; }
        public DateTime patientSince { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
    }
}