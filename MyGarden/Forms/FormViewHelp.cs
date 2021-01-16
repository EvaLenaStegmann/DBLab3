using System;
using System.IO;
using System.Windows.Forms;

namespace MyGarden
{
    public partial class FormViewHelp : Form
    {
        public FormViewHelp()
        {
            InitializeComponent();
        }

        private void FormViewHelp_Load(object sender, EventArgs e)
        {
            string appPath = Directory.GetCurrentDirectory();
            string filename = Path.Combine(Path.GetDirectoryName(appPath), "Help.txt");
            filename = Path.Combine(Directory.GetCurrentDirectory(), "Help.txt");
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    textBoxHelpText.AppendText(line + Environment.NewLine);
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
