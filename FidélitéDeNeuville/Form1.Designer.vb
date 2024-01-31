<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        GroupBox1 = New GroupBox()
        Button6 = New Button()
        Button4 = New Button()
        Label7 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        GroupBox2 = New GroupBox()
        Button5 = New Button()
        Button3 = New Button()
        TextBox2 = New TextBox()
        Label5 = New Label()
        TextBox3 = New TextBox()
        Label6 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 25.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(138, 9)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(636, 92)
        Label1.TabIndex = 0
        Label1.Text = "Programme Fidélité"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(9, 73)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 32)
        Label2.TabIndex = 1
        Label2.Text = "Informations:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(9, 139)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 32)
        Label3.TabIndex = 2
        Label3.Text = "Points:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(176, 480)
        Button1.Margin = New Padding(4, 2, 4, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(223, 47)
        Button1.TabIndex = 3
        Button1.Text = "Nouveau Client"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(509, 480)
        Button2.Margin = New Padding(4, 2, 4, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(150, 47)
        Button2.TabIndex = 4
        Button2.Text = "Achat"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button6)
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(69, 158)
        GroupBox1.Margin = New Padding(6)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(6)
        GroupBox1.Size = New Size(371, 314)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Client chargé"
        ' 
        ' Button6
        ' 
        Button6.Enabled = False
        Button6.Location = New Point(107, 259)
        Button6.Name = "Button6"
        Button6.Size = New Size(150, 46)
        Button6.TabIndex = 9
        Button6.Text = "Ticket"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Enabled = False
        Button4.Location = New Point(131, 197)
        Button4.Name = "Button4"
        Button4.Size = New Size(92, 46)
        Button4.TabIndex = 8
        Button4.Text = "Voir"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(10, 204)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(114, 32)
        Label7.TabIndex = 7
        Label7.Text = "Coupons:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(91, 128)
        Label4.Margin = New Padding(6, 0, 6, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 51)
        Label4.TabIndex = 6
        Label4.Text = "X"
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Location = New Point(163, 66)
        TextBox1.Margin = New Padding(6)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(182, 39)
        TextBox1.TabIndex = 6
        TextBox1.Text = "Aucun"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button5)
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(TextBox3)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Location = New Point(494, 115)
        GroupBox2.Margin = New Padding(6)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(6)
        GroupBox2.Size = New Size(371, 256)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "Recherche"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(190, 196)
        Button5.Name = "Button5"
        Button5.Size = New Size(150, 46)
        Button5.TabIndex = 7
        Button5.Text = "Fichier"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(42, 195)
        Button3.Margin = New Padding(6)
        Button3.Name = "Button3"
        Button3.Size = New Size(139, 49)
        Button3.TabIndex = 9
        Button3.Text = "Rechercher"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(130, 124)
        TextBox2.Margin = New Padding(4, 2, 4, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(201, 39)
        TextBox2.TabIndex = 8
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(15, 124)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(109, 32)
        Label5.TabIndex = 7
        Label5.Text = "Prénom :"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(100, 62)
        TextBox3.Margin = New Padding(4, 2, 4, 2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(201, 39)
        TextBox3.TabIndex = 6
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 62)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 32)
        Label6.TabIndex = 5
        Label6.Text = "Nom :"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(919, 572)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 2, 4, 2)
        MaximizeBox = False
        Name = "Form1"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "MyFidelity"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button

End Class
