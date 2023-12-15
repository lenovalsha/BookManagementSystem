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
        public Form1()
        {
            InitializeComponent();
            dbContext = new MyDBContext();
            RefreshGenre();
        }
        private void RefreshGenre()
        {
            if (dbContext.Genres != null)
            {
                var genres = dbContext.Genres.ToList();

                foreach (Genre gen in genres)
                {
                    cmbGenres.Items.Add(gen); //make sure that in the class you are overriding the string to return name
                }
            }
        }
        private void btnCreateGenre_Click(object sender, EventArgs e)
        {
            if(txtGenre.Text != string.Empty)
            {
                var newGenre = new Model.Genre
                {
                    Name = txtGenre.Text
                };
                dbContext.Genres.Add(newGenre); // add it to the context
                dbContext.SaveChanges(); // this looks at all the changes in the context and refreshes it in the database
                MessageBox.Show(newGenre.Name + " has been added!");
                RefreshGenre() ;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            if (txtBook.Text != string.Empty && cmbGenres.SelectedItem != null)
            {
                var selectedGenre = cmbGenres.SelectedItem as Model.Genre;
                var newBook = new Model.Book
                {
                    Title = txtBook.Text,
                    GenreId = (cmbGenres.SelectedItem as Model.Genre).Id
                   
                };
                dbContext.Books.Add(newBook);
                dbContext.SaveChanges();
            }
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            var qry = from b in dbContext.Books
                      orderby b.Title
                      select new { b.Title, b.Genre};

            dgvContent.DataSource = qry.ToList();
            //dgvContent.Columns[0].Visible = false;
            dgvContent.Refresh();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

            Book book = new Book();
            book.Show();
        }
    }
}
