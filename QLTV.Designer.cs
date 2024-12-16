namespace QuanLyThanhVien
{
    partial class QLTV
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
            this.EmailText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DienThoaiText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ThongKeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TenThanhVienText = new System.Windows.Forms.TextBox();
            this.MaThanhVienText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuaButton = new System.Windows.Forms.Button();
            this.XoaButton = new System.Windows.Forms.Button();
            this.ThemButton = new System.Windows.Forms.Button();
            this.dgvThanhVien = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(855, 203);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(326, 22);
            this.EmailText.TabIndex = 83;
            this.EmailText.TextChanged += new System.EventHandler(this.EmailText_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(677, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 82;
            this.label6.Text = "NHẬP EMAIL:";
            // 
            // DienThoaiText
            // 
            this.DienThoaiText.Location = new System.Drawing.Point(855, 161);
            this.DienThoaiText.Name = "DienThoaiText";
            this.DienThoaiText.Size = new System.Drawing.Size(326, 22);
            this.DienThoaiText.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(677, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 80;
            this.label5.Text = "NHẬP ĐIỆN THOẠI:";
            // 
            // ThongKeButton
            // 
            this.ThongKeButton.Location = new System.Drawing.Point(290, 462);
            this.ThongKeButton.Name = "ThongKeButton";
            this.ThongKeButton.Size = new System.Drawing.Size(130, 23);
            this.ThongKeButton.TabIndex = 79;
            this.ThongKeButton.Text = "Thống Kê";
            this.ThongKeButton.UseVisualStyleBackColor = true;
            this.ThongKeButton.Click += new System.EventHandler(this.ThongKeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(795, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 32);
            this.label4.TabIndex = 76;
            this.label4.Text = "QUẢN LÝ THÀNH VIÊN";
            // 
            // TenThanhVienText
            // 
            this.TenThanhVienText.Location = new System.Drawing.Point(855, 114);
            this.TenThanhVienText.Name = "TenThanhVienText";
            this.TenThanhVienText.Size = new System.Drawing.Size(326, 22);
            this.TenThanhVienText.TabIndex = 75;
            // 
            // MaThanhVienText
            // 
            this.MaThanhVienText.Location = new System.Drawing.Point(855, 68);
            this.MaThanhVienText.Name = "MaThanhVienText";
            this.MaThanhVienText.Size = new System.Drawing.Size(326, 22);
            this.MaThanhVienText.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(677, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "NHẬP TÊN THÀNH VIÊN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "NHẬP MÃ THÀNH VIÊN:";
            // 
            // SuaButton
            // 
            this.SuaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaButton.Location = new System.Drawing.Point(814, 268);
            this.SuaButton.Name = "SuaButton";
            this.SuaButton.Size = new System.Drawing.Size(96, 32);
            this.SuaButton.TabIndex = 69;
            this.SuaButton.Text = " Sửa";
            this.SuaButton.UseVisualStyleBackColor = true;
            this.SuaButton.Click += new System.EventHandler(this.SuaButton_Click);
            // 
            // XoaButton
            // 
            this.XoaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaButton.Location = new System.Drawing.Point(947, 268);
            this.XoaButton.Name = "XoaButton";
            this.XoaButton.Size = new System.Drawing.Size(96, 32);
            this.XoaButton.TabIndex = 68;
            this.XoaButton.Text = "Xóa";
            this.XoaButton.UseVisualStyleBackColor = true;
            this.XoaButton.Click += new System.EventHandler(this.XoaButton_Click);
            // 
            // ThemButton
            // 
            this.ThemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemButton.Location = new System.Drawing.Point(680, 268);
            this.ThemButton.Name = "ThemButton";
            this.ThemButton.Size = new System.Drawing.Size(96, 32);
            this.ThemButton.TabIndex = 67;
            this.ThemButton.Text = " Thêm";
            this.ThemButton.UseVisualStyleBackColor = true;
            this.ThemButton.Click += new System.EventHandler(this.ThemButton_Click);
            // 
            // dgvThanhVien
            // 
            this.dgvThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhVien.Location = new System.Drawing.Point(55, 28);
            this.dgvThanhVien.Name = "dgvThanhVien";
            this.dgvThanhVien.RowHeadersWidth = 51;
            this.dgvThanhVien.RowTemplate.Height = 24;
            this.dgvThanhVien.Size = new System.Drawing.Size(605, 428);
            this.dgvThanhVien.TabIndex = 66;
            this.dgvThanhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanhVien_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1085, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 32);
            this.button1.TabIndex = 84;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QLTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1213, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DienThoaiText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ThongKeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TenThanhVienText);
            this.Controls.Add(this.MaThanhVienText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SuaButton);
            this.Controls.Add(this.XoaButton);
            this.Controls.Add(this.ThemButton);
            this.Controls.Add(this.dgvThanhVien);
            this.Name = "QLTV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLTV_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DienThoaiText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ThongKeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TenThanhVienText;
        private System.Windows.Forms.TextBox MaThanhVienText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SuaButton;
        private System.Windows.Forms.Button XoaButton;
        private System.Windows.Forms.Button ThemButton;
        private System.Windows.Forms.DataGridView dgvThanhVien;
        private System.Windows.Forms.Button button1;
    }
}

