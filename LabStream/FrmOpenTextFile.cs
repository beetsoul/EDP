namespace LabStream
{
    public partial class FrmOpenTextFile : Form
    {
        public FrmOpenTextFile()
        {
            InitializeComponent();
        }

        private void DisplayToList()
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string filePath = openFileDialog1.FileName;
            lvShowText.Items.Clear();

            try
            {
                using (StreamReader streamReader = File.OpenText(filePath))
                {
                    string lineText;
                    while ((lineText = streamReader.ReadLine()) != null)
                    {
                        lvShowText.Items.Add(lineText);
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Cannot read the file.", "File Error");
            }
        }

        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            DisplayToList();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FrmStream lab1 = new FrmStream();
            lab1.Show(this);
            this.Hide();
        }
    }
}
