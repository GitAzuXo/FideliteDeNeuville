Imports Microsoft.VisualBasic

Public Class Printer

    Private Shared lines As New Queue(Of String)
    Private Shared _myfont As font
    Private Shared prn As printing.printdocument

    Shared Sub New()
        _myfont = New Font("Courrier New", 8, fontstyle.regular, graphicsunit.point)
    End Sub

End Class
