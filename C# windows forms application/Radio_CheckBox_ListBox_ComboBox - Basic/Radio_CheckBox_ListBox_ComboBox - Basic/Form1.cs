using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Radio_CheckBox_ListBox_ComboBox___Basic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton_RED_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void radioButton_PURPLE_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }

        private void radioButton_YELLOW_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void button_SUBMIT_Click(object sender, EventArgs e)
        {
            string msg = "";

            if (checkBox_NUM1.Checked)
                msg = msg + "NUM1  ";
            
            if (checkBox_NUM2.Checked)
                msg = msg + "NUM2  ";
            
            if (checkBox_NUM3.Checked)
                msg = msg + "NUM3  ";

            if (msg.Length > 0)
                MessageBox.Show(msg = msg + "Selected");
            else
                MessageBox.Show(msg = "No checkBox selected");

        }


        private void comboBox1_INPUT_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2_OUTPUT.Items.Clear();
            listBox1_OUTPUT.Items.Clear();
            
            if (comboBox1_INPUT.SelectedItem == "Numbers")
            {
                comboBox2_OUTPUT.Items.Add("1");
                comboBox2_OUTPUT.Items.Add("2");

                listBox1_OUTPUT.Items.Add("3");
                listBox1_OUTPUT.Items.Add("4");
            }
            else if (comboBox1_INPUT.SelectedItem == "Letters")
            {
                comboBox2_OUTPUT.Items.Add("A");
                comboBox2_OUTPUT.Items.Add("B");

                listBox1_OUTPUT.Items.Add("C");
                listBox1_OUTPUT.Items.Add("D");
            }
        }
    }
}
