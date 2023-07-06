﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eSyaPatientManagement.DO
{
    public class DO_DoctorClinicSchedule
    {
        public int SpecialtyId { get; set; }
        public string SpecialtyDesc { get; set; }
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorRemarks { get; set; }
        public string DayOfWeek { get; set; }
        public DateTime ScheduleDate { get; set; }

        public TimeSpan FromTime { get; set; }
        public TimeSpan ToTime { get; set; }

        public bool IsAvailable { get; set; }
        public bool IsOnLeave { get; set; }

        public bool Week1 { get; set; }
        public bool Week2 { get; set; }
        public bool Week3 { get; set; }
        public bool Week4 { get; set; }
        public bool Week5 { get; set; }

        public int NumberofPatients { get; set; }
    }
}
