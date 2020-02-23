Imports System.IO
Public Class OrderForm
    Public StockRequest As Boolean
    Public NameValue As String
    Public StockValue As Integer
    Dim Orders() As OrderArray
    Dim Customers() As CustomerInfoArray
    Dim Products() As ProductInfoArray
    Dim myOrderDetailsArray() As OrderDetails
    Dim intNumofOrders As Integer
    Dim intNumofCustomers As Integer
    Dim intNumofProducts As Integer
    Dim intNumofOrderDets As Integer
    Dim ProductPrice As Double
    Dim NumofProduct As Integer
    Dim NumofItems As Integer
    Dim TotalPrice As Double
    Dim ValidateInput As New Validation
    Private Sub ReadAllOrderRecsIntoArray()
        ReadInOrder(intNumofOrders, Orders)
        ReadInCustomers(intNumofCustomers, Customers)
        ReadInProducts(intNumofProducts, Products)
        ReadInOrderDetails(intNumofOrderDets, myOrderDetailsArray)
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intCounter As Integer
        Dim ProdStock As Integer
        Dim Found As Boolean = False
        Dim OrderPrice As Double
        Dim ProductNums As String = ""
        Dim NumofItems As Integer
        Dim Valid As Boolean = False

        Dim ValidInput As Boolean = True
        ValidateInput.ValidateClearAll()
        If Not ValidateInput.ValidateRequired("First Name", txtFirstName.Text) Or
            Not ValidateInput.ValidateLength("First Name", txtFirstName.Text, 15) Or
            Not ValidateInput.ValidateRequired("Surname", txtSurname.Text) Or
            Not ValidateInput.ValidateLength("Surname", txtSurname.Text, 20) Or
            Not ValidateInput.ValidateRequired("Address", txtAddress.Text) Or
            Not ValidateInput.ValidateLength("Address", txtAddress.Text, 30) Or
            Not ValidateInput.ValidateRequired("Town/Province", txtTown.Text) Or
            Not ValidateInput.ValidateLength("Town/Province", txtTown.Text, 25) Or
            Not ValidateInput.ValidateRequired("Postcode", txtPostcode.Text) Or
            Not ValidateInput.ValidateLength("Postcode", txtPostcode.Text, 7) Or
            Not ValidateInput.ValidateRequired("Home Tel. No.", txtHomeTelNo.Text) Or
            Not ValidateInput.ValidateLength("Home Tel. No.", txtHomeTelNo.Text, 11) Or
            Not ValidateInput.ValidateFormat("Home Tel. No.", txtHomeTelNo.Text) Or
            Not ValidateInput.ValidateRequired("Mobile Tel. No.", txtMobTelNo.Text) Or
            Not ValidateInput.ValidateLength("Mobile Tel. No.", txtMobTelNo.Text, 11) Or
            Not ValidateInput.ValidateFormat("Mobile Tel. No.", txtMobTelNo.Text) Then
            ValidInput = False
        End If
        If Not ValidInput = True Then
            MsgBox(ValidateInput.ToString)
        Else
            ReadAllOrderRecsIntoArray()

            NumofItems = txtNumofItems.Text
            If VATButton.Checked Then
                OrderPrice = txtTotalGrossPrice.Text
            Else
                OrderPrice = txtTotalNetPrice.Text
            End If
            intNumofOrders = intNumofOrders + 1
            intNumofCustomers = intNumofCustomers + 1
            intNumofProducts = intNumofProducts + 1
            intNumofOrderDets = intNumofOrderDets + 1

            ReDim Preserve Customers(intNumofCustomers)

            Customers(intNumofCustomers).CustomerID = txtCustNo.Text
            Customers(intNumofCustomers).FirstName = txtFirstName.Text
            Customers(intNumofCustomers).Surname = txtSurname.Text
            Customers(intNumofCustomers).HomeTelNum = txtHomeTelNo.Text
            Customers(intNumofCustomers).MobTelNum = txtMobTelNo.Text
            Customers(intNumofCustomers).Address = txtAddress.Text
            Customers(intNumofCustomers).TownProvince = txtTown.Text
            Customers(intNumofCustomers).PostCode = txtPostcode.Text
            Customers(intNumofCustomers).Email = txtEmail.Text

            ReDim Preserve Orders(intNumofOrders)
            Orders(intNumofOrders).CustomerID = txtCustNo.Text
            Orders(intNumofOrders).EmployeeID = txtEmployeeID.Text
            Orders(intNumofOrders).NumofItems = txtNumofItems.Text
            For k = 1 To lstProdNums.Items.Count
                ProductNums = ProductNums & lstProdNums.SelectedItem & ","
            Next
            Orders(intNumofOrders).ProductNo = ProductNums

            ReDim Preserve myOrderDetailsArray(intNumofOrderDets)
            myOrderDetailsArray(intNumofOrderDets).OrderID = txtOrderNo.Text
            myOrderDetailsArray(intNumofOrderDets).CustomerID = txtCustNo.Text
            myOrderDetailsArray(intNumofOrderDets).TotalPrice = OrderPrice
            myOrderDetailsArray(intNumofOrderDets).Postcode = txtPostcode.Text
            myOrderDetailsArray(intNumofOrderDets).DriverID = ""

            For i = 1 To lstNumofProds.Items.Count
                Dim ProdNum As Integer = lstProdNums.SelectedItem(i)
                Do
                    intCounter += 1
                    If Products(intCounter).ProductNo = ProdNum Then
                        ProdStock = Products(intCounter).ProductStock
                        Dim NumofPrd As Integer = lstNumofProds.SelectedItem(i)
                        ProdStock = ProdStock - NumofPrd
                        Products(intCounter).ProductStock = ProdStock
                    End If
                Loop Until (Found = True) Or (intCounter = intNumofProducts)
            Next

            WriteInOrder(intNumofOrders, Orders)
            WriteInCustomers(intNumofCustomers, Customers)
            WriteInOrderDetails(intNumofOrderDets, myOrderDetailsArray)

            txtOrderNo.Text = intNumofOrderDets + 1
            txtCustNo.Text = intNumofCustomers + 1

            Me.Visible = False
            MainMenu.Visible = True
        End If
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Visible = False
        MainMenu.Visible = True
    End Sub

    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ReadAllOrderRecsIntoArray()
        lstProdNums.Items.Clear()
        lstProductNames.Items.Clear()
        lstNumofProds.Items.Clear()
        Dim CustomerID As Integer
        Dim OrderID As Integer
        CustomerID = intNumofCustomers + 1
        txtCustNo.Text = CustomerID
        OrderID = intNumofOrderDets + 1
        txtOrderNo.Text = OrderID
    End Sub

    Private Sub btFindProd_Click(sender As Object, e As EventArgs) Handles btFindProd.Click
        Dim ProductNm As Integer
        Dim Valid As Boolean = False

        Dim ValidInput As Boolean = True
        ValidateInput.ValidateClearAll()
        If Not ValidateInput.ValidateRequired("Product Number", txtProductNo.Text) Then
            Valid = True
        End If
        If Valid Then
            MsgBox(ValidateInput.ToString)
        Else
            ProductNm = txtProductNo.Text
            ReadInProducts(intNumofProducts, Products)

            For intCounter = 1 To intNumofProducts
                If Products(intCounter).ProductNo = ProductNm Then
                    txtProductName.Text = Products(intCounter).ProductName
                End If
            Next
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim intCounter As Integer
        Dim ProductNm As Integer

        If txtProductNum.Text = "" Then
            MsgBox("Error: No Product Number found")
        Else
            ProductNm = txtProductNum.Text
            ReadInProducts(intNumofProducts, Products)
            For intCounter = 1 To intNumofProducts
                If Products(intCounter).ProductNo = ProductNm Then
                    lblProductInfo.Text = ("Product No.: " & ProductNm & Environment.NewLine & "Product Name: " & Products(intCounter).ProductName & Environment.NewLine & "Product Price: £" & Products(intCounter).ProductPrice & Environment.NewLine & "Product Stock: " & Products(intCounter).ProductStock)
                End If
            Next
        End If
    End Sub

    Private Sub btnRequestStock_Click(sender As Object, e As EventArgs) Handles btnRequestStock.Click
        Dim intCounter As Integer

        StockRequest = True

        NameValue = InputBox("Enter Product Number:")

        ReadInProducts(intNumofProducts, Products)

        For intCounter = 0 To intNumofProducts
            If NameValue = Products(intCounter).ProductNo Then
                StockValue = Products(intCounter).ProductStock
            End If
        Next

        MsgBox("Stock Request has been sent. Thank you.")

    End Sub

    Private Sub btnAddtoOrder_Click(sender As Object, e As EventArgs) Handles btnAddtoOrder.Click
        Dim intCounter As Integer
        Dim NumofProdOrdered As Integer
        Dim ProdNum As Integer = txtProductNo.Text
        Dim ProdName As String = txtProductName.Text
        Dim TotPrice As Double = txtTotalNetPrice.Text

        ReadInProducts(intNumofProducts, Products)

        NumofProdOrdered = InputBox("Enter how many items to be ordered:")

        For intCounter = 1 To intNumofProducts
            If Products(intCounter).ProductNo = ProdNum Then
                TotalPrice = NumofProdOrdered * Products(intCounter).ProductPrice
            End If
        Next

        TotalPrice = TotPrice + TotalPrice
        NumofItems = NumofItems + NumofProdOrdered

        lstProdNums.Items.Add(ProdNum)
        lstProductNames.Items.Add(ProdName)
        lstNumofProds.Items.Add(NumofProdOrdered)
        txtProductNo.Text = ""
        txtProductName.Text = ""
        txtNumofItems.Text = NumofItems
        txtTotalNetPrice.Text = TotalPrice
        If VATButton.Checked Then
            Dim VAT As Double
            VAT = txtTotalNetPrice.Text * 0.2
            txtTotalGrossPrice.Text = "£" & VAT
        End If
    End Sub
    Private Sub VATButton_CheckedChanged(sender As Object, e As EventArgs)
        Dim VAT As Double
        VAT = txtTotalNetPrice.Text * 0.2
        VAT = txtTotalNetPrice.Text + VAT
        txtTotalGrossPrice.Text = "£" & VAT
    End Sub
End Class