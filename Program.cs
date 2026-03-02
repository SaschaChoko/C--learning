using System;
using System.Collections.Generic;
using System.Reflection;
using Library;

class Program
{
    static void Main()
    {
        string title_kobsar = "Kobsar";
        string author_kobsar = "Taras Shevchenko";
        int pages_kobsar = 600;
        
        Book kobsar = new Book(title_kobsar, author_kobsar, pages_kobsar);
        kobsar.PrintInfo(title_kobsar, author_kobsar, pages_kobsar);

        string title_berkut = "Zachar Berkut";
        string author_berkut = "Ivan Franko";
        int pages_berkut = 300;

        Book berkut = new Book(title_berkut, author_berkut, pages_berkut);
        berkut.PrintInfo(title_berkut, author_berkut, pages_berkut);
    }
}
namespace Library
{
    class Book
    {
        public string title;
        public string author;
        public int pages;
        public Book(string Title, string Author, int Pages)
        {
            title = Title;
            author = Author;
            pages = Pages;
        }
        public void PrintInfo(string title, string author, int pages)
        {
            Console.WriteLine($"Title: {title}, author: {author}, pages: {pages}.");
        }
    }
}