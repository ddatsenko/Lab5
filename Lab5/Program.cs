using System;
using System.IO;

namespace Lab5
{
    struct Student
        {
            public string surname;
            public string firstName;
            public string patronymic;
            public char sex;
            public string dateOfBirth;
            public char mathematicsMark;
            public char physicsMark;
            public char informaticsMark;
            public int scholarship;

              public Student(string lineWithAllData)
              {
                string[] linesWiThDataAboutOneStudent = lineWithAllData.Split(' ');

                this.surname = linesWiThDataAboutOneStudent[0];
                this.firstName = linesWiThDataAboutOneStudent[1];
                this.patronymic = linesWiThDataAboutOneStudent[2];
                this.sex = Convert.ToChar(linesWiThDataAboutOneStudent[3]);
                this.dateOfBirth = linesWiThDataAboutOneStudent[4];
                this.mathematicsMark = Convert.ToChar(linesWiThDataAboutOneStudent[5]);
                this.physicsMark = Convert.ToChar(linesWiThDataAboutOneStudent[6]);
                this.informaticsMark = Convert.ToChar(linesWiThDataAboutOneStudent[7]);
                this.scholarship = Convert.ToInt32(linesWiThDataAboutOneStudent[8]);
              }
        }

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"input.txt";
       
            Student[] studs = ReadData(path);

            runMenu(studs);
            Console.ReadKey();
        }

        static void runMenu(Student[] studs)
        {

            for (int i = 0; i < studs.Length; i++)
            {
                if (studs[i].informaticsMark == '5' && studs[i].sex == 'F')
                {
                    Console.WriteLine(studs[i].surname);
                }
            }
        }

        static Student[] ReadData(string fileName)
        {
            string[] pathForFile = File.ReadAllLines(fileName);
            Student[] ArrayOfStudent = new Student[pathForFile.Length];
           
            for(int i = 0; i < pathForFile.Length;i++)
            {
                ArrayOfStudent[i] = new Student(pathForFile[i]);
            }
            return ArrayOfStudent;
        }
    }
}