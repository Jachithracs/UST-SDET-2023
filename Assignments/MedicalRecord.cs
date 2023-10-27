using Assignments;
using Assignments.ExceptionMessages;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MedicalRecord : Patient
    {
        public static List<MedicalRecord> medical= new List<MedicalRecord>();
        public MedicalRecord(int patientId, string? patientName, 
            int age, string? diagnosis,int recordId,int treatmentCost) : base(patientId, patientName, age, diagnosis)
        {
            RecordId = recordId;
            TreatmentCost = treatmentCost;
        }

        public int RecordId { get; set; }
        public int TreatmentCost { get; set; }

        public static void AddMedicalDetails(MedicalRecord record)
        {
            if(record.RecordId <= 0 )
            {
                throw new RecIdException(MedicalException.exlist["RecId"]);
            }
            if (String.IsNullOrWhiteSpace(record.PatientName))
            {
                throw new NameException(MyException.exmesslist["Name"]);
            }
            if (String.IsNullOrWhiteSpace(record.Diagnosis))
            {
                throw new DiagnosisException(MyException.exmesslist["Diagnosis"]);
            }
            if(record.TreatmentCost <= 0) 
            {
                throw new CostException(MedicalException.exlist["TreatCost"]);
            }
            medical.Add(record);
        }
        public static void DisplayMedicalInfo()

        {
            foreach (MedicalRecord item in medical)
            {
                Console.WriteLine("Record Id : {0} \n Patient Name : {1} \nAge : {2} \n Diagnosis : {3}\n Treatment Cost : {4} ",
                   item.PatientId, item.PatientName,item.Age, item.Diagnosis,item.TreatmentCost);
            }
        }
    }
}

