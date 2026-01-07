namespace HotelBookingPlatform.Domain.Entities;
public class Amenity
{
    public int AmenityID { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int HotelId { get; set; }
    public Hotel Hotel { get; set; } = null!;
    public ICollection<RoomClass> RoomClasses { get; set; } = new List<RoomClass>();
}
