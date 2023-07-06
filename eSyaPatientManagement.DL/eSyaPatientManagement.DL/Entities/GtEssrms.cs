﻿using System;
using System.Collections.Generic;

namespace eSyaPatientManagement.DL.Entities
{
    public partial class GtEssrms
    {
        public GtEssrms()
        {
            GtEspasm = new HashSet<GtEspasm>();
        }

        public int ServiceId { get; set; }
        public int ServiceClassId { get; set; }
        public string ServiceDesc { get; set; }
        public string ServiceShortDesc { get; set; }
        public string Gender { get; set; }
        public bool IsServiceBillable { get; set; }
        public decimal ServiceCost { get; set; }
        public string InternalServiceCode { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedTerminal { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedTerminal { get; set; }

        public virtual GtEssrcl ServiceClass { get; set; }
        public virtual ICollection<GtEspasm> GtEspasm { get; set; }
    }
}
