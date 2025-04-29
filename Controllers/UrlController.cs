using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UrlShortener.Data;
using UrlShortener.Models;

namespace UrlShortener.Controllers;

[ApiController]
[Route("[controller]")]
public class UrlController : ControllerBase
{
    private readonly AppDbContext _db;

    public UrlController(AppDbContext db)
    {
        _db = db;
    }

    // POST /url
    // Takes a long URL and returns a shortened version
    [HttpPost]
    public async Task<IActionResult> Shorten([FromBody] string originalUrl)
    {
        if (string.IsNullOrWhiteSpace(originalUrl))
            return BadRequest("URL cannot be empty.");

        // Generate a short code (6 characters)
        var shortCode = Guid.NewGuid().ToString("N")[..6];

        var entry = new UrlMapping
        {
            OriginalUrl = originalUrl,
            ShortCode = shortCode
        };

        _db.UrlMappings.Add(entry);
        await _db.SaveChangesAsync();

        // Construct the full short URL based on host
        var shortUrl = $"{Request.Scheme}://{Request.Host}/{shortCode}";

        return Ok(new { shortUrl });
    }

    // GET /{code}
    // Redirects the short code to the original URL
    [HttpGet("/{code}")]
    public async Task<IActionResult> RedirectToOriginal(string code)
    {
        var match = await _db.UrlMappings.FirstOrDefaultAsync(x => x.ShortCode == code);

        if (match is null)
            return NotFound("Short URL not found.");

        return Redirect(match.OriginalUrl);
    }
}
