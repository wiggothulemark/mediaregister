using System;
using System.Collections.Generic;
using System.Text;

namespace mediaregister
{
    class Book : Media
    {
        private string _author;
        private int _pages;

        public Book(string title, string author, int pages)
        {
            Title = title;
            _author = author;
            _pages = pages;
        }

        public override string ToString()
        {
            return Title + " " + _author + " " + _pages;
        }
    }
}
