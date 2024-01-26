Imports Microsoft.VisualBasic.FileIO

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text.Length = 0 Or TextBox2.Text.Length = 0) Then
            MsgBox("Vous ne pouvez pas enregister un client vierge", MsgBoxStyle.Critical)
        Else
            Dim path As String = "C:\\Users\\Public\\clients.csv"
            If TextBox3.Text = "" Then
                TextBox3.Text = "example@dn.fr"
            End If
            If String.IsNullOrWhiteSpace(MaskedTextBox2.Text) Then
                MaskedTextBox2.Text = "00 00 00 00 00"
            End If
            If TextBox4.Text = "" Then
                TextBox4.Text = "Pas d'adresse"
            End If
            If Dir(path) <> "" Then
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
                    If (CheckBox1.Checked = True) Then
                        out.WriteLine(TextBox1.Text + ";" + TextBox2.Text + ";0" + ";" + MaskedTextBox1.Text + ";" + MaskedTextBox2.Text + ";" + TextBox3.Text + ";" + TextBox4.Text)
                    Else
                        out.WriteLine(TextBox1.Text + ";" + TextBox2.Text + ";0;00/00/0000;" + MaskedTextBox2.Text + ";" + TextBox3.Text + ";" + TextBox4.Text)
                    End If
                    out.Close()
                    MsgBox("Client enregistré avec succès !", MsgBoxStyle.Information)
                    Form1.Show()
                    Me.Close()
                End If
            Else
                Dim out As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(path, True)
                If (CheckBox1.Checked = True) Then
                    out.WriteLine(TextBox1.Text + ";" + TextBox2.Text + ";0" + ";" + MaskedTextBox1.Text + ";" + MaskedTextBox2.Text + ";" + TextBox3.Text + ";" + TextBox4.Text)
                Else
                    out.WriteLine(TextBox1.Text + ";" + TextBox2.Text + ";0;00/00/0000;" + MaskedTextBox2.Text + ";" + TextBox3.Text + ";" + TextBox4.Text)
                End If
                out.Close()
                MsgBox("Client enregistré avec succès !", MsgBoxStyle.Information)
                Form1.Show()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        MaskedTextBox1.Enabled = Not MaskedTextBox1.Enabled
    End Sub
End Class