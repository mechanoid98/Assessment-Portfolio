Imports System.IO
Public Class LoginForm
    Dim myfilereader As StreamReader 'Declare all global variables
    Dim myfilename As String
    Dim intNumofLogins As Integer
    Dim intNumofDriverLogins As Integer
    Dim Login() As LoginInformation
    Dim DriverLogin() As DriverLoginInformation
    Dim ValidateInput As New Validation

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim intCounter As Integer
        Dim Password As String
        Dim Valid As Boolean = False
        Dim Username As String = String.Empty

        Dim ValidInput As Boolean = True
        ValidateInput.ValidateClearAll() 'Call the validate function
        If Not ValidateInput.ValidateRequired("Username", txtUsername.Text) Or
        Not ValidateInput.ValidateLength("Username", txtUsername.Text, 15) Or
               Not ValidateInput.ValidateRequired("Password", txtPassword.Text) Or
              Not ValidateInput.ValidateLength("Password", txtPassword.Text, 20) Then 'Presence checks and length checks the text boxes
            ValidInput = False
        End If
        If Not ValidInput = True Then
            MsgBox(ValidateInput.ToString) 'Display an error message to the user with details of what is te problem
        Else

            Dim Found As Boolean = False
            Username = txtUsername.Text
            Dim CorrectPassword As String = String.Empty
            Dim DriverCorrectPassword As String = String.Empty
            Dim PasswordInput As String
            Dim C As Integer = 0
            Static Tries As Integer

            'Find User and correct password
            Do
                intCounter += 1
                If Username = Decryption(Login(intCounter).Username) Then
                    Found = True 'If the entered username matches a username in the employee login text file, the password corresponding with the username is stored as a variable

                    CorrectPassword = Decryption(Login(intCounter).Password)
                End If
            Loop Until (Found = True) Or (intCounter = intNumofLogins)

            intCounter = 0
            Do
                intCounter += 1
                If Username = Decryption(DriverLogin(intCounter).DriverUsername) Then
                    Found = True 'If the entered username matches a username in the driver login text file, the password corresponding with the username is stored as a variable
                    DriverCorrectPassword = Decryption(DriverLogin(intCounter).DriverPassword)
                End If
            Loop Until (Found = True) Or (intCounter = intNumofDriverLogins)
            If Username = "Manager" Then 'If the username is manager and password is password then the manager is logged into their system
                Password = txtPassword.Text
                If Password = "password" Then
                    Me.Visible = False
                    ManagerMenu.Visible = True
                End If
            End If


            'Match password
            PasswordInput = txtPassword.Text
            If PasswordInput = "password" And Username = "Manager" Then
                Me.Visible = False
                ManagerMenu.Visible = True
            ElseIf PasswordInput <> CorrectPassword Then 'If the password input is not the same as the password stored in the variable, it checks the same with the driver password
                If PasswordInput <> DriverCorrectPassword Then 'If this is the same, an error message appears, giving the user 3 tries
                    Tries += 1
                    If Tries = 3 Then
                        MsgBox("Incorrect password - you have no tries remaining." & vbNewLine & "The program will now close") 'If all 3 tries are used, the system is shut down
                        Application.Exit()
                    Else
                        MsgBox("Incorrect password - you have " & 3 - Tries & " tries remaining")
                        txtPassword.Text = ""
                    End If
                Else
                    Me.Hide() 'If the password input matches the driver password, the driver menu is shown
                    DriverMenu.Show()
                End If
            Else
                Me.Hide() 'If the password input matches the employee password, the employee menu is shown
                MainMenu.Show()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit() 'Exits the application completely
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadInLogin(intNumofLogins, Login) 'Reads in login information
        ReadInDriverLogin(intNumofDriverLogins, DriverLogin) 'Reads in driver login information
    End Sub
End Class
