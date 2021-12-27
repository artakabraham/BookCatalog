using BookCatalog.Models;

namespace BookCatalog.Repository
{
    public class InMemoryBookRepository : IBook
    {
        private List<Book> _Books;

        public InMemoryBookRepository()
        {
            _Books = new List<Book>()
            {
                new Book(){ Id = Guid.NewGuid(), Title = "Book 0", Price = 10},
                new Book(){ Id = Guid.NewGuid(), Title = "Book 1", Price = 15}
            };
        }

        public void CreateBook(Book book)
        {
            _Books.Add(book);
        }

        public void DeleteBook(Book book)
        {
            throw new NotImplementedException();
        }

        public Book GetBook(Guid id)
        {
            var book = _Books.Where(x => x.Id == id).FirstOrDefault();
            return book;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _Books;
        }

        public void UpdateBook(Guid id, Book book)
        {
            var bookIndex = _Books.FindIndex(x => x.Id == id);
            if (bookIndex > -1)
            {
                _Books[bookIndex] = book;
            }
        }
    }
}
