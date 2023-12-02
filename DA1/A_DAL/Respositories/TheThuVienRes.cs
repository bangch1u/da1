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
    public class TheThuVienRes : ITheThuVienRes
    {
        public bool AddTheThuVien(TheThuVien theThuVien)
        {
            try
            {
                dbConnection._dbDuAn.TheThuViens.Add(theThuVien);
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int GetDiemUyTinById(string id)
        {
            int? diemUyTin = dbConnection._dbDuAn.TheThuViens
            .Where(TTV => TTV.IdTheThuVien == id)
            .Select(TTV => (int?)TTV.DiemUyTin)
            .SingleOrDefault();

            return diemUyTin ?? 0; //nếu null trả về 0
        }

        public string? GetTheThuVienByID(string id)
        {
            List<String> theThuVienList = (from TTV in dbConnection._dbDuAn.TheThuViens
                                           join PM in dbConnection._dbDuAn.PhieuMuons on TTV.IdTheThuVien equals PM.IdTheThuVien
                                           where PM.IdTheThuVien == id
                                           select TTV.HoTen).ToList();

            return String.Join(", ", theThuVienList);
        }
    }
}
