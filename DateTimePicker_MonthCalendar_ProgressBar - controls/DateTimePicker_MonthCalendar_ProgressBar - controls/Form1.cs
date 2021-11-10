using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DateTimePicker_MonthCalendar_ProgressBar___controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1_DateTimePicker.Text = dateTimePicker1.Value.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox2_MonthCalendar.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < progressBar1_without_timer.Maximum; i++)
                progressBar1_without_timer.Value = i;

            timer1_for_ProgressBar2.Start();
        }

        private void timer1_for_ProgressBar2_Tick(object sender, EventArgs e)
        {
            progressBar2_with_Timer.Value += 10;
            if (progressBar2_with_Timer.Value == progressBar2_with_Timer.Maximum)
            {
                //timer1_for_ProgressBar2.Stop();
                progressBar2_with_Timer.Value = 0;
            }
        }

        //--------------------------------------------------------------------------------

        private void progressBar1_without_timer_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < 200; i++)
            //progressBar1_without_timer.Value = i;
        }

        private void progressBar2_with_Timer_Click(object sender, EventArgs e)
        {
            //progressBar2_with_Timer.Minimum = 0;
            //progressBar2_with_Timer.Maximum = 100;

            //timer1_for_ProgressBar2.Start();
        }
    }
}
