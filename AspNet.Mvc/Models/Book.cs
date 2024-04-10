namespace AspNet.Mvc.Models
{
    public class Book
    {
        public string Title { get; }

        public string ISBN { get; }

        public int ReleaseYear { get; }

        public List<Author> Authors { get; }

        public string Author
        {
            get
            {
                return string.Join(", ", Authors);
            }
        }

        public Book(string title, string isbn, int releaseYear, List<Author> authors) {
            Title = title;
            ISBN = isbn;
            ReleaseYear = releaseYear;
            Authors = authors;
        }

        public Book(string title, string isbn, int releaseYear, Author author)
            : this(title, isbn, releaseYear, new List<Author> { author })
        {
        }
    }
}
