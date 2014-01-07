using ConsoleApp.Abstractions;

namespace ConsoleApp.Concrete.Shapes
{
    public class Circle : Shape, IPrint
    {
        public int Size { get; set; }

        public Circle(int x = 1, int y = 1, int size = 300)
        {
            this.X = x;
            this.Y = y;
            this.Size = size;
        }

        public override string ToString()
        {
            return string.Format("Circle ({0},{1}) size={2}", X, Y, Size);
        }
    }
}
