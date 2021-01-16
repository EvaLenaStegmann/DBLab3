using System;
using System.Windows.Forms;

namespace MyGarden
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
