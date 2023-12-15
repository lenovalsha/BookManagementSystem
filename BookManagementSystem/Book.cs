using BookManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class Book : Form
    {
        MyDBContext MyDBContext;
        public Book()
        {
            InitializeComponent();
            MyDBContext = new MyDBContext();
            RefreshAuthor();
            RefreshGenre();
            #region DateTimePicker
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
            #endregion

        }
        private void RefreshGenre()
        {
            if (MyDBContext.Genres != null)
            {
                var genres = MyDBContext.Genres.ToList();

                foreach (Genre gen in genres)
                {
                    cmbGenre.Items.Add(gen); //make sure that in the class you are overriding the string to return name
                }
            }
        }
        private void RefreshAuthor()
        {
            if (MyDBContext.Authors != null)
            {
                var authors = MyDBContext.Authors.ToList();

                foreach (Author author in authors)
                {
                    cmbGenre.Items.Add(author); //make sure that in the class you are overriding the string to return name
                }
            }
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
            if (txtTitle.Text != string.Empty && cmbGenre.SelectedItem != null && cmbAuthor.SelectedItem !=null && dateTimePicker1.Value != null)
            {
                var selectedGenre = cmbGenre.SelectedItem as Model.Genre;
                var newBook = new Model.Book
                {
                    Title = txtTitle.Text,
                    GenreId = (cmbGenre.SelectedItem as Model.Genre).Id,
                    AuthorId = (cmbGenre.SelectedItem as Model.Author).Id,
                    PublishYear = dateTimePicker1.Value.Year

                };
                MyDBContext.Books.Add(newBook);
                MyDBContext.SaveChanges();
            }else
                MessageBox.Show("Please make sure all data is entered correctly");
        }
    }
}
