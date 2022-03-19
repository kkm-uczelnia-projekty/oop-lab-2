namespace po
{
    public enum TaskStatus
    {
        Waiting,
        Progress,
        Done,
        Rejected,

    }

    public class Task 
    {
        public string name { get; }
        public TaskStatus status { get; set; }

        public Task(string name, TaskStatus status)
        {
            this.name = name;
            this.status = status;
        }

        public override string ToString()
        {
            return String.Format("{0} [{1}]", name, status);
        }
    }
}
