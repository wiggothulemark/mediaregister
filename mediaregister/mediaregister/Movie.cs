using System;
using System.Collections.Generic;
using System.Text;

namespace mediaregister
{
    class Movie : Media
    {
        private string _director;
        private int _length;

        public Movie(string title, string director, int length)
        {
            Title = title;
            _director = director;
            _length = length;
        }

        public override string ToString()
        {
            return Title + " " + _director + " " + _length;
        }
    }
}
