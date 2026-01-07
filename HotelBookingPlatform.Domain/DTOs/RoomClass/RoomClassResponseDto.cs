namespace HotelBookingPlatform.Domain.DTOs.RoomClass;
public class RoomClassResponseDto
{
    public int RoomClassID { get; set; }
    public string RoomType { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; } 
    public string HotelName { get; set; } = string.Empty;
}