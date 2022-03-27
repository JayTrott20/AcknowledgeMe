using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using HairDLL;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueensBeyondV._3
{
    enum ServiceRequestType
    {
        Dreadlocs,
        Natural,
        Braids,
        Wigs,
        Relaxers
    };

    public partial class FormQueen3 : Form
    {
        SalonAppointmentTable table;
        AppointmentRepository repository;
        public FormQueen3()
        {
            InitializeComponent();
        }

        private void FormQueen3_Load(object sender, EventArgs e)
        {
            repository = new AppointmentRepository();
           // queen3 = new FormQueen3();
           // paneladminView.Hide();
            AdminGridView.DataSource = repository.GetAppointments();
        }
        
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            SalonClient obj = new SalonClient();
            this.Hide();
            obj.Show();

            //logonPage = new LogonPage();
            //logonPage.Show();
            //btnAdminLogin.Hide();
            //paneladminView.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalonClient salon = new SalonClient();
            salon.Close();
            LogonPage logon = new LogonPage();
            FormQueen3 formQueen3 = new FormQueen3();
            MessageBox.Show("You have been logged off successfully");
          
        }

        private void btnClientView_Click(object sender, EventArgs e)
        {
            //logonPage = new LogonPage(); -----> Commentted for later use;
            //logonPage.Hide(); -----> Commentted for later use;
            btnAdminLogin.Hide();
            btnLogout.Show();
            //salonClient = new SalonClient(); -----> Commentted for later use;
            //salonClient.Show();  -----> Commentted for later use;

        }
        private void RefreshData()
        {

        }

        private void btnAddAppt_Click(object sender, EventArgs e)
        { 
                SalonClient obj = new SalonClient();
                this.Hide();
                obj.Show();
            //   entities.SalonAppointmentTables.Add(new SalonAppointmentTable());
            //   entities.SaveChanges();-----> Commentted for later use;


        }

        private void btnDeleteAppt_Click(object sender, EventArgs e)
        {
            var obj = AdminGridView.CurrentRow.Cells[0].Value.ToString();
            var objDelete = repository.GetAppointments().First(x => x.Service_Id == obj);
            repository.DeleteAppointment(objDelete);
            //AppointmentRepository.entities.SalonAppointmentTables.ToList().RemoveAt(obj +1);
            //AppointmentRepository.entities.SaveChanges();
            AdminGridView.DataSource = null;
            AdminGridView.DataSource = repository.GetAppointments();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
