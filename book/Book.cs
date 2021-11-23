using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    class Book : IComparable<Book>
    {
        private string title;
        private string author;
        private int edition;

        public Book(string t, string a, int e)
        {
            title = t;
            author = a;
            edition = e;
        }

        public string Title { get { return title; } }
        public string Author { get { return author; } }
        public int Edition { get { return edition; } }

        public int CompareTo(Book b)
        {
            if (author.CompareTo(b.Author) != 0)
                return author.CompareTo(b.Author);
            if (title.CompareTo(b.Title) != 0)
                return title.CompareTo(b.Title);

            return edition.CompareTo(b.Edition);
        }
    }
}