namespace HotelBookingPlatform.Domain.Entities;
public class Review 
{
    public int ReviewID { get; set; }
    public int HotelId { get; set; }
    public Hotel Hotel { get; set; } = null!;
    public string Content { get; set; } = string.Empty;
    public int Rating { get; set; }
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime? ModifiedAtUtc { get; set; } = DateTime.UtcNow;
    public string UserId { get; set; } = string.Empty;
    public LocalUser User { get; set; } = null!;
}

