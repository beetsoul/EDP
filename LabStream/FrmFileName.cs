using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
namespace LabStream
{
    public partial class FrmFileName : Form
    {
        public static string SetFileName;
        private FrmLabStream _parentForm;
        public FrmFileName(FrmLabStream parent)

        {
            InitializeComponent();
            _parentForm = parent;
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFileName.Text))
                    throw new FormatException("File Name must not be empty and can only contain letters and spaces.");
                SetFileName = txtFileName.Text + ".txt";
                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            SetFileName = null;
            this.Close();
        }
    }
}
