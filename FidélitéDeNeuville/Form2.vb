Imports Microsoft.VisualBasic.FileIO

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text.Length = 0 And TextBox2.Text.Length = 0) Then
            MsgBox("Vous ne pouvez pas enregister un client vierge", MsgBoxStyle.Critical)
        Else
            Dim path As String = "C:\\Users\\hisla\\Documents\\clients.csv"
            Dim clientExists As Boolean = False
            Using parser As New TextFieldParser(path)
                parser.TextFieldType = FieldType.Delimited
                parser.SetDelimiters(";")
                While Not parser.EndOfData
                    Dim fields As String() = parser.ReadFields()
                    If fields.Length >= 2 AndAlso fields(0) = TextBox1.Text AndAlso fields(1) = TextBox2.Text Then
                        clientExists = True
                        Exit While
                    End If
                End While
            End Using
            If clientExists Then
                MsgBox("Le client existe déjà dans la base !", MsgBoxStyle.Critical)
            Else
                ' Ajouter le client dans le fichier CSV
                Dim out As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(path, True)
                out.WriteLine(TextBox1.Text + ";" + TextBox2.Text)
                out.Close()
                MsgBox("Client enregistré avec succès !", MsgBoxStyle.Information)
                Form1.Show()
                Me.Close()
            End If
        End If

    End Sub
End Class