using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6._2
{
    public partial class FormCarDB : Form
    {
        CarRepository carRepository;
        public FormCarDB()
        {
            InitializeComponent();
        }

        private void FormCarDB_Load(object sender, EventArgs e)
        {
            //pull data from db into datagrid
            carRepository = new CarRepository();
            dataGridCars.DataSource=carRepository.ReadCars();

            //hide forms until needed by button interaction
            groupBoxCarInfo.Visible=false;
            btnSubmitNew.Visible=false;
            btnSubmitUpdate.Visible=false;
        }
        public void SetGridHeightWidth(DataGridView grd, int maxWidth, int maxHeight)
        {
            var height = 26;
            foreach (DataGridViewRow row in grd.Rows)
            {
                if (row.Visible)
                {
                    height += row.Height;
                }
            }
            if (height > maxHeight)
            {
                height = maxHeight;
            }
            grd.Height = height;

            var width = 60;
            foreach (DataGridViewColumn col in grd.Columns)
            {
                if (col.Visible)
                    width += col.Width;
            }

            if (width > maxWidth)
                width = maxWidth;

            grd.Width = width;
        }
        public void RefreshData()
        {
            txtVIN.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtPrice.Clear();
            txtColor.Clear();
            dataGridCars.DataSource = null;
            dataGridCars.DataSource = carRepository.ReadCars();

            groupBoxCarInfo.Visible = false;
            btnSubmitNew.Visible = false;
            btnSubmitUpdate.Visible = false;

            SetGridHeightWidth(dataGridCars, 1000, 210);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //clear the form
            RefreshData();

            //autofill the VIN with the next available number, disallow user editing of VIN
            txtVIN.Text = (carRepository.GetMaxVIN() + 1.ToString());
            txtVIN.ReadOnly = true;

            //show the forms
            groupBoxCarInfo.Visible = true;
            btnSubmitNew.Visible = true;
        }

        private void btnSubmitNew_Click(object sender, EventArgs e)
        {
            //verify all fields are filled before attempting to submit data
            if (!string.IsNullOrWhiteSpace(txtVIN.Text) && !string.IsNullOrWhiteSpace(txtMake.Text) && !string.IsNullOrWhiteSpace(txtModel.Text) && !string.IsNullOrWhiteSpace(txtYear.Text) && !string.IsNullOrWhiteSpace(txtPrice.Text) && !string.IsNullOrWhiteSpace(txtColor.Text))
            {
                //assign values to the new data member being added to the db
                var newcar = new tblCar();
                newcar.Make = txtMake.Text;
                newcar.Model = txtModel.Text;
                newcar.Year = Convert.ToInt32(txtYear.Text);
                newcar.Color = txtColor.Text;
                newcar.Price = Convert.ToDecimal(txtPrice.Text);

                //save the new data member to db
                carRepository.AddRecord(newcar);
                MessageBox.Show($"{newcar.Year} {newcar.Make} {newcar.Model} has been added to the records");
            }
            //clear the form
            RefreshData();

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            

            //clear anyhting that may be present
            //RefreshData();

            //show the text boxes and button for submitting update data
            groupBoxCarInfo.Visible = true;
            btnSubmitUpdate.Visible = true;

            //locate data in db based on selected index
            var id=dataGridCars.CurrentRow.Cells[0].Value;
            var cartoupdate = carRepository.FindCar((int)id);

            //pull data from database into text boxes to be edited
            txtVIN.Text=cartoupdate.VIN.ToString();
            txtVIN.ReadOnly = true;
            txtMake.Text = cartoupdate.Make;
            txtModel.Text = cartoupdate.Model;
            txtYear.Text= cartoupdate.Year.ToString();
            txtPrice.Text=cartoupdate.Price.ToString();
            txtColor.Text = cartoupdate.Color;
        }

        private void btnSubmitUpdate_Click(object sender, EventArgs e)
        {
            //verify none of the fields have been left empty
            if (!string.IsNullOrWhiteSpace(txtVIN.Text) && !string.IsNullOrWhiteSpace(txtMake.Text) && !string.IsNullOrWhiteSpace(txtModel.Text) && !string.IsNullOrWhiteSpace(txtYear.Text) && !string.IsNullOrWhiteSpace(txtPrice.Text) && !string.IsNullOrWhiteSpace(txtColor.Text))
            {
                //locate the car based on the VIN (primary key) in the db
                var id = Convert.ToInt32(txtVIN.Text);
                var cartoupdate = carRepository.FindCar((id) );

                //update data with text in textboxes
                cartoupdate.Make = txtMake.Text;
                cartoupdate.Model = txtModel.Text;
                cartoupdate.Year = Convert.ToInt32(txtYear.Text);
                cartoupdate.Color = txtColor.Text;
                cartoupdate.Price = Convert.ToDecimal(txtPrice.Text);

                //save changes to db
                carRepository.UpdateRecord(id, cartoupdate);
                MessageBox.Show($"{cartoupdate.Year} {cartoupdate.Make} {cartoupdate.Model} has been updated");

                //clear form
                RefreshData();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //locate car in db based on selected grid index
            var id = dataGridCars.CurrentRow.Cells[0].Value;
            var cartodelete = carRepository.FindCar((int)id);

            //remove record from db
            MessageBox.Show($"{cartodelete.Year} {cartodelete.Make} {cartodelete.Model} has been removed from the records");
            carRepository.DeleteRecord(cartodelete);

            //update data grid to verify removal
            RefreshData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void txtYear_Leave(object sender, EventArgs e)
        {
            //verify only numbers being input, and that year falls within years that cars existed
            if (!txtYear.Text.All(c => Char.IsNumber(c)) || (txtYear.Text.Length != 4) || (Convert.ToInt32(txtYear.Text) < 1886) || (Convert.ToInt32(txtYear.Text) > 2023))
            {
                txtYear.BackColor = Color.OrangeRed;
                MessageBox.Show("Please enter a valid year between 1886 and 2023");
                txtYear.Focus();
                txtYear.Clear();
            }
            else
            {
                txtYear.BackColor= Color.White;
            }
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMenu f2 = new FormMenu();
            this.Hide();
            f2.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMake_Leave(object sender, EventArgs e)
        {
            TextLengthWarning(txtMake);
        }
        private void TextLengthWarning(TextBox txt)
        {
            if (txt.Text.Length > 20)
            {
                txt.BackColor = Color.Orchid;
                MessageBox.Show("Please enter a shorter name");
                txt.Focus();
            }
            else
            {
                txt.BackColor= Color.White;
            }
        }

        private void txtModel_Leave(object sender, EventArgs e)
        {
            TextLengthWarning(txtModel);
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (!txtPrice.Text.All(c => Char.IsNumber(c)))
            {
                txtPrice.BackColor = Color.DarkGoldenrod;
                MessageBox.Show("Please enter a valid number");
                txtPrice.Focus();
            }
            else
            {
                txtPrice.BackColor= Color.White;
            }
        }

        private void txtColor_Leave(object sender, EventArgs e)
        {
            TextLengthWarning(txtColor);
        }
    }
}
