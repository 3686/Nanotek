using ConsoleApp.Abstractions;

namespace ConsoleApp.Concrete.Shapes
{
    public class Rectangle : Shape, IPrint
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Rectangle(int x = 10, int y = 10, int width = 30, int height = 40)
        {
            this.X = x;
            this.Y = y;
            this.Height = height;
            this.Width = width;
        }

        public override string ToString()
        {
            return string.Format("Rectangle ({0},{1}) width={2} height={3}", X, Y, Width, Height);
        }
    }

}
