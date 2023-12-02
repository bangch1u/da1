using A_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRespositories
{
    public interface ITacGiaSachRes
    {
        public string? GetTacGiaByID(string id);
        public List<TacGiaSach> GetAllTacGia();
        public bool AddTacGiaSach(TacGiaSach tacGiaSach);
    }
}
