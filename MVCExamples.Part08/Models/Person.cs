using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCExamples.Part08.Models;

//public class Person
//{
//    public Person()
//    {
//        FirstName = string.Empty;
//        LastName = string.Empty;
//        Email = string.Empty;
//    }

//    public int ID { get; set; }
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public string Email { get; set; }

//}


//public class Person
//{

//    public Person()
//    {
//        FirstName = string.Empty;
//        LastName = string.Empty;
//        Email = string.Empty;
//    }

//    [DisplayName("شناسه")]
//    public int ID { get; set; }

//    [DisplayName("نام")]
//    [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
//    public string FirstName { get; set; }

//    [DisplayName("نام خانوادگی")]
//    [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
//    public string LastName { get; set; }

//    [DisplayName("ایمیل")]
//    [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
//    [EmailAddress]
//    public string Email { get; set; }

//}




public class Person
{
    public int ID { get; set; }

    [DisplayName("نام")]
    [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
    public string FirstName { get; set; }

    [DisplayName("نام خانوادگی")]
    [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
    [MaxLength(5)]
    [MinLength(3, ErrorMessage = "حداقل سه کاراکتر بنویس")]
    public string LastName { get; set; }

    [DataType(dataType: DataType.Password)]
    public string Password { get; set; }

    [EmailAddress]
    [DataType(dataType: DataType.EmailAddress)]
    [RegularExpression("")]
    public string Email { get; set; }

    [Compare("Password")]
    public string ConfirmPassword { get; set; }

}

