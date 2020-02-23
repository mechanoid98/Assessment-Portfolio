Imports System.IO
Public Class NewDriverForm
    Dim strMyFileName As String 'Declares global vairaibles for the form
    Dim Driver() As DriverInformation
    Dim DriverLogin() As DriverLoginInformation
    Dim intNumofDrivers As Integer
    Dim intNumofDriverLogin As Integer
    Dim ValidateInput As New Validation
    Dim strResult As String

    Private Sub ReadAllRecIntoAnArray()
        ReadInDriver(intNumofDrivers, Driver) 'Reads in Driver Information
        ReadInDriverLogin(intNumofDriverLogin, DriverLogin) 'Reads in Driver Login Information
    End Sub

    Private Sub NewDriverForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ReadAllRecIntoAnArray() 'Calls the function
        Dim DriverID As Integer
        DriverID = intNumofDrivers 'Increments the Driver ID by 1
        txtDriverID.Text = DriverID + 1
    End Sub

    Private Sub btnGenerateLogin_Click(sender As Object, e As EventArgs) Handles btnGenerateLogin.Click
        Dim ValidInput As Boolean = True
        ValidateInput.ValidateClearAll()
        If Not ValidateInput.ValidateRequired("Driver First Name", txtDriverFirstName.Text) Or
        Not ValidateInput.ValidateLength("Driver First Name", txtDriverFirstName.Text, 10) Or _
               Not ValidateInput.ValidateRequired("Driver Surname", txtDriverSurname.Text) Or _
              Not ValidateInput.ValidateLength("Driver Surname", txtDriverSurname.Text, 20) Then
            ValidInput = False
        End If
        If Not ValidInput = True Then
            MsgBox(ValidateInput.ToString) 'Outputs an error message box
        Else

            Randomize()
            Dim UsernameStartChar As String 'Declares variables
            Dim UsernameEndWord As String
            Dim intvalue As String = CInt(Int((6 * Rnd()) + 1000)) 'Creates new random number

            UsernameStartChar = txtDriverFirstName.Text.First
            UsernameEndWord = txtDriverSurname.Text

            txtDriverUsername.Text = UsernameStartChar & UsernameEndWord 'Creates a new username
            txtDriverPassword.Text = intvalue 'Creates a new password
        End If
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Visible = False
        ManagerMenu.Visible = True 'Takes the manager back to their menu
    End Sub

    Private Sub btnSaveDriver_Click(sender As Object, e As EventArgs) Handles btnSaveEmp.Click
        Dim ValidInput As Boolean = True
        ValidateInput.ValidateClearAll()
        If Not ValidateInput.ValidateRequired("Driver First Name", txtDriverFirstName.Text) Or _
            Not ValidateInput.ValidateLength("Driver First Name", txtDriverFirstName.Text, 10) Or
            Not ValidateInput.ValidateRequired("Driver Surname", txtDriverSurname.Text) Or
            Not ValidateInput.ValidateLength("Driver Surname", txtDriverSurname.Text, 20) Or
            Not ValidateInput.ValidateRequired("Username", txtDriverUsername.Text) Or
            Not ValidateInput.ValidateLength("Username", txtDriverUsername.Text, 21) Or
            Not ValidateInput.ValidateRequired("Password", txtDriverPassword.Text) Or
            Not ValidateInput.ValidateLength("Password", txtDriverPassword.Text, 4) Then
            ValidInput = False
        End If
        If Not ValidInput = True Then
            MsgBox(ValidateInput.ToString) 'Outputs an error message
        Else
            Dim Gender As Char
            Dim NumberofDeliveries As Integer = 0 'Declares the variable
            If MaleButton.Checked Then
                Gender = "M" 'Sets the variable as this character if the corresponding button is selected
            ElseIf FemaleButton.Checked Then
                Gender = "F" 'Sets the variable as this if the corressponding button is selected
            End If

            intNumofDrivers = intNumofDrivers + 1 'Increments the number of records by 1
            intNumofDriverLogin = intNumofDriverLogin + 1

            ReDim Preserve Driver(intNumofDrivers)
            Driver(intNumofDrivers).DriverNo = txtDriverID.Text 'The contents of the array are set to te text boxes given
            Driver(intNumofDrivers).DriverFirstName = txtDriverFirstName.Text
            Driver(intNumofDrivers).DriverSurname = txtDriverSurname.Text
            Driver(intNumofDrivers).DriverGender = Gender
            Driver(intNumofDrivers).NumberofDeliveries = NumberofDeliveries

            ReDim Preserve DriverLogin(intNumofDriverLogin)
            DriverLogin(intNumofDriverLogin).DriverUsername = Encryption(txtDriverUsername.Text)
            DriverLogin(intNumofDriverLogin).DriverPassword = Encryption(txtDriverPassword.Text)

            WriteInDriver(intNumofDrivers, Driver) 'The information is written into the driver text file
            WriteInDriverLogin(intNumofDriverLogin, DriverLogin) 'The information is written into the driver login text file 

            txtDriverID.Text = intNumofDrivers + 1
            txtDriverFirstName.Text = ""
            txtDriverSurname.Text = ""
            txtDriverUsername.Text = ""
            txtDriverPassword.Text = ""
        End If
    End Sub
End Class