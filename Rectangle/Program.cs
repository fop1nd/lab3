using System.Drawing;

class Program
{
    static void Main()
    {
        double inputSide1, inputSide2;

        Console.WriteLine("Enter the length of the first side of the rectangle:");
        while (!double.TryParse(Console.ReadLine(), out inputSide1) || inputSide1 <= 0)
        {
            Console.WriteLine("Enter a valid value for the length of the first side (positive number):");
        }

        Console.WriteLine("Enter the length of the second side of the rectangle:");
        while (!double.TryParse(Console.ReadLine(), out inputSide2) || inputSide2 <= 0)
        {
            Console.WriteLine("Enter a valid value for the length of the other side (positive number):");
        }

        Rectangle rectangle = new Rectangle(inputSide1, inputSide2);

        Console.WriteLine($"Perimeter of a rectangle: {rectangle.Perimeter}");
        Console.WriteLine($"Area of ​​the rectangle: {rectangle.Area}");

        Console.ReadLine();
    }
}