using HotelBookingPlatform.Domain.DTOs.Amenity;

namespace HotelBookingPlatform.Domain.DTOs.HomePage;
public class HotelSearchResultDto
{
    public int HotelId { get; set; }
    public string HotelName { get; set; } = string.Empty;
    public int StarRating { get; set; }
    public double RoomPrice { get; set; }
    public string RoomType { get; set; } = string.Empty;
    public string CityName { get; set; } = string.Empty;
    public double Discount { get; set; }
    public IEnumerable<AmenityResponseDto> Amenities { get; set; } = new List<AmenityResponseDto>();
}
