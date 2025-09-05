using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AccountRegistration
{
    public partial class Form2 : Form
    {                  
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
       
        public Form2()
        {
            InitializeComponent();

        }
        private void Form2_Load(object sender, EventArgs e)
        {

            lblStudentNo.Text = StudentInformationClass.SetStudentNo.ToString();
            lblName.Text = StudentInformationClass.SetFullName;
            lblProgram.Text = StudentInformationClass.SetProgram;
            lblBirthday.Text = StudentInformationClass.SetBirthDay;
            lblGender.Text = StudentInformationClass.SetGender;
            lblContactNo.Text = StudentInformationClass.SetContactNo.ToString();
            lblAge.Text = StudentInformationClass.SetAge.ToString();

        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
         
            string connectionString = "Server=DESKTOP-PB8NME4\\SQLEXPRESS;Database=RegistrationDB;Trusted_Connection=True;";

          
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO StudentInformation 
                         (StudentNo, FullName, Program, BirthDay, Gender, ContactNo, Age) 
                         VALUES 
                         (@StudentNo, @FullName, @Program, @BirthDay, @Gender, @ContactNo, @Age)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentNo", StudentInformationClass.SetStudentNo);
                cmd.Parameters.AddWithValue("@FullName", StudentInformationClass.SetFullName);
                cmd.Parameters.AddWithValue("@Program", StudentInformationClass.SetProgram);
                cmd.Parameters.AddWithValue("@BirthDay", StudentInformationClass.SetBirthDay);
                cmd.Parameters.AddWithValue("@Gender", StudentInformationClass.SetGender);
                cmd.Parameters.AddWithValue("@ContactNo", StudentInformationClass.SetContactNo);
                cmd.Parameters.AddWithValue("@Age", StudentInformationClass.SetAge);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
