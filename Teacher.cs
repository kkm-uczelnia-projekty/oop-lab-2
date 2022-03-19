namespace po
{
    public class Teacher : Person
    {
        public Teacher(string name, int age): base(name, age)
        {

        }

        public override string ToString()
        {
            return String.Format("Teacher: {0}", base.ToString());
        }
    }
}