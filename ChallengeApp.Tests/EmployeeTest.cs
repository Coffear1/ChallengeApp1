
namespace ChallengeApp.Tests
{
    public class Tests
    { 
        [Test]
        public void WhenUserCollectTwoScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Adam", "Kowalski", "43");
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(-5);
            employee.AddScore(2);

            // act
            var result = employee.Result;

            //assert
            Assert.AreEqual(8, result);
        }
    }
}