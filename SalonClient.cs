using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Drawing.Imaging;
using System.Timers;
using HairDLL;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueensBeyondV._3
{
    public partial class SalonClient : Form
    {
        AppointmentRepository repository;
        SalonAppointmentTable salonAppt;
        FormQueen3 queen3;
        public SalonClient()
        {
            InitializeComponent();
        }

        private void comboServiceRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
              comboServiceRequest.Enabled = true;
        }

        private void SalonClient_Load(object sender, EventArgs e)
        {
            comboServiceRequest.DataSource = Enum.GetValues(typeof(ServiceRequestType));
            repository = new AppointmentRepository();
        }

        private void btnApptRequest_Click(object sender, EventArgs e)
        {
            salonAppt = new SalonAppointmentTable();
            salonAppt.Full_Name = txtFullName.Text;
            salonAppt.Service_Request_Type = comboServiceRequest.Text;
            salonAppt.Date_and_Time_Requested = dateTimeRequest.Value;
            salonAppt.Service_Id = txtServiceId.Text;
            repository.AddAppointment(salonAppt);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            queen3 = new FormQueen3();
            this.Hide();
            queen3.Show();   
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
