Namespace Printers

    Public Class ConsolePrinter
        Implements IPrint

        Private _collection As New List(Of IPrintable)
        Public ReadOnly Property Collection As List(Of IPrintable)
            Get
                Return _collection
            End Get
        End Property

        Public Function Print() As String Implements IPrint.Print
            Dim sb As New System.Text.StringBuilder()

            sb.AppendLine("----------------------------------------------------------------")
            sb.AppendLine("Current Drawing")
            sb.AppendLine("----------------------------------------------------------------")

            For Each element In Collection
                sb.AppendLine(element.ToString())
            Next

            sb.AppendLine("----------------------------------------------------------------")

            Return sb.ToString()
        End Function

    End Class

End Namespace