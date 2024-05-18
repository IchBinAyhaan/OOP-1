
namespace Library
{
    internal class Novel : Book
    {
        public string Genre { get; }

        public Novel(string title, string author, int pageCount, string genre)
            : base(title, author, pageCount)
        {
            Genre = genre;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Genre: {Genre}"); 
        }
    }
}
