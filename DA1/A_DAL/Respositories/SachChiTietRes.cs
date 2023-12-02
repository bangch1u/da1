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
    public class SachChiTietRes : ISachCTRes
    {
        public bool AddSCT(SachChiTiet sachChiTiet)
        {
            try
            {
                dbConnection._dbDuAn.SachChiTiets.Add(sachChiTiet);
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<SachChiTiet?> getAll(string Id)
        {
            return dbConnection._dbDuAn.SachChiTiets.Where(sct => sct.BarCodeSach == Id).ToList();
        }

        public List<SachChiTiet?> getAll2()
        {
            return dbConnection._dbDuAn.SachChiTiets.ToList();
        }

        public string GetTenSachBySct(string Id)
        {
            List<String> tenSach = (from Sct in dbConnection._dbDuAn.SachChiTiets
                                    join S in dbConnection._dbDuAn.Saches on Sct.BarCodeSach equals S.BarCodeSach
                                    where Sct.BarCodeMaSach == Id
                                    select S.TenSach).ToList();

            return String.Join(", ", tenSach);
        }

        public bool UpdateSCT(SachChiTiet sachChiTiet)
        {
            try
            {
                dbConnection._dbDuAn.SachChiTiets.Update(sachChiTiet);
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
