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

namespace BookManagementSystem
{
    public partial class Author : Form
    {
        MyDBContext myDBContext;
            string phone = "222-222-2222";
        public Author()
        {
            InitializeComponent();
            myDBContext = new MyDBContext();
            txtPhone.Text = phone;  
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearContents()
        {
            txtFName.Text = string.Empty;
            txtLName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhone.Text = phone;
            txtAddress.Text = string.Empty;

        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtFName.Text != string.Empty && txtLName.Text !=string.Empty)
            {
                var newAuthor = new Model.Author
                {
                    FirstName = txtFName.Text,
                    LastName = txtLName.Text,
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                };
                myDBContext.Authors.Add(newAuthor);
                myDBContext.SaveChanges();
                MessageBox.Show(newAuthor.FirstName + " " + newAuthor.LastName + " Added");
                ClearContents();
            }
            else
            {
                MessageBox.Show("Please Enter Valid Author");
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
