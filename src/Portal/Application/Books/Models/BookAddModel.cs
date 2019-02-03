using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.Books.Models
{
    public class BookAddModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }
        public string ImagePath { get; set; }
    }
}
