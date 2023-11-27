class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the first side of the rectangle:");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of the second side of the rectangle:");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Rectangle rectangle = new Rectangle(side1, side2);

        Console.WriteLine($"Perimeter of a rectangle: {rectangle.Perimeter}");
        Console.WriteLine($"Area of ​​the rectangle: {rectangle.Area}");

        Console.ReadLine();
    }
}