
namespace ChallengeApp.Tests
{
    public class EmployeeTests 
    {
        [Test]
        public void TestStatisticsForMin()
        {
            var employee = new Employee("Adam", "Kowalski", 'M', 45);
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(5);
            employee.AddGrade(2);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(statistics.Min, 2);
        }

        [Test]
        public void TestStatisticsForMax()
        {
            var employee = new Employee("Tomasz", "G�owacki", 'M', 34);
            employee.AddGrade(5);
            employee.AddGrade(4);
            employee.AddGrade(6);
            employee.AddGrade(1);

            var ststistics = employee.GetStatistics();

            Assert.AreEqual(ststistics.Max, 6);
        }

        [Test]
        public void TestStatisticForAverage()
        {
            var employee = new Employee("Krzysztof", "Nowak", 'M', 36);
            employee.AddGrade(10);
            employee.AddGrade(4);
            employee.AddGrade(4);
            employee.AddGrade(2);

            var statisctics = employee.GetStatistics();

            Assert.AreEqual(statisctics.Average, 5);
        }

        [Test]
        public void TestStatisticForAverageLetters()
        {
            var employee = new Employee("Daniel", "Gawlas", 'M', 33);
            employee.AddGrade(10);
            employee.AddGrade(20);
            employee.AddGrade(35);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(statistics.AverageLetter, 'D');
        }

        [Test]
        public void IfAddGradeAsChar_ShouldReturnAverage()
        {
            var employee = new Employee("Zbigniew", "Michalak", 'M', 23);
            employee.AddGrade('a');
            employee.AddGrade('c');
            employee.AddGrade('e');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(statistics.Average, 60);
        }
    }
}


