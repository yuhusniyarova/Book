using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace book
{
    class Book
    {
        public int ISBN { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public Book()
        { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
