using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ADO.NET
            con.ConnectionString = ConnectionManagement.ConnectionStrings;
            command.Connection = con;
            command.CommandText = "GetAllStudent";
            command.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand = command;
            adapter.Fill(ds);
            bindingSource1.DataSource = ds.Tables[0];
            table.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;


        }

        private void LoadData()
        {
            txtFirstName.DataBindings.Add("Text", bindingSource1, "FirstName");
        }



        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            //ds.Table[0].DefaultView = select * form student
            //RowFilter
            ds.Tables[0].DefaultView.RowFilter = $"FirstName like '%{toolStripTextBox1.Text}'.";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                TextBox1.Text table.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command.CommandText = "UpdateStudent";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("FirstName", txtFirstName.Text);
            command.Parameters.AddWithValue("LastName", txtLastName.Text);
            command.Parameters.AddWithValue("Gender", txtGender.Checked);
            command.Parameters.AddWithValue("Dob", dateTimePicker1.Value);
            command.Parameters.AddWithValue("Id", txtId.Text);
            con.Open();

            try
            {
                command.ExceuteNonQuery();
                MessageBox.Show("Success","info");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "error");
            }
            finally
            {
                con.Clone();
                command.Parameters.Clear();

                txtId.DataBindings.Clear();
                txtFirstName.DataBindings.Clear();
                txtLastName.DataBindings.Clear();
                dateTimePicker1.DataBindings.Clear();
                txtId.DataBindings.Clear();

                LoadData();

            }
        }

        private void btnUpdateAdapter_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();
            SqlCommandBuilder builder= new SqlCommandBuilder(adapter);
            builder.GetUpdateCommand();
            try
            {
                adapter.Update(ds.table[0]);
                MessageBox.Show("Success", "info");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "error");
            }
        }
    }
}
