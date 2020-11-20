using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Command_Add_ImpNow: Command
    {
        private Task task;
        public Command_Add_ImpNow(Task task)
        {
            this.task = task;
        }
        public string Execute()
        {

            return task.ImportantNow();
        }

       
    }
}
