namespace Lab03
{
    internal class Professor : Person
    {
        private string v1;
        private string v2;
        private string[] Courses;

        public Professor(string firstName, string lastName, string[] courses) : base(firstName, lastName)
        {
            this.Courses = courses;
        }

        public override string GetSummary()
        {
            string courseString = "";
            for (int i = 0; i < Courses.Length; i++)
            {
                courseString += Courses[i];

            }

            return "PROFESSOR: " + base.GetSummary() + " Courses:" + courseString;
        }
    }
}