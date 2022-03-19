namespace po
{
    public class Person
    {
        protected string name { get; }
        protected int age { get; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public bool Equals(Person? otherPerson)
        {
            if (otherPerson == null) {
                return false;
            }

            return this.age == otherPerson.age && this.name == otherPerson.name;
        }

        override public string ToString()
        {
            return String.Format("{0} ({1} y. o.)", name, age);
        }
    }    
}