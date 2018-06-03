using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Monitor
{
       
    public partial class Form1 : Form
    {

        PerformanceCounter perfCPUCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter perfSystemCounter = new PerformanceCounter("System", "System Up Time");


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Podaj wartosc zuzycia procesora: ");
            Console.ReadLine();

            label1.Text = "CPU:" + "        " + (int)perfCPUCounter.NextValue() + "  " + "%";
            label2.Text = "System Up Time:" + "       " + (int)perfSystemCounter.NextValue() + " secounds";
            if ((int)perfCPUCounter.NextValue()>)
                Console.Beep(5000, 500);

        }
        
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        } 

    }
}
