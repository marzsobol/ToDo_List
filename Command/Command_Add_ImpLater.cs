using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Command_Add_ImpLater:Command
    {
        private Task task;

        public Command_Add_ImpLater(Task task)
        {
            this.task = task;
        }
        public string Execute()
        {
            return task.ImportantLater();
        }


    }
}
