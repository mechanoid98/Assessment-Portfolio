<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewProductForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProdID = New System.Windows.Forms.TextBox()
        Me.btnSaveProd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAmountInStock = New System.Windows.Forms.TextBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProductPriceStart = New System.Windows.Forms.TextBox()
        Me.txtProductPriceEnd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter New Product Information:"
        '
        'txtProdID
        '
        Me.txtProdID.Enabled = False
        Me.txtProdID.Location = New System.Drawing.Point(90, 28)
        Me.txtProdID.Name = "txtProdID"
        Me.txtProdID.Size = New System.Drawing.Size(38, 20)
        Me.txtProdID.TabIndex = 2
        '
        'btnSaveProd
        '
        Me.btnSaveProd.Location = New System.Drawing.Point(12, 135)
        Me.btnSaveProd.Name = "btnSaveProd"
        Me.btnSaveProd.Size = New System.Drawing.Size(111, 38)
        Me.btnSaveProd.TabIndex = 22
        Me.btnSaveProd.Text = "Save Product"
        Me.btnSaveProd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Product Name:"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(90, 54)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(100, 20)
        Me.txtProductName.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Product ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Enter amount in stock:"
        '
        'txtAmountInStock
        '
        Me.txtAmountInStock.Location = New System.Drawing.Point(125, 106)
        Me.txtAmountInStock.Name = "txtAmountInStock"
        Me.txtAmountInStock.Size = New System.Drawing.Size(65, 20)
        Me.txtAmountInStock.TabIndex = 24
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(161, 135)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(111, 38)
        Me.btnMenu.TabIndex = 25
        Me.btnMenu.Text = "Main Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Product Price:"
        '
        'txtProductPriceStart
        '
        Me.txtProductPriceStart.Location = New System.Drawing.Point(106, 80)
        Me.txtProductPriceStart.Name = "txtProductPriceStart"
        Me.txtProductPriceStart.Size = New System.Drawing.Size(33, 20)
        Me.txtProductPriceStart.TabIndex = 27
        '
        'txtProductPriceEnd
        '
        Me.txtProductPriceEnd.Location = New System.Drawing.Point(161, 80)
        Me.txtProductPriceEnd.Name = "txtProductPriceEnd"
        Me.txtProductPriceEnd.Size = New System.Drawing.Size(33, 20)
        Me.txtProductPriceEnd.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(87, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "£"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(145, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "."
        '
        'NewProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 185)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtProductPriceEnd)
        Me.Controls.Add(Me.txtProductPriceStart)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.txtAmountInStock)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSaveProd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProdID)
        Me.Controls.Add(Me.Label2)
        Me.Name = "NewProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewProductForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtProdID As TextBox
    Friend WithEvents btnSaveProd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAmountInStock As TextBox
    Friend WithEvents btnMenu As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProductPriceStart As TextBox
    Friend WithEvents txtProductPriceEnd As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
