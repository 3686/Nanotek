using ConsoleApp.Abstractions;

namespace ConsoleApp.Concrete.Shapes
{
    public class Textbox : Shape, IPrint
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string Text { get; set; }

        public Textbox(int x = 5, int y = 5, int width = 200, int height= 100, string text = @"sample text")
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Text = text;
        }

        public override string ToString()
        {
            return string.Format(@"Textbox ({0},{1}) width={2} height={3} Text=""{4}""", X, Y, Width, Height, Text);
        }
    }
}
