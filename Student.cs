namespace po
{
    public class Student : Person
    {
        private string group { get; }
        private List<Task> tasks;

        public Student(string name, int age, string group) : base(name, age)
        {
            this.group = group;
            this.tasks = new List<Task>();
        }

        public Student(string name, int age, string group, List<Task> tasks) : base(name, age)
        {
            this.group = group;
            this.tasks = tasks;
        }

        public void AddTask(string taskName, TaskStatus taskStatus)
        {
            var task = new Task(taskName, taskStatus);
            this.tasks.Add(task);
        }

        public void RemoveTask(int taskIndex)
        {
            this.tasks.RemoveAt(taskIndex);
        }

        public void UpdateTask(int taskIndex, TaskStatus status)
        {
            var task = this.tasks[taskIndex];
            if (task == null)
            {
                throw new ArgumentOutOfRangeException("Task index is out of range");
            }

            task.status = status;
        }

        public string RenderTasks(string prefix = "\t")
        {
            var index = 0;
            var convertedTasks = this.tasks.ConvertAll<string>(task => String.Format("{0}{1}. {2} [{3}]", prefix, index++, task.name, task.status));
            return String.Join("\n", convertedTasks);
        }

        public override string ToString()
        {
            return String.Format("Student {0}\nGroup: {1}\nTasks: \n{2}", base.ToString(), group, RenderTasks());
        }
    }
}