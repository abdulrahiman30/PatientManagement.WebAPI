﻿using System;
using System.Collections.Generic;

namespace eSyaPatientManagement.DL.Entities
{
    public partial class GtEfoppi
    {
        public int BusinessKey { get; set; }
        public long RUhid { get; set; }
        public long Opnumber { get; set; }
        public int SerialNumber { get; set; }
        public bool IsPrimaryPayer { get; set; }
        public int Payer { get; set; }
        public int RatePlan { get; set; }
        public int SchemePlan { get; set; }
        public string MemberId { get; set; }
        public decimal CoPayPerc { get; set; }
        public string InsuranceCardNo { get; set; }
        public DateTime? InsuranceExpDate { get; set; }
        public bool ActiveStatus { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedTerminal { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedTerminal { get; set; }

        public virtual GtEfopvd GtEfopvd { get; set; }
    }
}
