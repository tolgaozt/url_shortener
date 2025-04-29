namespace UrlShortener.Models;

public class UrlMapping
{
    public int Id { get; set; }

    // The original long URL provided by the user
    public string OriginalUrl { get; set; } = string.Empty;

    // Unique code used to create a short URL (e.g., abc123)
    public string ShortCode { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
