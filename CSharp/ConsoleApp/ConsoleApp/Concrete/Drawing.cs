using ConsoleApp.Abstractions;
using System.Collections.Generic;

namespace ConsoleApp.Concrete
{
    public class Drawing : List<IPrint>, IDrawing
    {

    }
}
