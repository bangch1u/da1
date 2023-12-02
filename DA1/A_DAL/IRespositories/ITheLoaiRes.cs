using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.DomainClass;

namespace A_DAL.IRespositories
{
    public interface ITheLoaiRes
    {
        public string? GetTheLoaiByID(string id);
        public List<TheLoai> GetAllTheLoai();
    }
}
