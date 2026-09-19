using System;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
       
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            long studentNo;
            long age;
            long contactNo;

            if (string.IsNullOrWhiteSpace(txtBoxStudentNo.Text) ||
                string.IsNullOrWhiteSpace(txtBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxMiddleName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxLastName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxAge.Text) ||
                string.IsNullOrWhiteSpace(txtBoxContactNo.Text) ||
                string.IsNullOrWhiteSpace(txtBoxAddress.Text))
            {
                MessageBox.Show(
                    "Please complete all fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!long.TryParse(txtBoxStudentNo.Text, out studentNo) ||
                studentNo <= 0)
            {
                MessageBox.Show(
                    "Enter a valid student number.",
                    "Invalid Student Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBoxStudentNo.Focus();
                return;
            }

            if (!long.TryParse(txtBoxAge.Text, out age) ||
                age <= 0 ||
                age > 150)
            {
                MessageBox.Show(
                    "Enter a valid age.",
                    "Invalid Age",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBoxAge.Focus();
                return;
            }

            if (!long.TryParse(txtBoxContactNo.Text, out contactNo) ||
                contactNo <= 0)
            {
                MessageBox.Show(
                    "Enter a valid numeric contact number.",
                    "Invalid Contact Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBoxContactNo.Focus();
                return;
            }

            StudentInfoClass.StudentNo = studentNo;
            StudentInfoClass.FirstName = txtBoxFirstName.Text.Trim();
            StudentInfoClass.MiddleName = txtBoxMiddleName.Text.Trim();
            StudentInfoClass.LastName = txtBoxLastName.Text.Trim();
            StudentInfoClass.Age = age;
            StudentInfoClass.ContactNo = contactNo;
            StudentInfoClass.Address = txtBoxAddress.Text.Trim();
            StudentInfoClass.Program = cbProgram.Text;

            using (FrmConfirm confirmForm = new FrmConfirm())
            {
                if (confirmForm.ShowDialog() == DialogResult.OK)
                {
                    ResetControls();
                    
                }
            }
        }


        private void ResetControls()
        {
            txtBoxStudentNo.Clear();
            txtBoxFirstName.Clear();
            txtBoxMiddleName.Clear();
            txtBoxLastName.Clear();
            txtBoxAge.Clear();
            txtBoxContactNo.Clear();
            txtBoxAddress.Clear();
            txtBoxStudentNo.Focus();
        }
    }
}