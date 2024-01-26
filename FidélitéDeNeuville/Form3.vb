Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.FileIO

Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text Is "" Then
            Stop
        Else
            Dim path As String = "C:\\Users\\Public\\clients.csv"
            Dim lines As New ArrayList
            If Dir(path) <> "" Then
                Using parser As New TextFieldParser(path)
                    parser.TextFieldType = FieldType.Delimited
                    parser.SetDelimiters(";")
                    While Not parser.EndOfData
                        Dim currentLine As String = parser.ReadLine()
                        Dim fields As String() = currentLine.Split(";")
                        Dim completelist As New List(Of String) ' Déplacez la déclaration de completelist ici
                        If fields.Length >= 2 AndAlso fields(0) = Form1.TextBox3.Text AndAlso fields(1) = Form1.TextBox2.Text Then
                            For j As Integer = 0 To fields.Length - 1
                                completelist.Add(fields(j))
                            Next
                            completelist.Remove(ComboBox1.Text)
                            currentLine = String.Join(";", completelist)
                            MsgBox("Bon consommé avec succès", MsgBoxStyle.Information, "Succès")
                        Else
                            completelist.AddRange(fields) ' Utilisez AddRange pour ajouter tous les champs
                            currentLine = String.Join(";", completelist)
                        End If
                        lines.Add(currentLine)
                    End While
                End Using
                Dim out As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(path, False)
                For Each line In lines
                    out.WriteLine(line)
                Next
                out.Close()
                Me.Close()
            End If
        End If
    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As String = "C:\\Users\\Public\\clients.csv"
        If Dir(path) <> "" Then
            Using parser As New TextFieldParser(path)
                parser.TextFieldType = FieldType.Delimited
                parser.SetDelimiters(";")
                While Not parser.EndOfData
                    Dim currentLine As String = parser.ReadLine()
                    Dim fields As String() = currentLine.Split(";")
                    If fields.Length >= 2 AndAlso fields(0) = Form1.TextBox3.Text AndAlso fields(1) = Form1.TextBox2.Text Then
                        Dim completelist As New List(Of String)
                        If fields.Length <= 7 Then
                            Me.Close()
                            MsgBox("Ce client n'a aucun coupon", MsgBoxStyle.Critical)
                        End If
                        For j As Integer = 7 To fields.Length - 1
                            completelist.Add(fields(j))
                        Next
                        For i As Integer = 0 To completelist.Count - 1
                            ComboBox1.Items.Add(completelist(i))
                        Next
                    End If
                End While
            End Using
        End If
    End Sub
End Class