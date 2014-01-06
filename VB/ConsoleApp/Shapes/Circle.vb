Imports ConsoleApp.Printers

Namespace Shapes

    Public Class Circle
        Inherits Shape
        Implements IPrintable

        Public Property Size As Integer = 0

        Public Sub New(x As Integer, y As Integer, size As Integer)
            Me.X = x
            Me.Y = y
            Me.Size = size
        End Sub

        Public Overrides Function ToString() As String Implements IPrintable.ToString
            Return String.Format("Circle ({0},{1}) size={2}", X, Y, Size)
        End Function

    End Class

End Namespace