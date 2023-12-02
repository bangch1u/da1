using A_DAL.Context;
using A_DAL.DomainClass;
using A_DAL.IRespositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Respositories
{
    public class PhieuMuonChiTietRes : IPMCTRes
    {
        public bool AddPMCT(PhieuMuonChiTiet phieuMuonChiTiet)
        {
            try
            {
                dbConnection._dbDuAn.PhieuMuonChiTiets.Add(phieuMuonChiTiet);
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<PhieuMuonChiTiet> GetAllPMCT()
        {
            return dbConnection._dbDuAn.PhieuMuonChiTiets.ToList();
        }

        public bool UpdatePMCT(PhieuMuonChiTiet phieuMuonChiTiet)
        {
            try
            {
                dbConnection._dbDuAn.PhieuMuonChiTiets.Update(phieuMuonChiTiet);
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
