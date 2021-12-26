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
            throw new NotImplementedException();
        }

        public void DeleteBook(Book book)
        {
            throw new NotImplementedException();
        }

        public Book GetBook(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetBooks()
        {
            return _Books;
        }

        public void UpdateBook(Guid id, Book book)
        {
            throw new NotImplementedException();
        }
    }
}
