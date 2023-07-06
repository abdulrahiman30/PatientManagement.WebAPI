using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaPatientManagement.DO;
using eSyaPatientManagement.IF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace eSyaPatientManagement.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PatientAccessController : ControllerBase
    {
        private readonly IPatientAccessRepository _patientAccessRepository;

        public PatientAccessController(IPatientAccessRepository patientAccessRepository)
        {
            _patientAccessRepository = patientAccessRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetPatientAccessbyISDCode(int ISDCode)
        {
            var pa = await _patientAccessRepository.GetPatientAccessbyISDCode(ISDCode);
            return Ok(pa);
        }

        [HttpPost]
        public async Task<IActionResult> InsertIntoPatientAccess(DO_PatientAccess obj)
        {
            var msg = await _patientAccessRepository.InsertIntoPatientAccess(obj);
            return Ok(msg);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateIntoPatientAccess(DO_PatientAccess obj)
        {
            var msg = await _patientAccessRepository.UpdateIntoPatientAccess(obj);
            return Ok(msg);
        }

        
    }
}