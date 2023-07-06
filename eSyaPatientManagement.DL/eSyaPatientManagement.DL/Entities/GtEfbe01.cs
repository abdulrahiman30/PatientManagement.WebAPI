using System;
using System.Collections.Generic;

namespace eSyaPatientManagement.DL.Entities
{
    public partial class GtEfbe01
    {
        public string EpisodeId { get; set; }
        public string EpisodeDesc { get; set; }
        public int Sequence { get; set; }
        public bool AllowConsultation { get; set; }
        public string TokenType { get; set; }
        public bool TokenStatus { get; set; }
        public bool DefaultEpisode { get; set; }
        public bool ActiveStatus { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedTerminal { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedTerminal { get; set; }
    }
}
