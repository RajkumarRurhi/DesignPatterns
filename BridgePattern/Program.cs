using System;

namespace BridgePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RedColor red = new RedColor();
            GreenColor green = new GreenColor();
            BlueColor blue = new BlueColor();

            Square redSquare = new Square(red);
            redSquare.applyColor();

            Square blueSquare = new Square(blue);
            blueSquare.applyColor();

            Circle greenCircle = new Circle(green);
            greenCircle.applyColor();

            Circle redCircle = new Circle(red);
            redCircle.applyColor();

            Console.ReadLine();
        }
    }
}
