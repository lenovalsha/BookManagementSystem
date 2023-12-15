using BookManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class Book : Form
    {
        MyDBContext dbContext;
        bool isUpdating = false;
        Model.Book f;
        public Book()
        {
            InitializeComponent();
            dbContext = new MyDBContext();
            RefreshAuthor();
            RefreshGenre();
            #region DateTimePicker
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
            #endregion

        }
        public Book(int? id)
        {
          
            InitializeComponent();

            dbContext = new MyDBContext();
            RefreshAuthor();
            RefreshGenre();
            f = dbContext.Books.Find(id);
            if (f != null)
            {
                txtTitle.Text = f.Title;
                cmbGenre.Text = f.Genre.Name;
                cmbAuthor.Text = f.Author.ToString();
                DateTime dateTime = new DateTime(f.PublishYear, 1, 1); // Assuming January 1st of the given year
                dateTimePicker1.Value = dateTime;
                isUpdating = true;
            }
        }


        private void RefreshGenre()
        {
            if (dbContext.Genres != null)
            {
                var genres = dbContext.Genres.ToList();

                foreach (Model.Genre gen in genres)
                {
                    cmbGenre.Items.Add(gen); //make sure that in the class you are overriding the string to return name
                }
            }
        }
        private void RefreshAuthor()
        {
            if (dbContext.Authors != null)
            {
                var authors = dbContext.Authors.ToList();

                foreach (Model.Author aut in authors)
                {
                    cmbAuthor.Items.Add(aut); //make sure that in the class you are overriding the string to return name
                }
            }
        }
        private void Refresh()
        {
            txtTitle.Text = string.Empty;
            cmbGenre.Text = string.Empty;
            cmbAuthor.Text = string.Empty;

        }
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (txtTitle.Text != string.Empty && cmbGenre.SelectedItem != null && cmbAuthor.SelectedItem != null && dateTimePicker1.Value != null)
            {
                int genreId = (cmbGenre.SelectedItem as Model.Genre).Id;
                int authorId = (cmbAuthor.SelectedItem as Model.Author).Id;

                if (isUpdating)
                {
                    f.Title = txtTitle.Text;
                    f.GenreId = genreId;
                    f.AuthorId = authorId;
                    f.PublishYear = dateTimePicker1.Value.Year;
                    dbContext.SaveChanges();
                    MessageBox.Show("Updated");
                    this.Close();
                }
                else
                {
                    var newBook = new Model.Book
                    {
                        Title = txtTitle.Text,
                        GenreId = genreId,
                        AuthorId = authorId,
                        PublishYear = dateTimePicker1.Value.Year

                    };
                    dbContext.Books.Add(newBook);
                    dbContext.SaveChanges();
                    MessageBox.Show(newBook.Title + " has been added!");
                    Refresh();
                }
            }
            else
                MessageBox.Show("Please make sure all data is entered correctly");

        }
    }
}
