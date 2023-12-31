﻿using eSyaPatientManagement.DO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eSyaPatientManagement.IF
{
    public interface IMasterRepository
    {
        Task<List<DO_IsdCodes>> GetISDCodes();
        Task<List<DO_Place>> GetStateList(int isdCode);
        //REMOVED TABLE 
        //Task<List<DO_Place>> GetCityList(int isdCode, int stateCode);
        //REMOVED TABLE 
        //Task<List<DO_AddressIN>> GetAreaList(int isdCode, int stateCode, int cityCode, string pincode);

        //REMOVED TABLE 
        //Task<List<DO_AddressIN>> GetCountryAreaDetailsByPincode(int isdCode, string pincode);

        Task<List<DO_EpisodeType>> GetEpisodeType();
        Task<List<DO_PatientType>> GetPatientType();
        Task<List<DO_PatientCategory>> GetPatientCategory(int patientTypeId);
        Task<List<DO_BillSuspendType>> GetBillSuspendType();

        Task<List<DO_ServiceCode>> GetServiceClassesByTypeID(int serviceType);
        Task<List<DO_DrugMaster>> GetDrugMaster();
        Task<List<DO_ServiceCode>> GetServiceCodesByClassID(int serviceType, int serviceClass);

        //Task<DO_Doctors> GetDoctorByID(int doctorId);

        Task<List<DO_ApplicationCodes>> GetApplicationCodesByCodeTypeList(List<int> l_codeType);

        Task<List<DO_CurrencyMaster>> GetActiveCurrencies();
    }
}
