﻿class Program
{
    static void Main()
    {
        Point A = new Point(0, 0, "A");
        Point B = new Point(3, 0, "B");
        Point C = new Point(3, 4, "C");

        Figure figure = new Figure(A, B, C);
        figure.CalculatePerimeter();

        Console.ReadLine();
    }
}