namespace Entities.ModelBinding.Simple;

public class Person
{
    public Person()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        AddressObject = new();
    }

    /// <summary>
    /// آیدی شخص
    /// </summary>
    public int PersonID { get; set; }

    /// <summary>
    /// نام شخص
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// نام خانوادگی
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// نقش شخص
    /// </summary>
    public EnRole Role { get; set; }

    /// <summary>
    /// تاریخ تولد
    /// </summary>
    public DateTime BirthDate { get; set; }

    /// <summary>
    /// تایید شده؟
    /// </summary>
    public bool IsApproved { get; set; }

    /// <summary>
    /// آدرس منزل
    /// </summary>
    public Address AddressObject { get; set; }


    public override string ToString()
    {
        return $"{PersonID} {FirstName} {LastName} {Role} {IsApproved} {BirthDate} {AddressObject}";
    }
}