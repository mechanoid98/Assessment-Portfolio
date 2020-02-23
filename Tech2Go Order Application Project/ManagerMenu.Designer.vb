<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerMenu
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
        Me.btnChangeOffers = New System.Windows.Forms.Button()
        Me.btnNewEmployee = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnNewDriver = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnNewProduct = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnChangeOffers
        '
        Me.btnChangeOffers.Location = New System.Drawing.Point(252, 35)
        Me.btnChangeOffers.Name = "btnChangeOffers"
        Me.btnChangeOffers.Size = New System.Drawing.Size(109, 42)
        Me.btnChangeOffers.TabIndex = 0
        Me.btnChangeOffers.Text = "Change Offers"
        Me.btnChangeOffers.UseVisualStyleBackColor = True
        '
        'btnNewEmployee
        '
        Me.btnNewEmployee.Location = New System.Drawing.Point(127, 35)
        Me.btnNewEmployee.Name = "btnNewEmployee"
        Me.btnNewEmployee.Size = New System.Drawing.Size(119, 42)
        Me.btnNewEmployee.TabIndex = 1
        Me.btnNewEmployee.Text = "Enter New Employee"
        Me.btnNewEmployee.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(264, 87)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(88, 34)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnNewDriver
        '
        Me.btnNewDriver.Location = New System.Drawing.Point(127, 83)
        Me.btnNewDriver.Name = "btnNewDriver"
        Me.btnNewDriver.Size = New System.Drawing.Size(119, 42)
        Me.btnNewDriver.TabIndex = 4
        Me.btnNewDriver.Text = "Enter New Driver"
        Me.btnNewDriver.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.Location = New System.Drawing.Point(12, 35)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(109, 42)
        Me.btnBackup.TabIndex = 5
        Me.btnBackup.Text = "Backup Files"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(12, 83)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(109, 42)
        Me.btnImport.TabIndex = 6
        Me.btnImport.Text = "Import Files"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnNewProduct
        '
        Me.btnNewProduct.Location = New System.Drawing.Point(127, 131)
        Me.btnNewProduct.Name = "btnNewProduct"
        Me.btnNewProduct.Size = New System.Drawing.Size(119, 42)
        Me.btnNewProduct.TabIndex = 7
        Me.btnNewProduct.Text = "Enter New Product"
        Me.btnNewProduct.UseVisualStyleBackColor = True
        '
        'ManagerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 180)
        Me.Controls.Add(Me.btnNewProduct)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.btnNewDriver)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnNewEmployee)
        Me.Controls.Add(Me.btnChangeOffers)
        Me.Name = "ManagerMenu"
        Me.Text = "ManagerMenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnChangeOffers As System.Windows.Forms.Button
    Friend WithEvents btnNewEmployee As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnNewDriver As System.Windows.Forms.Button
    Friend WithEvents btnBackup As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents btnNewProduct As Button
End Class
