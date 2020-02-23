Imports System.IO
Public Class NewProductForm
    Dim strMyFileName As String 'Declares the global variables
    Dim Product() As ProductInfoArray
    Dim intNumofProducts As Integer
    Dim ValidateInput As New Validation 'Calls the validation function
    Private Sub btnSaveProd_Click(sender As Object, e As EventArgs) Handles btnSaveProd.Click
        Dim ValidInput As Boolean = True
        ValidateInput.ValidateClearAll()
        If Not ValidateInput.ValidateRequired("Product Name", txtProductName.Text) Or
        Not ValidateInput.ValidateLength("Product Name", txtProductName.Text, 30) Or
               Not ValidateInput.ValidateRequired("Product Price Start", txtProductPriceStart.Text) Or
              Not ValidateInput.ValidateLength("Product Price Start", txtProductPriceStart.Text, 4) Or
              Not ValidateInput.ValidateRequired("Product Price End", txtProductPriceEnd.Text) Or
              Not ValidateInput.ValidateLength("Product Price End", txtProductPriceEnd.Text, 2) Or
              Not ValidateInput.ValidateRequired("Amount in stock", txtAmountInStock.Text) Or
              Not ValidateInput.ValidateLength("Amount in stock", txtAmountInStock.Text, 4) Then
            ValidInput = False
        End If
        If Not ValidInput = True Then
            MsgBox(ValidateInput.ToString) 'Outputs the error message into a message box
        Else
            Dim ProductID As Integer
            ProductID = intNumofProducts

            intNumofProducts = intNumofProducts + 1 'Increments the number of products by 1

            ReDim Preserve Product(intNumofProducts)
            Product(intNumofProducts).ProductNo = txtProdID.Text
            Product(intNumofProducts).ProductName = txtProductName.Text 'Reads in all information into the array
            Product(intNumofProducts).ProductPrice = txtProductPriceStart.Text & "." & txtProductPriceEnd.Text
            Product(intNumofProducts).ProductStock = txtAmountInStock.Text

            WriteInProducts(intNumofProducts, Product) 'Writes information from the array into the product information form

            MsgBox("Product save complete") 'Displays a message box

            txtProdID.Text = intNumofProducts + 1 'Increments the product number by 1
            txtProductName.Text = ""
            txtProductPriceStart.Text = ""
            txtProductPriceEnd.Text = ""
            txtAmountInStock.Text = ""
        End If
    End Sub

    Private Sub NewProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadInProducts(intNumofProducts, Product)
        txtProdID.Text = intNumofProducts + 1 'Adds 1 onto the number of products and out puts the new value into the text box
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Visible = False
        ManagerMenu.Visible = True 'Takes the manager back to the manager main menu
    End Sub
End Class