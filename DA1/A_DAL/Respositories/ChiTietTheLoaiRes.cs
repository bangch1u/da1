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
    public class ChiTietTheLoaiRes : IChiTietTheLoai
    {
        public bool AddTLCT(ChiTietTheLoai chiTietTheLoai)
        {
            try
            {
                
                dbConnection._dbDuAn.ChiTietTheLoais.Add(chiTietTheLoai);
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string? GetTheLoaiByID(string id)
        {
            List<String> theLoaiList = (from TLCT in dbConnection._dbDuAn.ChiTietTheLoais
                                        join TL in dbConnection._dbDuAn.TheLoais on TLCT.IdTheLoai equals TL.IdTheLoai
                                        join S in dbConnection._dbDuAn.Saches on TLCT.BarCodeSach equals S.BarCodeSach
                                        where TLCT.BarCodeSach == id
                                        select TL.TenTheLoai).ToList();

            return String.Join(", ", theLoaiList);
        }
    }
}
