namespace HotelBookingPlatform.Domain.DTOs.Review;
public class ReviewResponseDto
{
    public int ReviewID { get; set; }
    public string HotelName { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public int Rating { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime? ModifiedAtUtc { get; set; }
    public string UserName { get; set; } = string.Empty;
}
