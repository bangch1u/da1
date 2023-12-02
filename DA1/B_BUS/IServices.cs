using A_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS
{
    public interface IServices
    {
        //public bool? Login(string username, string password); //Đăng nhập
        public List<Sach?> GetAllSach(); //Lấy list sách
        public int getCountById(string Id); //Lấy số lượng sách
        public List<SachChiTiet?> GetAllSachCT(string Id); //Lấy list sách chi tiết
        public List<SachChiTiet?> GetAllSachCT2(); //Lấy list sách chi tiết
        public string? GetTacGiaByID(string id); //Lấy Tác giả sách
        public string? GetTheLoaiByID(string id); //Lấy thể loại sách
        public List<TheLoai> GetAllTheLoai(); //Lấy danh sách thể loại

        public string? GetTheThuVienByID(string id); // bằng
        public List<PhieuMuon> GetAllPhieuMuon(string id); // lấy danh sách phiếu mượn (bằng)

        public bool AddTheThuVien(TheThuVien theThuVien);
        public bool AddPhieuMuon(PhieuMuon phieuMuon);
        public bool UpdatePhieuMuon(PhieuMuon phieuMuon);
        public List<PhieuMuonChiTiet> GetAllPMCT();
        public bool AddSach(Sach sach);
        public string? GetNhaXuatBanByID(string id);
        public string? GetTenSach(string id);
        public List<NhanVien> GetAllNhanVien();
        public int GetDiemUyTin(string id);
        public bool AddPMCT(PhieuMuonChiTiet phieuMuonChiTiet);
        public bool UpdateSCT(SachChiTiet sachChiTiet);
        public List<TacGium> GetAllTacGia();
        public bool AddTacGiaSach(TacGiaSach tacGiaSach);
        //public List<TheLoaiSach> GetAllTheLoaiSach();
        public bool AddTheLoaiChiTiet(ChiTietTheLoai chiTietTheLoai);
        public List<NhaXuatBan> GetAllNXB();
        public bool AddSachChiTiet(SachChiTiet sachChiTiet);
        public bool UpdateSach(Sach sach);
        public string GetTenSachBySct(string id);
        public bool UpdatePhieuMuonCT(PhieuMuonChiTiet phieuMuonChiTiet);
    }
}
