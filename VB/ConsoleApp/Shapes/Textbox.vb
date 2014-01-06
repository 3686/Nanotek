Imports ConsoleApp.Printers

Namespace Shapes

    Public Class Textbox
        Inherits Shape
        Implements IPrintable

        Public Property Text As String = String.Empty
        Public Property Width As Integer = 0
        Public Property Height As Integer = 0

        Public Sub New(x As Integer, y As Integer, width As Integer, height As Integer, Optional text As String = "")
            Me.X = x
            Me.Y = y
            Me.Width = width
            Me.Height = height
            Me.Text = text
        End Sub

        Public Overrides Function ToString() As String Implements IPrintable.ToString
            Return String.Format("Textbox ({0},{1}) width={2} height={3} Text=""{4}""", X, Y, Width, Height, Text)
        End Function

    End Class

End Namespace