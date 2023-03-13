﻿
namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
       
        public override event GradeAddedDelegate GradeAdded;

        

        private const string fileName = "grades.txt";

        
        public EmployeeInFile(string name, string surname, char sex, int age)
            : base(name, surname, sex, age)
        {
        }
        public override void AddGrade(float grade)
       {
           if (grade >= 0 && grade <= 100)
            {
               using (var writer = File.AppendText(fileName))
               {
                   writer.WriteLine(grade);
               }
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }

        public override void AddGrade(char grade)
        {
            
        }

        public override void AddGrade(string grade)
        {
            switch (grade)
            {
              case "A":
               case "a":
                    using(var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(100);
                    }                                                           
                    break;
                case "B":
                case "b":
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(80);
                    }                                                          
                    break;
                case "C":
                case "c":
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(60);
                    }                                                                 
                    break;
                case "D":
                case "d":
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(40);
                    }                                                                               
                    break;
                case "E":
                case "e":
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(20);
                    }
                 
                    break;
                default:
                    if (float.TryParse(grade, out float result))
                    {
                        this.AddGrade((float)result);
                    }
                    else
                    {
                        throw new Exception("String nie jest floatem");
                    }
                    break;
            }
            if (GradeAdded != null)
            {
                GradeAdded(this, new EventArgs());
            }
        }

        public override void AddGrade(double grade)
        {
            float DoubleAsFloat = (float)grade;
            this.AddGrade(DoubleAsFloat);
        }

        public override void AddGrade(long grade)
        {
            float LongAsFloat = (float)grade;
            this.AddGrade(LongAsFloat);
        }
        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);                    
            return result;
        }
        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}")) 
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
#pragma warning disable CA1305 // Określ interfejs IFormatProvider
                        var number = float.Parse(line);
#pragma warning restore CA1305 // Określ interfejs IFormatProvider
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }
        private Statistics CountStatistics(List<float>grades)
        {
            var statistics = new Statistics();
            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }     
            return statistics;
        }
    }
}
