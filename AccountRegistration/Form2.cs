using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class Form2 : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName,
                            DelAddress;

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;
        public Form2()
        {
            InitializeComponent();

            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);

            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblform2Program.Text = DelProgram(StudentInfoClass.Program);
            lblform2LName.Text = DelLastName(StudentInfoClass.LastName);
            lblform2FName.Text = DelFirstName(StudentInfoClass.FirstName);
            lblform2MName.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lblform2Address.Text = DelAddress(StudentInfoClass.Address);

            lblform2Age.Text = DelNumAge(StudentInfoClass.Age).ToString();
            lblform2ContactNum.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            lblform2StudNum.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
