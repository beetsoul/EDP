using System;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;

        private DelegateNumber DelAge, DelContactNo, DelStudentNo;


        public FrmConfirm()
        {
            InitializeComponent();

            DelProgram = new DelegateText(StudentInfoClass.GetProgram);

            DelLastName = new DelegateText(StudentInfoClass.GetLastName);

            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);

            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);

            DelAddress = new DelegateText(StudentInfoClass.GetAddress);

            DelAge = new DelegateNumber(StudentInfoClass.GetAge);

            DelContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);

            DelStudentNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
        }



        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_Load_1(object sender, EventArgs e)
        {

            lblStudentNo.Text = DelStudentNo(StudentInfoClass.StudentNo).ToString();

            lblProgram.Text = DelProgram(StudentInfoClass.Program);

            lblLastName.Text = DelLastName(StudentInfoClass.LastName);

            lblFirstName.Text = DelFirstName(StudentInfoClass.FirstName);

            lblMiddleName.Text = DelMiddleName(StudentInfoClass.MiddleName);

            lblAge.Text = DelAge(StudentInfoClass.Age).ToString();

            lblContactNo.Text = DelContactNo(StudentInfoClass.ContactNo).ToString();

            lblAddress.Text = DelAddress(StudentInfoClass.Address);
        }
    }
}


