namespace HotelBookingPlatform.Domain.DTOs.City;
public class CityResponseDto
{
    public int CityID { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string PostOffice { get; set; } = string.Empty;
    public DateTime CreatedAtUtc { get; set; }
    public string Description { get; set; } = string.Empty;
}
