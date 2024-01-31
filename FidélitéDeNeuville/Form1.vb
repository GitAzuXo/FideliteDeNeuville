Imports System.Drawing.Printing
Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports System.IO.Ports

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
                                CouponPrint(20)
                            ElseIf fields(2) >= 200 Then
                                fields(2) -= 200
                                Label4.Text = fields(2)
                                completelist.Add(fields(2))
                                For j As Integer = 3 To fields.Length - 1
                                    completelist.Add(fields(j))
                                Next
                                MsgBox("Votre client gagne un bon de 10€ pour la prochaine fois", MsgBoxStyle.Information, "Gain bon")
                                completelist.Add("Bon de 10€")
                                CouponPrint(10)
                            ElseIf fields(2) >= 100 Then
                                fields(2) -= 100
                                Label4.Text = fields(2)
                                completelist.Add(fields(2))
                                For j As Integer = 3 To fields.Length - 1
                                    completelist.Add(fields(j))
                                Next
                                MsgBox("Votre client gagne un bon de 5€ pour la prochaine fois", MsgBoxStyle.Information, "Gain bon")
                                completelist.Add("Bon de 5€")
                                CouponPrint(5)
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
        Dim clientFound As Boolean = False

        If Dir(path) <> "" Then
            Using parser As New TextFieldParser(path)
                parser.TextFieldType = FieldType.Delimited
                parser.SetDelimiters(";")

                While Not parser.EndOfData
                    Dim currentLine As String = parser.ReadLine()
                    Dim fields As String() = currentLine.Split(";")
                    Dim completelist As New List(Of String)(fields)

                    If fields.Length >= 2 AndAlso fields(0) = TextBox3.Text AndAlso fields(1) = TextBox2.Text Then
                        clientFound = True
                        MsgBox("Client chargé avec succès !", MsgBoxStyle.Information)
                        TextBox1.Text = fields(0) + " " + fields(1)
                        Label4.Text = fields(2)
                        Button4.Enabled = True
                        Button6.Enabled = True

                        Dim today As String = DateTime.Now.ToString("MM")
                        Dim anniv As String() = fields(3).Split("/")
                        Dim annivfait As Boolean = False

                        If File.Exists("C:\\Users\\Public\\anniv.txt") Then
                            Using out As IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\\Users\\Public\\anniv.txt")
                                While Not out.EndOfStream
                                    Dim line As String = out.ReadLine()
                                    If line.ToLower.Equals(TextBox1.Text.ToLower) Then
                                        annivfait = True
                                        Exit While
                                    End If
                                End While
                            End Using
                        End If

                        If Not annivfait AndAlso anniv(1) = today Then
                            MsgBox("C'est le mois anniversaire de ce client, ses points sont doublés et il gagne un coupon anniversaire", MsgBoxStyle.OkOnly, "Anniversaire")
                            fields(2) = (CInt(fields(2)) * 2).ToString()
                            Label4.Text = fields(2)
                            completelist(2) = fields(2)
                            completelist.Add("Bon Anniversaire")

                            Using outw As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("C:\\Users\\Public\\anniv.txt", True)
                                outw.WriteLine(TextBox1.Text)
                            End Using
                        End If
                    End If

                    currentLine = String.Join(";", completelist)
                    lines.Add(currentLine)
                End While
            End Using
            If Not clientfound Then
                MsgBox("Client non trouvé !", MsgBoxStyle.Critical, "Erreur")
            Else
                Using out As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(path, False)
                    For Each line In lines
                        out.WriteLine(line)
                    Next
                End Using
            End If
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form4.Show()
    End Sub
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim strprint As String
        Dim name As String()
        name = TextBox1.Text.Split(" ")
        strprint = "Bilan compte fidélité de " & name(0).ToUpper & " " & name(1) & vbCrLf
        strprint = strprint & "------------------------------" & vbCrLf
        Dim currentDate As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm")
        strprint = strprint & "En date du: " & currentDate & vbCrLf
        strprint = strprint & "Solde: " & Label4.Text & vbCrLf
        strprint = strprint & "------------------------------" & vbCrLf

        Dim port As New SerialPort("COM2", 9600, Parity.None, 8, StopBits.One)

        Try
            port.Open()
            port.WriteLine(strprint) ' Envoyer le texte formaté à l'imprimante
            port.Close()
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message)
        End Try
    End Sub
    Private Sub CouponPrint(valeur As Integer)
        Dim strprint As String
        Dim name As String()
        name = TextBox1.Text.Split(" ")
        strprint = "Gain d'un coupon de réduction !" & vbCrLf
        strprint = strprint & "-----------------------------------------------------" & vbCrLf
        Dim currentDate As DateTime = DateTime.Now
        Dim futureDate As DateTime = currentDate.AddMonths(3).Date
        Dim formattedDate As String = futureDate.ToString("dd/MM/yyyy")
        strprint = strprint & "Titulaire: " & name(0).ToUpper & " " & name(1) & vbCrLf
        strprint = strprint & "En date du: " & currentDate & vbCrLf
        strprint = strprint & "Valeur du Coupon: " & valeur.ToString & "€" & vbCrLf
        strprint = strprint & "" & vbCrLf
        strprint = strprint & "Attention ! Votre coupon est valable jusqu'au " & futureDate & vbCrLf
        strprint = strprint & "-----------------------------------------------------" & vbCrLf

        Dim port As New SerialPort("COM2", 9600, Parity.None, 8, StopBits.One)

        Try
            port.Open()
            port.WriteLine(strprint) ' Envoyer le texte formaté à l'imprimante
            port.Close()
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message)
        End Try

    End Sub
End Class