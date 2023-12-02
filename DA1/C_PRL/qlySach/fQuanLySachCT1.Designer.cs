﻿namespace C_PRL.qlySach
{
    partial class fQuanLySachCT1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanTaiBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamTaiBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KichCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemUyTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.Barcode,
            this.TinhTrang,
            this.LanTaiBan,
            this.NamTaiBan,
            this.KichCo,
            this.DiemUyTin,
            this.NhaXuatBan});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Location = new System.Drawing.Point(11, 133);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1128, 339);
            this.dataGridView1.TabIndex = 2;
            // 
            // stt
            // 
            this.stt.FillWeight = 30F;
            this.stt.HeaderText = "Stt";
            this.stt.MinimumWidth = 40;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // Barcode
            // 
            this.Barcode.HeaderText = "Barcode Id";
            this.Barcode.MinimumWidth = 6;
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình trạng sách";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // LanTaiBan
            // 
            this.LanTaiBan.HeaderText = "Lần tái bản";
            this.LanTaiBan.MinimumWidth = 6;
            this.LanTaiBan.Name = "LanTaiBan";
            this.LanTaiBan.ReadOnly = true;
            // 
            // NamTaiBan
            // 
            this.NamTaiBan.HeaderText = "Năm tái bản";
            this.NamTaiBan.MinimumWidth = 6;
            this.NamTaiBan.Name = "NamTaiBan";
            this.NamTaiBan.ReadOnly = true;
            // 
            // KichCo
            // 
            this.KichCo.HeaderText = "Kích cỡ";
            this.KichCo.MinimumWidth = 6;
            this.KichCo.Name = "KichCo";
            this.KichCo.ReadOnly = true;
            // 
            // DiemUyTin
            // 
            this.DiemUyTin.HeaderText = "Điểm uy tín";
            this.DiemUyTin.MinimumWidth = 6;
            this.DiemUyTin.Name = "DiemUyTin";
            this.DiemUyTin.ReadOnly = true;
            // 
            // NhaXuatBan
            // 
            this.NhaXuatBan.FillWeight = 200F;
            this.NhaXuatBan.HeaderText = "Nhà xuất bản";
            this.NhaXuatBan.MinimumWidth = 6;
            this.NhaXuatBan.Name = "NhaXuatBan";
            this.NhaXuatBan.ReadOnly = true;
            // 
            // fQuanLySachCT1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 605);
            this.Controls.Add(this.dataGridView1);
            this.Name = "fQuanLySachCT1";
            this.Text = "fQuanLySachCT1";
            this.Load += new System.EventHandler(this.fQuanLySachCT1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn TinhTrang;
        private DataGridViewTextBoxColumn LanTaiBan;
        private DataGridViewTextBoxColumn NamTaiBan;
        private DataGridViewTextBoxColumn KichCo;
        private DataGridViewTextBoxColumn DiemUyTin;
        private DataGridViewTextBoxColumn NhaXuatBan;
    }
}