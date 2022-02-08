using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4._4._2
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
            drinkGrid.DataSource = null;
            comboType.DataSource=Enum.GetValues(typeof(CoffeeTypes));
            comboSize.DataSource=Enum.GetValues(typeof(DrinkSize));
            comboTemp.DataSource=Enum.GetValues(typeof(PreferredTemp));
            grpCoff.Visible = false;
        }
        private void RefreshData()
        {
            txtName.Clear();
            drinkGrid.DataSource = null;
            drinkGrid.DataSource=coffeeList.ToList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            grpCoff.Visible = true;
            if (txtName.Text != string.Empty)
            {
                Coffee newcoffee = new Coffee();
                newcoffee.Name = txtName.Text;
                newcoffee.Type = (CoffeeTypes)comboType.SelectedIndex;
                newcoffee.Size=(DrinkSize)comboSize.SelectedIndex;
                newcoffee.Temp=(PreferredTemp)comboTemp.SelectedIndex;
                if (newcoffee.Size == DrinkSize.Small)
                {
                    newcoffee.Price = 3.00m;
                }
                else if (newcoffee.Size == DrinkSize.Medium)
                {
                    newcoffee.Price = 4.00m;
                }
                else if (newcoffee.Size == DrinkSize.Large)
                {
                    newcoffee.Price = 5.00m;
                }
                coffeeList.Add(newcoffee);
            }
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            coffeeList.RemoveAt(drinkGrid.CurrentRow.Index);
            RefreshData();
        }
    }
}
