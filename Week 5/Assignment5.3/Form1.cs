using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5._3
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonBinary_Click(object sender, EventArgs e)
        {
            FormPuppy f1 = new FormPuppy();
            this.Hide();
            f1.Show();
        }

        private void buttonXML_Click(object sender, EventArgs e)
        {
            FormXML f2 = new FormXML();
            this.Hide();
            f2.Show();
        }

        private void buttonJSON_Click(object sender, EventArgs e)
        {
            FormJSON f3 = new FormJSON();
            this.Hide();
            f3.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
