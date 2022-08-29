using System;
using System.IO;
namespace Assignment
{
    class Patient
    {
        static int patientNo = 1000;

        public Patient()
        {
            PatientID = ++patientNo;
        }

        public Patient(int id)
        {
            PatientID = id;
        }
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public long PatientNum { get; set; }
        public int PatientBill { get; set; }
        public override string ToString()
        {
            return $"{PatientName} with ID {PatientID} has to pay Rs.{PatientBill}. His number is {PatientNum}";
        }
    }
    class PatientIO
    {
        const string fileName = "PatientDetails.txt";
        static void writeToFile(Patient pat)
        {
            FileStream pt = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(pt);
            writer.WriteLine($"{pat.PatientID},{pat.PatientName},{pat.PatientBill},{pat.PatientNum}");
            writer.Close();
            pt.Close();
        }

        static Patient readFromFile()
        {
            FileStream pt = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(pt);
            string data = reader.ReadLine();
            string[] details = data.Split(',');
            Patient pat = new Patient(int.Parse(details[0]));
            pat.PatientName = details[1];
            pat.PatientID = int.Parse(details[2]);
            pat.PatientNum = long.Parse(details[3]);
            pt.Close();
            return pat;
        }
        static void Main(string[] args)
        {
            writeToFile(new Patient { PatientID = 101, PatientName = "sammy", PatientNum = 33456774321, PatientBill = 13211 });
            Console.WriteLine(readFromFile());
        }
    }
}