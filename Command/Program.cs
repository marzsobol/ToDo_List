using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
             AllTasks tasks = new AllTasks();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Form2 form2 = new Form2();
            form2.Show();
            form2.Hide();
            Application.Run(new Form1());
        }
    }
}
