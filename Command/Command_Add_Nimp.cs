using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Command
{
    public class Command_Add_NimpNow:Command
    {
        private Task task;

        public Command_Add_NimpNow(Task task)
        {
            this.task = task;
        }
        public string Execute()
        {
            return task.NotImportantNow();
        }

  
    }
}
