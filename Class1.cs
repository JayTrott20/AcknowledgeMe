using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueensBeyondV._3
{
    public interface CRUD
    {
        int GetId();
        char GetServiceDesignation(char serviceDesignationName);
        void AddAppointment(SalonAppointmentTable obj);
        string GetServiceRequestType();
        void DeleteAppointment(SalonAppointmentTable obj);
        void UpdateAppointment(string ServiceId);
        DateTime SetDate(DateTime dateTime);
        DateTime GetDateRequested();
        string GetServiceId(char serviceDesignationName, int id);
        ICollection<SalonAppointmentTable> GetAppointments();
    }

    public class AppointmentRepository : CRUD
    {
       public static SalonManagementSystemEntities1 entities = new SalonManagementSystemEntities1();
        public AppointmentRepository()
        {

        }
        public void AddAppointment(SalonAppointmentTable obj)
        {
            entities.SalonAppointmentTables.Add(obj);   
            entities.SaveChanges();
        }

        public void DeleteAppointment(SalonAppointmentTable obj)
        {
            entities.SalonAppointmentTables.Remove(obj);
            entities.SaveChanges();
        }

        public ICollection<SalonAppointmentTable> GetAppointments()
        {
           return entities.SalonAppointmentTables.ToList();
        }

        public DateTime GetDateRequested()
        {
            throw new NotImplementedException();
        }

        public int GetId()
        {
            throw new NotImplementedException();
        }

        public char GetServiceDesignation(char serviceDesignationName)
        {
            throw new NotImplementedException();
        }

        public string GetServiceId(char serviceDesignationName, int id)
        {
            throw new NotImplementedException();
        }

        public string GetServiceRequestType()
        {
            throw new NotImplementedException();
        }

        public DateTime SetDate(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public void UpdateAppointment(string ServiceId)
        {
            throw new NotImplementedException();
        }
    }
}
