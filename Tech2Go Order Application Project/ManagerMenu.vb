Public Class ManagerMenu
    Dim Path As String = String.Empty
    Private Sub ManagerMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OrderForm.StockRequest = True Then 'This message is shown if a request has been sent by the last employee who logged in
            MsgBox("There are only " & OrderForm.StockValue & " of the product " & OrderForm.NameValue & " left in stock. Consider ordering in more.")
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Visible = False 'Takes the user to the Login form and clears all text boxes on the form
        LoginForm.txtUsername.Text = ""
        LoginForm.txtPassword.Text = ""
        LoginForm.Visible = True
    End Sub

    Private Sub btnNewEmployee_Click(sender As Object, e As EventArgs) Handles btnNewEmployee.Click
        Me.Visible = False 'Takes the user to the New Employee Form
        NewEmployeeForm.txtEmpFirstName.Text = ""
        NewEmployeeForm.txtEmpSurname.Text = ""
        NewEmployeeForm.txtEmpUsername.Text = ""
        NewEmployeeForm.txtEmpPassword.Text = ""
        NewEmployeeForm.Visible = True
    End Sub

    Private Sub btnNewDriver_Click(sender As Object, e As EventArgs) Handles btnNewDriver.Click
        Me.Visible = False ' Takes the user to the New Driver Form
        NewDriverForm.txtDriverID.Text = ""
        NewDriverForm.txtDriverFirstName.Text = ""
        NewDriverForm.txtDriverSurname.Text = ""
        NewDriverForm.txtDriverUsername.Text = ""
        NewDriverForm.txtDriverPassword.Text = ""
        NewDriverForm.Visible = True
    End Sub

    Private Sub FindPath(ByRef Path As String)
        Dim fdb As New FolderBrowserDialog
        If fdb.ShowDialog = Windows.Forms.DialogResult.OK Then
            Path = fdb.SelectedPath
        End If
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Dim fdb As New FolderBrowserDialog
        Dim Result As String = String.Empty
        MsgBox("Select folder for backup:")
        If fdb.ShowDialog = Windows.Forms.DialogResult.OK Then ' Opens a dialog box for the user tochoose a folder
            Path = fdb.SelectedPath 'Sets the selcected folder as the location for the backup
        End If
        If Not FileIO.FileSystem.DirectoryExists(Path & "\Tech2GoOrderBackup") Then
            MkDir(Path & "\Tech2GoOrderBackup") 'Creates a new folder with the name if the folder does not already exist
            Call Backup(Path)
        Else
            Result = MsgBox("Backup folder exists. Do you wish to overwrite?", 1) 'Checks with the user if the folder does exist
            If Result = DialogResult.OK Then
                Call Backup(Path)
            Else
                MsgBox("Operation cancelled")
            End If
        End If
    End Sub
    Sub Backup(ByVal Path As String)
        FileCopy("OrderInfo.txt", Path & "\Tech2GoOrderBackup\OrderInfo.txt") 'Backs up all text files
        FileCopy("CustomerInfo.txt", Path & "\Tech2GoOrderBackup\CustomerInfo.txt")
        FileCopy("EmployeeInfo.txt", Path & "\Tech2GoOrderBackup\EmployeeInfo.txt")
        FileCopy("LoginInfo.txt", Path & "\Tech2GoOrderBackup\LoginInfo.txt")
        FileCopy("DriverInfo.txt", Path & "\Tech2GoOrderBackup\DriverInfo.txt")
        FileCopy("DriverLogin.txt", Path & "\Tech2GoOrderBackup\DriverLogin.txt")
        FileCopy("ProductInfo.txt", Path & "\Tech2GoOrderBackup\ProductInfo.txt")
        FileCopy("OrderDetails.txt", Path & "\Tech2GoOrderBackup\OrderDetails.txt")
        MsgBox("Backup Complete")
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim Path As String = String.Empty
        Dim ImportChoice As Integer
        ImportChoice = MsgBox("You are about to overwrite all current " & vbNewLine &
                              "data files with the last backup made." & vbNewLine &
                              "Do you wish to continue?", MsgBoxStyle.YesNo, "Tech2Go") 'Checks if the user wants to overwrite all information
        If ImportChoice <> 7 Then
            FindPath(Path)
            If FileIO.FileSystem.DirectoryExists(Path & "\Tech2GoOrderBackup") Then
                Call Import(Path) 'Imports the files
                MsgBox("Files imported")
            Else
                MsgBox("Backup folder not found") 'If the files are not found an error message will be shown instead
            End If
        End If
    End Sub

    Sub Import(ByVal Path As String)
        FileCopy(Path & "\Tech2GoOrderBackup\OrderInfo.txt", "OrderInfo.txt")
        FileCopy(Path & "\Tech2GoOrderBackup\CustomerInfo.txt", "CustomerInfo.txt")
        FileCopy(Path & "\Tech2GoOrderBackup\EmployeeInfo.txt", "EmployeeInfo.txt")
        FileCopy(Path & "\Tech2GoOrderBackup\LoginInfo.txt", "LoginInfo.txt")
        FileCopy(Path & "\Tech2GoOrderBackup\DriverInfo.txt", "DriverInfo.txt")
        FileCopy(Path & "\Tech2GoOrderBackup\DriverLogin.txt", "DriverLogin.txt")
        FileCopy(Path & "\Tech2GoOrderBackup\ProductInfo.txt", "ProductInfo.txt")
        FileCopy(Path & "\Tech2GoOrderBackup\OrderDetails.txt", "OrderDetails.txt")
    End Sub

    Private Sub btnNewProduct_Click(sender As Object, e As EventArgs) Handles btnNewProduct.Click
        Me.Visible = False 'Takes the user to the New Product Form
        NewProductForm.Visible = True
    End Sub

    Private Sub btnChangeOffers_Click(sender As Object, e As EventArgs) Handles btnChangeOffers.Click
        Me.Visible = False
        ChangeOffers.txtSearchValue.Text = ""
        ChangeOffers.lblProdInfo.Text = ("Product Name: " & Environment.NewLine & "Product Price: ")
        ChangeOffers.lblNewProductInfo.Text = ("Product Name: " & Environment.NewLine & "New Product Price: ")
        ChangeOffers.Visible = True
    End Sub
End Class