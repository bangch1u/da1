using A_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRespositories
{
    public interface ISachCTRes
    {
        List<SachChiTiet?> getAll(string Id);
        List<SachChiTiet?> getAll2();
        public bool UpdateSCT(SachChiTiet sachChiTiet);
        public bool AddSCT(SachChiTiet sachChiTiet);
        public string GetTenSachBySct(string Id);
    }
}
