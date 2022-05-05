
namespace HE_THONG_TIEM_CHUNG_AN_BINH
{
    partial class KH_Info
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
            this.KH_Info_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KH_Info_label
            // 
            this.KH_Info_label.AutoSize = true;
            this.KH_Info_label.Location = new System.Drawing.Point(12, 9);
            this.KH_Info_label.Name = "KH_Info_label";
            this.KH_Info_label.Size = new System.Drawing.Size(94, 13);
            this.KH_Info_label.TabIndex = 0;
            this.KH_Info_label.Text = "Thông tin cá nhân";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(136, 9);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(18, 13);
            this.ID_label.TabIndex = 1;
            this.ID_label.Text = "ID";
            this.ID_label.Click += new System.EventHandler(this.ID_label_Click);
            // 
            // KH_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 334);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.KH_Info_label);
            this.Name = "KH_Info";
            this.Text = "KH_Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KH_Info_label;
        private System.Windows.Forms.Label ID_label;
    }
}