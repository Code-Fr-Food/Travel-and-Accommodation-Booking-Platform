namespace HotelBookingPlatform.Domain.DTOs.Hotel;
public class HotelResponseDto
{
    public int HotelId { get; set; }
    public string Name { get; set; } = string.Empty;
    public double ReviewsRating { get; set; }
    public string CityName { get; set; } = string.Empty;
    public string OwnerName { get; set; } = string.Empty;
    public int StarRating { get; set; }
    public string? Description { get; set; }
    public string PhoneNumber { get; set; } = string.Empty;
    public DateTime CreatedAtUtc { get; set; }
    public ICollection<ReviewResponseDto> Reviews { get; set; } = new List<ReviewResponseDto>();

}
