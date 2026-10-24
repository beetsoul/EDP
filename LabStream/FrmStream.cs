namespace LabStream
{
    public partial class FrmStream : Form
    {
        public FrmStream()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            try
            {
                FrmFileName frmName = new FrmFileName();
                frmName.ShowDialog();

                string getInput = txtInput.Text;
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
                {
                    outputFile.WriteLine(getInput);
                    Console.WriteLine(getInput);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegisteration_Click(object sender, EventArgs e)
        {
            FrmRegistration frmRegistration = new FrmRegistration();
            frmRegistration.Show(this);
            this.Hide();
        }

        private void BtnOpenTextFile_Click(object sender, EventArgs e)
        {
            FrmOpenTextFile frm = new FrmOpenTextFile();
            frm.Show(this);
            this.Hide();
        }
    }
}

