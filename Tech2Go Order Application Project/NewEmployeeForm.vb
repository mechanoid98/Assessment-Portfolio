Imports System.IO
Public Class NewEmployeeForm
    Dim strMyFileName As String 'Declare variables and arrays
    Dim Employees() As EmployeeInformation
    Dim Login() As LoginInformation
    Dim intNumofEmployee As Integer
    Dim intNumofLogin As Integer
    Dim ValidateInput As New Validation 'Calls the validation function
    Dim strResult As String
    Private Sub ReadAllRecIntoAnArray()
        ReadInEmployee(intNumofEmployee, Employees) 'Read in information from the employee text file
        ReadInLogin(intNumofLogin, Login) 'Read in information from the login text file
    End Sub
    Private Sub btnGenerateLogin_Click(sender As Object, e As EventArgs) Handles btnGenerateLogin.Click
        Dim ValidInput As Boolean = True
        ValidateInput.ValidateClearAll()
        If Not ValidateInput.ValidateRequired("Employee First Name", txtEmpFirstName.Text) Or _
        Not ValidateInput.ValidateLength("Employee First Name", txtEmpFirstName.Text, 10) Or _
               Not ValidateInput.ValidateRequired("Employee Surname", txtEmpSurname.Text) Or _
              Not ValidateInput.ValidateLength("Employee Surname", txtEmpSurname.Text, 20) Then
            ValidInput = False
        End If
        If Not ValidInput = True Then
            MsgBox(ValidateInput.ToString)
        Else
            Randomize()
            Dim UsernameStartChar As String
            Dim UsernameEndWord As String
            Dim intvalue As String = CInt(Int((6 * Rnd()) + 1000)) 'Generates a random number

            UsernameStartChar = txtEmpFirstName.Text.First
            UsernameEndWord = txtEmpSurname.Text

            txtEmpUsername.Text = UsernameStartChar & UsernameEndWord 'Generates the employee username
            txtEmpPassword.Text = intvalue
        End If
    End Sub
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Visible = False 'Takes the manager back to the manager main menu
        ManagerMenu.Visible = True
    End Sub

    Private Sub btnSaveEmp_Click(sender As Object, e As EventArgs) Handles btnSaveEmp.Click
        Dim ValidInput As Boolean = True
        ValidateInput.ValidateClearAll()
        If Not ValidateInput.ValidateRequired("Employee First Name", txtEmpFirstName.Text) Or _
            Not ValidateInput.ValidateLength("Employee First Name", txtEmpFirstName.Text, 10) Or
            Not ValidateInput.ValidateRequired("Employee Surname", txtEmpSurname.Text) Or
            Not ValidateInput.ValidateLength("Employee Surname", txtEmpSurname.Text, 20) Or
            Not ValidateInput.ValidateRequired("Username", txtEmpUsername.Text) Or
            Not ValidateInput.ValidateLength("Username", txtEmpUsername.Text, 21) Or
            Not ValidateInput.ValidateRequired("Password", txtEmpPassword.Text) Or
            Not ValidateInput.ValidateLength("Password", txtEmpPassword.Text, 4) Then
            ValidInput = False
        End If
        If Not ValidInput = True Then
            MsgBox(ValidateInput.ToString)
        Else
            Dim Gender As Char

            If MaleButton.Checked Then
                Gender = "M" 'Sets the value to this character if this button is clicked
            ElseIf FemaleButton.Checked Then
                Gender = "F" 'Sets the value to this character if this button is clicked
            End If

            intNumofEmployee = intNumofEmployee + 1 'Increments the number of records in each array by 1
            intNumofLogin = intNumofLogin + 1

            ReDim Preserve Employees(intNumofEmployee)
            Employees(intNumofEmployee).EmployeeID = txtEmpID.Text
            Employees(intNumofEmployee).EmployeeFirstName = txtEmpFirstName.Text 'Reads all information into the array
            Employees(intNumofEmployee).EmployeeSurname = txtEmpSurname.Text
            Employees(intNumofEmployee).EmployeeGender = Gender

            ReDim Preserve Login(intNumofLogin)
            Login(intNumofLogin).Username = Encryption(txtEmpUsername.Text) 'Reads all information into the array
            Login(intNumofLogin).Password = Encryption(txtEmpPassword.Text)

            WriteInEmployee(intNumofEmployee, Employees) 'Writes information from the array into the Employee Information text file
            WriteInLogin(intNumofLogin, Login) 'Write information from the array into the Employee Login Information file

            txtEmpID.Text = intNumofEmployee + 1
            txtEmpFirstName.Text = ""
            txtEmpSurname.Text = ""
            txtEmpUsername.Text = ""
            txtEmpPassword.Text = ""
        End If
    End Sub

    Private Sub NewEmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadAllRecIntoAnArray()
        Dim EmpID As Integer
        EmpID = intNumofEmployee + 1 'Adds 1 to the number of records in the array and outputs it into the text box
        txtEmpID.Text = EmpID
    End Sub
End Class