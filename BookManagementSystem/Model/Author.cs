﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem.Model
{
     class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if (!IsValidEmail(value))
                {
                   MessageBox.Show("Invalid email address.");
                }
                _email = value;
            }
        }
        public string Phone { get; set; }

        //public string Phone
        //{
        //    get { return _phone; }
        //    set
        //    {
        //        if (!IsValidPhoneNumber(value))
        //        {MessageBox.Show("Invalid phone number.");
        //        }
        //        _phone = value;
        //    }
        //}

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }
       
    }
}
