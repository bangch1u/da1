namespace C_PRL.QuanLyPhieu
{
    partial class fQuanLyPhieuMuon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHuyPhieu = new System.Windows.Forms.Button();
            this.btnKichHoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSachMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTaoPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuyPhieu
            // 
            this.btnHuyPhieu.Location = new System.Drawing.Point(386, 44);
            this.btnHuyPhieu.Name = "btnHuyPhieu";
            this.btnHuyPhieu.Size = new System.Drawing.Size(94, 29);
            this.btnHuyPhieu.TabIndex = 15;
            this.btnHuyPhieu.Text = "Hủy Phiếu";
            this.btnHuyPhieu.UseVisualStyleBackColor = true;
            this.btnHuyPhieu.Click += new System.EventHandler(this.btnHuyPhieu_Click);
            // 
            // btnKichHoat
            // 
            this.btnKichHoat.Location = new System.Drawing.Point(249, 45);
            this.btnKichHoat.Name = "btnKichHoat";
            this.btnKichHoat.Size = new System.Drawing.Size(94, 29);
            this.btnKichHoat.TabIndex = 14;
            this.btnKichHoat.Text = "Kích Hoạt";
            this.btnKichHoat.UseVisualStyleBackColor = true;
            this.btnKichHoat.Click += new System.EventHandler(this.btnKichHoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(912, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tìm kiếm: ";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(32, 44);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 31);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm thông tin sách";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(995, 45);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(153, 27);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.MaPM,
            this.HoTen,
            this.TongSachMuon,
            this.NgayTaoPhieu,
            this.TrangThai});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Location = new System.Drawing.Point(32, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1117, 339);
            this.dataGridView1.TabIndex = 10;
            // 
            // stt
            // 
            this.stt.FillWeight = 30F;
            this.stt.HeaderText = "Stt";
            this.stt.MinimumWidth = 40;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // MaPM
            // 
            this.MaPM.HeaderText = "Mã Phiếu Mượn";
            this.MaPM.MinimumWidth = 6;
            this.MaPM.Name = "MaPM";
            this.MaPM.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // TongSachMuon
            // 
            this.TongSachMuon.HeaderText = "Tổng Sách Mượn";
            this.TongSachMuon.MinimumWidth = 6;
            this.TongSachMuon.Name = "TongSachMuon";
            this.TongSachMuon.ReadOnly = true;
            // 
            // NgayTaoPhieu
            // 
            this.NgayTaoPhieu.HeaderText = "Ngày Tạo Phiếu";
            this.NgayTaoPhieu.MinimumWidth = 6;
            this.NgayTaoPhieu.Name = "NgayTaoPhieu";
            this.NgayTaoPhieu.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // fQuanLyPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 467);
            this.Controls.Add(this.btnHuyPhieu);
            this.Controls.Add(this.btnKichHoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "fQuanLyPhieuMuon";
            this.Text = "fQuanLyPhieuMuon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnHuyPhieu;
        private Button btnKichHoat;
        private Label label1;
        private Button btnThem;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn MaPM;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn TongSachMuon;
        private DataGridViewTextBoxColumn NgayTaoPhieu;
        private DataGridViewTextBoxColumn TrangThai;
    }
}