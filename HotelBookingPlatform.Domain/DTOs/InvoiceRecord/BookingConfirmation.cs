namespace HotelBookingPlatform.Domain.DTOs.InvoiceRecord;
public class BookingConfirmation
{
    public string ConfirmationNumber { get; set; } = string.Empty;
    public string HotelName { get; set; } = string.Empty;
    public string HotelAddress { get; set; } = string.Empty;
    public decimal? AfterDiscountedPrice { get; set; }
    public string RoomType { get; set; } = string.Empty;
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public decimal TotalPrice { get; set; }
    public string UserEmail { get; set; } = string.Empty;
    public decimal Percentage { get; set; }
}
