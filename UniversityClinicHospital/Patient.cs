using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Patient
    {
        public int HealthStatus { get; set; }
        public int BloodLevel { get; set; }

        public Patient()
        {
            HealthStatus = 10;
            BloodLevel = 20;
        }
    }
}
