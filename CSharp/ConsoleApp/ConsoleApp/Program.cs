using ConsoleApp.Concrete;
using ConsoleApp.Concrete.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var drawing = new Drawing();
            drawing.Add(new Rectangle(10,10,30,40));
            drawing.Add(new Square(15, 30, 35));
            drawing.Add(new Ellipse(100, 150, 300, 200));
            drawing.Add(new Circle(1, 1, 300));
            drawing.Add(new Textbox(5, 5, 200, 100, "sample text"));

            var printer = new ConsolePrinter(drawing);
            var result = printer.Print();

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
