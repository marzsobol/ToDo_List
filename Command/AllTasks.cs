using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class AllTasks
    {
        public List<Task> tasklist = new List<Task>();

        public AllTasks() { }
        public void TasksAddtoAll(Task task)
        {
            tasklist.Add(task);
        }
        public void TaskDelete(Task task)
        {

                tasklist.Remove(task);

        }

        public Task TaskFind(string taskname)
        {
            
            for (int i = 0; i < tasklist.Count; i++)
            {
                if(tasklist[i].task_name == taskname)
                    return tasklist[i];
            }

                return null;
            
        }
        public int TaskCount()
        {
            return tasklist.Count();
        }
    }
}
