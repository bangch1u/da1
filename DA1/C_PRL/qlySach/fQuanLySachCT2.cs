using A_DAL.DomainClass;
using B_BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PRL.qlySach
{
    public partial class fQuanLySachCT2 : Form
    {
        List<SachChiTiet> sachCTList;
        public fQuanLySachCT2()
        {
            InitializeComponent();
            ShowData();
        }
        void ConfigData()
        {
            for (int i = 1; i <= sachCTList.Count; i++)
            {
                var sachCT = sachCTList[i - 1];
                var tt = sachCT.TrangThai;
                string trangThai;
                if (tt == 0)
                {
                    trangThai = "đã mượn";
                }
                else 
                {
                    trangThai = "chưa mượn";
                }
                dtgShow.Rows.Add(
                i.ToString(),
                sachCT.BarCodeMaSach,
                svc.services.GetTenSach(sachCT.BarCodeSach),             
                sachCT.TinhTrangSach,
                sachCT.LanTaiBan,
                
                sachCT.NamTaiBan,
                sachCT.DiemUyTinMin,
                svc.services.GetNhaXuatBanByID(sachCT.IdNxb),
                sachCT.KichCo,
                trangThai
                );
            }
        }

        void ShowData()
        {
            sachCTList = svc.services.GetAllSachCT2();

            ConfigData();
        }
    }
}
