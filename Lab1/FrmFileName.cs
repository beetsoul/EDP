using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Lab1
{
    public partial class FrmFileName : Form
    {
        public static string SetFileName;
        public FrmFileName()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFileName.Text))
            {
                MessageBox.Show("Cannot be empty. Please Try again.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                return;
            }
            else
            {

                MessageBox.Show("Creating file is Completed.", "Create!", MessageBoxButtons.OK);
                SetFileName = txtFileName.Text + ".txt";
                this.Close();

            }
        }

   
    }
}
