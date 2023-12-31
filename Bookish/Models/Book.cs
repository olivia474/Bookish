using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace Bookish;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string CoverImageUrl { get; set; }
    public string Blurb { get; set; }
    public Author Author { get; set; }
    public List<Genre> Genres { get; set; }

}