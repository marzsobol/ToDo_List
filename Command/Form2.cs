using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command
{
    public partial class Form2 : Form
    {
        static Form1 form1 = new Form1();
        public int a;
        DateTime datetask = DateTime.Now;
        //private AllTasks tasks = new AllTasks();

        // internal AllTasks Tasks { get => tasks; set => tasks = value; }

        public static AllTasks tasks;
       // private List<Task> tasklist = new List<Task>();
        public Form2( )
        {
            InitializeComponent();
            this.label2.Text = "Przewidywany termin\n zakończenia zadania:";
        }
        public Form2(AllTasks tasks_)
        {
            tasks_ = tasks;
            InitializeComponent();
            this.label2.Text = "Przewidywany termin\n zakończenia zadania:";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }
        private void monthCalendar1_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            // Show the start and end dates in the text box.
            this.label3.Text = e.Start.ToShortDateString();
            datetask = e.Start;
        }



        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {

            string nametask = this.textBox1.Text;
            if (nametask == "")
            {
                var result = MessageBox.Show("Nie wpisałeś nazwy tasku. Zrób to jeszcze raz.",
                    "Nazwa tasku", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

            else if (label3.Text == "")
            {
                var result = MessageBox.Show("Nie zaznaczyłeś daty w kalendarzu. Zrób to jeszcze raz.",
                    "Nazwa tasku", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
            Task task = new Task(nametask, datetask.Year, datetask.Month, datetask.Day);
            Form1.tasks.TasksAddtoAll(task);
            form1.listBox1.Items.Add(task.task_name);
            this.Hide();

            form1.Show();

        }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
