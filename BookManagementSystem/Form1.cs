using BookManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookManagementSystem.Model;
namespace BookManagementSystem
{
    public partial class Form1 : Form
    {
        private MyDBContext dbContext;
        BindingSource bindingSource;
        bool isSelected = false;
        int selectedBookId;
        public Form1()
        {
            InitializeComponent();
            dbContext = new MyDBContext();
        }

        private void btnCreateGenre_Click(object sender, EventArgs e)
        {
            if (txtGenre.Text != string.Empty)
            {
                var newGenre = new Model.Genre
                {
                    Name = txtGenre.Text
                };
                dbContext.Genres.Add(newGenre); // add it to the context
                dbContext.SaveChanges(); // this looks at all the changes in the context and refreshes it in the database
                MessageBox.Show(newGenre.Name + " has been added!");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            ShowAllBooks();
        }


        private void btnAddBook_Click(object sender, EventArgs e)
        {

            Book book = new Book();
            book.Show();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bindingSource = new BindingSource();
            var qry = from b in dbContext.Books
                      where b.Title.Contains(txtSearch.Text)
                      orderby b.Title
                      select new { b.Title, b.Genre, b.Author, b.PublishYear };

            dgvContent.DataSource = qry.ToList();
            //dgvContent.Columns[0].Visible = false;
            dgvContent.Refresh();
        }

        private void btnGenerateGenre_Click(object sender, EventArgs e)
        {
            string[] genres = { "Horror", "Comedy", "Drama" };
            foreach (string genre in genres)
            {

                var qry = new Model.Genre
                {
                    Name = genre,

                };
                dbContext.Genres.Add(qry);
                dbContext.SaveChanges();
                MessageBox.Show(qry + " has been generated");
            }
        }

        private void btnGenerateAuthors_Click(object sender, EventArgs e)
        {
            string[] fName = { "Sarah", "Marg", "Peter" };
            string[] LName = { "Stew", "Johnson", "Park" };


            for (int i = 0; i < fName.Length; i++)
            {
                var qry = new Model.Author
                {
                    FirstName = fName[i],
                    LastName = LName[i],
                    Address = "Address",
                    Email = "email@email.com",
                    Phone = "555-555-5555"
                };
                dbContext.Authors.Add(qry);
                dbContext.SaveChanges();
            }
        }

        private void btnDeleteAllAuthors_Click(object sender, EventArgs e)
        {
            var qry = dbContext.Authors.ToList();
            dbContext.Authors.RemoveRange(qry);
            dbContext.SaveChanges();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SelectedRow();
            if (isSelected)
            {
                Book bookForm = new Book(selectedBookId);
                bookForm.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SelectedRow();
            if (isSelected)
            {
                var b = dbContext.Books.Find(selectedBookId);
                DialogResult result = MessageBox.Show("You are about to delete " + b.Title + " . Do you want to continue?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dbContext.Books.Remove(b);
                    dbContext.SaveChanges();
                    ShowAllBooks();
                }
                else
                {
                    return;
                }
            }
        }
        private void SelectedRow()
        {

            if (dgvContent.Rows.Count > 0)
            {

                var selectedRowIndex = dgvContent.SelectedCells[0].RowIndex;
                if (selectedRowIndex >= 0 && selectedRowIndex < dgvContent.Rows.Count)
                {
                    // Assuming the book ID is stored in the first cell of the selected row
                    DataGridViewCell cell = dgvContent.Rows[selectedRowIndex].Cells[0];

                    // Check if the cell value is not null and can be converted to an integer
                    if (cell.Value != null && int.TryParse(cell.Value.ToString(), out selectedBookId))
                    {
                        isSelected = true;
                    }
                    else
                    {
                        // Handle the case where the conversion fails or the value is null
                        isSelected = false;
                        MessageBox.Show("Please select a row");
                    }
                }
            }
            else
                MessageBox.Show("Please select a row");

        }
        private void ShowAllBooks()
        {
            bindingSource = new BindingSource();
            var qry = from b in dbContext.Books
                      orderby b.Title
                      select new { b.Id, b.Title, b.Genre, b.Author, b.PublishYear };

            dgvContent.DataSource = qry.ToList();
            dgvContent.Columns[0].Visible = false;
            dgvContent.Refresh();
        }
    }
}
