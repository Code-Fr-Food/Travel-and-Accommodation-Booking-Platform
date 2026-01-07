using HotelBookingPlatform.Domain.DTOs.Hotel;
namespace HotelBookingPlatform.Domain.DTOs.City;
public class CityWithHotelsResponseDto
{
    public int CityID { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string PostOffice { get; set; } = string.Empty;
    public DateTime CreatedAtUtc { get; set; }
    public string Description { get; set; } = string.Empty;
    public IEnumerable<HotelResponseDto> Hotels { get; set; } = new List<HotelResponseDto>();
}
