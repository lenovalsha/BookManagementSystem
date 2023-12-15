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
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.Show();
        }
    }
}
