

namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname, char sex, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Sex { get; private set; }
        public int Age { get; private set; }

        public abstract void AddGrade(float grade);
        public abstract void AddGrade(char grade);
        public abstract void AddGrade(string grade);
        public abstract void AddGrade(double grade);
        public abstract void AddGrade(long grade);
        public abstract Statistics GetStatistics();
       
    }
}
