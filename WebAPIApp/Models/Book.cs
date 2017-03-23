using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIApp.Models {
    public class Book {
        public int Id { get; set; }
        public Author Author { get; set; }
        public String Title { get; set; }
        public int Year { get; set; }

        public Book() { }
        
        public Book(Author a, String t, int y) {
            Author = a;
            Title = t;
            Year = y;
        }
    }
}