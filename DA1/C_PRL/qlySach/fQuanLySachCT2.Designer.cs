namespace C_PRL.qlySach
{
    partial class fQuanLySachCT2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgShow = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lanTaiBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namTaiBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemUyTinMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kichCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgShow
            // 
            this.dtgShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.maSach,
            this.tenSach,
            this.tinhTrangSach,
            this.lanTaiBan,
            this.namTaiBan,
            this.diemUyTinMin,
            this.nxb,
            this.kichCo,
            this.trangThai});
            this.dtgShow.Location = new System.Drawing.Point(29, 285);
            this.dtgShow.Name = "dtgShow";
            this.dtgShow.RowHeadersWidth = 51;
            this.dtgShow.RowTemplate.Height = 29;
            this.dtgShow.Size = new System.Drawing.Size(1097, 353);
            this.dtgShow.TabIndex = 0;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.Width = 50;
            // 
            // maSach
            // 
            this.maSach.HeaderText = "Mã Sách";
            this.maSach.MinimumWidth = 6;
            this.maSach.Name = "maSach";
            this.maSach.Width = 125;
            // 
            // tenSach
            // 
            this.tenSach.HeaderText = "Tên Sách";
            this.tenSach.MinimumWidth = 6;
            this.tenSach.Name = "tenSach";
            this.tenSach.Width = 125;
            // 
            // tinhTrangSach
            // 
            this.tinhTrangSach.HeaderText = "Tình Trạng";
            this.tinhTrangSach.MinimumWidth = 6;
            this.tinhTrangSach.Name = "tinhTrangSach";
            this.tinhTrangSach.Width = 125;
            // 
            // lanTaiBan
            // 
            this.lanTaiBan.HeaderText = "Lần Tái Bản";
            this.lanTaiBan.MinimumWidth = 6;
            this.lanTaiBan.Name = "lanTaiBan";
            this.lanTaiBan.Width = 50;
            // 
            // namTaiBan
            // 
            this.namTaiBan.HeaderText = "Năm Tái Bản";
            this.namTaiBan.MinimumWidth = 6;
            this.namTaiBan.Name = "namTaiBan";
            this.namTaiBan.Width = 125;
            // 
            // diemUyTinMin
            // 
            this.diemUyTinMin.HeaderText = "Điểm UT";
            this.diemUyTinMin.MinimumWidth = 6;
            this.diemUyTinMin.Name = "diemUyTinMin";
            this.diemUyTinMin.Width = 70;
            // 
            // nxb
            // 
            this.nxb.HeaderText = "NXB";
            this.nxb.MinimumWidth = 6;
            this.nxb.Name = "nxb";
            this.nxb.Width = 125;
            // 
            // kichCo
            // 
            this.kichCo.HeaderText = "Kích Cỡ";
            this.kichCo.MinimumWidth = 6;
            this.kichCo.Name = "kichCo";
            this.kichCo.Width = 125;
            // 
            // trangThai
            // 
            this.trangThai.HeaderText = "Trạng Thái";
            this.trangThai.MinimumWidth = 6;
            this.trangThai.Name = "trangThai";
            this.trangThai.Width = 125;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(867, 244);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(242, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(791, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(76, 106);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(141, 66);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm Sách";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(252, 106);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(141, 66);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa Sách";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(425, 106);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(141, 66);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa Sách";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // fQuanLySachCT2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 650);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtgShow);
            this.Name = "fQuanLySachCT2";
            this.Text = "fQuanLySachCT2";
            ((System.ComponentModel.ISupportInitialize)(this.dtgShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgShow;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn maSach;
        private DataGridViewTextBoxColumn tenSach;
        private DataGridViewTextBoxColumn tinhTrangSach;
        private DataGridViewTextBoxColumn lanTaiBan;
        private DataGridViewTextBoxColumn namTaiBan;
        private DataGridViewTextBoxColumn diemUyTinMin;
        private DataGridViewTextBoxColumn nxb;
        private DataGridViewTextBoxColumn kichCo;
        private DataGridViewTextBoxColumn trangThai;
        private TextBox txtSearch;
        private Label label1;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
    }
}