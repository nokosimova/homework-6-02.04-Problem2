using System;

namespace Proj2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            Title n = new Title();
            Console.WriteLine("Enter the data of book:");
            Console.Write("name: ");
            b1.name.TitleName = Console.ReadLine();
            Console.Write("author: ");
            b1.author.AuthorName = Console.ReadLine();
            Console.Write("content: ");
            b1.content.ContentName = Console.ReadLine();
            Console.WriteLine("about book: ");
            b1.Show();            
            
        }

        class Book
        {
            public Title name = new Title();
            public Author author = new Author();
            public Content content = new Content();

            public void Show() 
            {
                this.name.Show();
                this.author.Show();
                this.content.Show();
            }

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
                Console.WriteLine($"Author: {this.ContentName}");
            }

        }
        class Author
        {
            public string AuthorName{get; set;}
            public void Show() 
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Content: {this.AuthorName}");
            }
        }
    }
}
        /*при создании класса Book, изначально поля были добавлены так: 
        class Book
        {
                public Title name {get; set};
                public Author name {get; set};
                public Content name {get; set};
        }
        это стало причиной того что в поле класса нельзя было передать данные,
        ошибку исправила просмотрев код других студентов академии,
        на выложенном ими репозитории
        */