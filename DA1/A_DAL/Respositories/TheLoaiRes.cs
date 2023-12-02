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
    public class TheLoaiRes : ITheLoaiRes
    {
        public List<TheLoai> GetAllTheLoai()
        {
            return dbConnection._dbDuAn.TheLoais.ToList();
        }

        public string? GetTheLoaiByID(string id)
        {
            throw new NotImplementedException();
        }
    }
}
