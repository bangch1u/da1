namespace C_PRL.qlySach
{
    partial class fThemSachCT
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
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBarcodeSach = new System.Windows.Forms.TextBox();
            this.txtBarcodeMaSach = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtLanTaiBan = new System.Windows.Forms.TextBox();
            this.txtKichCo = new System.Windows.Forms.TextBox();
            this.txtNamTaiBan = new System.Windows.Forms.TextBox();
            this.txtDiemUyTinMin = new System.Windows.Forms.TextBox();
            this.cmbNXB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgShow
            // 
            this.dtgShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenSach,
            this.soLuong,
            this.barcode});
            this.dtgShow.Location = new System.Drawing.Point(669, 97);
            this.dtgShow.Name = "dtgShow";
            this.dtgShow.RowHeadersWidth = 51;
            this.dtgShow.RowTemplate.Height = 29;
            this.dtgShow.Size = new System.Drawing.Size(300, 334);
            this.dtgShow.TabIndex = 0;
            this.dtgShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgShow_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 125;
            // 
            // soLuong
            // 
            this.soLuong.HeaderText = "Số Lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.Width = 125;
            // 
            // barcode
            // 
            this.barcode.HeaderText = "Barcode";
            this.barcode.MinimumWidth = 6;
            this.barcode.Name = "barcode";
            this.barcode.Visible = false;
            this.barcode.Width = 125;
            // 
            // txtBarcodeSach
            // 
            this.txtBarcodeSach.Location = new System.Drawing.Point(455, 97);
            this.txtBarcodeSach.Name = "txtBarcodeSach";
            this.txtBarcodeSach.Size = new System.Drawing.Size(125, 27);
            this.txtBarcodeSach.TabIndex = 1;
            // 
            // txtBarcodeMaSach
            // 
            this.txtBarcodeMaSach.Location = new System.Drawing.Point(457, 148);
            this.txtBarcodeMaSach.Name = "txtBarcodeMaSach";
            this.txtBarcodeMaSach.Size = new System.Drawing.Size(125, 27);
            this.txtBarcodeMaSach.TabIndex = 2;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(454, 191);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(125, 27);
            this.txtTinhTrang.TabIndex = 3;
            // 
            // txtLanTaiBan
            // 
            this.txtLanTaiBan.Location = new System.Drawing.Point(458, 241);
            this.txtLanTaiBan.Name = "txtLanTaiBan";
            this.txtLanTaiBan.Size = new System.Drawing.Size(125, 27);
            this.txtLanTaiBan.TabIndex = 4;
            // 
            // txtKichCo
            // 
            this.txtKichCo.Location = new System.Drawing.Point(461, 287);
            this.txtKichCo.Name = "txtKichCo";
            this.txtKichCo.Size = new System.Drawing.Size(125, 27);
            this.txtKichCo.TabIndex = 5;
            // 
            // txtNamTaiBan
            // 
            this.txtNamTaiBan.Location = new System.Drawing.Point(461, 335);
            this.txtNamTaiBan.Name = "txtNamTaiBan";
            this.txtNamTaiBan.Size = new System.Drawing.Size(125, 27);
            this.txtNamTaiBan.TabIndex = 6;
            // 
            // txtDiemUyTinMin
            // 
            this.txtDiemUyTinMin.Location = new System.Drawing.Point(463, 372);
            this.txtDiemUyTinMin.Name = "txtDiemUyTinMin";
            this.txtDiemUyTinMin.Size = new System.Drawing.Size(125, 27);
            this.txtDiemUyTinMin.TabIndex = 7;
            // 
            // cmbNXB
            // 
            this.cmbNXB.FormattingEnabled = true;
            this.cmbNXB.Location = new System.Drawing.Point(479, 419);
            this.cmbNXB.Name = "cmbNXB";
            this.cmbNXB.Size = new System.Drawing.Size(151, 28);
            this.cmbNXB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Barcode ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tình Trạng ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lần Tái Bản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kích Cỡ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Năm Tái Bản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Điểm Uy Tín";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nhà Xuất Bản";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(64, 111);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // fThemSachCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 542);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNXB);
            this.Controls.Add(this.txtDiemUyTinMin);
            this.Controls.Add(this.txtNamTaiBan);
            this.Controls.Add(this.txtKichCo);
            this.Controls.Add(this.txtLanTaiBan);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.txtBarcodeMaSach);
            this.Controls.Add(this.txtBarcodeSach);
            this.Controls.Add(this.dtgShow);
            this.Name = "fThemSachCT";
            this.Text = "fThemSachCT";
            ((System.ComponentModel.ISupportInitialize)(this.dtgShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgShow;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewTextBoxColumn barcode;
        private TextBox txtBarcodeSach;
        private TextBox txtBarcodeMaSach;
        private TextBox txtTinhTrang;
        private TextBox txtLanTaiBan;
        private TextBox txtKichCo;
        private TextBox txtNamTaiBan;
        private TextBox txtDiemUyTinMin;
        private ComboBox cmbNXB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnThem;
    }
}