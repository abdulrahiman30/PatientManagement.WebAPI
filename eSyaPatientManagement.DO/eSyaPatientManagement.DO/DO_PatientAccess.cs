using System;
using System.Collections.Generic;
using System.Text;

namespace eSyaPatientManagement.DO
{
   public class DO_PatientAccess
    {
        public int Isdcode { get; set; }
        public int AccessId { get; set; }
        public string AccessDesc { get; set; }
        public string AccessIdpattern { get; set; }
        public bool DefaultAccess { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormID { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
