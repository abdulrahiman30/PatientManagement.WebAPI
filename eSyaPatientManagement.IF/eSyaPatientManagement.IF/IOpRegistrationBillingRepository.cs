using eSyaPatientManagement.DO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eSyaPatientManagement.IF
{
    public interface IOpRegistrationBillingRepository
    {
        // DUE TO TABLES STRUCTRE CHANGED LIKE GT_ESDOCD--QUALIFICATION,TIME SLOT IN MINUTES REMOVED. GT_ESDOS2 SCHEDULE DATE REMOVED
        //Task<DO_ResponseParameter> InsertOPRegistrationVisit(DO_OPRegistrationVisit obj);
    }
}
