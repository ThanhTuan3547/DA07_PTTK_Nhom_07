
namespace HE_THONG_TIEM_CHUNG_AN_BINH
{
    partial class ConnectDB
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
            this.sv_name = new System.Windows.Forms.TextBox();
            this.db_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sv_name
            // 
            this.sv_name.Location = new System.Drawing.Point(112, 33);
            this.sv_name.Name = "sv_name";
            this.sv_name.Size = new System.Drawing.Size(100, 20);
            this.sv_name.TabIndex = 0;
            // 
            // db_name
            // 
            this.db_name.Location = new System.Drawing.Point(112, 71);
            this.db_name.Name = "db_name";
            this.db_name.Size = new System.Drawing.Size(100, 20);
            this.db_name.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConnectDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 151);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.db_name);
            this.Controls.Add(this.sv_name);
            this.Name = "ConnectDB";
            this.Text = "ConnectDB";
            this.Load += new System.EventHandler(this.ConnectDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sv_name;
        private System.Windows.Forms.TextBox db_name;
        private System.Windows.Forms.Button button1;
    }
}