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

namespace C_PRL.qlyPhieu
{
    public partial class fMuonSach : Form
    {
        List<SachChiTiet> sachCTList;
        public fMuonSach()
        {
            InitializeComponent();
            ShowData();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            DataCmb();
        }
        void ConfigData()
        {
            dataGridView1.Rows.Clear();
            for (int i = 1; i <= sachCTList.Count; i++)
            {
                var sachCT = sachCTList[i - 1];
                if (sachCT.TrangThai == 0)//nếu trạng thái là 0: đã bị mượn và ẩn
                {
                    continue; // Bỏ qua dòng này và tiếp tục vòng lặp
                }
                dataGridView1.Rows.Add(
                i.ToString(),
                sachCT.BarCodeMaSach,
                sachCT.BarCodeSach,
                svc.services.GetTenSach(sachCT.BarCodeSach),
                sachCT.TinhTrangSach,
                svc.services.GetNhaXuatBanByID(sachCT.IdNxb),
                //sachCT.LanTaiBan,
                //sachCT.NamTaiBan,
                //sachCT.KichCo,
                sachCT.DiemUyTinMin,
                sachCT.TrangThai

                );
            }
        }

        void ShowData()
        {
            sachCTList = svc.services.GetAllSachCT2();

            ConfigData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSach.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBarcodeS.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        public void DataCmb()
        {
            var lstNhanVien = svc.services.GetAllNhanVien();
            cmbNhanVien.DataSource = lstNhanVien;
            cmbNhanVien.DisplayMember = "hoTen";
            cmbNhanVien.ValueMember = "idNhanVien";
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            var obj = svc.services.GetAllPhieuMuon(null).FirstOrDefault(pm => pm.IdPhieuMuon == txtMaPM.Text);
            var sct = svc.services.GetAllSachCT2().FirstOrDefault(s => s.BarCodeMaSach == txtMaSach.Text);
            int diemUyTin = svc.services.GetDiemUyTin(obj.IdTheThuVien); //lấy điểm uy tín để check mượn sách
            MessageBox.Show(diemUyTin.ToString());
            PhieuMuonChiTiet pmct = new PhieuMuonChiTiet()
            {
                IdPhieuMuon = txtMaPM.Text,
                BarCodeMaSach = txtMaSach.Text,
                NgayMuonSach = dtNgayMuon.Value,
                NgayTraSach = dtNgayTra.Value,
                SoLanGiaHan = 0,
                IdNhanVien = cmbNhanVien.SelectedValue.ToString()
            };
            //MessageBox.Show(cmbNhanVien.SelectedValue.ToString());
            int minUyTin = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            if (diemUyTin < minUyTin)
            {
                MessageBox.Show("Bạn không đủ điểm uy tín để mượn quyển sách này!");
                return;
            }
            var resultAdd = svc.services.AddPMCT(pmct);

            // Update the TongSachMuon in PhieuMuon
            if (resultAdd)
            {
                // Increment the TongSachMuon by 1
                obj.TongSachMuon += 1;

                // Update the PhieuMuon
                var resultUpPM = svc.services.UpdatePhieuMuon(obj);
                // chuyển trạng thái sách
                sct.TrangThai = 0;
                var resultUpSCT = svc.services.UpdateSCT(sct);
                if (resultUpSCT == false)
                {
                    MessageBox.Show("Lỗi cập nhập sách chi tiết");
                }
                if (resultUpPM)
                {
                    MessageBox.Show("Mượn thành công");
                }
                else
                {
                    // Handle the case where updating PhieuMuon fails
                    MessageBox.Show("Lỗi khi cập nhật thông tin mượn sách");
                }
            }
            else
            {
                // Handle the case where adding PhieuMuonChiTiet fails
                MessageBox.Show("Lỗi khi thêm chi tiết mượn sách");
               
            }
            ShowData();
        }
    }
}
