using Assignments.ExceptionMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Patient
    {
        public static List<Patient> patients = new List<Patient>();
        public Patient(int patientId, string? patientName, int age, string? diagnosis)
        {
            PatientId = patientId;
            PatientName = patientName;
            Age = age;
            Diagnosis = diagnosis;
        }

        public int PatientId { get; set; }
        public string? PatientName { get; set;}
        public int Age { get; set; }
        public string? Diagnosis { get; set; }


        public void AddPatientInfo(Patient patient)
        {
            if(patient.Age > 0 || patient.Age < 120)
            {
                throw new AgeException(MyException.exmesslist["Age"]);
            }
            patients.Add(patient);

        }
    }
}
