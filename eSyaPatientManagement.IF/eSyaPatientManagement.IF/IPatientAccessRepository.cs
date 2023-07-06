using eSyaPatientManagement.DO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eSyaPatientManagement.IF
{
   public interface IPatientAccessRepository
    {
        Task<List<DO_PatientAccess>> GetPatientAccessbyISDCode(int ISDCode);

        Task<DO_ResponseParameter> InsertIntoPatientAccess(DO_PatientAccess obj);

        Task<DO_ResponseParameter> UpdateIntoPatientAccess(DO_PatientAccess obj);

    }
}
