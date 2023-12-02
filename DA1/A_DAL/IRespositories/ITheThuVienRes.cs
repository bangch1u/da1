using A_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRespositories
{
    public interface ITheThuVienRes
    {
        public string? GetTheThuVienByID(string id);
        public bool AddTheThuVien(TheThuVien theThuVien);
        public int GetDiemUyTinById(string id); // lấy điểm uy tín để so sánh mượn sách
    }
}
