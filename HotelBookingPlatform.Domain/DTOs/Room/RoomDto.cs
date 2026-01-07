namespace HotelBookingPlatform.Domain.DTOs.Room;
public class RoomDto
{
    public int RoomId { get; set; }
    public string RoomType { get; set; } = string.Empty;
    public string Number {  get; set; } = string.Empty;
    public decimal PricePerNight { get; set; }
}
