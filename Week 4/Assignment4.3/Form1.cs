using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Assignment4._3
{
    public partial class Form1 : Form
    {
        ArrayList studlist;
        public Form1()
        {
            InitializeComponent();
        }

        private void studGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studlist = new ArrayList();
            studlist.Add(new Student() { Sid = 1, FirstName = "Kyle", LastName = "Wood", Address = "123 Main St.",AdMonth=AdmissionMonth.July,StudGrade=StudentGrade.B });
            studlist.Add(new Student() { Sid = 2, FirstName = "Niteka", LastName = "Ramsey", Address = "456 Mission Blvd.",AdMonth=AdmissionMonth.April,StudGrade=StudentGrade.A });
            studGrid.DataSource = studlist;
            comboMonth.DataSource=Enum.GetValues(typeof(AdmissionMonth));
            comboGrade.DataSource=Enum.GetValues(typeof(StudentGrade));
            grpStud.Visible = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            studlist.RemoveAt(studGrid.CurrentRow.Index);
            RefreshData();
        }
        private void RefreshData()
        {
            txtSid.Clear();
            txtFname.Clear();
            txtLname.Clear();
            studGrid.DataSource = null;
            studGrid.DataSource = studlist;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grpStud.Visible = true;
            if (txtSid.Text != string.Empty && txtFname.Text != string.Empty && txtLname.Text != string.Empty && txtAddress.Text != string.Empty)
            {
                Student newStud = new Student();
                newStud.Sid = Int32.Parse(txtSid.Text);
                newStud.FirstName = txtFname.Text;
                newStud.LastName = txtLname.Text;
                newStud.Address = txtAddress.Text;
                newStud.AdMonth=(AdmissionMonth)comboMonth.SelectedIndex;
                newStud.StudGrade=(StudentGrade)comboGrade.SelectedIndex;
                studlist.Add(newStud);
            }
            RefreshData();
        }
    }
}
