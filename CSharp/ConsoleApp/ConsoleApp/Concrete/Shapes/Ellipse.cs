using ConsoleApp.Abstractions;

namespace ConsoleApp.Concrete.Shapes
{
    public class Ellipse : Shape, IPrint
    {
        public int HorizontalDiameter { get; set; }
        public int VerticalDiameter { get; set; }

        public Ellipse(int x = 100, int y = 150, int horizontalDiameter = 300, int verticalDiameter = 200)
        {
            this.X = x;
            this.Y = y;
            this.HorizontalDiameter = horizontalDiameter;
            this.VerticalDiameter = verticalDiameter;
        }

        public override string ToString()
        {
            return string.Format("Ellipse ({0},{1}) diameterH = {2} diameterV = {3}", X, Y, HorizontalDiameter, VerticalDiameter);
        }
    }
}
