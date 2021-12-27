using BookCatalog.Dto;
using BookCatalog.Models;
using BookCatalog.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookCatalog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly IBook _bookRepository;
        public BooksController(IBook bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BookDto>> GetBooks()
        {
            return _bookRepository.GetBooks()
                .Select(x => new BookDto { Id = x.Id, Title = x.Title, Price = x.Price }).ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<BookDto> GetBook(Guid id)
        {
            var book = _bookRepository.GetBook(id);
            if (book is null)
            {
                return NotFound();
            }
            return new BookDto
            {
                Id = book.Id,
                Title = book.Title,
                Price = book.Price
            };
        }

        [HttpPost]
        public ActionResult CreateBook(CreateOrUpdateBookDto bookDto)
        {
            var book = new Book
            {
                Id = Guid.NewGuid(),
                Title = bookDto.Title,
                Price = bookDto.Price
            };
            _bookRepository.CreateBook(book);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateBook(Guid id, CreateOrUpdateBookDto bookDto)
        {
            var book = _bookRepository.GetBook(id);
            if (book is null)
            {
                return NotFound();
            }

            book.Title = bookDto.Title;
            book.Price = bookDto.Price;
            _bookRepository.UpdateBook(id, book);
            return Ok();
        }
    }
}
