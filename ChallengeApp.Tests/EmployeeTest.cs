
namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void TestStatisticsForMin()
        {
            var employee = new Employee("Adam", "Kowalski");
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
            var employee = new Employee("Tomasz", "G³owacki");
            employee.AddGrade(5);
            employee.AddGrade(4);
            employee.AddGrade(6);
            employee.AddGrade(-1);

            var ststistics = employee.GetStatistics();

            Assert.AreEqual(ststistics.Max, 6);
        }

        [Test]
        public void TestStatisticForAverage()
        {
            var employee = new Employee("Krzysztof", "Nowak");
            employee.AddGrade(6);
            employee.AddGrade(-3);
            employee.AddGrade(4);
            employee.AddGrade(2);

            var statisctics = employee.GetStatistics();

            Assert.AreEqual(statisctics.Average, 2.25);
        }
    }
}


