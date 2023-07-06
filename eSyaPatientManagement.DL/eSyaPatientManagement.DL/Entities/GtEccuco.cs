﻿using System;
using System.Collections.Generic;

namespace eSyaPatientManagement.DL.Entities
{
    public partial class GtEccuco
    {
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public string Symbol { get; set; }
        public decimal DecimalPlaces { get; set; }
        public bool ShowInMillions { get; set; }
        public bool SymbolSuffixToAmount { get; set; }
        public string DecimalPortionWord { get; set; }
        public bool UsageStatus { get; set; }
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
