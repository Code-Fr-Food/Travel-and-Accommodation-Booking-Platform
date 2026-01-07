namespace HotelBookingPlatform.Domain.Entities;
public class InvoiceRecord
{
    public int InvoiceRecordId { get; set; }
    public int BookingID { get; set; }
    public Booking Booking { get; set; } = null!;
    public int RoomID { get; set; }
    public string RoomClassName { get; set; } = string.Empty;
    public string RoomNumber { get; set; } = string.Empty;
    public decimal PriceAtBooking { get; set; }
    public decimal? DiscountPercentageAtBooking { get; set; }
}
