using System;
using HospitalManagementSystem.entity;

namespace HospitalManagementSystem.dao
{
    interface IHospitalService
    {
        
        public Appointment GetAppointmentById(int appointmentId);

        
        public List<Appointment> GetAppointmentsForPatient(int patientId);
        
        
        public List<Appointment> GetAppointmentsForDoctor(int doctorId);
        
       
        public bool ScheduleAppointment(Appointment appointment);

        public bool UpdateAppointment(Appointment appointment);

        public bool CancelAppointment(int appointmentId);

        public List<Doctor> DisplayAllDoctors();

        
        public List<Patient> DisplayAllPatients();

        public List<Appointment> DisplayAllAppointments();
    }
}
