
namespace HE_THONG_TIEM_CHUNG_AN_BINH
{
    partial class dang_nhap
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
            this.textBox_TaiKhoan = new System.Windows.Forms.TextBox();
            this.textBox2_MatKhau = new System.Windows.Forms.TextBox();
            this.Btn_Dang_nhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_TaiKhoan
            // 
            this.textBox_TaiKhoan.Location = new System.Drawing.Point(310, 120);
            this.textBox_TaiKhoan.Name = "textBox_TaiKhoan";
            this.textBox_TaiKhoan.Size = new System.Drawing.Size(169, 22);
            this.textBox_TaiKhoan.TabIndex = 0;
            // 
            // textBox2_MatKhau
            // 
            this.textBox2_MatKhau.Location = new System.Drawing.Point(310, 162);
            this.textBox2_MatKhau.Name = "textBox2_MatKhau";
            this.textBox2_MatKhau.Size = new System.Drawing.Size(169, 22);
            this.textBox2_MatKhau.TabIndex = 1;
            this.textBox2_MatKhau.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Btn_Dang_nhap
            // 
            this.Btn_Dang_nhap.Location = new System.Drawing.Point(346, 211);
            this.Btn_Dang_nhap.Name = "Btn_Dang_nhap";
            this.Btn_Dang_nhap.Size = new System.Drawing.Size(106, 35);
            this.Btn_Dang_nhap.TabIndex = 2;
            this.Btn_Dang_nhap.Text = "Đăng nhập";
            this.Btn_Dang_nhap.UseVisualStyleBackColor = true;
            this.Btn_Dang_nhap.Click += new System.EventHandler(this.Btn_Dang_nhap_Click);
            // 
            // dang_nhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Dang_nhap);
            this.Controls.Add(this.textBox2_MatKhau);
            this.Controls.Add(this.textBox_TaiKhoan);
            this.Name = "dang_nhap";
            this.Text = "DANG NHAP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_TaiKhoan;
        private System.Windows.Forms.TextBox textBox2_MatKhau;
        private System.Windows.Forms.Button Btn_Dang_nhap;
    }
}

