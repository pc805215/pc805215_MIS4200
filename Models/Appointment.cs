using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pc805215_MIS4200.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        public string description { get; set; }
        public DateTime appointmentDate { get; set; }

        public int doctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        public int patientId { get; set; }
        public virtual Patient Patient { get; set; }
    }
}