using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataBase_Wizard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void empBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.emp' table. You can move, or remove it, as needed.
            this.empTableAdapter.Fill(this.database1DataSet.emp);

        }
    }
}
