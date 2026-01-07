namespace HotelBookingPlatform.Domain.DTOs.Hotel;
public class HotelCreateRequest
{
    public string Name { get; set; } = string.Empty;
    public int StarRating { get; set; }
    public string? Description { get; set; }
    public string PhoneNumber { get; set; } = string.Empty;
    public int OwnerID { get; set; }
}
