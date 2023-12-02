namespace C_PRL.QuanLyPhieu
{
    partial class fThemPM
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
            this.tbMaPM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRescan = new System.Windows.Forms.Button();
            this.tbIDTheTV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbMaPM
            // 
            this.tbMaPM.Location = new System.Drawing.Point(149, 61);
            this.tbMaPM.Name = "tbMaPM";
            this.tbMaPM.Size = new System.Drawing.Size(196, 27);
            this.tbMaPM.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Mã Phiếu Mượn";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(259, 281);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 31);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Trạng Thái";
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Items.AddRange(new object[] {
            "Hoạt Động",
            "Không Hoạt Động"});
            this.cmbTrangThai.Location = new System.Drawing.Point(149, 183);
            this.cmbTrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(195, 28);
            this.cmbTrangThai.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 139);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 27);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Ngày Tạo Phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Mã Thẻ Thư Viện";
            // 
            // btnRescan
            // 
            this.btnRescan.Location = new System.Drawing.Point(150, 281);
            this.btnRescan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRescan.Name = "btnRescan";
            this.btnRescan.Size = new System.Drawing.Size(86, 31);
            this.btnRescan.TabIndex = 32;
            this.btnRescan.Text = "Reset";
            this.btnRescan.UseVisualStyleBackColor = true;
            // 
            // tbIDTheTV
            // 
            this.tbIDTheTV.Location = new System.Drawing.Point(149, 98);
            this.tbIDTheTV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbIDTheTV.Name = "tbIDTheTV";
            this.tbIDTheTV.Size = new System.Drawing.Size(195, 27);
            this.tbIDTheTV.TabIndex = 31;
            // 
            // fThemPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 374);
            this.Controls.Add(this.tbMaPM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTrangThai);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRescan);
            this.Controls.Add(this.tbIDTheTV);
            this.Name = "fThemPM";
            this.Text = "fThemPM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbMaPM;
        private Label label3;
        private Button btnThem;
        private Label label6;
        private ComboBox cmbTrangThai;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btnRescan;
        private TextBox tbIDTheTV;
    }
}