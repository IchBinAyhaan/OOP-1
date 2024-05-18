namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {

            Library library = new Library();

            Book book1 = new Book("Harry Potter and the Philosopher's Stone", "J.K. Rowling", 336);
            Book book2 = new Novel("1984", "George Orwell", 328, "Dystopian Fiction");
            library.AddBook(book1);
            library.AddBook(book2);

            library.DisplayBooks();
        }
    }
}

