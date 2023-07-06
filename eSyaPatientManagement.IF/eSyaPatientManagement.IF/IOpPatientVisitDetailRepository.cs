﻿using eSyaPatientManagement.DO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eSyaPatientManagement.IF
{
    public interface IOpPatientVisitDetailRepository
    {
        Task<List<DO_PatientRegisteredList>> GetPatientRegisteredList(
          int businessKey, DateTime visitFromDate, DateTime visitTillDate,
           int? clinicTypeId, int? patientTypeId, long? uhid);

        Task<DO_PatientOpVisitDetails> GetPatientOpVisitDetails(int businessKey, long uhid, long opNumber);

        Task<List<DO_PatientRegisteredList>> GetPatientRegisteredListbySearchCriteria(
    int businessKey, DateTime visitFromDate, DateTime visitTillDate,
     int? clinicTypeId, int? patientTypeId, long? uhid, string patientname);
    }
}
