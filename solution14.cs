using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
namespace Assignment
{
    [Serializable]
    class Employee
    {
        static int empNo = 1000;
        public Employee()
        {
            EmpID = ++empNo;
        }

        public Employee(int id)
        {
            EmpID = id;
        }
        public int EmpID { get; private set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public int EmpSalary { get; set; }
        public override string ToString()
        {
            return $"{EmpID}, {EmpName}, {EmpAddress}, {EmpSalary}";
        }
    }
    class FileIODemo
    {
        const string fileName = "EmployeeDetails.txt";
        static void writeToFile(Employee emp)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine(emp);
            writer.Close();
            fs.Close();
        }

        static Employee readFromFile()
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fs);
                string data = reader.ReadLine();
                string[] details = data.Split(',');
                Employee emp = new Employee(int.Parse(details[0]));
                emp.EmpName = details[1];
                emp.EmpAddress = details[2];
                emp.EmpSalary = int.Parse(details[3]);
                fs.Close();
                return emp;
            }
            throw new Exception("File does not exist");
        }

        static void writeUsingFile(Employee emp)
        {
            if (File.Exists(fileName))
            {
                File.WriteAllText(fileName, emp.ToString());
            }
        }

        static Employee readUsingFile()
        {
            if (File.Exists(fileName))
            {
                var lines = File.ReadLines(fileName);
                foreach (var line in lines)
                {
                    string[] details = line.Split(',');
                    Employee emp = new Employee(int.Parse(details[0]));
                    emp.EmpName = details[1];
                    emp.EmpAddress = details[2];
                    emp.EmpSalary = int.Parse(details[3]);
                    return emp;
                }
            }
            throw new Exception("File not found to read");
        }
        static void Main(string[] args)
        {
            //writeToFile(new Employee { EmpName = "Phaniraj", EmpAddress = "Bangalore", EmpSalary = 67000 });
            //Console.WriteLine(readFromFile());
            //writeUsingFile(new Employee { EmpName = "Sunder", EmpAddress = "Mysore", EmpSalary = 77000 });
            //Console.WriteLine(readUsingFile());
            Employee emp = new Employee { EmpName = "ayesha", EmpAddress = "Bangalore", EmpSalary = 67000 };
            writeFileToDirectory("C:\\SubDir", $"{emp.EmpName}.txt", emp);
        }

        private static void writeFileToDirectory(string dirName, string fileName, Employee details)
        {
            DirectoryInfo info;
            if (Directory.Exists(dirName))
            {
                info = new DirectoryInfo(dirName);
            }
            else
                info = Directory.CreateDirectory(dirName);
            StreamWriter writer = File.CreateText(Path.Combine(info.FullName, fileName));
            writer.WriteLine(details);
            writer.Close();
        }
    }
}