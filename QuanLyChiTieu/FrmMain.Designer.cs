namespace QuanLyChiTieu
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.cbxLoaiChiTieu = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoaTrang = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongChiPhi = new System.Windows.Forms.Label();
            this.dgvChiTieu = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiChiTieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTieu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 621);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvChiTieu);
            this.groupBox1.Location = new System.Drawing.Point(11, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 583);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các chi tiêu";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(744, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 248);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết chi tiêu";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnXoaTrang);
            this.panel2.Controls.Add(this.cbxLoaiChiTieu);
            this.panel2.Controls.Add(this.txtNoiDung);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.txtSoTien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 225);
            this.panel2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Location = new System.Drawing.Point(744, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 314);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin thống kê";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtTongChiPhi);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 291);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại chi tiêu : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tiền : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nội dung :";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(117, 67);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(254, 24);
            this.txtSoTien.TabIndex = 4;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(117, 110);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(254, 52);
            this.txtNoiDung.TabIndex = 5;
            // 
            // cbxLoaiChiTieu
            // 
            this.cbxLoaiChiTieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbxLoaiChiTieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoaiChiTieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxLoaiChiTieu.FormattingEnabled = true;
            this.cbxLoaiChiTieu.Items.AddRange(new object[] {
            "Ăn uống",
            "Di chuyển",
            "Nhà cửa",
            "Xe cộ",
            "Nhu yếu phẩm",
            "Dịch vụ"});
            this.cbxLoaiChiTieu.Location = new System.Drawing.Point(118, 21);
            this.cbxLoaiChiTieu.Name = "cbxLoaiChiTieu";
            this.cbxLoaiChiTieu.Size = new System.Drawing.Size(253, 25);
            this.cbxLoaiChiTieu.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(251, 173);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 39);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm chi tiêu";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaTrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoaTrang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaTrang.ForeColor = System.Drawing.Color.Black;
            this.btnXoaTrang.Location = new System.Drawing.Point(125, 173);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(120, 39);
            this.btnXoaTrang.TabIndex = 13;
            this.btnXoaTrang.Text = "Xóa trắng";
            this.btnXoaTrang.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng cộng :";
            // 
            // txtTongChiPhi
            // 
            this.txtTongChiPhi.AutoSize = true;
            this.txtTongChiPhi.Location = new System.Drawing.Point(115, 24);
            this.txtTongChiPhi.Name = "txtTongChiPhi";
            this.txtTongChiPhi.Size = new System.Drawing.Size(63, 17);
            this.txtTongChiPhi.TabIndex = 1;
            this.txtTongChiPhi.Text = "1,250,000";
            // 
            // dgvChiTieu
            // 
            this.dgvChiTieu.AllowUserToResizeColumns = false;
            this.dgvChiTieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTieu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvChiTieu.ColumnHeadersHeight = 30;
            this.dgvChiTieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.LoaiChiTieu,
            this.SoTien,
            this.NoiDung});
            this.dgvChiTieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTieu.EnableHeadersVisualStyles = false;
            this.dgvChiTieu.GridColor = System.Drawing.Color.Black;
            this.dgvChiTieu.Location = new System.Drawing.Point(3, 20);
            this.dgvChiTieu.MultiSelect = false;
            this.dgvChiTieu.Name = "dgvChiTieu";
            this.dgvChiTieu.ReadOnly = true;
            this.dgvChiTieu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvChiTieu.RowHeadersWidth = 25;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiTieu.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChiTieu.RowTemplate.Height = 30;
            this.dgvChiTieu.RowTemplate.ReadOnly = true;
            this.dgvChiTieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTieu.Size = new System.Drawing.Size(715, 560);
            this.dgvChiTieu.TabIndex = 5;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.FillWeight = 8F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // LoaiChiTieu
            // 
            this.LoaiChiTieu.DataPropertyName = "LoaiChiTieu";
            this.LoaiChiTieu.FillWeight = 18F;
            this.LoaiChiTieu.HeaderText = "Loại chi tiêu";
            this.LoaiChiTieu.Name = "LoaiChiTieu";
            this.LoaiChiTieu.ReadOnly = true;
            // 
            // SoTien
            // 
            this.SoTien.DataPropertyName = "SoTien";
            this.SoTien.FillWeight = 12F;
            this.SoTien.HeaderText = "Số tiền";
            this.SoTien.Name = "SoTien";
            this.SoTien.ReadOnly = true;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.FillWeight = 25F;
            this.NoiDung.HeaderText = "Nội dung";
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.ReadOnly = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 621);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chi tiêu";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.ComboBox cbxLoaiChiTieu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoaTrang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtTongChiPhi;
        private System.Windows.Forms.DataGridView dgvChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
    }
}

