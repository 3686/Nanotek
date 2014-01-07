using ConsoleApp.Abstractions;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Concrete
{
    public class ConsolePrinter : IPrinter
    {
        private readonly IDrawing _drawing;
        public IDrawing Drawing
        {
            get
            {
                return _drawing;
            }
        }

        public ConsolePrinter(IDrawing drawing)
        {
            _drawing = drawing;
        }

        public string Print()
        {
            var sb = new StringBuilder();

            sb.AppendLine("----------------------------------------------------------------");
            sb.AppendLine("Current Drawing");
            sb.AppendLine("----------------------------------------------------------------");

            var items = (List<IPrint>)_drawing;

            foreach (var element in items)
            {
                sb.AppendLine(element.ToString());
            }

            sb.AppendLine("----------------------------------------------------------------");

            return sb.ToString();
        }

    }

}
