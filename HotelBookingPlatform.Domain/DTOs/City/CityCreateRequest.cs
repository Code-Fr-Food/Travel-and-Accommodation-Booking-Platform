namespace HotelBookingPlatform.Domain.DTOs.City;
public class CityCreateRequest
{
    public string Name { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string PostOffice { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
