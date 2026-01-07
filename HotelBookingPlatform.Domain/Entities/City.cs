namespace HotelBookingPlatform.Domain.Entities;
public class City 
{
    public int CityID { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string PostOffice { get; set; } = string.Empty;
    public ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public int VisitCount { get; set; } // I mean Trending search
}
