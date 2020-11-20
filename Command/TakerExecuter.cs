using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    
     class TakerExecuter
    {
        public List<Command> commandlist = new List<Command>();
        public List<string> commandstring = new List<string>();
        public string temp;

        public void TakeCommands(Command command)
        {
            commandlist.Add(command);
        }

        public void PlaceCommands()
        {
            for (int i = 0; i < commandlist.Count ; ++i)
            {
                commandstring.Add(commandlist[0].Execute());

            }
            commandlist.Clear();
        }

        public void ClearString()
        {
            commandstring.Clear();
        }

    }
}
