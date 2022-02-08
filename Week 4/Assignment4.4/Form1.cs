using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4._4
{
    public partial class Form1 : Form
    {
        List<Coffee> coffeeList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            coffeeList = new List<Coffee>();
            //coffeeGrid.DataSource = coffeeList;
        }

        
    }
}
