namespace Entities.ModelBinding.Advance;

public class Phone
{
    public Phone()
    {
        PhoneNumber = string.Empty;  
    }
    public string PhoneNumber { get; set; }
    public EnPhoneType PhoneType { get; set; }

    public override string ToString()
    {
        return $"{PhoneNumber} {PhoneType}";
    }
}
