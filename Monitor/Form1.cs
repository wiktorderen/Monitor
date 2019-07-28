using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Monitor
{
       
    public partial class Form1 : Form
    {
        PerformanceCounter perfCPUCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter perfSystemCounter = new PerformanceCounter("System", "System Up Time");
        PerformanceCounter perfGPUCounter = new PerformanceCounter("GPU Engine", "Utilization Percentage", "SUM(pid_*_luid_0x00000000_0x000095CA_phys_*_eng_*_engtype_VideoEncode)");
        PerformanceCounter perfNetworkD = new PerformanceCounter("Karta sieciowa", "Bajty odebrane/s", "Intel[R] Dual Band Wireless-AC 3165");
        PerformanceCounter perfNetworkU = new PerformanceCounter("Karta sieciowa", "Bajty wysłane/s", "Intel[R] Dual Band Wireless-AC 3165");

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float time = perfSystemCounter.NextValue();

            int c = (int)perfCPUCounter.NextValue();

           float nD = perfNetworkD.NextValue();
            float nU = perfNetworkU.NextValue();

            //int g = (int)perfGPUCounter.NextValue();

            int threshold;
            threshold = Convert.ToInt32(comboBox1.SelectedItem);

            int Gthreshold;
            Gthreshold = Convert.ToInt32(comboBox2.SelectedItem);
            
            label1.Text = "CPU:" + "                        " + c + "  " + "%";
            label2.Text = "System Up Time:" + "      " + change(time);
            //label3.Text = "Author:    Wiktor Dereń";
            //label5.Text = "GPU:" + "            " + g + "  " + "%";
            label7.Text = "Network activity" + '\n'  +"Download:"+"              " +nD+"  mb/s"+ "    " + "    " +"Upload:"+ "   "  +       nU+"  mb/s";



            if (c > threshold)
                Console.Beep(5000, 500);

            /*if (g > Gthreshold)
                Console.Beep(1000, 250);*/
        }
        private string change(float time)
        {
            if (time < 60)
                return Math.Floor(time) + " sec";

            else //if (60 < time && time < 3600)
                return Math.Floor(time / 60) + " min " + Math.Floor((time/60-Math.Floor(time/60))*60) + " sec";
            
        }
       /* private string change1(float nD, float nU)
        {
            if(nD>8)
            {

            }
        }*/
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
