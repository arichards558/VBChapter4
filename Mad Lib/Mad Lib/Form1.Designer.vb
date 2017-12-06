<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstColor = New System.Windows.Forms.ListBox()
        Me.lstEST = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstNumber = New System.Windows.Forms.ListBox()
        Me.lstBodyParts = New System.Windows.Forms.ListBox()
        Me.lstAnimals = New System.Windows.Forms.ListBox()
        Me.lstPlural = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstNoun = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstColor
        '
        Me.lstColor.FormattingEnabled = True
        Me.lstColor.Items.AddRange(New Object() {"Red", "Blue", "Yellow", "Maroon", "Pink", "Silver"})
        Me.lstColor.Location = New System.Drawing.Point(12, 50)
        Me.lstColor.Name = "lstColor"
        Me.lstColor.Size = New System.Drawing.Size(120, 95)
        Me.lstColor.TabIndex = 0
        '
        'lstEST
        '
        Me.lstEST.FormattingEnabled = True
        Me.lstEST.Items.AddRange(New Object() {"biggest", "smallest", "fattest", "fastest", "largest", "blackest", "whitest ", "skinniest", ""})
        Me.lstEST.Location = New System.Drawing.Point(187, 50)
        Me.lstEST.Name = "lstEST"
        Me.lstEST.Size = New System.Drawing.Size(120, 95)
        Me.lstEST.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Color"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Words Ending in est"
        '
        'lstNumber
        '
        Me.lstNumber.FormattingEnabled = True
        Me.lstNumber.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "100", "200", "69", "96"})
        Me.lstNumber.Location = New System.Drawing.Point(401, 50)
        Me.lstNumber.Name = "lstNumber"
        Me.lstNumber.Size = New System.Drawing.Size(120, 95)
        Me.lstNumber.TabIndex = 4
        '
        'lstBodyParts
        '
        Me.lstBodyParts.FormattingEnabled = True
        Me.lstBodyParts.Items.AddRange(New Object() {"arms", "legs", "buttcheeks", "fingers", "heads", "toes", "belly buttons", "kneecaps", "hips", "heels", "shoulders", "elbows"})
        Me.lstBodyParts.Location = New System.Drawing.Point(12, 207)
        Me.lstBodyParts.Name = "lstBodyParts"
        Me.lstBodyParts.Size = New System.Drawing.Size(120, 95)
        Me.lstBodyParts.TabIndex = 5
        '
        'lstAnimals
        '
        Me.lstAnimals.FormattingEnabled = True
        Me.lstAnimals.Items.AddRange(New Object() {"gorilla", "monkey", "cat ", "dog", "zebra", "dragon", "drake", "pig", "cow", "hippo", "walrus", "seal", "eagle"})
        Me.lstAnimals.Location = New System.Drawing.Point(190, 207)
        Me.lstAnimals.Name = "lstAnimals"
        Me.lstAnimals.Size = New System.Drawing.Size(120, 95)
        Me.lstAnimals.TabIndex = 6
        '
        'lstPlural
        '
        Me.lstPlural.FormattingEnabled = True
        Me.lstPlural.Items.AddRange(New Object() {"desks", "geese", "crayons", "markers", "computers", "people", "lions", "panthers", "spiders", "rainforests"})
        Me.lstPlural.Location = New System.Drawing.Point(12, 348)
        Me.lstPlural.Name = "lstPlural"
        Me.lstPlural.Size = New System.Drawing.Size(120, 95)
        Me.lstPlural.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(401, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Number"
        '
        'lstNoun
        '
        Me.lstNoun.FormattingEnabled = True
        Me.lstNoun.Items.AddRange(New Object() {"box", "sqaure", "gumball", "triangle", "rectangle", "keyboard", "monitor", "tower", "motherboard", "random acess memory", "knot", "tree stump" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.lstNoun.Location = New System.Drawing.Point(401, 207)
        Me.lstNoun.Name = "lstNoun"
        Me.lstNoun.Size = New System.Drawing.Size(120, 95)
        Me.lstNoun.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Body Parts"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(190, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Animals"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(401, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Noun"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Plural Noun"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(190, 348)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 15
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 453)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstNoun)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstPlural)
        Me.Controls.Add(Me.lstAnimals)
        Me.Controls.Add(Me.lstBodyParts)
        Me.Controls.Add(Me.lstNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstEST)
        Me.Controls.Add(Me.lstColor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstColor As System.Windows.Forms.ListBox
    Friend WithEvents lstEST As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstNumber As System.Windows.Forms.ListBox
    Friend WithEvents lstBodyParts As System.Windows.Forms.ListBox
    Friend WithEvents lstAnimals As System.Windows.Forms.ListBox
    Friend WithEvents lstPlural As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstNoun As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button

End Class
