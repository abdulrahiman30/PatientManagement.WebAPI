﻿using System;
using System.Collections.Generic;

namespace eSyaPatientManagement.DL.Entities
{
    public partial class GtEssrbr
    {
        public int BusinessKey { get; set; }
        public int ServiceId { get; set; }
        public int RateType { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string ServiceRule { get; set; }
        public decimal OpbaseRate { get; set; }
        public decimal IpbaseRate { get; set; }
        public bool? IsIprateWardwise { get; set; }
        public DateTime? EffectiveTill { get; set; }
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
