namespace quanly
{
    partial class thanhvien
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
            this.checkin = new System.Windows.Forms.Button();
            this.chekuot = new System.Windows.Forms.Button();
            this.test1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkin
            // 
            this.checkin.Location = new System.Drawing.Point(518, 123);
            this.checkin.Name = "checkin";
            this.checkin.Size = new System.Drawing.Size(94, 29);
            this.checkin.TabIndex = 1;
            this.checkin.Text = "checkin";
            this.checkin.UseVisualStyleBackColor = true;
            this.checkin.Click += new System.EventHandler(this.button1_Click);
            // 
            // chekuot
            // 
            this.chekuot.Location = new System.Drawing.Point(943, 123);
            this.chekuot.Name = "chekuot";
            this.chekuot.Size = new System.Drawing.Size(94, 29);
            this.chekuot.TabIndex = 2;
            this.chekuot.Text = "checkout";
            this.chekuot.UseVisualStyleBackColor = true;
            this.chekuot.Click += new System.EventHandler(this.chekuot_Click);
            // 
            // test1
            // 
            this.test1.AutoSize = true;
            this.test1.Location = new System.Drawing.Point(738, 37);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(93, 20);
            this.test1.TabIndex = 0;
            this.test1.Text = "xin chào bạn";
            this.test1.Click += new System.EventHandler(this.label1_Click);
            // 
            // thanhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 709);
            this.Controls.Add(this.chekuot);
            this.Controls.Add(this.checkin);
            this.Controls.Add(this.test1);
            this.Name = "thanhvien";
            this.Text = "thanhvien";
            this.Load += new System.EventHandler(this.thanhvien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button checkin;
        private Button chekuot;
        private Label test1;
    }
}