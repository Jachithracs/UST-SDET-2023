using Assignments.ExceptionMessages;
using System;
using System.Collections.Generic;
using System.IO;
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

        
        public static void AddPatientInfo(Patient patient)
        {
            /*
            if(patient.Age < 0 || patient.Age > 120)
            {
                throw new AgeException(MyException.exmesslist["Age"]);
            }
            if (String.IsNullOrWhiteSpace(patient.PatientName))
            {
                throw new NameException(MyException.exmesslist["Name"]);
            }
            if (String.IsNullOrWhiteSpace(patient.Diagnosis))
            {
                throw new DiagnosisException(MyException.exmesslist["Diagnosis"]);
            }
            patients.Add(patient);
            */
            FileStream file = new FileStream("D:\\C# Daily Works\\Basic Solution\\Files\\PatientInfo.txt",
                FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(file);
           
            sw.WriteLine("Patient Id : {0}\nPatient Name : {1}\nPatient Age : {2}\nDiagnosis :{3}",
                patient.PatientId,patient.PatientName,patient.Age,patient.Diagnosis);
            sw.Flush();
            sw.Close();
            file.Close();
        }
        public static void DisplayPatientDetails()

        {
            /*
            foreach (Patient item in patients)
            {
                Console.WriteLine("Patient Id : {0} \n Patient Name : {1}\n Patient Age : {2} \n Diagnosis : {3}",
                   item.PatientId,item.PatientName,item.Age,item.Diagnosis );
            }
            */
            FileStream stream = new FileStream("D:\\C# Daily Works\\Basic Solution\\Files\\PatientInfo.txt",
                FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(stream);
            string? str =sr.ReadToEnd();
            Console.WriteLine(str);
            sr.Close();
            stream.Close();
        }

    }
}
