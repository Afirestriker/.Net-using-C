using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication_Basic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            int n1, n2;

            n1 = Convert.ToInt16(TextBoxNum1.Text);
            n2 = Convert.ToInt16(textBoxNum2.Text);

           textBox_NumRes.Text = (n1+n2).ToString();
        }

        private void button1_DisplayMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is program 1");
        }


    } //public partial class Form1 : Form end
}
