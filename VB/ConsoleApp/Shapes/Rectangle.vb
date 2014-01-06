Imports ConsoleApp.Printers

Namespace Shapes

    Public Class Rectangle
        Inherits Shape
        Implements IPrintable

        Public Property Height As Integer = 0
        Public Property Width As Integer = 0

        Public Sub New(x As Integer, y As Integer, width As Integer, height As Integer)
            Me.X = x
            Me.Y = y
            Me.Width = width
            Me.Height = height
        End Sub

        Public Overrides Function ToString() As String Implements IPrintable.ToString
            Return String.Format("Rectangle ({0},{1}) width={2} height={3}", X, Y, Width, Height)
        End Function

    End Class

End Namespace