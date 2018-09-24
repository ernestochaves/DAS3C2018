namespace Lab03
{
    internal class Student : Person
    {
        private double Average;

        public Student(string firstName, string lastName, double avg) : base(firstName, lastName)
        {
            this.Average = avg;
        }

        public override string GetSummary()
        {
            return "STUDENT: " + base.GetSummary() + "/n Avg. :" + Average;
        }
    }
}