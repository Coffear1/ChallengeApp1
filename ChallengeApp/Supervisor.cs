namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();
        public Supervisor(string name, string surname, char sex, int age )
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
            this.Age = age;
        }

        public string Name { get; private set; }

        public string Surname {get; private set; }

        public char Sex { get; private set; }

        public int Age { get; private set; }    


        public void AddGrade(float grade)
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
            public void AddGrade(double grade)
            {
                var DoubleAsFloat = (float)grade;
                this.AddGrade(DoubleAsFloat);
            }

            public void AddGrade(long grade)
            {
                var LongAsFloat = (float)grade;
                this.AddGrade(LongAsFloat);
            }
            public void AddGrade(char grade)
            {
                throw new NotImplementedException();
            }

            public void AddGrade(string grade)
            {
                switch (grade)
                {
                    case "6":
                        this.grades.Add(100);
                        break;
                    case "-6":
                    case "6-":
                        this.grades.Add(95);
                        break;
                    case "+5":
                    case "5+":
                        this.grades.Add(85);
                        break;
                    case "5":
                        this.grades.Add(80);
                        break;
                    case "-5":
                    case "5-":
                        this.grades.Add(75);
                        break;
                    case "+4":
                    case "4+":
                        this.grades.Add(65);
                        break;
                    case "4":
                        this.grades.Add(60);
                        break;
                    case "-4":
                    case "4-":
                        this.grades.Add(55);
                        break;
                    case "+3":
                    case "3+":
                        this.grades.Add(45);
                        break;
                    case "3":
                        this.grades.Add(40);
                        break;
                    case "-3":
                    case "3-":
                        this.grades.Add(35);
                        break;
                    case "+2":
                    case "2+":
                        this.grades.Add(25);
                        break;
                    case "2":
                        this.grades.Add(20);
                        break;
                    case "-2":
                    case "2-":
                        this.grades.Add(15);
                        break;
                    case "+1":
                    case "1+":
                        this.grades.Add(5);
                        break;
                    case "1":
                        this.grades.Add(0);
                        break;
                    default:
                    if (float.TryParse(grade, out float result))
                    {
                        this.AddGrade((float)result);
                    }
                    else
                    {
                        throw new Exception("Podaj ocenę od 1 do 6");
                    }
                    break;
            }
            }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average = statistics.Average / this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}
