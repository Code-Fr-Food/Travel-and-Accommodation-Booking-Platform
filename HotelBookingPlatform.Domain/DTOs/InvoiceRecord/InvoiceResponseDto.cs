namespace HotelBookingPlatform.Domain.DTOs.InvoiceRecord;
public class InvoiceResponseDto
{
    public int InvoiceRecordId { get; set; }
    public int BookingID { get; set; }
    public int RoomID { get; set; }
    public string RoomClassName { get; set; } = string.Empty;
    public string RoomNumber { get; set; } = string.Empty;
    public decimal PriceAtBooking { get; set; }
    public decimal? DiscountPercentageAtBooking { get; set; }
}
