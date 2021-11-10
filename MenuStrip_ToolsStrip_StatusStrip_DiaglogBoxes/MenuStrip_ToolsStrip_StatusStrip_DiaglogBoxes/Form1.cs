using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MenuStrip_ToolsStrip_StatusStrip_DiaglogBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();

            of.ShowDialog();
            //set default dialog box title
            of.Title = "Select file to open";//"Select only .txt file";
            of.Filter = "Text files |*.txt|All files|*.*";

            if (of.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(of.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();

            //sf.FileName = "unknown.txt";
            sf.Filter = "Text file (*.txt) | *.txt | All files (*.*) | *.* ";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                using(StreamWriter sw = new StreamWriter(sf.FileName))
                sw.WriteLine(richTextBox1.Text);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "") //if condition is optional
                richTextBox1.Cut();
            else
                MessageBox.Show("plzz select text");
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)   //if condition is optional
                richTextBox1.Copy();
            else
                MessageBox.Show("plzz select text");
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void fontFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            richTextBox1.Font = fd.Font;
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            richTextBox1.ForeColor = cd.Color;
        }

    }
}
