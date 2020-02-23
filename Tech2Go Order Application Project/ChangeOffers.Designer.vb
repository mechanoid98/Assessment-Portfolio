<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChangeOffers
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchValue = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblProdInfo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbOffers = New System.Windows.Forms.ComboBox()
        Me.btnApplyChanges = New System.Windows.Forms.Button()
        Me.lblNewProductInfo = New System.Windows.Forms.Label()
        Me.btnDisplayChanges = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(16, 86)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Change Offers:"
        '
        'txtSearchValue
        '
        Me.txtSearchValue.Location = New System.Drawing.Point(16, 60)
        Me.txtSearchValue.Name = "txtSearchValue"
        Me.txtSearchValue.Size = New System.Drawing.Size(100, 20)
        Me.txtSearchValue.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter Product ID:"
        '
        'lblProdInfo
        '
        Me.lblProdInfo.AutoSize = True
        Me.lblProdInfo.Location = New System.Drawing.Point(12, 112)
        Me.lblProdInfo.Name = "lblProdInfo"
        Me.lblProdInfo.Size = New System.Drawing.Size(78, 26)
        Me.lblProdInfo.TabIndex = 5
        Me.lblProdInfo.Text = "Product Name:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Product Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Select offer (%):"
        '
        'cmbOffers
        '
        Me.cmbOffers.FormattingEnabled = True
        Me.cmbOffers.Items.AddRange(New Object() {"5", "10", "20", "30", "40", "50", "60"})
        Me.cmbOffers.Location = New System.Drawing.Point(16, 167)
        Me.cmbOffers.Name = "cmbOffers"
        Me.cmbOffers.Size = New System.Drawing.Size(121, 21)
        Me.cmbOffers.TabIndex = 7
        Me.cmbOffers.Text = "Select an offer..."
        '
        'btnApplyChanges
        '
        Me.btnApplyChanges.Location = New System.Drawing.Point(15, 258)
        Me.btnApplyChanges.Name = "btnApplyChanges"
        Me.btnApplyChanges.Size = New System.Drawing.Size(75, 23)
        Me.btnApplyChanges.TabIndex = 8
        Me.btnApplyChanges.Text = "Apply offer"
        Me.btnApplyChanges.UseVisualStyleBackColor = True
        '
        'lblNewProductInfo
        '
        Me.lblNewProductInfo.AutoSize = True
        Me.lblNewProductInfo.Location = New System.Drawing.Point(13, 220)
        Me.lblNewProductInfo.Name = "lblNewProductInfo"
        Me.lblNewProductInfo.Size = New System.Drawing.Size(99, 26)
        Me.lblNewProductInfo.TabIndex = 9
        Me.lblNewProductInfo.Text = "Product Name:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "New Product Price:"
        '
        'btnDisplayChanges
        '
        Me.btnDisplayChanges.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayChanges.Location = New System.Drawing.Point(16, 194)
        Me.btnDisplayChanges.Name = "btnDisplayChanges"
        Me.btnDisplayChanges.Size = New System.Drawing.Size(86, 23)
        Me.btnDisplayChanges.TabIndex = 10
        Me.btnDisplayChanges.Text = "Display Changes"
        Me.btnDisplayChanges.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(171, 258)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMainMenu.TabIndex = 11
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'ChangeOffers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 293)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnDisplayChanges)
        Me.Controls.Add(Me.lblNewProductInfo)
        Me.Controls.Add(Me.btnApplyChanges)
        Me.Controls.Add(Me.cmbOffers)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblProdInfo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearchValue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "ChangeOffers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Offers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearchValue As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblProdInfo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbOffers As ComboBox
    Friend WithEvents btnApplyChanges As Button
    Friend WithEvents lblNewProductInfo As Label
    Friend WithEvents btnDisplayChanges As Button
    Friend WithEvents btnMainMenu As Button
End Class
