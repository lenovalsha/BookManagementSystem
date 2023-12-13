using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Model
{
     class BookAuthor
    {
        public int Id { get; set; }
        public Book BookId { get; set; }
        public Author AuthorId { get; set; }
       
    }
}
