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
    public partial class Form1 : Form
    { 
        //private AllTasks tasks = new AllTasks();
        //public static List<Task> tasklist;

        public static AllTasks tasks;
        public static AllTasks waznepilnetask;
        public static AllTasks wazneniepilnetask;
        public static AllTasks niewaznepilnetask;
        public static AllTasks niewazneniepilnetask;
        TakerExecuter taker = new TakerExecuter();
        
        //Task Task1 = new Task("xd", 2020, 2, 1);
        ///Task Task2 = new Task("xd1", 2020, 3, 2);
        ///Task Task3 = new Task("xd2",  2020,4, 1);


        public Form1()
        {
            //tasklist = new List<Task>();
            //this.tasks = tasks;
            tasks = new AllTasks();
            waznepilnetask = new AllTasks();
            wazneniepilnetask = new AllTasks();
            niewaznepilnetask = new AllTasks();
            niewazneniepilnetask = new AllTasks();
           // tasks.TasksAddtoAll(Task1);
            //tasks.TasksAddtoAll(Task2);
          //  tasks.TasksAddtoAll(Task3);

            InitializeComponent();

            wazne.Text = "WAŻNE";
            pilne.Text = "PILNE";
            niepilne.Text = "NIEPILNE";
            niewazne.Text = "NIEWAŻNE";
            

            //this.listBox1.Items.Add(Task1.task_name);
            //this.listBox1.Items.Add(Task2.task_name);
            //this.listBox1.Items.Add(Task3.task_name);
            

        }


        private void wazne_Click(object sender, EventArgs e)
        {

        }

        private void pilne_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();


        }
        private void Form1_Enter(object sender, EventArgs e)
        {
            wazne.Text = "bardzo wazne";
            //tasks = form2.Tasks;
        }

        

        private void waznepilne_SelectedIndexChanged(object sender, EventArgs e)
        {
            //JAK SIE NA JAKIES KLIKNIE WYSWIETLI ILE DNI ZOSTAŁO UŻYWAJĄC COMMAND I TAKEREXECUTER
            Task tasktemp;
            
            if (this.waznepilne.SelectedItems.Count > 0) {
                string nametask = this.waznepilne.SelectedItems[0].ToString();


                tasktemp = waznepilnetask.TaskFind(nametask);




            Command Command = new Command_Add_ImpNow(tasktemp);
            //TakerExecuter taker = new TakerExecuter();
            taker.TakeCommands(Command);
            taker.PlaceCommands();
            //MessageBox.Show(taker.temp);
            MessageBox.Show(taker.commandstring[0]);
            taker.ClearString();
            //mozna rozpbudować o multiple zaznaczanie, wtedy barziej widać działanie command
        }
            //this.waznepilne.ClearSelected();

        }

        private void niepilnewazne_SelectedIndexChanged(object sender, EventArgs e)
        {

            Task tasktemp;
            if (this.niepilnewazne.SelectedItems.Count > 0)
            {
                string nametask = this.niepilnewazne.SelectedItems[0].ToString();
                tasktemp = wazneniepilnetask.TaskFind(nametask);
                //MessageBox.Show(tasktemp.task_name);
                Command Command = new Command_Add_ImpLater(tasktemp);
               // TakerExecuter taker = new TakerExecuter();
                taker.TakeCommands(Command);
                taker.PlaceCommands();
                //MessageBox.Show(taker.temp);
                MessageBox.Show(taker.commandstring[0]);
                taker.ClearString();
            }
           // this.niepilnewazne.ClearSelected();
        }

        private void b_wp_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex >= 0)
            {
                Task tasktemp;
                this.waznepilne.Items.Add(listBox1.SelectedItems[0].ToString());
                tasktemp = tasks.TaskFind(listBox1.SelectedItems[0].ToString());
                waznepilnetask.TasksAddtoAll(tasktemp);
                tasks.TaskDelete(tasktemp);
                this.listBox1.Items.Remove(listBox1.SelectedItems[0]);

                // 
                //MessageBox.Show(tasks.TaskCount().ToString());

                //
                //tasks.TaskDelete();
            }
            else
                MessageBox.Show("Nie wybrałeś zadania. Zrob to ponwnie ", "Wybranie zadania",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void b_w_np_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex >= 0)
            {
                Task tasktemp;
                this.niepilnewazne.Items.Add(listBox1.SelectedItems[0].ToString());
                tasktemp = tasks.TaskFind(listBox1.SelectedItems[0].ToString());
                wazneniepilnetask.TasksAddtoAll(tasktemp);
                tasks.TaskDelete(tasktemp);
                this.listBox1.Items.Remove(listBox1.SelectedItems[0]);
                

                //tasks.TaskDelete();
            }
            else
                MessageBox.Show("Nie wybrałeś zadania. Zrob to ponwnie ", "Wybranie zadania",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
   


    private void b_nw_p_Click(object sender, EventArgs e)
        {
        if (this.listBox1.SelectedIndex >= 0)
        {
                Task tasktemp;
                this.niewaznepilne.Items.Add(listBox1.SelectedItems[0].ToString());
                tasktemp = tasks.TaskFind(listBox1.SelectedItems[0].ToString());
                niewaznepilnetask.TasksAddtoAll(tasktemp);
                tasks.TaskDelete(tasktemp);
                this.listBox1.Items.Remove(listBox1.SelectedItems[0]);
                
                //tasks.TaskDelete();
            }
        else
            MessageBox.Show("Nie wybrałeś zadania. Zrob to ponwnie ", "Wybranie zadania",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

        private void b_nw_np_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex >= 0)
            {
                Task tasktemp;
                this.niepilneniewazne.Items.Add(listBox1.SelectedItems[0].ToString());
                tasktemp = tasks.TaskFind(listBox1.SelectedItems[0].ToString());
                niewazneniepilnetask.TasksAddtoAll(tasktemp);
                tasks.TaskDelete(tasktemp);
                this.listBox1.Items.Remove(listBox1.SelectedItems[0]);
                
                //tasks.TaskDelete();
            }
            else
                MessageBox.Show("Nie wybrałeś zadania. Zrob to ponwnie ", "Wybranie zadania",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void niewaznepilne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.niewaznepilne.SelectedItems.Count > 0)
            {
                Task tasktemp;
                string nametask = this.niewaznepilne.SelectedItems[0].ToString();
                tasktemp = niewaznepilnetask.TaskFind(nametask);

                Command Command = new Command_Add_NimpNow(tasktemp);
                
                taker.TakeCommands(Command);
                taker.PlaceCommands();
                //MessageBox.Show(taker.temp);
                MessageBox.Show(taker.commandstring[0]);
                taker.ClearString();
                //int index = this.waznepilne.SelectedIndex;
                //
            }

           // this.niewaznepilne.ClearSelected();
        }

        private void niepilneniewazne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.niepilneniewazne.SelectedItems.Count > 0)
            {
                Task tasktemp;
                string nametask = this.niepilneniewazne.SelectedItems[0].ToString();
                tasktemp = niewazneniepilnetask.TaskFind(nametask);

                Command Command = new Command_Add_NimpLater(tasktemp);
               // TakerExecuter taker = new TakerExecuter();
                taker.TakeCommands(Command);
                taker.PlaceCommands();
                //MessageBox.Show(taker.temp);
                MessageBox.Show(taker.commandstring[0]);
                taker.ClearString();
            }
           // this.niepilneniewazne.ClearSelected();
        }

        private void b_main_Click(object sender, EventArgs e)
        {
            if(this.waznepilne.SelectedItems.Count > 0)
            {

                
                Task tasktemp;
                tasktemp = waznepilnetask.TaskFind(waznepilne.SelectedItem.ToString());
                
                //dodawanie
                tasks.TasksAddtoAll(tasktemp);
                //dodawanie wizualne
                this.listBox1.Items.Add(waznepilne.SelectedItem);

                //usuwanie wizualne
                waznepilne.Items.Remove(waznepilne.SelectedItem);
                //usuwanie z waznepilne z listy
                waznepilnetask.TaskDelete(tasktemp);


            }

            if (this.niepilnewazne.SelectedItems.Count > 0)
            {


                Task tasktemp;
                tasktemp = wazneniepilnetask.TaskFind(niepilnewazne.SelectedItem.ToString());

                //dodawanie
                tasks.TasksAddtoAll(tasktemp);
                //dodawanie wizualne
                this.listBox1.Items.Add(niepilnewazne.SelectedItem);

                //usuwanie wizualne
                niepilnewazne.Items.Remove(niepilnewazne.SelectedItem);
                //usuwanie z waznepilne z listy
                wazneniepilnetask.TaskDelete(tasktemp);


            }

            if (this.niepilneniewazne.SelectedItems.Count > 0)
            {


                Task tasktemp;
                tasktemp = niewazneniepilnetask.TaskFind(niepilneniewazne.SelectedItem.ToString());

                //dodawanie
                tasks.TasksAddtoAll(tasktemp);
                //dodawanie wizualne
                this.listBox1.Items.Add(niepilneniewazne.SelectedItem);

                //usuwanie wizualne
                niepilneniewazne.Items.Remove(niepilneniewazne.SelectedItem);
                //usuwanie z waznepilne z listy
                niewazneniepilnetask.TaskDelete(tasktemp);


            }
            if (this.niewaznepilne.SelectedItems.Count > 0)
            {


                Task tasktemp;
                tasktemp = niewaznepilnetask.TaskFind(niewaznepilne.SelectedItem.ToString());

                //dodawanie
                tasks.TasksAddtoAll(tasktemp);
                //dodawanie wizualne
                this.listBox1.Items.Add(niewaznepilne.SelectedItem);

                //usuwanie wizualne
                niewaznepilne.Items.Remove(niewaznepilne.SelectedItem);
                //usuwanie z waznepilne z listy
                niewaznepilnetask.TaskDelete(tasktemp);


            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void niepilne_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel exc = new Excel("test.xlsx");

        }
    }
    }

