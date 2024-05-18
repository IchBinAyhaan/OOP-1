

namespace Library
{
    internal class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void DisplayBooks()
        {
            Console.WriteLine("Library Inventory:");
            foreach (var book in books)
            {
                book.DisplayInfo(); 
                Console.WriteLine(); 
            }
        }
    }
}
