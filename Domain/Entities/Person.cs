namespace Entities;

/// <summary>
/// موجودیت اشخاص
/// </summary>
public class Person(int id, string firstName, string lastName)
{
    /// <summary>
    /// شناسه شخص
    /// </summary>
    public int ID { get; set; } = id;
   
    /// <summary>
    /// نام شخص
    /// </summary>
    public string FirstName { get; private set; } = firstName;
   
    /// <summary>
    /// نام خانوادگی
    /// </summary>
    public string LastName { get; private set; } = lastName;

    /// <summary>
    /// توضیحات
    /// </summary>
    public string? Note { get; set; }
   
    /// <summary>
    /// آیا مدیر است ؟
    /// </summary>
    public bool IsAdmin { get; set; }
  
    public override string ToString()
    {
        return $"{ID} {FirstName} {LastName}";
    }
}




public class Product
{

    //public Product()
    //{

    //}

    public Product(int id, string title, int price)
    {
        ID = id;
        Title = title;
        Price = price;
    }

    public Product(int id, string title)
    {
        ID = id;
        Title = title;
        Price = 0;
    }

    public int ID { get; set; } 
    public string Title { get; private set; } 
    public int Price { get; private set; }

    public override string ToString()
    {
        return $"{ID} {Title} {Price}";
    }
}