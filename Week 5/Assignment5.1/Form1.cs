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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }
        DateTime dob;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Employee emp = new Employee();
            
            if (dateTimePicker1.Value.Year > 2004)
            {
                MessageBox.Show("Employee should be at least 18");
            }
            else
            {
                dob = dateTimePicker1.Value;
            }
            
            textEmpAge.Text = (DateTime.Now.Year-dob.Year).ToString();
            //textEmpAge.Text = emp.Age.ToString();
            textEmpAge.ReadOnly = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textFName.Text.Length > 15)
            {
                MessageBox.Show("Input cannot exceed 15 characters");
            }
            
        }

        private void textLName_TextChanged(object sender, EventArgs e)
        {
            if (textLName.Text.Length > 15)
            {
                MessageBox.Show("Input cannot exceed 15 characters");
            }
            
        }

        private void labelDept_Click(object sender, EventArgs e)
        {

        }
        Dictionary<int, Employee> empDictionary;

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            comboDept.DataSource=Enum.GetValues(typeof(Department));

            groupAddEmp.Visible = false;
            dataGridEmp.Visible = false;
            buttonDeleteEmp.Visible = false;
            
            empDictionary = new Dictionary<int, Employee>();
        }
        private void RefreshData()
        {
            //textID.Clear();
            dateTimePicker1.Refresh();
            textFName.Clear();
            textLName.Clear();
            dataGridEmp.DataSource = null;
            dataGridEmp.DataSource=empDictionary.Values.ToList();
        }

        private void buttonAddEmp_Click(object sender, EventArgs e)
        {
            groupAddEmp.Visible=true;
        }
        Random random = new Random();
        private void buttonSubmitEmp_Click(object sender, EventArgs e)
        {
            if ( textFName.Text != string.Empty && textLName.Text != string.Empty)
            {
                
                Employee newemp = new Employee();
                newemp.EmpID = random.Next(1, 999999);
                //newemp.EmpID = Int32.Parse(textID.Text);
                newemp.dob = dob;
                newemp.Age = DateTime.Now.Year - newemp.dob.Year;
                newemp.FirstName = textFName.Text;
                newemp.LastName = textLName.Text;
                newemp.Dept = (Department)comboDept.SelectedIndex;

                empDictionary.Add(newemp.EmpID,newemp);
                MessageBox.Show($"{textFName.Text} {textLName.Text} has been added to the employee database!");

                dataGridEmp.Visible = true;
                buttonDeleteEmp.Visible = true;
                
            }
            else
            {
                MessageBox.Show("Please fill enter all values properly");
            }
            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{dataGridEmp.CurrentRow.Cells[2].Value} {dataGridEmp.CurrentRow.Cells[3].Value} has been removed from the database!");
            empDictionary.Remove((int)dataGridEmp.CurrentRow.Cells[4].Value);
            //empDictionary.Remove(Convert.ToInt32(dataGridEmp.CurrentRow.Cells[4].Value));
            RefreshData();
            if (empDictionary.Count == 0)
            {
                dataGridEmp.Visible = false;
                buttonDeleteEmp.Visible = false;
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormMenu obj = new FormMenu();
            obj.Show();
        }
    }
}
