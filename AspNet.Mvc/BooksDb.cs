using AspNet.Mvc.Models;

namespace AspNet.Mvc
{
    public class BooksDb
    {
        public List<Book>? books { get; set; }

        public List<Book> getBooks()
        {
            if (books != null)
            {
                return books;
            }

            // Create authors
            var jkr = new Author("Joanne", "Rowling", new DateOnly(1965, 7, 31), "J.K. Rowling");
            var jv = new Author("Jules", "Verne", new DateOnly(1870, 6, 20));
            var sh = new Author("Stephen", "Hawking", new DateOnly(1942, 1, 8));


            books = new List<Book>
            {
                new Book(
                    "Harry Potter i Kamen Mudraca",
                    "978-0-7475-3269-9",
                    1997,
                    jkr
                ),

                new Book(
                    "Harry Potter i Odaja Tajni",
                    "0-7475-3849-2",
                    1998,
                    jkr
                ),

                new Book(
                    "Harry Potter i Zatočenik Azkabana",
                    "0-7475-4215-5",
                    1999,
                    jkr
                ),

                new Book(
                    "Harry Potter i Plameni Pehar",
                    "0-7475-4624-X",
                    2000,
                    jkr
                ),

                new Book(
                    "Harry Potter i Red Feniksa",
                    "0-7475-5100-6",
                    2003,
                    jkr
                ),

                new Book(
                    "Harry Potter i Princ Mješane Krvi",
                    "0-7475-8108-8",
                    2005,
                    jkr
                ),

                new Book(
                    "Harry Potter i Darovi Smrti",
                    "0-7475-9105-9",
                    2007,
                    jkr
                ),

                new Book(
                   "20.000 Milja Pod Morem",
                   "978-0-19-953927-7",
                   1870,
                   jv
                ),

                new Book(
                   "Put Na Mjesec",
                   "9780486206332",
                   1865,
                   jv
                ),

                new Book(
                   "Put u Središte Zemlje",
                   "9780486206332",
                   1864,
                   jv
                ),

                new Book(
                    "A Brief History of Time",
                    "978-0-553-10953-5",
                    1988,
                    sh
                ),

                new Book(
                    "The Universe in a Nutshell",
                    "0-553-80202-X",
                    2001,
                    sh
                ),

                new Book(
                    "Good Omens",
                    "0-575-04800-X",
                    1990,
                    new List<Author>
                    {
                        new Author("Terry", "Pratchett", new DateOnly(1948, 4, 28)),
                        new Author("Neil", "Gainman", new DateOnly(1960, 11, 10))
                    }
                )
            };

            return books;
        }
    }
}
