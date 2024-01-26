<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        GroupBox1 = New GroupBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        MaskedTextBox2 = New MaskedTextBox()
        Label7 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        MaskedTextBox1 = New MaskedTextBox()
        Label4 = New Label()
        CheckBox1 = New CheckBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Button1 = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(47, 9)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(424, 65)
        Label1.TabIndex = 0
        Label1.Text = "Ajouter un client"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(10, 24)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nom :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(56, 24)
        TextBox1.Margin = New Padding(2, 1, 2, 1)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(110, 23)
        TextBox1.TabIndex = 2
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(MaskedTextBox2)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(MaskedTextBox1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(18, 77)
        GroupBox1.Margin = New Padding(2, 1, 2, 1)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2, 1, 2, 1)
        GroupBox1.Size = New Size(503, 113)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Informations"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(299, 74)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(199, 23)
        TextBox4.TabIndex = 19
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(363, 45)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 18
        ' 
        ' MaskedTextBox2
        ' 
        MaskedTextBox2.Location = New Point(382, 16)
        MaskedTextBox2.Mask = "00 00 00 00 00"
        MaskedTextBox2.Name = "MaskedTextBox2"
        MaskedTextBox2.Size = New Size(81, 23)
        MaskedTextBox2.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(240, 77)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 15)
        Label7.TabIndex = 13
        Label7.Text = "Adresse :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(322, 47)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 15)
        Label5.TabIndex = 11
        Label5.Text = "Mail :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(310, 19)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 15)
        Label6.TabIndex = 9
        Label6.Text = "Téléphone :"
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Enabled = False
        MaskedTextBox1.Location = New Point(122, 84)
        MaskedTextBox1.Margin = New Padding(2, 1, 2, 1)
        MaskedTextBox1.Mask = "00/00/0000"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(77, 23)
        MaskedTextBox1.TabIndex = 8
        MaskedTextBox1.TextAlign = HorizontalAlignment.Center
        MaskedTextBox1.ValidatingType = GetType(Date)
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(4, 85)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 15)
        Label4.TabIndex = 7
        Label4.Text = "Date de naissance:"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(202, 87)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(15, 14)
        CheckBox1.TabIndex = 5
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(72, 53)
        TextBox2.Margin = New Padding(2, 1, 2, 1)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(110, 23)
        TextBox2.TabIndex = 4
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(10, 53)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 15)
        Label3.TabIndex = 3
        Label3.Text = "Prénom :"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(198, 210)
        Button1.Margin = New Padding(2, 1, 2, 1)
        Button1.Name = "Button1"
        Button1.Size = New Size(129, 22)
        Button1.TabIndex = 4
        Button1.Text = "Enregistrer le client"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(532, 242)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2, 1, 2, 1)
        MaximizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Nouveau Client"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
