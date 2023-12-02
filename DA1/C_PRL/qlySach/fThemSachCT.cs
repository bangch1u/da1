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
    public partial class fThemSachCT : Form
    {
        List<Sach?> sachList;
        public fThemSachCT()
        {
            InitializeComponent();
            DataCmb();
            ShowData();
        }
        public void DataCmb()
        {
            var lstNXB = svc.services.GetAllNXB();
            cmbNXB.DataSource = lstNXB;
            cmbNXB.DisplayMember = "tenNXB";
            cmbNXB.ValueMember = "idNXB";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var obj = svc.services.GetAllSach().FirstOrDefault(s => s.BarCodeSach == txtBarcodeSach.Text);
            SachChiTiet sach = new SachChiTiet()
            {
                BarCodeSach = txtBarcodeSach.Text,
                BarCodeMaSach = txtBarcodeMaSach.Text,
                TinhTrangSach = txtTinhTrang.Text,
                LanTaiBan = Convert.ToInt32(txtLanTaiBan.Text),
                KichCo = txtKichCo.Text,
                NamTaiBan = Convert.ToInt32(txtNamTaiBan.Text),
                DiemUyTinMin = Convert.ToInt32(txtDiemUyTinMin.Text),
                TrangThai = 1,
                IdNxb = cmbNXB.SelectedValue.ToString()
            };
            var result = svc.services.AddSachChiTiet(sach);
            obj.SoLuong += 1;
            var upsach = svc.services.UpdateSach(obj);
            if (result && upsach)
            {
                MessageBox.Show("Thêm thành công");
            }
            ShowData();
        }
        void ConfigData()
        {
            dtgShow.Rows.Clear();
            for (int i = 1; i <= sachList.Count; i++)
            {
                var sach = sachList[i - 1];
                dtgShow.Rows.Add(
                i.ToString(),             
                sach.TenSach,
                sach.SoLuong,
                sach.BarCodeSach
                );
            }
        }

        void ShowData()
        {
            sachList = svc.services.GetAllSach();

            ConfigData();
        }

        private void dtgShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarcodeSach.Text = dtgShow.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
