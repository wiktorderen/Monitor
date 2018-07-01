﻿using System;
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
            float time = perfSystemCounter.NextValue();

            int percent = (int)perfCPUCounter.NextValue();

            int threshold;
            threshold = Convert.ToInt32(comboBox1.SelectedItem); 
            
            label1.Text = "CPU:" + "                        " + percent + "  " + "%";
            label2.Text = "System Up Time:" + "      " + change(time);
            label3.Text = "Author:    Wiktor Dereń";
            

            if (percent > threshold)
                Console.Beep(5000, 500);
        }
        private string change(float time)
        {
            if (time < 60)
                return Math.Floor(time) + " sec";

            else //if (60 < time && time < 3600)
                return Math.Floor(time / 60) + " min " + Math.Floor((time/60-Math.Floor(time/60))*60) + " sec";
            
        }
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
    }
}//zmiana
