using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Controllers;

[Route("authors")]

public class AuthorController : Controller
{
    private readonly ILogger<AuthorController> _logger;

    public AuthorController(ILogger<AuthorController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{id}")]
    public IActionResult Author ([FromRoute] int id)
    {
            var context = new BookishDbContext();
            var books = context.Books
            .Include(b => b.Author)
            .Include(b => b.Genres);
            var book = books.Single(b => b.Id == id);
        
        return View(book);
    }

    [HttpGet("")]

    public IActionResult Index()
    {
        var context = new BookishDbContext();
        var authors = context.Authors
        .Include(a => a.Books)
        .ToList();
        
        return View(authors);
    }
}