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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radBigButt = New System.Windows.Forms.RadioButton()
        Me.radCCCC = New System.Windows.Forms.RadioButton()
        Me.radQueso = New System.Windows.Forms.RadioButton()
        Me.radBYOB = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkFries = New System.Windows.Forms.CheckBox()
        Me.chkSpinach = New System.Windows.Forms.CheckBox()
        Me.chkCurds = New System.Windows.Forms.CheckBox()
        Me.chkMexicano = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radBacon = New System.Windows.Forms.RadioButton()
        Me.radOnions = New System.Windows.Forms.RadioButton()
        Me.radEXPatty = New System.Windows.Forms.RadioButton()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radBYOB)
        Me.GroupBox1.Controls.Add(Me.radQueso)
        Me.GroupBox1.Controls.Add(Me.radCCCC)
        Me.GroupBox1.Controls.Add(Me.radBigButt)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 244)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Your Meal"
        '
        'radBigButt
        '
        Me.radBigButt.AutoSize = True
        Me.radBigButt.Location = New System.Drawing.Point(44, 52)
        Me.radBigButt.Name = "radBigButt"
        Me.radBigButt.Size = New System.Drawing.Size(175, 17)
        Me.radBigButt.TabIndex = 0
        Me.radBigButt.TabStop = True
        Me.radBigButt.Text = " I like Big Buns and I cannot Lie"
        Me.radBigButt.UseVisualStyleBackColor = True
        '
        'radCCCC
        '
        Me.radCCCC.AutoSize = True
        Me.radCCCC.Location = New System.Drawing.Point(44, 94)
        Me.radCCCC.Name = "radCCCC"
        Me.radCCCC.Size = New System.Drawing.Size(159, 17)
        Me.radCCCC.TabIndex = 1
        Me.radCCCC.TabStop = True
        Me.radCCCC.Text = "Crispy Chicken Cheese Curd"
        Me.radCCCC.UseVisualStyleBackColor = True
        '
        'radQueso
        '
        Me.radQueso.AutoSize = True
        Me.radQueso.Location = New System.Drawing.Point(44, 144)
        Me.radQueso.Name = "radQueso"
        Me.radQueso.Size = New System.Drawing.Size(108, 17)
        Me.radQueso.TabIndex = 2
        Me.radQueso.TabStop = True
        Me.radQueso.Text = "Quesadilla Burger"
        Me.radQueso.UseVisualStyleBackColor = True
        '
        'radBYOB
        '
        Me.radBYOB.AutoSize = True
        Me.radBYOB.Location = New System.Drawing.Point(44, 186)
        Me.radBYOB.Name = "radBYOB"
        Me.radBYOB.Size = New System.Drawing.Size(57, 17)
        Me.radBYOB.TabIndex = 3
        Me.radBYOB.TabStop = True
        Me.radBYOB.Text = "BYOB "
        Me.radBYOB.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkMexicano)
        Me.GroupBox2.Controls.Add(Me.chkCurds)
        Me.GroupBox2.Controls.Add(Me.chkSpinach)
        Me.GroupBox2.Controls.Add(Me.chkFries)
        Me.GroupBox2.Location = New System.Drawing.Point(378, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 244)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Topping"
        '
        'chkFries
        '
        Me.chkFries.AutoSize = True
        Me.chkFries.Location = New System.Drawing.Point(21, 74)
        Me.chkFries.Name = "chkFries"
        Me.chkFries.Size = New System.Drawing.Size(48, 17)
        Me.chkFries.TabIndex = 0
        Me.chkFries.Text = "Fries"
        Me.chkFries.UseVisualStyleBackColor = True
        '
        'chkSpinach
        '
        Me.chkSpinach.AutoSize = True
        Me.chkSpinach.Location = New System.Drawing.Point(21, 121)
        Me.chkSpinach.Name = "chkSpinach"
        Me.chkSpinach.Size = New System.Drawing.Size(65, 17)
        Me.chkSpinach.TabIndex = 1
        Me.chkSpinach.Text = "Spinach"
        Me.chkSpinach.UseVisualStyleBackColor = True
        '
        'chkCurds
        '
        Me.chkCurds.AutoSize = True
        Me.chkCurds.Location = New System.Drawing.Point(21, 170)
        Me.chkCurds.Name = "chkCurds"
        Me.chkCurds.Size = New System.Drawing.Size(92, 17)
        Me.chkCurds.TabIndex = 2
        Me.chkCurds.Text = "Cheese Curds"
        Me.chkCurds.UseVisualStyleBackColor = True
        '
        'chkMexicano
        '
        Me.chkMexicano.AutoSize = True
        Me.chkMexicano.Location = New System.Drawing.Point(21, 221)
        Me.chkMexicano.Name = "chkMexicano"
        Me.chkMexicano.Size = New System.Drawing.Size(69, 17)
        Me.chkMexicano.TabIndex = 3
        Me.chkMexicano.Text = "Jalepeno"
        Me.chkMexicano.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radEXPatty)
        Me.GroupBox3.Controls.Add(Me.radOnions)
        Me.GroupBox3.Controls.Add(Me.radBacon)
        Me.GroupBox3.Location = New System.Drawing.Point(628, 177)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(205, 111)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Side Orders"
        '
        'radBacon
        '
        Me.radBacon.AutoSize = True
        Me.radBacon.Location = New System.Drawing.Point(7, 31)
        Me.radBacon.Name = "radBacon"
        Me.radBacon.Size = New System.Drawing.Size(56, 17)
        Me.radBacon.TabIndex = 0
        Me.radBacon.TabStop = True
        Me.radBacon.Text = "Bacon"
        Me.radBacon.UseVisualStyleBackColor = True
        '
        'radOnions
        '
        Me.radOnions.AutoSize = True
        Me.radOnions.Location = New System.Drawing.Point(7, 55)
        Me.radOnions.Name = "radOnions"
        Me.radOnions.Size = New System.Drawing.Size(58, 17)
        Me.radOnions.TabIndex = 1
        Me.radOnions.TabStop = True
        Me.radOnions.Text = "Onions"
        Me.radOnions.UseVisualStyleBackColor = True
        '
        'radEXPatty
        '
        Me.radEXPatty.AutoSize = True
        Me.radEXPatty.Location = New System.Drawing.Point(7, 79)
        Me.radEXPatty.Name = "radEXPatty"
        Me.radEXPatty.Size = New System.Drawing.Size(76, 17)
        Me.radEXPatty.TabIndex = 2
        Me.radEXPatty.TabStop = True
        Me.radEXPatty.Text = "Extra Patty"
        Me.radEXPatty.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(46, 327)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(333, 102)
        Me.lblResult.TabIndex = 3
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(415, 405)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(628, 404)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(877, 405)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 448)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radBYOB As System.Windows.Forms.RadioButton
    Friend WithEvents radQueso As System.Windows.Forms.RadioButton
    Friend WithEvents radCCCC As System.Windows.Forms.RadioButton
    Friend WithEvents radBigButt As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkMexicano As System.Windows.Forms.CheckBox
    Friend WithEvents chkCurds As System.Windows.Forms.CheckBox
    Friend WithEvents chkSpinach As System.Windows.Forms.CheckBox
    Friend WithEvents chkFries As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radEXPatty As System.Windows.Forms.RadioButton
    Friend WithEvents radOnions As System.Windows.Forms.RadioButton
    Friend WithEvents radBacon As System.Windows.Forms.RadioButton
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
