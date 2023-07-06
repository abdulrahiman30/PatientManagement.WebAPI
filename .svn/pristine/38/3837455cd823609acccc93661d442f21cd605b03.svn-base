using eSyaPatientManagement.DL.Entities;
using eSyaPatientManagement.DL.Utility;
using eSyaPatientManagement.DO;
using eSyaPatientManagement.DO.StaticVariables;
using eSyaPatientManagement.IF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eSyaPatientManagement.DL.Repository
{
    public class PatientAccessRepository : IPatientAccessRepository
    {
        private eSyaEnterpriseContext _context { get; set; }
        public PatientAccessRepository(eSyaEnterpriseContext context)
        {
            _context = context;
        }

        public async Task<List<DO_PatientAccess>> GetPatientAccessbyISDCode(int ISDCode)
        {
            try
            {

                var _pa = _context.GtEpbe01.Where(x=>x.Isdcode==ISDCode)
                    .Select(d => new DO_PatientAccess
                    {
                        Isdcode = d.Isdcode,
                        AccessId = d.AccessId,
                        AccessDesc = d.AccessDesc,
                        AccessIdpattern = d.AccessIdpattern,
                        DefaultAccess=d.DefaultAccess,
                        ActiveStatus = d.ActiveStatus
                    }).ToListAsync();
                return await _pa;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<DO_ResponseParameter> InsertIntoPatientAccess(DO_PatientAccess obj)
        {
            var dbContext = _context.Database.BeginTransaction();
            try
            {

                var pa_Exits = _context.GtEpbe01.Where(w => w.Isdcode == obj.Isdcode && w.AccessId == obj.AccessId).Count();
                if (pa_Exits > 0)
                {
                    return new DO_ResponseParameter() { Status = false, Message = "Access ID is already Exists" };
                }

                bool pa_desc = _context.GtEpbe01.Where(x => x.Isdcode == obj.Isdcode).Any(a => a.AccessDesc.ToUpper().Replace(" ", "") == obj.AccessDesc.ToUpper().Replace(" ", ""));
                if (pa_desc)
                {
                    return new DO_ResponseParameter() { Status = false, Message = "Patient Access Description is already Exists" };
                }

                var is_DefaultAccess = _context.GtEpbe01.Where(w => w.Isdcode == obj.Isdcode && w.DefaultAccess == true  && w.ActiveStatus==true).Count();

                if (obj.DefaultAccess==true && is_DefaultAccess > 0)
                {
                    return new DO_ResponseParameter() { Status = false, Message = "Only one Patient Access can have Default Access true per ISD Code." };
                }

                int max_accessId = _context.GtEpbe01.Select(c => c.AccessId).DefaultIfEmpty().Max();

                int PAId = max_accessId + 1;

                var _pac = new GtEpbe01
                {
                    Isdcode = obj.Isdcode,
                    AccessId = PAId,
                    AccessDesc = obj.AccessDesc,
                    AccessIdpattern = obj.AccessIdpattern,
                    ActiveStatus = obj.ActiveStatus,
                    DefaultAccess=obj.DefaultAccess,
                    FormId = obj.FormID,
                    CreatedBy = obj.UserID,
                    CreatedOn = System.DateTime.Now,
                    CreatedTerminal = obj.TerminalID
                };
                _context.GtEpbe01.Add(_pac);
                await _context.SaveChangesAsync();
                dbContext.Commit();
                return new DO_ResponseParameter() { Status = true, Message = "Patient Access Saved Successfully." };
            }

            catch (Exception ex)
            {
                dbContext.Rollback();
                throw ex;
            }

        }

        public async Task<DO_ResponseParameter> UpdateIntoPatientAccess(DO_PatientAccess obj)
        {
            var dbContext = _context.Database.BeginTransaction();

            try
            {
                bool _dscExists = _context.GtEpbe01.Any(a => a.AccessId != obj.AccessId && a.AccessDesc.ToUpper().Trim().Replace(" ", "") == obj.AccessDesc.ToUpper().Trim().Replace(" ", ""));
                if (_dscExists)
                {
                    return new DO_ResponseParameter() { Status = false, Message = "Patient Access Description is already Exists" };
                }

                IEnumerable<GtEpbe01> ls_apct = _context.GtEpbe01.Where(w => w.Isdcode == obj.Isdcode).ToList();

                var is_DefaultaccessAssign = ls_apct.Where(w => w.DefaultAccess==true && w.Isdcode == obj.Isdcode
                              && w.AccessId != obj.AccessId && w.ActiveStatus).Count();

                if (obj.DefaultAccess==true && is_DefaultaccessAssign > 0)
                {
                    return new DO_ResponseParameter() { Status = false, Message = "Only one Patient Access can have Default Access true per ISD Code" };
                }

                GtEpbe01 _pa = _context.GtEpbe01.Where(w => w.AccessId == obj.AccessId && w.Isdcode == obj.Isdcode).FirstOrDefault();
                if (_pa == null)
                {
                    return new DO_ResponseParameter() { Status = false, Message = "Patient Access is not exist" };
                }

                _pa.AccessDesc = obj.AccessDesc;
                _pa.AccessIdpattern = obj.AccessIdpattern;
                _pa.DefaultAccess = obj.DefaultAccess;
                _pa.ActiveStatus = obj.ActiveStatus;
                _pa.ModifiedBy = obj.UserID;
                _pa.ModifiedOn = System.DateTime.Now;
                _pa.ModifiedTerminal = obj.TerminalID;
                await _context.SaveChangesAsync();
                dbContext.Commit();

                return new DO_ResponseParameter() { Status = true, Message = "Patient Access Updated Successfully." };
            }
            catch (Exception ex)
            {
                dbContext.Rollback();
                throw ex;
            }



        }

        
    }
}

