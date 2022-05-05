
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
            this.ID_box = new System.Windows.Forms.TextBox();
            this.Password_box = new System.Windows.Forms.TextBox();
            this.Btn_Dang_nhap = new System.Windows.Forms.Button();
            this.Role_box = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ID_box
            // 
            this.ID_box.Location = new System.Drawing.Point(309, 121);
            this.ID_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID_box.Name = "ID_box";
            this.ID_box.Size = new System.Drawing.Size(169, 22);
            this.ID_box.TabIndex = 0;
            this.ID_box.TextChanged += new System.EventHandler(this.textBox_TaiKhoan_TextChanged);
            // 
            // Password_box
            // 
            this.Password_box.Location = new System.Drawing.Point(309, 162);
            this.Password_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Password_box.Name = "Password_box";
            this.Password_box.Size = new System.Drawing.Size(169, 22);
            this.Password_box.TabIndex = 1;
            this.Password_box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Btn_Dang_nhap
            // 
            this.Btn_Dang_nhap.Location = new System.Drawing.Point(347, 210);
            this.Btn_Dang_nhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Dang_nhap.Name = "Btn_Dang_nhap";
            this.Btn_Dang_nhap.Size = new System.Drawing.Size(107, 34);
            this.Btn_Dang_nhap.TabIndex = 2;
            this.Btn_Dang_nhap.Text = "Đăng nhập";
            this.Btn_Dang_nhap.UseVisualStyleBackColor = true;
            this.Btn_Dang_nhap.Click += new System.EventHandler(this.Btn_Dang_nhap_Click);
            // 
            // Role_box
            // 
            this.Role_box.FormattingEnabled = true;
            this.Role_box.Location = new System.Drawing.Point(309, 89);
            this.Role_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Role_box.Name = "Role_box";
            this.Role_box.Size = new System.Drawing.Size(169, 24);
            this.Role_box.TabIndex = 3;
            // 
            // dang_nhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Role_box);
            this.Controls.Add(this.Btn_Dang_nhap);
            this.Controls.Add(this.Password_box);
            this.Controls.Add(this.ID_box);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "dang_nhap";
            this.Text = "DANG NHAP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_box;
        private System.Windows.Forms.TextBox Password_box;
        private System.Windows.Forms.Button Btn_Dang_nhap;
        private System.Windows.Forms.ComboBox Role_box;
    }
}

