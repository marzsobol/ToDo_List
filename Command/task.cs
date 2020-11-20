using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Task
    {
        public string task_name { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public int year { get; set; }

        public Task(string task_name, int year, int month , int day)
        {
            this.task_name = task_name;
            this.month = month;
            this.year = year;
            this.day = day;
        }

        private int CalculateTime()
        {
            DateTime datafinish = new DateTime(year, month, day);
            DateTime now_day = DateTime.Now;
            TimeSpan span = datafinish.Subtract(now_day);
            return (int)span.TotalDays;

        }

        public string ImportantNow()
        {
            string message = "Musisz zrobić to szybko!,\n\r Zostało: ";
            message = message + CalculateTime().ToString() + " dni!";
            return message;
        }

        public string ImportantLater()
        {
            
            string message = "Masz jeszcze troszkę czasu.Ale on się kiedyś skończy,\n\r Zostało: ";
            message = message + CalculateTime().ToString() + " dni!";
            return message;
        }

        public string NotImportantNow()
        {
            string message = "Przydało by się to skończyć, ale czy warto?\n\r Zostało: ";
            message = message + CalculateTime().ToString() + " dni!";
            return message;
        }

        public string NotImportantLater()
        {
            string message = "Możesz nie robić tego zadania, jeśli nie masz czasu.\n\r Zostało: ";
            message = message + CalculateTime().ToString() + " dni!";
            return message;
        }



    }
}
