namespace COMP003A.LectureActivity6_1;

/// <summary>
/// Represents a car, which is a type of vehicle
/// </summary>
public class Car : Vehicle
{
    // Auto-implemented properties
    public int Doors { get; set; }

    /// <summary>
    /// Constructs a car with the specified brand, year, and number of doors.
    /// </summary>
    /// <param name="brand"></param>
    /// <param name="year"></param>
    /// <param name="doors"></param>

    public Car(string brand, int year, int doors)
    {
        Brand = brand;
        Year = year;
        Doors = doors;
    }

    /// <summary>
    /// Displays car details including inherited properties
    /// </summary>

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Doors: {Doors}");
    }
}