Imports Microsoft.VisualBasic.FileIO

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 82
        DataGridView1.Size = New Size(876, 608)
        DataGridView1.TabIndex = 0
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 32.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(901, 626)
        Controls.Add(DataGridView1)
        Name = "Form3"
        Text = "Form3"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path = "C:\\Users\\hisla\\Documents\\clients.csv"
        Dim dt As New DataTable
        dt.Columns.Add("Nom")
        dt.Columns.Add("Prénom")
        ' Lire le fichier CSV
        Using parser As New TextFieldParser(path)
            parser.TextFieldType = FieldType.Delimited
            parser.SetDelimiters(";")
            ' Parcourir les lignes du fichier
            While Not parser.EndOfData
                Dim fields = parser.ReadFields

                ' Ajouter la ligne au DataTable
                If fields.Length >= 2 Then
                    dt.Rows.Add(fields(0), fields(1))
                End If
            End While
        End Using

        ' Affecter les données au DataGridView
        DataGridView1.DataSource = dt
    End Sub
End Class
