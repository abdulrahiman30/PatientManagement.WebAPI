﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaPatientManagement.IF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eSyaPatientManagement.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OpPatientVisitDetailController : ControllerBase
    {
        private readonly IOpPatientVisitDetailRepository _opPatientVisitDetailRepository;

        public OpPatientVisitDetailController(IOpPatientVisitDetailRepository opPatientVisitDetailRepository)
        {
            _opPatientVisitDetailRepository = opPatientVisitDetailRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetPatientRegisteredList(
          int businessKey, DateTime visitFromDate, DateTime visitTillDate,
           int? clinicTypeId, int? patientTypeId, long? uhid)
        {
            var rs = await _opPatientVisitDetailRepository.GetPatientRegisteredList(
                businessKey, visitFromDate, visitTillDate,
                clinicTypeId, patientTypeId, uhid);
            return Ok(rs);
        }

        [HttpGet]
        public async Task<IActionResult> GetPatientOpVisitDetails(int businessKey, long uhid, long opNumber)
        {
            var rs = await _opPatientVisitDetailRepository.GetPatientOpVisitDetails(
                businessKey, uhid, opNumber);
            return Ok(rs);
        }

        [HttpGet]
        public async Task<IActionResult> GetPatientRegisteredListbySearchCriteria(
    int businessKey, DateTime visitFromDate, DateTime visitTillDate,
     int? clinicTypeId, int? patientTypeId, long? uhid, string patientname)
        {
            var rs = await _opPatientVisitDetailRepository.GetPatientRegisteredListbySearchCriteria(
                businessKey, visitFromDate, visitTillDate,
                clinicTypeId, patientTypeId, uhid, patientname);
            return Ok(rs);
        }
    }
}