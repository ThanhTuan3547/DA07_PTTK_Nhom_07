
namespace HE_THONG_TIEM_CHUNG_AN_BINH
{
    partial class KH_main
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
            this.Info_btn = new System.Windows.Forms.Button();
            this.KQDKTC_btn = new System.Windows.Forms.Button();
            this.DKTC_btn = new System.Windows.Forms.Button();
            this.ThanhToan_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Info_btn
            // 
            this.Info_btn.Location = new System.Drawing.Point(26, 33);
            this.Info_btn.Name = "Info_btn";
            this.Info_btn.Size = new System.Drawing.Size(111, 23);
            this.Info_btn.TabIndex = 0;
            this.Info_btn.Text = "Thông tin cá nhân";
            this.Info_btn.UseVisualStyleBackColor = true;
            this.Info_btn.Click += new System.EventHandler(this.Info_btn_Click);
            // 
            // KQDKTC_btn
            // 
            this.KQDKTC_btn.Location = new System.Drawing.Point(292, 33);
            this.KQDKTC_btn.Name = "KQDKTC_btn";
            this.KQDKTC_btn.Size = new System.Drawing.Size(162, 23);
            this.KQDKTC_btn.TabIndex = 1;
            this.KQDKTC_btn.Text = "Kết quả đăng ký tiêm chủng";
            this.KQDKTC_btn.UseVisualStyleBackColor = true;
            // 
            // DKTC_btn
            // 
            this.DKTC_btn.Location = new System.Drawing.Point(153, 33);
            this.DKTC_btn.Name = "DKTC_btn";
            this.DKTC_btn.Size = new System.Drawing.Size(117, 23);
            this.DKTC_btn.TabIndex = 2;
            this.DKTC_btn.Text = "Đăng ký tiêm chủng";
            this.DKTC_btn.UseVisualStyleBackColor = true;
            // 
            // ThanhToan_btn
            // 
            this.ThanhToan_btn.Location = new System.Drawing.Point(460, 33);
            this.ThanhToan_btn.Name = "ThanhToan_btn";
            this.ThanhToan_btn.Size = new System.Drawing.Size(75, 23);
            this.ThanhToan_btn.TabIndex = 3;
            this.ThanhToan_btn.Text = "Thanh toán";
            this.ThanhToan_btn.UseVisualStyleBackColor = true;
            // 
            // KH_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 341);
            this.Controls.Add(this.ThanhToan_btn);
            this.Controls.Add(this.DKTC_btn);
            this.Controls.Add(this.KQDKTC_btn);
            this.Controls.Add(this.Info_btn);
            this.Name = "KH_main";
            this.Text = "KH_main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Info_btn;
        private System.Windows.Forms.Button KQDKTC_btn;
        private System.Windows.Forms.Button DKTC_btn;
        private System.Windows.Forms.Button ThanhToan_btn;
    }
}