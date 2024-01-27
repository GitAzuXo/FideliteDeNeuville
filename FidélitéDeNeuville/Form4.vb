Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As String = "C:\\Users\\Public\\clients.csv"
        Dim dt As New DataTable()
        dt.Columns.Add("Nom")
        dt.Columns.Add("Prénom")
        dt.Columns.Add("Points")
        dt.Columns.Add("Date de Naissance")
        dt.Columns.Add("Téléphone")
        dt.Columns.Add("Mail")
        dt.Columns.Add("Adresse")

        ' Lire le fichier CSV
        Using parser As New TextFieldParser(path)
            parser.TextFieldType = FieldType.Delimited
            parser.SetDelimiters(";")

            ' Parcourir les lignes du fichier
            While Not parser.EndOfData
                Dim fields As String() = parser.ReadFields()

                ' Ajouter la ligne au DataTable
                If fields.Length >= 2 Then
                    dt.Rows.Add(fields(0), fields(1), fields(2), fields(3), fields(4), fields(5), fields(6))
                End If
            End While
        End Using

        ' Affecter les données au DataGridView
        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        ' Vérifier si la ligne est valide
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Supposons que la première colonne est le nom et la deuxième est le prénom
            Dim nom As String = Convert.ToString(selectedRow.Cells("Nom").Value)
            Dim prenom As String = Convert.ToString(selectedRow.Cells("Prénom").Value)

            ' Afficher les informations ou faire quelque chose avec elles
            Form1.TextBox3.Text = nom
            Form1.TextBox2.Text = prenom
            Me.Close()
            Form1.Button3_Click(Form1, e)
        End If
    End Sub

    Private Sub SauvegarderDansCSV()
        ' Vérifier si le DataGridView a des données
        Dim path As String = "C:\\Users\\Public\\clients.csv"
        If DataGridView1.Rows.Count > 0 Then
            Using writer As New System.IO.StreamWriter(path, False)
                For Each row As DataGridViewRow In DataGridView1.Rows
                    Dim line As String = String.Join(";", row.Cells.Cast(Of DataGridViewCell).Select(Function(cell) cell.Value))
                    writer.WriteLine(line)
                Next
            End Using
        End If
    End Sub
    Private Sub Form4_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        SauvegarderDansCSV()
    End Sub
End Class