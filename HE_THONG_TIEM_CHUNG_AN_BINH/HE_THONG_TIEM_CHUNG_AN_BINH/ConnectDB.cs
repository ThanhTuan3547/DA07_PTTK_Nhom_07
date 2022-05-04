using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HE_THONG_TIEM_CHUNG_AN_BINH
{
    public partial class ConnectDB : Form
    {
        public ConnectDB()
        {
            InitializeComponent();
            // set text over here to debug
            sv_name.Text = "PIKACHU\\PIKACHU";
            db_name.Text = "HTTC";
        }

        private void ConnectDB_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            // build connection string to sql
            connectionString = @"Data Source =";
            connectionString += sv_name.Text + ";Initial Catalog=" + db_name.Text + ";Integrated Security=True;";
            //System.Diagnostics.Debug.WriteLine(connectionString);
            try
            {
                cnn = new SqlConnection(connectionString);
                //cnn.Open();
                //this.Hide();
                MessageBox.Show("Connected");
                // open new form Interface()
                this.Hide();
                dang_nhap interface1 = new dang_nhap(this, cnn);
                interface1.Show();


            }
            catch
            {// do nothing }

            }
        }
    }
}
