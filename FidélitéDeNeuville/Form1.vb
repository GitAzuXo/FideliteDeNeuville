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
                        Dim currentLine As String = parser.ReadLine()
                        Dim fields As String() = currentLine.Split(";")
                        Dim completelist As New List(Of String)
                        For j As Integer = 0 To 1
                            completelist.Add(fields(j))
                        Next
                        If fields(0) = TextBox3.Text AndAlso fields(1) = TextBox2.Text Then
                            fields(2) = (CLng(fields(2)) + price).ToString()
                            Label4.Text = fields(2)
                            If fields(2) >= 400 Then
                                fields(2) -= 400
                                Label4.Text = fields(2)
                                completelist.Add(fields(2))
                                For j As Integer = 3 To fields.Length - 1
                                    completelist.Add(fields(j))
                                Next
                                MsgBox("Votre client gagne un bon de 20€ pour la prochaine fois", MsgBoxStyle.Information, "Gain bon")
                                completelist.Add("Bon de 20€")
                            ElseIf fields(2) >= 200 Then
                                fields(2) -= 200
                                Label4.Text = fields(2)
                                completelist.Add(fields(2))
                                For j As Integer = 3 To fields.Length - 1
                                    completelist.Add(fields(j))
                                Next
                                MsgBox("Votre client gagne un bon de 10€ pour la prochaine fois", MsgBoxStyle.Information, "Gain bon")
                                completelist.Add("Bon de 10€")
                            ElseIf fields(2) >= 100 Then
                                fields(2) -= 100
                                Label4.Text = fields(2)
                                completelist.Add(fields(2))
                                For j As Integer = 3 To fields.Length - 1
                                    completelist.Add(fields(j))
                                Next
                                MsgBox("Votre client gagne un bon de 5€ pour la prochaine fois", MsgBoxStyle.Information, "Gain bon")
                                completelist.Add("Bon de 5€")
                            Else
                                For j As Integer = 2 To fields.Length - 1
                                    completelist.Add(fields(j))
                                Next
                            End If
                        Else
                            completelist.Add(fields(2))
                            For j As Integer = 3 To fields.Length - 1
                                completelist.Add(fields(j))
                            Next
                        End If
                        currentLine = String.Join(";", completelist)
                        lines.Add(currentLine)
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

    Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim path As String = "C:\\Users\\Public\\clients.csv"
        Dim lines As New ArrayList
        If Dir(path) <> "" Then
            Using parser As New TextFieldParser(path)
                parser.TextFieldType = FieldType.Delimited
                parser.SetDelimiters(";")
                While Not parser.EndOfData
                    Dim currentLine As String = parser.ReadLine()
                    Dim fields As String() = currentLine.Split(";")
                    Dim completelist As New List(Of String)
                    If fields.Length >= 2 AndAlso fields(0) = TextBox3.Text AndAlso fields(1) = TextBox2.Text Then
                        MsgBox("Client chargé avec succès !", MsgBoxStyle.Information)
                        For j As Integer = 0 To 1
                            completelist.Add(fields(j))
                        Next
                        TextBox1.Text = fields(0) + " " + fields(1)
                        Label4.Text = fields(2)
                        Button4.Enabled = True
                        Dim today As String = DateTime.Now.ToString("MM")
                        Dim anniv As String() = fields(3).Split("/")
                        Dim listcl As New ArrayList
                        If IO.File.Exists("C:\\Users\\Public\\birth.txt") Then
                            Dim ino As IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\\Users\\Public\\birth.txt")
                            While Not ino.EndOfStream
                                Dim line As String = ino.ReadLine()
                                listcl.Add(line)
                            End While
                            ino.Close()
                        Else
                            Dim pathtxt As String = "C:\Users\Public\birth.txt"

                            ' Use StreamWriter to create or overwrite the file
                            Using out As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(pathtxt, False)
                                ' No need to write anything; just opening and closing will create an empty file
                            End Using
                        End If
                        If anniv(1) = today Then
                            If Not listcl.Contains(fields(0) + " " + fields(1)) Then
                                If MsgBox("C'est le mois anniversaire de ce client, doubler ses points ?", MsgBoxStyle.YesNo, "Anniversaire") = vbYes Then
                                    fields(2) *= 2
                                    Dim out As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("C:\\Users\\Public\\birth.txt", True)
                                    out.WriteLine(fields(0) + " " + fields(1))
                                    out.Close()
                                    Label4.Text = fields(2)
                                    completelist.Add(fields(2))
                                    For j As Integer = 3 To fields.Length - 1
                                        completelist.Add(fields(j))
                                    Next
                                Else
                                    Exit Sub
                                End If
                            Else
                                Exit Sub
                            End If
                        Else
                            For j As Integer = 2 To fields.Length - 1
                                completelist.Add(fields(j))
                            Next
                        End If
                    Else
                        For j As Integer = 0 To fields.Length - 1
                            completelist.Add(fields(j))
                        Next
                    End If
                    currentLine = String.Join(";", completelist)
                    lines.Add(currentLine)
                End While
            End Using
            If TextBox1.Text = "Aucun" Then
                MsgBox("Client non trouvé !", MsgBoxStyle.Critical, "Erreur")
            Else
                Dim out As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(path, False)
                For Each line In lines
                    out.WriteLine(line)
                Next
                out.Close()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form4.Show()
    End Sub
End Class