Imports ConsoleApp.Printers
Imports ConsoleApp.Shapes

Module ConsoleApp

    Sub Main()

        Dim printer As ConsolePrinter = New ConsolePrinter()

        printer.Collection.Add(New Rectangle(10, 10, 30, 40))
        printer.Collection.Add(New Square(15, 30, 35))
        printer.Collection.Add(New Ellipse(100, 150, 300, 200))
        printer.Collection.Add(New Circle(1, 1, 300))
        printer.Collection.Add(New Textbox(5, 5, 200, 100, "sample text"))

        Console.WriteLine(printer.Print())
        Console.ReadLine()

    End Sub

End Module
