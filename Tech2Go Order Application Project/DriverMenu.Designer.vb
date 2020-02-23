<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DriverMenu
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtAvailability = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnmainmenu = New System.Windows.Forms.Button()
        Me.btnremoveorder = New System.Windows.Forms.Button()
        Me.btnaddorder = New System.Windows.Forms.Button()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DriverOrderInfo = New System.Windows.Forms.DataGridView()
        Me.ConfirmDeliveriesPage = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ConfirmDeliveriesNext = New System.Windows.Forms.Button()
        Me.ConfirmDeliveriesPrevious = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.DriverPersonalOrderGrid = New System.Windows.Forms.DataGridView()
        Me.OrderNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pstcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.OrderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPriceofOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Postcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DriverID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DriverOrderInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConfirmDeliveriesPage.SuspendLayout()
        CType(Me.DriverPersonalOrderGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.ConfirmDeliveriesPage)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(561, 319)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtAvailability)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.btnNext)
        Me.TabPage1.Controls.Add(Me.btnPrevious)
        Me.TabPage1.Controls.Add(Me.btnmainmenu)
        Me.TabPage1.Controls.Add(Me.btnremoveorder)
        Me.TabPage1.Controls.Add(Me.btnaddorder)
        Me.TabPage1.Controls.Add(Me.txtPostcode)
        Me.TabPage1.Controls.Add(Me.txtTotalPrice)
        Me.TabPage1.Controls.Add(Me.txtCustomerID)
        Me.TabPage1.Controls.Add(Me.txtOrderID)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.DriverOrderInfo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(553, 293)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Delivery Selection"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtAvailability
        '
        Me.txtAvailability.BackColor = System.Drawing.Color.Lime
        Me.txtAvailability.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAvailability.Location = New System.Drawing.Point(148, 266)
        Me.txtAvailability.Name = "txtAvailability"
        Me.txtAvailability.Size = New System.Drawing.Size(119, 20)
        Me.txtAvailability.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(83, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Available?:"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(37, 160)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(25, 23)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(6, 160)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(25, 23)
        Me.btnPrevious.TabIndex = 12
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnmainmenu
        '
        Me.btnmainmenu.Location = New System.Drawing.Point(457, 235)
        Me.btnmainmenu.Name = "btnmainmenu"
        Me.btnmainmenu.Size = New System.Drawing.Size(92, 29)
        Me.btnmainmenu.TabIndex = 11
        Me.btnmainmenu.Text = "Log out"
        Me.btnmainmenu.UseVisualStyleBackColor = True
        '
        'btnremoveorder
        '
        Me.btnremoveorder.Location = New System.Drawing.Point(457, 200)
        Me.btnremoveorder.Name = "btnremoveorder"
        Me.btnremoveorder.Size = New System.Drawing.Size(92, 29)
        Me.btnremoveorder.TabIndex = 10
        Me.btnremoveorder.Text = "Remove Order"
        Me.btnremoveorder.UseVisualStyleBackColor = True
        '
        'btnaddorder
        '
        Me.btnaddorder.Location = New System.Drawing.Point(457, 165)
        Me.btnaddorder.Name = "btnaddorder"
        Me.btnaddorder.Size = New System.Drawing.Size(92, 29)
        Me.btnaddorder.TabIndex = 9
        Me.btnaddorder.Text = "Add Order"
        Me.btnaddorder.UseVisualStyleBackColor = True
        '
        'txtPostcode
        '
        Me.txtPostcode.Enabled = False
        Me.txtPostcode.Location = New System.Drawing.Point(148, 240)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(119, 20)
        Me.txtPostcode.TabIndex = 8
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Enabled = False
        Me.txtTotalPrice.Location = New System.Drawing.Point(148, 214)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(119, 20)
        Me.txtTotalPrice.TabIndex = 7
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Enabled = False
        Me.txtCustomerID.Location = New System.Drawing.Point(148, 188)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(119, 20)
        Me.txtCustomerID.TabIndex = 6
        '
        'txtOrderID
        '
        Me.txtOrderID.Enabled = False
        Me.txtOrderID.Location = New System.Drawing.Point(148, 162)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(119, 20)
        Me.txtOrderID.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(87, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Postcode:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Customer ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Order ID:"
        '
        'DriverOrderInfo
        '
        Me.DriverOrderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DriverOrderInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderID, Me.CustomerID, Me.TotalPriceofOrder, Me.Postcode, Me.DriverID})
        Me.DriverOrderInfo.Location = New System.Drawing.Point(6, 3)
        Me.DriverOrderInfo.Name = "DriverOrderInfo"
        Me.DriverOrderInfo.Size = New System.Drawing.Size(543, 150)
        Me.DriverOrderInfo.TabIndex = 0
        '
        'ConfirmDeliveriesPage
        '
        Me.ConfirmDeliveriesPage.Controls.Add(Me.Button5)
        Me.ConfirmDeliveriesPage.Controls.Add(Me.Button3)
        Me.ConfirmDeliveriesPage.Controls.Add(Me.TextBox1)
        Me.ConfirmDeliveriesPage.Controls.Add(Me.TextBox2)
        Me.ConfirmDeliveriesPage.Controls.Add(Me.TextBox3)
        Me.ConfirmDeliveriesPage.Controls.Add(Me.TextBox4)
        Me.ConfirmDeliveriesPage.Controls.Add(Me.Label6)
        Me.ConfirmDeliveriesPage.Controls.Add(Me.Label7)
        Me.ConfirmDeliveriesPage.Controls.Add(Me.Label8)
        Me.ConfirmDeliveriesPage.Controls.Add(Me.Label9)
        Me.ConfirmDeliveriesPage.Controls.Add(Me.ConfirmDeliveriesNext)
        Me.ConfirmDeliveriesPage.Controls.Add(Me.ConfirmDeliveriesPrevious)
        Me.ConfirmDeliveriesPage.Controls.Add(Me.btnPrint)
        Me.ConfirmDeliveriesPage.Controls.Add(Me.DriverPersonalOrderGrid)
        Me.ConfirmDeliveriesPage.Location = New System.Drawing.Point(4, 22)
        Me.ConfirmDeliveriesPage.Name = "ConfirmDeliveriesPage"
        Me.ConfirmDeliveriesPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ConfirmDeliveriesPage.Size = New System.Drawing.Size(553, 293)
        Me.ConfirmDeliveriesPage.TabIndex = 1
        Me.ConfirmDeliveriesPage.Text = "Confirm Deliveries"
        Me.ConfirmDeliveriesPage.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(457, 191)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 38)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Email Current Orders"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(457, 162)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Confirm Order"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(163, 242)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(119, 20)
        Me.TextBox1.TabIndex = 16
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(163, 216)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(119, 20)
        Me.TextBox2.TabIndex = 15
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(163, 190)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(119, 20)
        Me.TextBox3.TabIndex = 14
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(163, 164)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(119, 20)
        Me.TextBox4.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(102, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Postcode:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(96, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Total Price:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(89, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Customer ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(107, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Order ID:"
        '
        'ConfirmDeliveriesNext
        '
        Me.ConfirmDeliveriesNext.Location = New System.Drawing.Point(40, 162)
        Me.ConfirmDeliveriesNext.Name = "ConfirmDeliveriesNext"
        Me.ConfirmDeliveriesNext.Size = New System.Drawing.Size(26, 23)
        Me.ConfirmDeliveriesNext.TabIndex = 3
        Me.ConfirmDeliveriesNext.Text = ">"
        Me.ConfirmDeliveriesNext.UseVisualStyleBackColor = True
        '
        'ConfirmDeliveriesPrevious
        '
        Me.ConfirmDeliveriesPrevious.Location = New System.Drawing.Point(8, 162)
        Me.ConfirmDeliveriesPrevious.Name = "ConfirmDeliveriesPrevious"
        Me.ConfirmDeliveriesPrevious.Size = New System.Drawing.Size(26, 23)
        Me.ConfirmDeliveriesPrevious.TabIndex = 2
        Me.ConfirmDeliveriesPrevious.Text = "<"
        Me.ConfirmDeliveriesPrevious.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.BackgroundImage = Global.Tech2Go_Order_Application_Project.My.Resources.Resources.Print_Button
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPrint.Location = New System.Drawing.Point(457, 6)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(46, 43)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'DriverPersonalOrderGrid
        '
        Me.DriverPersonalOrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DriverPersonalOrderGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderNo, Me.CustomerNo, Me.TotPrice, Me.Pstcode})
        Me.DriverPersonalOrderGrid.Location = New System.Drawing.Point(8, 6)
        Me.DriverPersonalOrderGrid.Name = "DriverPersonalOrderGrid"
        Me.DriverPersonalOrderGrid.Size = New System.Drawing.Size(443, 150)
        Me.DriverPersonalOrderGrid.TabIndex = 0
        '
        'OrderNo
        '
        Me.OrderNo.HeaderText = "Order ID"
        Me.OrderNo.Name = "OrderNo"
        '
        'CustomerNo
        '
        Me.CustomerNo.HeaderText = "Customer ID"
        Me.CustomerNo.Name = "CustomerNo"
        '
        'TotPrice
        '
        Me.TotPrice.HeaderText = "Total Price"
        Me.TotPrice.Name = "TotPrice"
        '
        'Pstcode
        '
        Me.Pstcode.HeaderText = "Postcode"
        Me.Pstcode.Name = "Pstcode"
        '
        'PrintDocument1
        '
        '
        'OrderID
        '
        Me.OrderID.HeaderText = "Order ID"
        Me.OrderID.Name = "OrderID"
        '
        'CustomerID
        '
        Me.CustomerID.HeaderText = "Customer ID"
        Me.CustomerID.Name = "CustomerID"
        '
        'TotalPriceofOrder
        '
        Me.TotalPriceofOrder.HeaderText = "Total Price"
        Me.TotalPriceofOrder.Name = "TotalPriceofOrder"
        '
        'Postcode
        '
        Me.Postcode.HeaderText = "Postcode"
        Me.Postcode.Name = "Postcode"
        '
        'DriverID
        '
        Me.DriverID.HeaderText = "Driver ID"
        Me.DriverID.Name = "DriverID"
        '
        'DriverMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 316)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "DriverMenu"
        Me.Text = "DriverMenu"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DriverOrderInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConfirmDeliveriesPage.ResumeLayout(False)
        Me.ConfirmDeliveriesPage.PerformLayout()
        CType(Me.DriverPersonalOrderGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ConfirmDeliveriesPage As System.Windows.Forms.TabPage
    Friend WithEvents DriverOrderInfo As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnmainmenu As Button
    Friend WithEvents btnremoveorder As Button
    Friend WithEvents btnaddorder As Button
    Friend WithEvents txtPostcode As TextBox
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents txtAvailability As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DriverPersonalOrderGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents OrderNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pstcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ConfirmDeliveriesNext As Button
    Friend WithEvents ConfirmDeliveriesPrevious As Button
    Friend WithEvents OrderID As DataGridViewTextBoxColumn
    Friend WithEvents CustomerID As DataGridViewTextBoxColumn
    Friend WithEvents TotalPriceofOrder As DataGridViewTextBoxColumn
    Friend WithEvents Postcode As DataGridViewTextBoxColumn
    Friend WithEvents DriverID As DataGridViewTextBoxColumn
End Class
