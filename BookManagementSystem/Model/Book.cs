﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Model
{
     class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Genre Genre{ get; set; }
        public int GenreId { get; set; }

        public int PublishYear { get; set; }

        public Author Author { get; set; }
        public int AuthorId { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
