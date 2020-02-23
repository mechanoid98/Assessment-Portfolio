<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewDriverForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnSaveEmp = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDriverPassword = New System.Windows.Forms.TextBox()
        Me.txtDriverUsername = New System.Windows.Forms.TextBox()
        Me.btnGenerateLogin = New System.Windows.Forms.Button()
        Me.FemaleButton = New System.Windows.Forms.RadioButton()
        Me.MaleButton = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDriverSurname = New System.Windows.Forms.TextBox()
        Me.txtDriverFirstName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDriverID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter New Driver Information:"
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(169, 234)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(111, 38)
        Me.btnMainMenu.TabIndex = 33
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnSaveEmp
        '
        Me.btnSaveEmp.Location = New System.Drawing.Point(16, 234)
        Me.btnSaveEmp.Name = "btnSaveEmp"
        Me.btnSaveEmp.Size = New System.Drawing.Size(111, 38)
        Me.btnSaveEmp.TabIndex = 32
        Me.btnSaveEmp.Text = "Save Employee"
        Me.btnSaveEmp.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Username:"
        '
        'txtDriverPassword
        '
        Me.txtDriverPassword.Location = New System.Drawing.Point(89, 208)
        Me.txtDriverPassword.Name = "txtDriverPassword"
        Me.txtDriverPassword.ReadOnly = True
        Me.txtDriverPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtDriverPassword.TabIndex = 29
        '
        'txtDriverUsername
        '
        Me.txtDriverUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtDriverUsername.Location = New System.Drawing.Point(89, 182)
        Me.txtDriverUsername.Name = "txtDriverUsername"
        Me.txtDriverUsername.ReadOnly = True
        Me.txtDriverUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtDriverUsername.TabIndex = 28
        '
        'btnGenerateLogin
        '
        Me.btnGenerateLogin.Location = New System.Drawing.Point(16, 138)
        Me.btnGenerateLogin.Name = "btnGenerateLogin"
        Me.btnGenerateLogin.Size = New System.Drawing.Size(111, 38)
        Me.btnGenerateLogin.TabIndex = 27
        Me.btnGenerateLogin.Text = "Generate Login Details"
        Me.btnGenerateLogin.UseVisualStyleBackColor = True
        '
        'FemaleButton
        '
        Me.FemaleButton.AutoSize = True
        Me.FemaleButton.Location = New System.Drawing.Point(143, 115)
        Me.FemaleButton.Name = "FemaleButton"
        Me.FemaleButton.Size = New System.Drawing.Size(59, 17)
        Me.FemaleButton.TabIndex = 26
        Me.FemaleButton.TabStop = True
        Me.FemaleButton.Text = "Female"
        Me.FemaleButton.UseVisualStyleBackColor = True
        '
        'MaleButton
        '
        Me.MaleButton.AutoSize = True
        Me.MaleButton.Location = New System.Drawing.Point(89, 115)
        Me.MaleButton.Name = "MaleButton"
        Me.MaleButton.Size = New System.Drawing.Size(48, 17)
        Me.MaleButton.TabIndex = 25
        Me.MaleButton.TabStop = True
        Me.MaleButton.Text = "Male"
        Me.MaleButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Gender:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Surname:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "First Name:"
        '
        'txtDriverSurname
        '
        Me.txtDriverSurname.Location = New System.Drawing.Point(89, 86)
        Me.txtDriverSurname.Name = "txtDriverSurname"
        Me.txtDriverSurname.Size = New System.Drawing.Size(100, 20)
        Me.txtDriverSurname.TabIndex = 21
        '
        'txtDriverFirstName
        '
        Me.txtDriverFirstName.Location = New System.Drawing.Point(89, 60)
        Me.txtDriverFirstName.Name = "txtDriverFirstName"
        Me.txtDriverFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtDriverFirstName.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Driver ID:"
        '
        'txtDriverID
        '
        Me.txtDriverID.Enabled = False
        Me.txtDriverID.Location = New System.Drawing.Point(89, 34)
        Me.txtDriverID.Name = "txtDriverID"
        Me.txtDriverID.Size = New System.Drawing.Size(38, 20)
        Me.txtDriverID.TabIndex = 18
        '
        'NewDriverForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 284)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnSaveEmp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDriverPassword)
        Me.Controls.Add(Me.txtDriverUsername)
        Me.Controls.Add(Me.btnGenerateLogin)
        Me.Controls.Add(Me.FemaleButton)
        Me.Controls.Add(Me.MaleButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDriverSurname)
        Me.Controls.Add(Me.txtDriverFirstName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDriverID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NewDriverForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewDriverForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnSaveEmp As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDriverPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtDriverUsername As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerateLogin As System.Windows.Forms.Button
    Friend WithEvents FemaleButton As System.Windows.Forms.RadioButton
    Friend WithEvents MaleButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDriverSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtDriverFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDriverID As System.Windows.Forms.TextBox
End Class
