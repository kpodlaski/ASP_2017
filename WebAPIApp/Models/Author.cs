using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIApp.Models {
    public class Author {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Sname { get {
                return Name[0] + ". " + Surname;
            } }

        public Author() { }
        public Author(String n, String s) {
            this.Name = n;
            this.Surname = s;
        }


    }
}