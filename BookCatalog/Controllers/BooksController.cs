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
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return _bookRepository.GetBooks().ToList();
        }
    }
}
