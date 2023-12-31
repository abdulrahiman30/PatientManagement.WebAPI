﻿using System;
using System.Collections.Generic;

namespace eSyaPatientManagement.DL.Entities
{
    public partial class GtEsdobl
    {
        public int BusinessKey { get; set; }
        public int DoctorId { get; set; }
        public int TimeSlotInMins { get; set; }
        public int PatientCountPerHour { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedTerminal { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedTerminal { get; set; }
    }
}
