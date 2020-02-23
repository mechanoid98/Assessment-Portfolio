Public Class ChangeOffers
    Dim Products() As ProductInfoArray 'Declare global variables
    Dim intNumofProducts As Integer
    Dim ProductName As String
    Dim ProductPrice As Double
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim intCounter As Integer 'Declare variables
        Dim ProductNm As Integer

        If txtSearchValue.Text = "" Then
            MsgBox("Error: No Product Number found") 'If the text box is empty, an error message is shown
        Else
            ProductNm = txtSearchValue.Text
            ReadInProducts(intNumofProducts, Products)
            For intCounter = 1 To intNumofProducts
                If Products(intCounter).ProductNo = ProductNm Then
                    ProductName = Products(intCounter).ProductName 'The product name is taken from the array
                    ProductPrice = Products(intCounter).ProductPrice 'The product price s taken from the array
                    lblProdInfo.Text = ("Product Name: " & Products(intCounter).ProductName & Environment.NewLine &
                        "Product Price: £" & Products(intCounter).ProductPrice) 'The product name and product price is output into the label
                End If
            Next
        End If
    End Sub

    Private Sub btnDisplayChanges_Click(sender As Object, e As EventArgs) Handles btnDisplayChanges.Click
        Dim Offer As Integer
        Dim DiscountPrice As Double
        Offer = cmbOffers.SelectedItem
        If String.IsNullOrEmpty(Offer) Then
            MsgBox("Please select an offer.") 'If there is no item selected, an error message is shown
        Else
            DiscountPrice = ProductPrice * (Offer / 100) 'The amount to take off the original price
            ProductPrice = ProductPrice - DiscountPrice 'This calculates the new price of the product
            lblNewProductInfo.Text = ("Product Name: " & ProductName & Environment.NewLine &
                "New Product Price: £" & ProductPrice) 'Outputs the new price into the label
        End If
    End Sub

    Private Sub btnApplyChanges_Click(sender As Object, e As EventArgs) Handles btnApplyChanges.Click
        Dim intCounter As Integer
        Dim ProductNum As String
        ProductNum = txtSearchValue.Text
        ReadInProducts(intNumofProducts, Products)
        For intCounter = 0 To intNumofProducts
            If Products(intCounter).ProductNo = ProductNum Then
                ReDim Preserve Products(intNumofProducts)
                Products(intCounter).ProductPrice = ProductPrice
                WriteInProducts(intCounter, Products) 'Saves the new information into the text file
                txtSearchValue.Text = "" 'Resets the input boxes
                lblProdInfo.Text = ("Product Name: " & Environment.NewLine & "Product Price: ") 'Resets the label
                lblNewProductInfo.Text = ("Product Name: " & Environment.NewLine & "New Product Price: ")
                MsgBox("The offer is successful") 'A message box is displayed
            End If
        Next
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Visible = False
        ManagerMenu.Visible = True 'The manager is taken back to the main menu
    End Sub
End Class