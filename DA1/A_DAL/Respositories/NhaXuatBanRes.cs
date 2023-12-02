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
    public class NhaXuatBanRes : INhaXuatBanRes
    {
        public List<NhaXuatBan> GetAllNXB()
        {
            return dbConnection._dbDuAn.NhaXuatBans.ToList();
        }

        public string? GetNhaXuatBanByID(string id)
        {
            List<String> nxbList = (from nxb in dbConnection._dbDuAn.NhaXuatBans
                                    where nxb.IdNxb == id
                                    select nxb.TenNxb).ToList();

            return String.Join(", ", nxbList);
        }
    }
}
