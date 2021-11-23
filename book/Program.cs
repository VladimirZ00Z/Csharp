using System;

namespace book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book a = new Book("To Kill a Mockingbird", "Harper Lee", 13);
            Book b = new Book("CLR via C#", "Jeffrey Richter", 4);
            Console.WriteLine(a.CompareTo(b));
        }
    }
}