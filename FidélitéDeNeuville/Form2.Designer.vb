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
        Label1.Location = New Point(33, 9)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(849, 128)
        Label1.TabIndex = 0
        Label1.Text = "Ajouter un client"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 51)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 32)
        Label2.TabIndex = 1
        Label2.Text = "Nom :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(104, 51)
        TextBox1.Margin = New Padding(4, 2, 4, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(201, 39)
        TextBox1.TabIndex = 2
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(MaskedTextBox1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(33, 164)
        GroupBox1.Margin = New Padding(4, 2, 4, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 2, 4, 2)
        GroupBox1.Size = New Size(418, 242)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Informations"
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Enabled = False
        MaskedTextBox1.Location = New Point(227, 179)
        MaskedTextBox1.Mask = "00/00/0000"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(139, 39)
        MaskedTextBox1.TabIndex = 8
        MaskedTextBox1.TextAlign = HorizontalAlignment.Center
        MaskedTextBox1.ValidatingType = GetType(Date)
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(8, 181)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(212, 32)
        Label4.TabIndex = 7
        Label4.Text = "Date de naissance:"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(375, 186)
        CheckBox1.Margin = New Padding(6)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(28, 27)
        CheckBox1.TabIndex = 5
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(134, 113)
        TextBox2.Margin = New Padding(4, 2, 4, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(201, 39)
        TextBox2.TabIndex = 4
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 113)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 32)
        Label3.TabIndex = 3
        Label3.Text = "Prénom :"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(568, 230)
        Button1.Margin = New Padding(4, 2, 4, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(240, 47)
        Button1.TabIndex = 4
        Button1.Text = "Enregistrer le client"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(912, 448)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 2, 4, 2)
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
End Class
