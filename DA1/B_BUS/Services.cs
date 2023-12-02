using A_DAL.DomainClass;
using A_DAL.IRespositories;
using A_DAL.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS
{
    public class Services : IServices
    {
        //public static IUserRes UserRes = new UserRes(); //Khởi tạo biến tài khoản repos
          public static ISachRes SachRes = new SachRes(); //Khởi tạo biến Sách repos
          public static ISachCTRes SachCTRes = new SachChiTietRes(); //Khởi tạo biến Sách Chi tiết repos
          public static ITacGiaSachRes TacGiaRes = new TacGiaSachRes(); //Khởi tạo biến tác giả repos
          public static ITheLoaiRes TheLoaiRes = new TheLoaiRes(); //Khởi tạo biến thể loại repos
          public static IPhieuMuonRes PhieuMuonRes = new PhieuMuonRes(); // 
          public static ITheThuVienRes TheThuVienRes = new TheThuVienRes();
          public static IPMCTRes PMCTRes = new PhieuMuonChiTietRes();//khởi tạo biến phiếu mượn chi tiết repos
          public static INhaXuatBanRes NXBRes = new NhaXuatBanRes();
          public static INhanVienRes NhanVienRes = new NhanVienRes();
          public static ITacGiaRes tacGiaRes = new TacGiaRes();
          public static IChiTietTheLoai cTTLRes = new ChiTietTheLoaiRes();



        //public bool? Login(string username, string password) => UserRes.Login(username, password); // Đăng nh
        public List<Sach?> GetAllSach() => SachRes.getAll(); //Lấy danh sách sách
        public int getCountById(string Id) => SachRes.getCountById(Id); //Lấy số lượng sách theo barcode
        public List<SachChiTiet?> GetAllSachCT(string Id) => SachCTRes.getAll(Id); //Lấy danh sách sách
        public List<SachChiTiet?> GetAllSachCT2() => SachCTRes.getAll2(); //Lấy danh sách sách

        public string? GetTacGiaByID(string id) => TacGiaRes.GetTacGiaByID(id); //Lấy chuỗi tên tác giả của sách theo mã sách
        public string? GetTheLoaiByID(string id) => cTTLRes.GetTheLoaiByID(id); //Lấy chuỗi thể loại của sách theo mã sách
        public List<TheLoai> GetAllTheLoai() => TheLoaiRes.GetAllTheLoai(); //Lấy danh sách thể loại

        public List<PhieuMuon> GetAllPhieuMuon(string id) => PhieuMuonRes.GetAllPhieuMuon(id);//lấy danh sách phiếu mượn

        public string? GetTheThuVienByID(string id) => TheThuVienRes.GetTheThuVienByID(id);

        public bool AddTheThuVien(TheThuVien theThuVien)
        {
            return TheThuVienRes.AddTheThuVien(theThuVien);
        }

        public bool AddPhieuMuon(PhieuMuon phieuMuon) => PhieuMuonRes.AddPhieuMuon(phieuMuon);

        public bool UpdatePhieuMuon(PhieuMuon phieuMuon) => PhieuMuonRes.UpdatePhieuMuon(phieuMuon);

  

        public List<PhieuMuonChiTiet> GetAllPMCT() => PMCTRes.GetAllPMCT();

        public bool AddSach(Sach sach) => SachRes.AddSach(sach);

        public string? GetNhaXuatBanByID(string id) => NXBRes.GetNhaXuatBanByID(id);

        public string GetTenSach(string id) => SachRes.GetTenSachById(id);

        public List<NhanVien> GetAllNhanVien() => NhanVienRes.GetAllNhanVien();
        public int GetDiemUyTin(string id) => TheThuVienRes.GetDiemUyTinById(id);

        public bool AddPMCT(PhieuMuonChiTiet phieuMuonChiTiet) => PMCTRes.AddPMCT(phieuMuonChiTiet);

        public bool UpdateSCT(SachChiTiet sachChiTiet) => SachCTRes.UpdateSCT(sachChiTiet);

        public List<TacGium> GetAllTacGia() => tacGiaRes.GetAllTacGia2();
        public bool AddTacGiaSach(TacGiaSach tacGiaSach) => TacGiaRes.AddTacGiaSach(tacGiaSach);

       // public List<TheLoai> GetAllTheLoaiSach() => TheLoaiRes.GetAllTheLoai();

        public bool AddTheLoaiChiTiet(ChiTietTheLoai chiTietTheLoai) => cTTLRes.AddTLCT(chiTietTheLoai);
        public List<NhaXuatBan> GetAllNXB() => NXBRes.GetAllNXB();

        public bool AddSachChiTiet(SachChiTiet sachChiTiet) => SachCTRes.AddSCT(sachChiTiet);
        public bool UpdateSach(Sach sach) => SachRes.UpdateSach(sach);
        public string GetTenSachBySct(string id) => SachCTRes.GetTenSachBySct(id);

        public bool UpdatePhieuMuonCT(PhieuMuonChiTiet phieuMuonChiTiet) => PMCTRes.UpdatePMCT(phieuMuonChiTiet);
        
    }
}
