Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim lines As New ArrayList
        If TextBox1.Text = "Aucun" Then
            MsgBox("Vous n'avez chargé aucun client !", MsgBoxStyle.Critical, "Erreur")
        Else
            Dim price As Long
            price = InputBox("Entrez le prix de l'article", "Prix?", 0)
            Dim path As String = "C:\\Users\\Public\\clients.csv"
            If Dir(path) <> "" Then
                Using parser As New TextFieldParser(path)
                    parser.TextFieldType = FieldType.Delimited
                    parser.SetDelimiters(";")
                    While Not parser.EndOfData
                        Dim fields As String() = parser.ReadFields()
                        If fields(0) = TextBox3.Text AndAlso fields(1) = TextBox2.Text Then
                            fields(2) = price + fields(2)
                            Label4.Text = fields(2)
                            lines.Add(fields(0) + ";" + fields(1) + ";" + fields(2) + ";" + fields(3))
                        Else
                            lines.Add(parser.ReadLine)
                            MsgBox("")
                        End If
                    End While
                End Using
            End If
            Dim out As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(path, False)
            For Each line In lines
                out.WriteLine(line)
            Next
            out.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim path As String = "C:\\Users\\Public\\clients.csv"
        If Dir(path) <> "" Then
            Using parser As New TextFieldParser(path)
                parser.TextFieldType = FieldType.Delimited
                parser.SetDelimiters(";")
                While Not parser.EndOfData
                    Dim fields As String() = parser.ReadFields()
                    If fields.Length >= 2 AndAlso fields(0) = TextBox3.Text AndAlso fields(1) = TextBox2.Text Then
                        MsgBox("Client chargé avec succès !", MsgBoxStyle.Information)
                        TextBox1.Text = fields(0) + " " + fields(1)
                        Label4.Text = fields(2)
                    End If
                End While
            End Using
            If TextBox1.Text = "Aucun" Then
                MsgBox("Client non trouvé !", MsgBoxStyle.Critical, "Erreur")
            End If
        End If
    End Sub
End Class