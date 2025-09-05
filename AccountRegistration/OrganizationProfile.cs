using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using static AccountRegistration.StudentInformationClass;
namespace AccountRegistration
{
    public partial class OrganizationProfile : Form
    {
        string connectionString = "Server=DESKTOP-PBNME4\\SQLEXPRESS;Database=RegistrationDB;Trusted_Connection=True;";

        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;

        public OrganizationProfile()
        {
            InitializeComponent();
        }

        private void OrganizationProfile_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]{
                   "BS Information Technology",
                   "BS Computer Science",
                   "BS Information Systems",
                   "BS in Accountancy",
                   "BS in Hospitality Management",
                   "BS in Tourism Management"
                    };
            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }
        }

        public long StudentNumber(string studNum)
        {
            _StudentNo = long.Parse(studNum);
            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            try
            {
                if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
                {
                    _ContactNo = long.Parse(Contact);
                }
                else
                {
                    throw new FormatException("Contact number must be 10 or 11 digits.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Contact Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Contact number is too large.", "Overflow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Reset or redirect to registration form
            }

            return _ContactNo;
        }


        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            try
            {
                if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") &&
                    Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") &&
                    Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
                {
                    _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
                }
                else
                {
                    throw new ArgumentNullException("Name fields must contain only letters.");
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Name input is incomplete.", "Index Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Reset or redirect to registration form
            }

            return _FullName;
        }

        public int Age(string age)
        {
            try
            {
                if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
                {
                    _Age = Int32.Parse(age);
                }
                else
                {
                    throw new FormatException("Age must be a number between 1 and 999.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Age Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Age value is too large.", "Overflow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Reset or redirect to registration form
            }

            return _Age;
        }

        private void btnRegister_Click(object sender, EventArgs e) { 
            StudentInformationClass.SetFullName = FullName(textBoxLName.Text, textBoxFName.Text, textBoxMName.Text); 
            StudentInformationClass.SetStudentNo = StudentNumber(textBoxStudNum.Text); 
            StudentInformationClass.SetProgram = cbPrograms.Text; 
            StudentInformationClass.SetGender = cbGender.Text; 
            StudentInformationClass.SetContactNo = ContactNo(textBoxContNum.Text);
            StudentInformationClass.SetAge = Age(textBoxAge.Text); 
            StudentInformationClass.SetBirthDay = datePickerBirthday.Value.ToString("yyyy-MM-dd"); Form2 frm = new Form2(); frm.ShowDialog(); }


    }
}
