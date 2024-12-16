namespace Login1
{
    partial class QLHD
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maHoaDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maThanhVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVDataSet = new Login1.QLTVDataSet();
            this.hoaDonTableAdapter = new Login1.QLTVDataSetTableAdapters.HoaDonTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.qLTVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVDataSet1 = new Login1.QLTVDataSet1();
            this.cTHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTHoaDonTableAdapter = new Login1.QLTVDataSet1TableAdapters.CTHoaDonTableAdapter();
            this.textMHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textMNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textTT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textMTV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNL = new System.Windows.Forms.TextBox();
            this.Rf = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.CTHD = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHoaDonDataGridViewTextBoxColumn,
            this.maThanhVienDataGridViewTextBoxColumn,
            this.maNhanVienDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hoaDonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(607, 355);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maHoaDonDataGridViewTextBoxColumn
            // 
            this.maHoaDonDataGridViewTextBoxColumn.DataPropertyName = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.HeaderText = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHoaDonDataGridViewTextBoxColumn.Name = "maHoaDonDataGridViewTextBoxColumn";
            this.maHoaDonDataGridViewTextBoxColumn.Width = 106;
            // 
            // maThanhVienDataGridViewTextBoxColumn
            // 
            this.maThanhVienDataGridViewTextBoxColumn.DataPropertyName = "MaThanhVien";
            this.maThanhVienDataGridViewTextBoxColumn.HeaderText = "MaThanhVien";
            this.maThanhVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maThanhVienDataGridViewTextBoxColumn.Name = "maThanhVienDataGridViewTextBoxColumn";
            this.maThanhVienDataGridViewTextBoxColumn.Width = 120;
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            this.maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.HeaderText = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            this.maNhanVienDataGridViewTextBoxColumn.Width = 114;
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            this.tongTienDataGridViewTextBoxColumn.Width = 95;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            this.ngayLapDataGridViewTextBoxColumn.Width = 92;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.qLTVDataSet;
            // 
            // qLTVDataSet
            // 
            this.qLTVDataSet.DataSetName = "QLTVDataSet";
            this.qLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(626, 235);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 20;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(549, 203);
            this.dataGridView2.TabIndex = 1;
            // 
            // qLTVDataSetBindingSource
            // 
            this.qLTVDataSetBindingSource.DataSource = this.qLTVDataSet;
            this.qLTVDataSetBindingSource.Position = 0;
            // 
            // qLTVDataSet1
            // 
            this.qLTVDataSet1.DataSetName = "QLTVDataSet1";
            this.qLTVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cTHoaDonBindingSource
            // 
            this.cTHoaDonBindingSource.DataMember = "CTHoaDon";
            this.cTHoaDonBindingSource.DataSource = this.qLTVDataSet1;
            // 
            // cTHoaDonTableAdapter
            // 
            this.cTHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // textMHD
            // 
            this.textMHD.Location = new System.Drawing.Point(738, 104);
            this.textMHD.Name = "textMHD";
            this.textMHD.Size = new System.Drawing.Size(100, 22);
            this.textMHD.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã hóa đơn : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = " Mã nhân viên";
            // 
            // textMNV
            // 
            this.textMNV.Location = new System.Drawing.Point(738, 142);
            this.textMNV.Name = "textMNV";
            this.textMNV.Size = new System.Drawing.Size(100, 22);
            this.textMNV.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(634, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = " Tổng tiền";
            // 
            // textTT
            // 
            this.textTT.Location = new System.Drawing.Point(738, 182);
            this.textTT.Name = "textTT";
            this.textTT.Size = new System.Drawing.Size(100, 22);
            this.textTT.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(864, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = " Mã thành viên";
            // 
            // textMTV
            // 
            this.textMTV.Location = new System.Drawing.Point(976, 107);
            this.textMTV.Name = "textMTV";
            this.textMTV.Size = new System.Drawing.Size(137, 22);
            this.textMTV.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(864, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = " Ngày lập";
            // 
            // textNL
            // 
            this.textNL.Location = new System.Drawing.Point(976, 145);
            this.textNL.Name = "textNL";
            this.textNL.Size = new System.Drawing.Size(137, 22);
            this.textNL.TabIndex = 10;
            // 
            // Rf
            // 
            this.Rf.Location = new System.Drawing.Point(12, 422);
            this.Rf.Name = "Rf";
            this.Rf.Size = new System.Drawing.Size(102, 23);
            this.Rf.TabIndex = 12;
            this.Rf.Text = " Làm mới";
            this.Rf.UseVisualStyleBackColor = true;
            this.Rf.Click += new System.EventHandler(this.Rf_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(143, 422);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 13;
            this.Delete.Text = " Xóa";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // CTHD
            // 
            this.CTHD.Location = new System.Drawing.Point(271, 422);
            this.CTHD.Name = "CTHD";
            this.CTHD.Size = new System.Drawing.Size(75, 23);
            this.CTHD.TabIndex = 14;
            this.CTHD.Text = " CTHD";
            this.CTHD.UseVisualStyleBackColor = true;
            this.CTHD.Click += new System.EventHandler(this.CTHD_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(387, 422);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 15;
            this.Quit.Text = " Thoát";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(516, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Quản Lý Hóa Đơn";
            // 
            // QLHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1187, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.CTHD);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Rf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textNL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textMTV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textTT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textMHD);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QLHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLHD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLHD_FormClosing);
            this.Load += new System.EventHandler(this.QLHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QLTVDataSetTableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThanhVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource qLTVDataSetBindingSource;
        private QLTVDataSet1 qLTVDataSet1;
        private System.Windows.Forms.BindingSource cTHoaDonBindingSource;
        private QLTVDataSet1TableAdapters.CTHoaDonTableAdapter cTHoaDonTableAdapter;
        private System.Windows.Forms.TextBox textMHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMTV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNL;
        private System.Windows.Forms.Button Rf;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button CTHD;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Label label6;
    }
}