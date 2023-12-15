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
            bindingSource = new BindingSource();
            var qry = from b in dbContext.Books
                      orderby b.Title
                      select new { b.Title, b.Genre, b.Author, b.PublishYear };

            dgvContent.DataSource = qry.ToList();
            //dgvContent.Columns[0].Visible = false;
            dgvContent.Refresh();
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
    }
}
