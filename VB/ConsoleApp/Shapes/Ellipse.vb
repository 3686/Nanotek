Imports ConsoleApp.Printers

Namespace Shapes

    Public Class Ellipse
        Inherits Shape
        Implements IPrintable

        Public Property HorizontalHeight As Integer = 0
        Public Property VerticalHeight As Integer = 0

        Public Sub New(x As Integer, y As Integer, horizontalHeight As Integer, verticalHeight As Integer)
            Me.X = x
            Me.Y = y
            Me.HorizontalHeight = horizontalHeight
            Me.VerticalHeight = verticalHeight
        End Sub

        Public Overrides Function ToString() As String Implements IPrintable.ToString
            Return String.Format("Ellipse ({0},{1}) diameterH = {2} diameterV = {3}", X, Y, HorizontalHeight, VerticalHeight)
        End Function

    End Class

End Namespace