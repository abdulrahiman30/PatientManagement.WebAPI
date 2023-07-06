﻿using System;
using System.Collections.Generic;

namespace eSyaPatientManagement.DL.Entities
{
    public partial class GtEcpapc
    {
        public int PatientTypeId { get; set; }
        public int PatientCategoryId { get; set; }
        public int ParameterId { get; set; }
        public decimal ParmPerc { get; set; }
        public string ParmDesc { get; set; }
        public decimal ParmValue { get; set; }
        public bool ParmAction { get; set; }
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
