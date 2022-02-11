using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment5._4;


namespace Assignment5._4_Forms
{
    
    public partial class LibraryForm : Form
    {
        BookRepository bookRepository;
        Library newbook = new Library();
        
        public LibraryForm()
        {
            InitializeComponent();
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            bookRepository = new BookRepository();
            dataGridLib.DataSource = bookRepository.GetBooks().ToList();
            comboGenre.DataSource=Enum.GetValues(typeof(Genre));

            groupBoxAddBooks.Visible = false;
            dataGridLib.Visible = false;
        }
        private void RefreshData()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            dataGridLib.DataSource = null;
            dataGridLib.DataSource = bookRepository.GetBooks().ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            groupBoxAddBooks.Visible=true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtAuthor.Text == string.Empty || txtTitle.Text == string.Empty)
            {
                MessageBox.Show("Please complete all fields before submitting tomes to this library");
            }
            else if (txtTitle.TextLength > 35)
            {
                txtTitle.BackColor = Color.Red;
                txtTitle.Focus();
                MessageBox.Show("This title is as long as the story itself! Please provide a shorter title");
                txtTitle.Clear();
            }
            else if (txtAuthor.TextLength > 25)
            {
                txtAuthor.BackColor = Color.MistyRose;
                txtAuthor.Focus();
                MessageBox.Show("My goodness! I've lost my breath trying to say such a long name! Please provide a shorter nickname, perhaps?");
            }
            else
            {
                Random random = new Random();

                txtTitle.BackColor= Color.White;
                txtAuthor.BackColor= Color.White;

                newbook.Id=random.Next(100000,999999);
                newbook.Title=txtTitle.Text;
                newbook.Author=txtAuthor.Text;
                newbook.BookGenre=(Genre)comboGenre.SelectedIndex;

                bookRepository.AddBook(newbook);
                MessageBox.Show($"{txtTitle.Text} has been added to our collection");

                RefreshData();

                if (bookRepository.GetBooks().Count > 0)
                {
                    btnDelete.Visible = true;
                    dataGridLib.Visible = true;
                }

                groupBoxAddBooks.Visible = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{dataGridLib.CurrentRow.Cells[1].Value.ToString()} has been removed from our collection");
            bookRepository.DeleteBook(dataGridLib.CurrentRow.Index);
            dataGridLib.DataSource = null;
            dataGridLib.DataSource = bookRepository.GetBooks().ToList();

            if (bookRepository.GetBooks().Count == 0)
            {
                btnDelete.Visible = false;
                dataGridLib.Visible = false;
            }
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void imSadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are amazing and I'm happy you're here :)");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            RefreshData();
            groupBoxAddBooks.Visible=false;
            dataGridLib.Visible = true;
        }
    }
}
