<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewEmployeeForm
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
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmpFirstName = New System.Windows.Forms.TextBox()
        Me.txtEmpSurname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MaleButton = New System.Windows.Forms.RadioButton()
        Me.FemaleButton = New System.Windows.Forms.RadioButton()
        Me.btnGenerateLogin = New System.Windows.Forms.Button()
        Me.txtEmpUsername = New System.Windows.Forms.TextBox()
        Me.txtEmpPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSaveEmp = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter New Employee Information:"
        '
        'txtEmpID
        '
        Me.txtEmpID.Enabled = False
        Me.txtEmpID.Location = New System.Drawing.Point(88, 38)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(38, 20)
        Me.txtEmpID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Employee ID:"
        '
        'txtEmpFirstName
        '
        Me.txtEmpFirstName.Location = New System.Drawing.Point(88, 64)
        Me.txtEmpFirstName.Name = "txtEmpFirstName"
        Me.txtEmpFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtEmpFirstName.TabIndex = 3
        '
        'txtEmpSurname
        '
        Me.txtEmpSurname.Location = New System.Drawing.Point(88, 90)
        Me.txtEmpSurname.Name = "txtEmpSurname"
        Me.txtEmpSurname.Size = New System.Drawing.Size(100, 20)
        Me.txtEmpSurname.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "First Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Surname:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Gender:"
        '
        'MaleButton
        '
        Me.MaleButton.AutoSize = True
        Me.MaleButton.Location = New System.Drawing.Point(88, 119)
        Me.MaleButton.Name = "MaleButton"
        Me.MaleButton.Size = New System.Drawing.Size(48, 17)
        Me.MaleButton.TabIndex = 9
        Me.MaleButton.TabStop = True
        Me.MaleButton.Text = "Male"
        Me.MaleButton.UseVisualStyleBackColor = True
        '
        'FemaleButton
        '
        Me.FemaleButton.AutoSize = True
        Me.FemaleButton.Location = New System.Drawing.Point(142, 119)
        Me.FemaleButton.Name = "FemaleButton"
        Me.FemaleButton.Size = New System.Drawing.Size(59, 17)
        Me.FemaleButton.TabIndex = 10
        Me.FemaleButton.TabStop = True
        Me.FemaleButton.Text = "Female"
        Me.FemaleButton.UseVisualStyleBackColor = True
        '
        'btnGenerateLogin
        '
        Me.btnGenerateLogin.Location = New System.Drawing.Point(15, 142)
        Me.btnGenerateLogin.Name = "btnGenerateLogin"
        Me.btnGenerateLogin.Size = New System.Drawing.Size(111, 38)
        Me.btnGenerateLogin.TabIndex = 11
        Me.btnGenerateLogin.Text = "Generate Login Details"
        Me.btnGenerateLogin.UseVisualStyleBackColor = True
        '
        'txtEmpUsername
        '
        Me.txtEmpUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmpUsername.Location = New System.Drawing.Point(88, 186)
        Me.txtEmpUsername.Name = "txtEmpUsername"
        Me.txtEmpUsername.ReadOnly = True
        Me.txtEmpUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtEmpUsername.TabIndex = 12
        '
        'txtEmpPassword
        '
        Me.txtEmpPassword.Location = New System.Drawing.Point(88, 212)
        Me.txtEmpPassword.Name = "txtEmpPassword"
        Me.txtEmpPassword.ReadOnly = True
        Me.txtEmpPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtEmpPassword.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Username:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Password:"
        '
        'btnSaveEmp
        '
        Me.btnSaveEmp.Location = New System.Drawing.Point(15, 238)
        Me.btnSaveEmp.Name = "btnSaveEmp"
        Me.btnSaveEmp.Size = New System.Drawing.Size(111, 38)
        Me.btnSaveEmp.TabIndex = 16
        Me.btnSaveEmp.Text = "Save Employee"
        Me.btnSaveEmp.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(168, 238)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(111, 38)
        Me.btnMainMenu.TabIndex = 17
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'NewEmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 291)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnSaveEmp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEmpPassword)
        Me.Controls.Add(Me.txtEmpUsername)
        Me.Controls.Add(Me.btnGenerateLogin)
        Me.Controls.Add(Me.FemaleButton)
        Me.Controls.Add(Me.MaleButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmpSurname)
        Me.Controls.Add(Me.txtEmpFirstName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmpID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NewEmployeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewEmployeeForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEmpFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MaleButton As System.Windows.Forms.RadioButton
    Friend WithEvents FemaleButton As System.Windows.Forms.RadioButton
    Friend WithEvents btnGenerateLogin As System.Windows.Forms.Button
    Friend WithEvents txtEmpUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSaveEmp As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
End Class
