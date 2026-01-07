namespace HotelBookingPlatform.Domain.Entities;
public class Hotel
{
    public int HotelId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int StarRating { get; set; }
    public string? Description { get; set; }
    public string PhoneNumber { get; set; } = string.Empty;
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public int CityID { get; set; }
    public City City { get; set; } = null!;
    public int OwnerID { get; set; }
    public Owner Owner { get; set; } = null!;
    public ICollection<RoomClass> RoomClasses { get; set;} = new List<RoomClass>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    public ICollection<Amenity> Amenities { get; set; } = new List<Amenity>();
}
