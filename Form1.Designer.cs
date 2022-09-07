namespace quanly
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTK = new System.Windows.Forms.Label();
            this.labelMK = new System.Windows.Forms.Label();
            this.textBoxTK = new System.Windows.Forms.TextBox();
            this.textBoxMK = new System.Windows.Forms.TextBox();
            this.dangnhap = new System.Windows.Forms.Button();
            this.dangky = new System.Windows.Forms.Button();
            this.quenMK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTK
            // 
            this.labelTK.AutoSize = true;
            this.labelTK.Location = new System.Drawing.Point(191, 120);
            this.labelTK.Name = "labelTK";
            this.labelTK.Size = new System.Drawing.Size(102, 20);
            this.labelTK.TabIndex = 0;
            this.labelTK.Text = "Số Điện Thoại";
            this.labelTK.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelMK
            // 
            this.labelMK.AutoSize = true;
            this.labelMK.Location = new System.Drawing.Point(202, 184);
            this.labelMK.Name = "labelMK";
            this.labelMK.Size = new System.Drawing.Size(72, 20);
            this.labelMK.TabIndex = 1;
            this.labelMK.Text = "Mật Khẩu";
            // 
            // textBoxTK
            // 
            this.textBoxTK.Location = new System.Drawing.Point(310, 113);
            this.textBoxTK.Name = "textBoxTK";
            this.textBoxTK.Size = new System.Drawing.Size(178, 27);
            this.textBoxTK.TabIndex = 2;
            // 
            // textBoxMK
            // 
            this.textBoxMK.Location = new System.Drawing.Point(310, 177);
            this.textBoxMK.Name = "textBoxMK";
            this.textBoxMK.PasswordChar = '*';
            this.textBoxMK.Size = new System.Drawing.Size(178, 27);
            this.textBoxMK.TabIndex = 3;
            // 
            // dangnhap
            // 
            this.dangnhap.Location = new System.Drawing.Point(156, 254);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(94, 29);
            this.dangnhap.TabIndex = 4;
            this.dangnhap.Text = "Đăng Nhập";
            this.dangnhap.UseVisualStyleBackColor = true;
            this.dangnhap.Click += new System.EventHandler(this.dangnhap_Click);
            // 
            // dangky
            // 
            this.dangky.Location = new System.Drawing.Point(524, 254);
            this.dangky.Name = "dangky";
            this.dangky.Size = new System.Drawing.Size(94, 29);
            this.dangky.TabIndex = 5;
            this.dangky.Text = "Đăng Ký";
            this.dangky.UseVisualStyleBackColor = true;
            this.dangky.Click += new System.EventHandler(this.dangky_Click);
            // 
            // quenMK
            // 
            this.quenMK.AllowDrop = true;
            this.quenMK.Location = new System.Drawing.Point(310, 254);
            this.quenMK.Name = "quenMK";
            this.quenMK.Size = new System.Drawing.Size(144, 29);
            this.quenMK.TabIndex = 6;
            this.quenMK.Text = "Quên Mật Khẩu";
            this.quenMK.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.dangnhap;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quenMK);
            this.Controls.Add(this.dangky);
            this.Controls.Add(this.dangnhap);
            this.Controls.Add(this.textBoxMK);
            this.Controls.Add(this.textBoxTK);
            this.Controls.Add(this.labelMK);
            this.Controls.Add(this.labelTK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTK;
        private Label labelMK;
        private TextBox textBoxTK;
        private TextBox textBoxMK;
        private Button dangnhap;
        private Button dangky;
        private Button quenMK;
    }
}