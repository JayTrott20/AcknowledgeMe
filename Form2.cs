using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using HairDLL;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QueensBeyondV._3
{
    public partial class LogonPage : Form
    {
        FormQueen3 queen3;
        LogonTable2 logonTable;
        SalonAppointmentTable salonAppointmentTable;
        public LogonPage()
        {
            InitializeComponent();
        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=msi;Initial Catalog=SalonManagementSystem;Integrated Security=True;");
            SqlDataAdapter adapter = new SqlDataAdapter("Select Count(*) From LogonTable2 where username ='" + txtUsername.Text  + "' and password ='" + txtPassword.Text + "'",conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Success: Account Validated");
                queen3 = new FormQueen3();
                queen3.Show();
            }
            else if (dt.Rows[0][0].ToString() == "2")
            {
                MessageBox.Show("Success: Account Validated");
                queen3 = new FormQueen3();
                queen3.Show();
            }
            else if (dt.Rows[0][0].ToString() == "3")
            {
                MessageBox.Show("Success: Account Validated");
                queen3 = new FormQueen3();
                queen3.Show();
            }
            else
                MessageBox.Show("Please enter a valid username and/or password.");

            queen3 = new FormQueen3();
            queen3.Hide();
        }

        private void LogonPage_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
