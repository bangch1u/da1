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
    public class TacGiaSachRes : ITacGiaSachRes
    {
        public bool AddTacGiaSach(TacGiaSach tacGiaSach)
        {
            try
            {
                dbConnection._dbDuAn.TacGiaSaches.Add(tacGiaSach);
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<TacGiaSach> GetAllTacGia()
        {
            return dbConnection._dbDuAn.TacGiaSaches.ToList();
        }

        public string? GetTacGiaByID(string id)
        {
            List<String> tacGiaList = (from TGS in dbConnection._dbDuAn.TacGiaSaches
                                       join TG in dbConnection._dbDuAn.TacGia on TGS.IdTacGia equals TG.IdTacGia
                                       join S in dbConnection._dbDuAn.Saches on TGS.BarCodeSach equals S.BarCodeSach
                                       where TGS.BarCodeSach == id
                                       select TG.HoTen).ToList();

            return String.Join(", ", tacGiaList);
        }
    }
}
