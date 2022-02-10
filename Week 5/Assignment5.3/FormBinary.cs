using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.RegularExpressions;

namespace Assignment5._3
{
    public partial class FormPuppy : Form
    {
        Puppy newPuppy = new Puppy();
        public FormPuppy()
        {
            InitializeComponent();
        }

        private void FormPuppy_Load(object sender, EventArgs e)
        {
            //give combo boxes values
            comboBreed.DataSource=Enum.GetValues(typeof(Breed));
            comboToy.DataSource=Enum.GetValues(typeof(Toy));
            comboSerSelect.DataSource=Enum.GetValues(typeof(SerialType));


        }
        private void RefreshData()
        {
            textName.Clear();
            textAge.Clear();
        }

        private void comboSerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string val = comboSerSelect.SelectedIndex.ToString();
            //MessageBox.Show(val);
            switch (val)
            {
                case "0":
                    buttonBinSer.Visible = true;
                    buttonBinDes.Visible = true;
                    buttonXMLSer.Visible = false;
                    buttonXMLDes.Visible = false;
                    buttonJSONSer.Visible = false;
                    buttonJSONDes.Visible = false;
                    break;
                case "1":
                    buttonBinSer.Visible = false;
                    buttonBinDes.Visible = false;
                    buttonXMLSer.Visible = true;
                    buttonXMLDes.Visible = true;
                    buttonJSONSer.Visible = false;
                    buttonJSONDes.Visible = false;
                    break;
                case "2":
                    buttonBinSer.Visible = false;
                    buttonBinDes.Visible = false;
                    buttonXMLSer.Visible = false;
                    buttonXMLDes.Visible = false;
                    buttonJSONSer.Visible = true;
                    buttonJSONDes.Visible = true;
                    break;
            }
        }

        private void comboSerSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboSerSelect.SelectedValue as string);
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu f1 = new FormMenu();
            this.Hide();
            f1.Show();
        }

        private void buttonBinSer_Click(object sender, EventArgs e)
        {
            string filepathBin = @"C:\MSSAfiles\newBinarySer.txt";

            newPuppy.PuppyBreed = (Breed)comboBreed.SelectedIndex;
            newPuppy.Name = textName.Text;
            newPuppy.Age = Int32.Parse(textAge.Text);
            newPuppy.FaveToy=(Toy)comboToy.SelectedIndex;

            if (textName.Text == string.Empty || textAge.Text == string.Empty)
            {
                MessageBox.Show("Please complete all fields before serializing data");
            }
            
            else
            {
                FileStream fileStream = new FileStream(filepathBin, FileMode.OpenOrCreate, FileAccess.ReadWrite);

                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, newPuppy);

                MessageBox.Show($"{newPuppy.Name} has been serialized in binary!");

                fileStream.Close();
            }

            
        }

        private void buttonBinDes_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            string filepathBin = @"C:\MSSAfiles\newBinarySer.txt";

            FileStream fileStream = new FileStream(filepathBin, FileMode.Open, FileAccess.Read);
            Puppy puppy =(Puppy)binaryFormatter.Deserialize(fileStream);

            MessageBox.Show($"Deserialized puppy: {newPuppy.Name} is a {newPuppy.PuppyBreed}, who is {newPuppy.Age} years old, and their favorite toy is a {newPuppy.FaveToy}");

            fileStream.Close();
        }

        private void buttonXMLSer_Click(object sender, EventArgs e)
        {
            newPuppy.PuppyBreed = (Breed)comboBreed.SelectedIndex;
            newPuppy.Name = textName.Text;
            newPuppy.Age = Int32.Parse(textAge.Text);
            newPuppy.FaveToy = (Toy)comboToy.SelectedIndex;

            if (textName.Text == string.Empty || textAge.Text == string.Empty)
            {
                MessageBox.Show("Please complete all fields before serializing data");
            }
            else
            {
                FileStream fileStreamXML = new FileStream(@"C:\MSSAfiles\xmlpuppy.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fileStreamXML, newPuppy);
                fileStreamXML.Close();
                MessageBox.Show($"{newPuppy.Name}'s data has been serialized in XML!");
            }
            
            
        }

        private void buttonXMLDes_Click(object sender, EventArgs e)
        {
            SoapFormatter soapFormatter = new SoapFormatter();

            FileStream fileStreamXML = new FileStream(@"C:\MSSAfiles\xmlpuppy.xml", FileMode.Open, FileAccess.Read);

            Puppy puppy = soapFormatter.Deserialize(fileStreamXML) as Puppy;
            MessageBox.Show($"Deserialized puppy: {newPuppy.Name} is a {newPuppy.PuppyBreed}, who is {newPuppy.Age} years old, and their favorite toy is a {newPuppy.FaveToy}");

            fileStreamXML.Close();
        }

        private void textAge_Leave(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textAge.Text, "[^0-9.,]"))
            {
                textAge.BackColor = Color.Red;
                textAge.Focus();
                MessageBox.Show("Please enter only numbers.");
                textAge.Clear();
            }
            else
            {
                textAge.BackColor = Color.White;
            }
        }

        private void buttonJSONSer_Click(object sender, EventArgs e)
        {
            newPuppy.PuppyBreed = (Breed)comboBreed.SelectedIndex;
            newPuppy.Name = textName.Text;
            newPuppy.Age = Int32.Parse(textAge.Text);
            newPuppy.FaveToy = (Toy)comboToy.SelectedIndex;

            if (textName.Text == string.Empty || textAge.Text == string.Empty)
            {
                MessageBox.Show("Please complete all fields before serializing data");
            }
            else
            {
                FileStream fileStreamJSON = new FileStream(@"C:\MSSAfiles\jsonpuppy.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                DataContractJsonSerializer serializer = new DataContractJsonSerializer(newPuppy.GetType());
                serializer.WriteObject(fileStreamJSON, newPuppy);

                fileStreamJSON.Close();

                MessageBox.Show($"{newPuppy.Name}'s data has been serialized in JSON!");
            }
        }

        private void buttonJSONDes_Click(object sender, EventArgs e)
        {
            FileStream fileStreamJSON = new FileStream(@"C:\MSSAfiles\jsonpuppy.txt", FileMode.Open, FileAccess.Read);

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(newPuppy.GetType());
            Puppy puppy = serializer.ReadObject(fileStreamJSON) as Puppy;
            fileStreamJSON.Close();

            MessageBox.Show($"Deserialized puppy: {newPuppy.Name} is a {newPuppy.PuppyBreed}, who is {newPuppy.Age} years old, and their favorite toy is a {newPuppy.FaveToy}");
        }
    }
}
