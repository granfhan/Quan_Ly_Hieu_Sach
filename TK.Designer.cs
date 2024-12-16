namespace Login1
{
    partial class TK
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
            this.dataGridViewTK = new System.Windows.Forms.DataGridView();
            this.maHoaDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVDataSet2 = new Login1.QLTVDataSet2();
            this.hoaDonTableAdapter = new Login1.QLTVDataSet2TableAdapters.HoaDonTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTK = new System.Windows.Forms.Label();
            this.buttonTK = new System.Windows.Forms.Button();
            this.labelTK2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTK
            // 
            this.dataGridViewTK.AutoGenerateColumns = false;
            this.dataGridViewTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHoaDonDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn});
            this.dataGridViewTK.DataSource = this.hoaDonBindingSource;
            this.dataGridViewTK.Location = new System.Drawing.Point(67, 75);
            this.dataGridViewTK.Name = "dataGridViewTK";
            this.dataGridViewTK.RowHeadersWidth = 51;
            this.dataGridViewTK.RowTemplate.Height = 24;
            this.dataGridViewTK.Size = new System.Drawing.Size(561, 336);
            this.dataGridViewTK.TabIndex = 0;
            this.dataGridViewTK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTK_CellContentClick);
            // 
            // maHoaDonDataGridViewTextBoxColumn
            // 
            this.maHoaDonDataGridViewTextBoxColumn.DataPropertyName = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.HeaderText = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHoaDonDataGridViewTextBoxColumn.Name = "maHoaDonDataGridViewTextBoxColumn";
            this.maHoaDonDataGridViewTextBoxColumn.Width = 125;
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            this.tongTienDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            this.ngayLapDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.qLTVDataSet2;
            // 
            // qLTVDataSet2
            // 
            this.qLTVDataSet2.DataSetName = "QLTVDataSet2";
            this.qLTVDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = " Thống Kê Doanh Thu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTK
            // 
            this.labelTK.AutoSize = true;
            this.labelTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTK.Location = new System.Drawing.Point(13, 434);
            this.labelTK.Name = "labelTK";
            this.labelTK.Size = new System.Drawing.Size(200, 25);
            this.labelTK.TabIndex = 2;
            this.labelTK.Text = " Tổng Doanh Thu : ";
            this.labelTK.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonTK
            // 
            this.buttonTK.Location = new System.Drawing.Point(404, 434);
            this.buttonTK.Name = "buttonTK";
            this.buttonTK.Size = new System.Drawing.Size(124, 23);
            this.buttonTK.TabIndex = 4;
            this.buttonTK.Text = " Thống Kê";
            this.buttonTK.UseVisualStyleBackColor = true;
            this.buttonTK.Click += new System.EventHandler(this.buttonTK_Click);
            // 
            // labelTK2
            // 
            this.labelTK2.AutoSize = true;
            this.labelTK2.Location = new System.Drawing.Point(203, 441);
            this.labelTK2.Name = "labelTK2";
            this.labelTK2.Size = new System.Drawing.Size(10, 16);
            this.labelTK2.TabIndex = 5;
            this.labelTK2.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Điền mã hóa đơn :";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(186, 47);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(187, 22);
            this.txtTimKiem.TabIndex = 7;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Location = new System.Drawing.Point(379, 46);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(75, 23);
            this.buttonTimKiem.TabIndex = 8;
            this.buttonTimKiem.Text = "Tìm Kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = " Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTK2);
            this.Controls.Add(this.buttonTK);
            this.Controls.Add(this.labelTK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTK);
            this.Name = "TK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TK_FormClosing);
            this.Load += new System.EventHandler(this.TK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTK;
        private QLTVDataSet2 qLTVDataSet2;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QLTVDataSet2TableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTK;
        private System.Windows.Forms.Button buttonTK;
        private System.Windows.Forms.Label labelTK2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Button button1;
    }
}