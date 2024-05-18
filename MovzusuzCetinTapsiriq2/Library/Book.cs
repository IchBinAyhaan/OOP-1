

namespace Library
{
    abstract class Book
    {
        public string Title { get; }
        public string Author { get; }
        public int PageCount { get; }

        public Book(string title, string author, int pageCount)
        {
            Title = title;
            Author = author;
            PageCount = pageCount;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Page Count: {PageCount}");
        }
    }
}
