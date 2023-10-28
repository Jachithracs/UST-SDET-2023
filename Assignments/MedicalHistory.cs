using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MedicalHistory
    {
        public static List<MedicalHistory> History = new List<MedicalHistory>();
        public MedicalHistory(int recordId, int patientId, string? description, string? date)
        {
            RecordId = recordId;
            PatientId = patientId;
            Description = description;
            Date = date;
        }

        public int RecordId { get; set; }
        public int PatientId { get; set; }
        public string? Description { get; set; }
        public string? Date {  get; set; }

        public static void AddPatientInfo(MedicalHistory medical)
        {
            History.Add(medical);
        }
        public static void AddPatientHistFile(MedicalHistory med)
        {
            FileStream file = new FileStream("D:\\C# Daily Works\\Basic Solution\\Files\\PatientHist.txt",
                FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(file);

            sw.WriteLine("{0},{1}, {2}, {3}",
               med.RecordId, med.PatientId,med.Description, med.Date);
            sw.Flush();
            sw.Close();
            file.Close();
        }
        public static void DisplayPatientDetails(int pid)

        {
            FileStream stream = new FileStream("D:\\C# Daily Works\\Basic Solution\\Files\\PatientHist.txt",
                FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(stream);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string? str = sr.ReadLine();
            while (str != null)
            {
                string[] arr = str.Split(",");
                int n = int.Parse(arr[1]);
                if (n==pid)
                {
                    Console.WriteLine("Record Id : {0} Patient Id : {1} Description : {2} Date :{3}",
                        arr[0], arr[1], arr[2], arr[3]);
                }
                str = sr.ReadLine();
            }
            sr.Close();
            stream.Close();
        }

    }
}
