using System;

namespace Proj2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        class Book
        {

        }
        class Title
        {
            public string TitleName{get; set;}
            public void Show() 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Title: {this.TitleName}");
            }


        }
        class Content
        {
            public string ContentName{get; set;}
            public void Show() 
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Title: {this.ContentName}");
            }

        }
        class Author
        {
            public string AuthorName{get; set;}
            public void Show() 
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Title: {this.AuthorName}");
            }
        }
    }
}
