using ConsoleApp.Abstractions;

namespace ConsoleApp.Concrete.Shapes
{
    public class Square : Shape, IPrint
    {
        public int Size { get; set; }

        public Square(int x = 15, int y = 30, int size = 35)
        {
            this.X = x;
            this.Y = y;
            this.Size = size;
        }

        public override string ToString()
        {
            return string.Format("Square ({0},{1}) size={2}", X, Y, Size);
        }
    }
}
