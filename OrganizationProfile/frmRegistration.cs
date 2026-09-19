using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OrganizationProfile
{
    public partial class frmRegistration : Form
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo, _StudentNo;

        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[] {
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
            if (Regex.IsMatch(studNum, @"^[0-9]{1,18}$"))
            {
                _StudentNo = long.Parse(studNum);
            }
            else
            {
                throw new OverflowException("Student number should be numbers only.");
            }
            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }
            else
            {
                throw new FormatException("Contact number must be 10-11 digits and numbers only.");
            }
            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+(\s[a-zA-Z]+)*$") &&
                Regex.IsMatch(FirstName, @"^[a-zA-Z]+(\s[a-zA-Z]+)*$") &&
                Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + " " + MiddleInitial+ ".";
            }
            else
            {
                throw new ArgumentNullException("Name", "Please enter a valid last name and first name.");
            }
            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }
            else
            {
                throw new IndexOutOfRangeException("Age must be a valid number.");
            }
            return _Age;
        }

        public string Gender(string gender)
        {
            if (!string.IsNullOrWhiteSpace(gender))
            {
                return gender;
            }
            else
            {
                throw new ArgumentNullException("Gender", "Please select a gender first.");
            }
        }

        public string Program(string program)
        {
            if (!string.IsNullOrWhiteSpace(program))
            {
                return program;
            }
            else
            {
                throw new ArgumentNullException("Program", "Please select a program first.");
            }
        }

        private void ResetFields()
        {
            txtStudentNo.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleInitial.Clear();
            txtAge.Clear();
            txtContactNo.Clear();
            cbPrograms.SelectedIndex = -1;
            cbGender.SelectedIndex = -1;
            datePickerBirthday.Value = DateTime.Now;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            try
            {
                StudentInformationClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
                StudentInformationClass.SetStudentNo = StudentNumber(txtStudentNo.Text);
                StudentInformationClass.SetProgram = Program(cbPrograms.Text);
                StudentInformationClass.SetGender = Gender(cbGender.Text);
                StudentInformationClass.SetContactNo = ContactNo(txtContactNo.Text);
                StudentInformationClass.SetAge = Age(txtAge.Text);
                StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");

                frmConfirm frm = new frmConfirm();
                frm.ShowDialog();

                ResetFields(); 
            }
         
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Contact Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Student Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Console.WriteLine("Validation attempt finished at " + DateTime.Now);
            }
        }
    }
}