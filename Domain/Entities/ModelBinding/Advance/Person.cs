using System.ComponentModel.DataAnnotations;

namespace Entities.ModelBinding.Advance;


public class Person
{
    public Person()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        AddressObject = new();
        Favorites = [];
        Phones = [];
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
    [Display(Name = "آیا تایید شده است؟")]
    public bool IsApproved { get; set; }

    /// <summary>
    /// آدرس منزل
    /// </summary>
    public Address AddressObject { get; set; }

    /// <summary>
    /// لیست علاقه مندی ها
    /// </summary>
    public List<string> Favorites { get; set; }

    /// <summary>
    /// لیست از شماره های تماس
    /// </summary>
    public List<Phone> Phones { get; set; }

    public override string ToString()
    {
        return $"{PersonID} {FirstName} {LastName} {Role} {IsApproved} {BirthDate} {AddressObject}";
    }

}
