using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataBase_Code
{
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\a coding\.NET Framework\C# database connection\Database1.accdb");
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            con.Open();
                OleDbCommand cmd = con.CreateCommand();     //connecting cmd object with con object
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into emp values ("+ IdTextbox.Text +" , '"+ NameTextbox.Text +"' , '"+ AddressTextbox.Text +"' , "+ NumberTextbox.Text +") ";
                cmd.ExecuteNonQuery();                      //execute query automatically
            con.Close();

            MessageBox.Show("Record inserted");
            IdTextbox.Text = " ";
            NameTextbox.Text = " ";
            AddressTextbox.Text = " ";
            NumberTextbox.Text = " ";
        }//add button close

        //same as add button code, only insert query is change with delete query
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.
                cmd.CommandText = " delete from emp where id = "+ IdTextbox.Text +" ";    
                cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted");
        }//delete button close

        //same as add button code, only insert query is change with update query
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.
                cmd.CommandText = " update emp set name = '"+ NameTextbox.Text +"' where id = "+ IdTextbox.Text +" ";
                cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record update");
        }

        //this is optional (used to check the changes in form only, instead of going to access for checking the changes)
        private void ViewButton_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.
            cmd.CommandText = " select * from emp ";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable()                      //datatable is a class for storing your data in the form of table
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);    //data adapter is a bridge between dataset and database
            da.Fill(dt);                                        //here we are filling the da connent i.e cmd into dt
            TabledataGridView.DataSource = dt;                  //passing dt content to tabldataegridview control
            
            con.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {            
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.
            cmd.CommandText = " select * from emp where id = "+ IdTextbox.Text +" ";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            TabledataGridView.DataSource = dt;

            con.Close();
        }

        //private void SearchButton_Click(object sender, EventArgs e)
        //{
        //    count = 0;  //this is optional
        //    con.Open();
        //    OleDbCommand cmd = con.CreateCommand();
        //    cmd.CommandType = CommandType.
        //    cmd.CommandText = " select * from emp where id = "+ IdTextbox.Text +" ";
        //    cmd.ExecuteNonQuery();

        //    DataTable dt = new DataTable();
        //    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        //    da.Fill(dt);
        //    count = Convert.ToInt16(dt.Rows.Count.ToString()); // this is optional
        //    TabledataGridView.DataSource = dt;

        //    con.Close();

        //    //this if statement is optional
        //    if (count == 0)
        //    {
        //        MessageBox.Show("Data not found");
        //    }
        //}



    } //form1 class close
}
