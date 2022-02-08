using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5._1
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEmployee obj = new FormEmployee();
            this.Hide();
            //this.Visible = false;
            obj.Show();

        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            FormCalculator obj = new FormCalculator();
            this.Hide();
            obj.Show();
        }
    }
}
