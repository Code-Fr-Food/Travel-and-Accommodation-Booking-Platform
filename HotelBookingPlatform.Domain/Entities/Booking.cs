namespace HotelBookingPlatform.Domain.Entities;
public class Booking
{
    public int BookingID { get; set; }
    public string UserId { get; set; } = string.Empty;
    public LocalUser User { get; set; } = null!;
    public BookingStatus Status { get; set; }
    public string ConfirmationNumber { get; set; } = string.Empty;
    public decimal TotalPrice { get; set; }
    public decimal AfterDiscountedPrice { get; set; }
    public DateTime BookingDateUtc { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public int HotelId { get; set; }
    public Hotel Hotel { get; set; } = null!;
    public DateTime CheckInDateUtc { get; set; }
    public DateTime CheckOutDateUtc { get; set; }
    public ICollection<Room> Rooms { get; set; } = new List<Room>();
    public ICollection<InvoiceRecord> Invoice { get; set; } = new List<InvoiceRecord>();
}
