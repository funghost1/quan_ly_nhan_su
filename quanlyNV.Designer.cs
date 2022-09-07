namespace quanly
{
    partial class quanlyNV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbangnhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idchucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucluongso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tailai = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.luu = new System.Windows.Forms.Button();
            this.textboxten = new System.Windows.Forms.TextBox();
            this.combochucvu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chucvuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textboxsdt = new System.Windows.Forms.TextBox();
            this.textboxemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textboxmucluong = new System.Windows.Forms.TextBox();
            this.textboxsinhnhat = new System.Windows.Forms.TextBox();
            this.trove = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 97);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(285, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ten,
            this.username,
            this.sdt,
            this.email,
            this.namsinh,
            this.trangthai,
            this.dataGridViewTextBoxColumn1,
            this.chucvu,
            this.idbangnhanvien,
            this.idchucvu,
            this.mucluongso});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 419);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1141, 202);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError_1);
            // 
            // ten
            // 
            this.ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Họ Tên";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ten.Width = 90;
            // 
            // username
            // 
            this.username.DataPropertyName = "taikhoang";
            this.username.HeaderText = "User Name";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số Điện Thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            // 
            // email
            // 
            this.email.DataPropertyName = "Emai";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            // 
            // namsinh
            // 
            this.namsinh.DataPropertyName = "namsinh";
            this.namsinh.HeaderText = "Năm Sinh";
            this.namsinh.MinimumWidth = 6;
            this.namsinh.Name = "namsinh";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng Thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MucLuong";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mức Lương";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // chucvu
            // 
            this.chucvu.DataPropertyName = "chucvu";
            this.chucvu.HeaderText = "Chức Vụ";
            this.chucvu.MinimumWidth = 6;
            this.chucvu.Name = "chucvu";
            // 
            // idbangnhanvien
            // 
            this.idbangnhanvien.DataPropertyName = "idbangnhanvien";
            this.idbangnhanvien.HeaderText = "id nhan vien";
            this.idbangnhanvien.MinimumWidth = 6;
            this.idbangnhanvien.Name = "idbangnhanvien";
            this.idbangnhanvien.Visible = false;
            // 
            // idchucvu
            // 
            this.idchucvu.DataPropertyName = "idchucvu";
            this.idchucvu.HeaderText = "id chuc vu";
            this.idchucvu.MinimumWidth = 6;
            this.idchucvu.Name = "idchucvu";
            this.idchucvu.Visible = false;
            // 
            // mucluongso
            // 
            this.mucluongso.DataPropertyName = "mucluongso";
            this.mucluongso.HeaderText = "mức lương so";
            this.mucluongso.MinimumWidth = 6;
            this.mucluongso.Name = "mucluongso";
            this.mucluongso.Visible = false;
            // 
            // chucvuBindingSource
            // 
            this.chucvuBindingSource.DataSource = typeof(quanly.Models.Chucvu);
            // 
            // tailai
            // 
            this.tailai.Location = new System.Drawing.Point(248, 320);
            this.tailai.Name = "tailai";
            this.tailai.Size = new System.Drawing.Size(122, 66);
            this.tailai.TabIndex = 11;
            this.tailai.Text = "Tải Lại Trang";
            this.tailai.UseVisualStyleBackColor = true;
            this.tailai.Click += new System.EventHandler(this.tailai_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(130, 320);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(121, 66);
            this.xoa.TabIndex = 12;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            // 
            // luu
            // 
            this.luu.Location = new System.Drawing.Point(13, 320);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(121, 66);
            this.luu.TabIndex = 13;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // textboxten
            // 
            this.textboxten.Location = new System.Drawing.Point(12, 165);
            this.textboxten.Name = "textboxten";
            this.textboxten.Size = new System.Drawing.Size(194, 27);
            this.textboxten.TabIndex = 15;
            // 
            // combochucvu
            // 
            this.combochucvu.FormattingEnabled = true;
            this.combochucvu.Location = new System.Drawing.Point(13, 232);
            this.combochucvu.Name = "combochucvu";
            this.combochucvu.Size = new System.Drawing.Size(194, 28);
            this.combochucvu.TabIndex = 16;
            this.combochucvu.SelectionChangeCommitted += new System.EventHandler(this.combochucvu_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(212, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên Nhân Viên";
            this.label2.Click += new System.EventHandler(this.quanlyNV_Load);
            // 
            // chucvuBindingSource1
            // 
            this.chucvuBindingSource1.DataSource = typeof(quanly.Models.Chucvu);
            // 
            // textboxsdt
            // 
            this.textboxsdt.Location = new System.Drawing.Point(393, 165);
            this.textboxsdt.Name = "textboxsdt";
            this.textboxsdt.Size = new System.Drawing.Size(194, 27);
            this.textboxsdt.TabIndex = 19;
            // 
            // textboxemail
            // 
            this.textboxemail.Location = new System.Drawing.Point(393, 230);
            this.textboxemail.Name = "textboxemail";
            this.textboxemail.Size = new System.Drawing.Size(194, 27);
            this.textboxemail.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(593, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(212, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Chức Vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(593, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(959, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Sinh Nhật";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(959, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Mức Lương";
            // 
            // textboxmucluong
            // 
            this.textboxmucluong.Location = new System.Drawing.Point(759, 168);
            this.textboxmucluong.Name = "textboxmucluong";
            this.textboxmucluong.Size = new System.Drawing.Size(194, 27);
            this.textboxmucluong.TabIndex = 24;
            // 
            // textboxsinhnhat
            // 
            this.textboxsinhnhat.Location = new System.Drawing.Point(756, 230);
            this.textboxsinhnhat.Name = "textboxsinhnhat";
            this.textboxsinhnhat.Size = new System.Drawing.Size(197, 27);
            this.textboxsinhnhat.TabIndex = 28;
            // 
            // trove
            // 
            this.trove.ForeColor = System.Drawing.Color.Red;
            this.trove.Location = new System.Drawing.Point(959, 320);
            this.trove.Name = "trove";
            this.trove.Size = new System.Drawing.Size(157, 66);
            this.trove.TabIndex = 29;
            this.trove.Text = "Quay Lại Trang Chủ";
            this.trove.UseVisualStyleBackColor = true;
            this.trove.Click += new System.EventHandler(this.trove_Click);
            // 
            // quanlyNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1165, 651);
            this.Controls.Add(this.trove);
            this.Controls.Add(this.textboxsinhnhat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textboxmucluong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textboxemail);
            this.Controls.Add(this.textboxsdt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combochucvu);
            this.Controls.Add(this.textboxten);
            this.Controls.Add(this.luu);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.tailai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "quanlyNV";
            this.Text = "quanlyNV";
            this.Load += new System.EventHandler(this.quanlyNV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button tailai;
        private Button xoa;
        private Button luu;
        private TextBox textboxten;
        private ComboBox combochucvu;
        private BindingSource chucvuBindingSource;
        private Label label2;
        private BindingSource chucvuBindingSource1;
        private TextBox textboxsdt;
        private TextBox textboxemail;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textboxmucluong;
        private TextBox textboxsinhnhat;
        private DataGridViewTextBoxColumn ten;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn sdt;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn namsinh;
        private DataGridViewTextBoxColumn trangthai;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn chucvu;
        private DataGridViewTextBoxColumn idbangnhanvien;
        private DataGridViewTextBoxColumn idchucvu;
        private DataGridViewTextBoxColumn mucluongso;
        private Button trove;
    }
}