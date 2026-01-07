namespace HotelBookingPlatform.Domain.DTOs.Booking;
public class BookingDto
{
    public int BookingId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string ConfirmationNumber { get; set; } = string.Empty;
    public decimal TotalPrice { get; set; }
    public DateTime BookingDateUtc { get; set; }
    public string PaymentMethod { get; set; } = string.Empty;
    public decimal? AfterDiscountedPrice { get; set; }
    public string HotelName { get; set; } = string.Empty;
    public DateTime CheckInDateUtc { get; set; }
    public DateTime CheckOutDateUtc { get; set; }
    public string Status { get; set; } = string.Empty;
    public List<string> Numbers { get; set; } = new();
}
