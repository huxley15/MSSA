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
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }
        double num1;
        double num2;
        double result;
        Calculator newcalculator = new Calculator();

        private void FormCalculator_Load(object sender, EventArgs e)
        {

        }
        private void RefreshData()
        {
            textNum1.Clear();
            textNum2.Clear();
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textNum1.Text);
            num2 = double.Parse(textNum2.Text);
            result = newcalculator.Add(num1, num2);
            MessageBox.Show($"The sum of {num1} and {num2} is {result}");
            RefreshData();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textNum1.Text);
            num2 = double.Parse(textNum2.Text);
            result = newcalculator.Subtract(num1, num2);
            MessageBox.Show($"The difference of {num1} - {num2} is {result}");
            RefreshData();
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textNum1.Text);
            num2 = double.Parse(textNum2.Text);
            result = newcalculator.Multiply(num1, num2);
            MessageBox.Show($"The product of {num1} and {num2} is {result}");
            RefreshData();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textNum1.Text);
            num2 = double.Parse(textNum2.Text);
            if (num2 == 0)
            {
                MessageBox.Show("Second number cannot be zero! You shall not break the rules of math and divide by zero! Please enter a non-zero number for your second number :)");
                RefreshData();
            }
            else
            {
                num1 = double.Parse(textNum1.Text);
                num2 = double.Parse(textNum2.Text);
                result = newcalculator.Divide(num1, num2);
                MessageBox.Show($"The result of dividing {num1} by {num2} is {result}");
                RefreshData();
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormMenu obj = new FormMenu();
            obj.Show();
        }

        private void textNum1_Leave(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textNum1.Text, "[^0-9.,]"))
            {
                textNum1.BackColor = Color.Red;
                textNum1.Focus();
                MessageBox.Show("Please enter only numbers.");
                textNum1.Clear();
            }
            else
            {
                textNum1.BackColor = Color.White;
            }
        }

        private void textNum2_Leave(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textNum2.Text, "[^0-9.,]"))
            {
                textNum2.BackColor = Color.Red;
                textNum2.Focus();
                MessageBox.Show("Please enter only numbers.");
                textNum2.Clear();
            }
            else
            {
                textNum2.BackColor = Color.White;
            }
        }
    }
}
