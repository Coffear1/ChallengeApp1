
namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void CompareTwoDifferentEmployees_ShouldReturnCorrect()
        {
            
            var employee1 = GetUser("Adam", "Kowalski", "45");
            var employee2 = GetUser("Tomasz", "Nowak", "43");

            Assert.AreNotEqual(employee1, employee2);
        }


        [Test]
        public void CompereTwoEmployees_ShouldReturnCorrect()
        {
            var employee1 = GetUser("Tomasz", "Kowalski", "45");
            var employee2 = GetUser("Tomasz", "Kowalski", "45");

            Assert.AreEqual(employee1.Imię, employee2.Imię);
        }


        [Test]
        public void CompareTwoInt_ShouldReturnCorrect()
        {
            int number1 = 100;
            int number2 = 100;

            Assert.AreEqual(number1, number2);
        }


        [Test]
        public void CompareTwoDouble_ShouldReturnCorrect()
        {
            double number1 = 45.55;
            double number2 = 45.55;

            Assert.AreEqual(number1, number2);
        }


        [Test]
        public void CompareTwoString_ShouldReturnCorrect()
        {
            string tekst1 = "Nagrywanie";
            string tekst2 = "Streamowanie";

            Assert.AreNotEqual(tekst1, tekst2);
        }


        private Employee GetUser(string imię,string nazwisko, string wiek)
        {
            return new Employee(imię, nazwisko, wiek);
        }
    }
}
