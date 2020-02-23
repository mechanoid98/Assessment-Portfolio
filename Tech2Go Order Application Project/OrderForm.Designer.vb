<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderForm
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnRequestStock = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblProductInfo = New System.Windows.Forms.Label()
        Me.txtProductNum = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.VATButton = New System.Windows.Forms.CheckBox()
        Me.lstNumofProds = New System.Windows.Forms.ListBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTotalGrossPrice = New System.Windows.Forms.TextBox()
        Me.txtTotalNetPrice = New System.Windows.Forms.TextBox()
        Me.lstProductNames = New System.Windows.Forms.ListBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNumofItems = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnAddtoOrder = New System.Windows.Forms.Button()
        Me.lstProdNums = New System.Windows.Forms.ListBox()
        Me.btFindProd = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtProductNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOrderNo = New System.Windows.Forms.TextBox()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtMobTelNo = New System.Windows.Forms.TextBox()
        Me.txtHomeTelNo = New System.Windows.Forms.TextBox()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.txtTown = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCustNo = New System.Windows.Forms.TextBox()
        Me.OrderFormTab = New System.Windows.Forms.TabControl()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.OrderFormTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnRequestStock)
        Me.TabPage2.Controls.Add(Me.btnSearch)
        Me.TabPage2.Controls.Add(Me.lblProductInfo)
        Me.TabPage2.Controls.Add(Me.txtProductNum)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(845, 413)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Stock Checker"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnRequestStock
        '
        Me.btnRequestStock.Location = New System.Drawing.Point(164, 178)
        Me.btnRequestStock.Name = "btnRequestStock"
        Me.btnRequestStock.Size = New System.Drawing.Size(87, 23)
        Me.btnRequestStock.TabIndex = 4
        Me.btnRequestStock.Text = "RequestStock"
        Me.btnRequestStock.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(11, 178)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblProductInfo
        '
        Me.lblProductInfo.AutoSize = True
        Me.lblProductInfo.Location = New System.Drawing.Point(8, 64)
        Me.lblProductInfo.Name = "lblProductInfo"
        Me.lblProductInfo.Size = New System.Drawing.Size(10, 13)
        Me.lblProductInfo.TabIndex = 2
        Me.lblProductInfo.Text = "."
        '
        'txtProductNum
        '
        Me.txtProductNum.Location = New System.Drawing.Point(129, 19)
        Me.txtProductNum.Name = "txtProductNum"
        Me.txtProductNum.Size = New System.Drawing.Size(122, 20)
        Me.txtProductNum.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Enter Product Number:"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.VATButton)
        Me.TabPage1.Controls.Add(Me.lstNumofProds)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.txtTotalGrossPrice)
        Me.TabPage1.Controls.Add(Me.txtTotalNetPrice)
        Me.TabPage1.Controls.Add(Me.lstProductNames)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.txtNumofItems)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txtProductName)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.btnAddtoOrder)
        Me.TabPage1.Controls.Add(Me.lstProdNums)
        Me.TabPage1.Controls.Add(Me.btFindProd)
        Me.TabPage1.Controls.Add(Me.btnMainMenu)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txtProductNo)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtOrderNo)
        Me.TabPage1.Controls.Add(Me.txtEmployeeID)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.txtMobTelNo)
        Me.TabPage1.Controls.Add(Me.txtHomeTelNo)
        Me.TabPage1.Controls.Add(Me.txtPostcode)
        Me.TabPage1.Controls.Add(Me.txtTown)
        Me.TabPage1.Controls.Add(Me.txtAddress)
        Me.TabPage1.Controls.Add(Me.txtSurname)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtFirstName)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtCustNo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(845, 413)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Order Form"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'VATButton
        '
        Me.VATButton.AutoSize = True
        Me.VATButton.Location = New System.Drawing.Point(655, 360)
        Me.VATButton.Name = "VATButton"
        Me.VATButton.Size = New System.Drawing.Size(76, 17)
        Me.VATButton.TabIndex = 49
        Me.VATButton.Text = "VAT (20%)"
        Me.VATButton.UseVisualStyleBackColor = True
        '
        'lstNumofProds
        '
        Me.lstNumofProds.FormattingEnabled = True
        Me.lstNumofProds.Location = New System.Drawing.Point(685, 17)
        Me.lstNumofProds.Name = "lstNumofProds"
        Me.lstNumofProds.Size = New System.Drawing.Size(136, 277)
        Me.lstNumofProds.TabIndex = 48
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(615, 386)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 13)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "Gross Price:"
        '
        'txtTotalGrossPrice
        '
        Me.txtTotalGrossPrice.Enabled = False
        Me.txtTotalGrossPrice.Location = New System.Drawing.Point(685, 383)
        Me.txtTotalGrossPrice.Name = "txtTotalGrossPrice"
        Me.txtTotalGrossPrice.ReadOnly = True
        Me.txtTotalGrossPrice.Size = New System.Drawing.Size(46, 20)
        Me.txtTotalGrossPrice.TabIndex = 45
        Me.txtTotalGrossPrice.Text = "0.00"
        '
        'txtTotalNetPrice
        '
        Me.txtTotalNetPrice.Enabled = False
        Me.txtTotalNetPrice.Location = New System.Drawing.Point(685, 335)
        Me.txtTotalNetPrice.Name = "txtTotalNetPrice"
        Me.txtTotalNetPrice.ReadOnly = True
        Me.txtTotalNetPrice.Size = New System.Drawing.Size(46, 20)
        Me.txtTotalNetPrice.TabIndex = 44
        Me.txtTotalNetPrice.Text = "0.00"
        '
        'lstProductNames
        '
        Me.lstProductNames.FormattingEnabled = True
        Me.lstProductNames.Location = New System.Drawing.Point(543, 17)
        Me.lstProductNames.Name = "lstProductNames"
        Me.lstProductNames.Size = New System.Drawing.Size(136, 277)
        Me.lstProductNames.TabIndex = 42
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(568, 308)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 13)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Total No. of Products:"
        '
        'txtNumofItems
        '
        Me.txtNumofItems.Enabled = False
        Me.txtNumofItems.Location = New System.Drawing.Point(685, 305)
        Me.txtNumofItems.Name = "txtNumofItems"
        Me.txtNumofItems.ReadOnly = True
        Me.txtNumofItems.Size = New System.Drawing.Size(46, 20)
        Me.txtNumofItems.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(33, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Order No.:"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(95, 361)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(207, 20)
        Me.txtProductName.TabIndex = 37
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 368)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 13)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Product Name:"
        '
        'btnAddtoOrder
        '
        Me.btnAddtoOrder.Location = New System.Drawing.Point(206, 332)
        Me.btnAddtoOrder.Name = "btnAddtoOrder"
        Me.btnAddtoOrder.Size = New System.Drawing.Size(96, 23)
        Me.btnAddtoOrder.TabIndex = 35
        Me.btnAddtoOrder.Text = "Add to Order"
        Me.btnAddtoOrder.UseVisualStyleBackColor = True
        '
        'lstProdNums
        '
        Me.lstProdNums.FormattingEnabled = True
        Me.lstProdNums.Location = New System.Drawing.Point(401, 17)
        Me.lstProdNums.Name = "lstProdNums"
        Me.lstProdNums.Size = New System.Drawing.Size(136, 277)
        Me.lstProdNums.TabIndex = 34
        '
        'btFindProd
        '
        Me.btFindProd.Location = New System.Drawing.Point(95, 332)
        Me.btFindProd.Name = "btFindProd"
        Me.btFindProd.Size = New System.Drawing.Size(96, 23)
        Me.btFindProd.TabIndex = 33
        Me.btFindProd.Text = "Find"
        Me.btFindProd.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(14, 384)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMainMenu.TabIndex = 31
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(737, 381)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 23)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "Save Order"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(625, 339)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Net Price:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 308)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Product No.:"
        '
        'txtProductNo
        '
        Me.txtProductNo.Location = New System.Drawing.Point(95, 303)
        Me.txtProductNo.Name = "txtProductNo"
        Me.txtProductNo.Size = New System.Drawing.Size(207, 20)
        Me.txtProductNo.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Employee ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(51, 254)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "E-mail:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Mobile Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Home Number:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Postcode:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Town/Province:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Address:"
        '
        'txtOrderNo
        '
        Me.txtOrderNo.Location = New System.Drawing.Point(95, 17)
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.Size = New System.Drawing.Size(207, 20)
        Me.txtOrderNo.TabIndex = 13
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(95, 277)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(207, 20)
        Me.txtEmployeeID.TabIndex = 12
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(95, 251)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(207, 20)
        Me.txtEmail.TabIndex = 11
        '
        'txtMobTelNo
        '
        Me.txtMobTelNo.Location = New System.Drawing.Point(95, 225)
        Me.txtMobTelNo.Name = "txtMobTelNo"
        Me.txtMobTelNo.Size = New System.Drawing.Size(207, 20)
        Me.txtMobTelNo.TabIndex = 10
        '
        'txtHomeTelNo
        '
        Me.txtHomeTelNo.Location = New System.Drawing.Point(95, 199)
        Me.txtHomeTelNo.Name = "txtHomeTelNo"
        Me.txtHomeTelNo.Size = New System.Drawing.Size(207, 20)
        Me.txtHomeTelNo.TabIndex = 9
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(95, 173)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(207, 20)
        Me.txtPostcode.TabIndex = 8
        '
        'txtTown
        '
        Me.txtTown.Location = New System.Drawing.Point(95, 147)
        Me.txtTown.Name = "txtTown"
        Me.txtTown.Size = New System.Drawing.Size(207, 20)
        Me.txtTown.TabIndex = 7
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(95, 121)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(207, 20)
        Me.txtAddress.TabIndex = 6
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(95, 95)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(207, 20)
        Me.txtSurname.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Surname:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(95, 69)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(207, 20)
        Me.txtFirstName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer No.:"
        '
        'txtCustNo
        '
        Me.txtCustNo.Location = New System.Drawing.Point(95, 43)
        Me.txtCustNo.Name = "txtCustNo"
        Me.txtCustNo.Size = New System.Drawing.Size(207, 20)
        Me.txtCustNo.TabIndex = 0
        '
        'OrderFormTab
        '
        Me.OrderFormTab.Controls.Add(Me.TabPage1)
        Me.OrderFormTab.Controls.Add(Me.TabPage2)
        Me.OrderFormTab.Location = New System.Drawing.Point(0, 0)
        Me.OrderFormTab.Name = "OrderFormTab"
        Me.OrderFormTab.SelectedIndex = 0
        Me.OrderFormTab.Size = New System.Drawing.Size(853, 439)
        Me.OrderFormTab.TabIndex = 0
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 437)
        Me.Controls.Add(Me.OrderFormTab)
        Me.Name = "OrderForm"
        Me.Text = "OrderForm"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.OrderFormTab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtProductNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtMobTelNo As System.Windows.Forms.TextBox
    Friend WithEvents txtHomeTelNo As System.Windows.Forms.TextBox
    Friend WithEvents txtPostcode As System.Windows.Forms.TextBox
    Friend WithEvents txtTown As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCustNo As System.Windows.Forms.TextBox
    Friend WithEvents OrderFormTab As System.Windows.Forms.TabControl
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btFindProd As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblProductInfo As System.Windows.Forms.Label
    Friend WithEvents txtProductNum As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnRequestStock As System.Windows.Forms.Button
    Friend WithEvents btnAddtoOrder As System.Windows.Forms.Button
    Friend WithEvents lstProdNums As System.Windows.Forms.ListBox
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtOrderNo As System.Windows.Forms.TextBox
    Friend WithEvents txtNumofItems As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtTotalGrossPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalNetPrice As System.Windows.Forms.TextBox
    Friend WithEvents lstProductNames As System.Windows.Forms.ListBox
    Friend WithEvents lstNumofProds As System.Windows.Forms.ListBox
    Friend WithEvents VATButton As System.Windows.Forms.CheckBox
End Class
