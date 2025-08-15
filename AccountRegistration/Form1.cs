using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AccountRegistration.StudentInfoClass;
namespace AccountRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = textBoxFName.Text.ToString();
            StudentInfoClass.LastName = textBoxLName.Text.ToString();
            StudentInfoClass.MiddleName = textBoxMName.Text.ToString();
            StudentInfoClass.Address = TextBoxAddress.Text.ToString();
            StudentInfoClass.Program = comboBoxProgram.Text.ToString();
            StudentInfoClass.Age = Convert.ToInt64(textBoxAge.Text);
            StudentInfoClass.ContactNo = Convert.ToInt64(textBoxContNum.Text); 
            StudentInfoClass.StudentNo = Convert.ToInt64(textBoxStudNum.Text);

            Form2 confirmForm = new Form2();
            DialogResult result = confirmForm.ShowDialog();

            
            if (result == DialogResult.OK)
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox tb)
                        tb.Clear();
                    if (ctrl is ComboBox cb)
                        cb.SelectedIndex = -1;
                    
                }
            }

        }
    }
}
