Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = LoadData()
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
    Private Sub FilterData(searchString As String, dt As DataTable)
        If String.IsNullOrEmpty(searchString) Then
            DataGridView1.DataSource = LoadData()
        Else
            Dim filteredData As New DataTable()
            filteredData = LoadData.Clone()

            For Each row As DataRow In dt.Rows
                If row("Nom").ToString().ToLower().Contains(searchString.ToLower()) OrElse row("Prénom").ToString().ToLower().Contains(searchString.ToLower()) Then
                    filteredData.ImportRow(row)
                End If
            Next

            DataGridView1.DataSource = filteredData
        End If
    End Sub
    Private Function LoadData() As DataTable
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
        Return dt
    End Function
    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        FilterData(TextBox1.Text, LoadData)
    End Sub
End Class