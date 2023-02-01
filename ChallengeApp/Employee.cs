namespace ChallengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();

        public Employee(string imię, string nazwisko, string wiek)
        {
            this.Imię = imię;
            this.Nazwisko = nazwisko;
            this.Wiek = wiek;
        }

        public string Imię { get; private set; }
        public string Nazwisko { get; private set; }
        public string Wiek { get; private set; }


        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }


        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}
