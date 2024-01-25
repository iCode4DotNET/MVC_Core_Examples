namespace Entities.ModelBinding.Advance;

public class Address
{
    public Address()
    {
        Country = string.Empty;
        City = string.Empty;
        PostalCode = string.Empty;
        Line1 = string.Empty;
    }

    /// <summary>
    /// کشور
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// شهر
    /// </summary>
    public string City { get; set; }

    /// <summary>
    /// آدرس لاین یک
    /// </summary>
    public string Line1 { get; set; }

    /// <summary>
    /// آدرس لاین دوم
    /// </summary>
    public string? Line2 { get; set; }

    /// <summary>
    /// کد پستی
    /// </summary>
    public string PostalCode { get; set; }

    public override string ToString()
    {
        return $"{Country} {City} {Line1} {PostalCode}";
    }
}