﻿
namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;


        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname, char sex, int age)
            : base(name, surname, sex, age)
        {


           
        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

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
                    this.grades.Add(100);                  
                    break;
                case "B":
                case "b":
                    this.grades.Add(80);                  
                    break;
                case "C":
                case "c":
                    this.grades.Add(60);
                    break;
                case "D":
                case "d":
                    this.grades.Add(40);                  
                    break;
                case "E":
                case "e":
                    this.grades.Add(20);                  
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
            var statistics = new Statistics();
            foreach (var grade in this.grades) 
            {
                statistics.AddGrade(grade);
            }           
            return statistics;
        }
    }
}
