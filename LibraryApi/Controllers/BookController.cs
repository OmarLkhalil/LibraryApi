using LibraryApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Forms;
using System.Collections;

namespace LibraryApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BookController(ApplicationDbContext context) { 
       
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {

            var books = _context.Books.ToList();
            return Ok(books);
        }



        [HttpGet("search")]
        public ActionResult<IEnumerable<Book>> SearchBooks(string keyword) {

            var books = _context.Books.Where(
                b => b.Title == keyword
                ).ToList();

            return Ok(books);
        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Book>> DeleteBooks(int id)
        {
            var book = _context.Books.Find(id);

             _context.Remove(book);

             _context.SaveChanges();

            return NoContent();
        }

    }
}
