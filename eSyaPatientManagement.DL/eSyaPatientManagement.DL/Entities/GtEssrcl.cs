﻿using System;
using System.Collections.Generic;

namespace eSyaPatientManagement.DL.Entities
{
    public partial class GtEssrcl
    {
        public GtEssrcl()
        {
            GtEssrms = new HashSet<GtEssrms>();
        }

        public int ServiceClassId { get; set; }
        public int ServiceGroupId { get; set; }
        public string ServiceClassDesc { get; set; }
        public int ParentId { get; set; }
        public int PrintSequence { get; set; }
        public bool IsBaseRateApplicable { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedTerminal { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedTerminal { get; set; }

        public virtual GtEssrgr ServiceGroup { get; set; }
        public virtual ICollection<GtEssrms> GtEssrms { get; set; }
    }
}
