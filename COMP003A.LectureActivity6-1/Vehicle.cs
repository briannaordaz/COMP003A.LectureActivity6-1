namespace COMP003A.LectureActivity6_1;

/// <summary>
/// Represents a general vehicle
/// </summary>
public class Vehicle
{
    // Fields 
    private string _brand;
    
    // Properties
    public string Brand
    {
        get { return _brand; }
        set { _brand = value; }
        
    }
    
    public int Year { get; set; }

    /// <summary>
    /// Displays vehicle details.
    /// </summary>
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Year: {Year}");
    }
}
