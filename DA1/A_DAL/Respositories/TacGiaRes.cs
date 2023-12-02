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
    public class TacGiaRes : ITacGiaRes
    {
        public List<TacGium> GetAllTacGia2()
        {
            return dbConnection._dbDuAn.TacGia.ToList();
        }
    }
}
