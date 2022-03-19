namespace po
{
    public class Classroom
    {
        private string name { get; }
        private Person[] people;

        public Classroom(string name, Person[] people)
        {
            this.name = name;
            this.people = people;
        }

        public override string ToString()
        {
            return String.Format("Classroom: {0}\n{1}", name, formatPeople());
        }

        private string formatPeople()
        {
            var convertedPeople = this.people.ToList().ConvertAll<string>(person => person.ToString());
            return String.Join("\n\n", convertedPeople);
        }
    }
}
