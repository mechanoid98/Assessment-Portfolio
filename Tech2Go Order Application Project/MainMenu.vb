Imports System.IO
Public Class MainMenu
    Dim myfilereader As StreamReader 'Calls the streamreader function
    Dim intNumofRecs As Integer 'Declares all global variables for the form
    Dim myEmployeeInfoArray() As EmployeeInformation
    Dim myEmployeenewLoginArray() As newLoginInformation
    Dim intNumofEmployees As Integer
    Dim intNumofLogins As Integer
    Dim strMyFileName As String
    Dim ValidateInput As New Validation 'Calls the validation function
    Dim CorrectPassword As String = String.Empty
    Dim Username As String = String.Empty
    Dim NewPassword As String = String.Empty
    Dim intCounter As Integer

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Me.Visible = False
        OrderForm.Visible = True 'Takes the employee to the new order form
        OrderForm.lstProdNums.Items.Clear()
        OrderForm.lstProductNames.Items.Clear() 'Clears all the list boxes on the form
        OrderForm.lstNumofProds.Items.Clear()
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        UsernameSearch() 'Takes the user to the username search function
    End Sub

    Private Sub UsernameSearch()
        Dim ValidInput As Boolean = True
        Username = InputBox("Please enter your username:") 'Asks the user to input their username
        If Username = "" Then
            MsgBox("Please input your username") 'If the input box is empty, an error message is shown
            UsernameSearch()
        Else
            ValidateInput.ValidateClearAll()
            If Not ValidateInput.ValidateRequired("Username", Username) Then 'Checks if the input box is empty
                ValidInput = False
            End If
            If Not ValidInput Then
                MsgBox(ValidateInput.ToString) 'The error message is output in a message box
                UsernameSearch()
            Else
                Dim Found As Boolean = False

                Do
                    intCounter += 1
                    If Username = Decryption(myEmployeenewLoginArray(intCounter).newUsername) Then 'If the username input matches a username in the text file, the password for that user is then assigned to a variable
                        Found = True
                        CorrectPassword = Decryption(myEmployeenewLoginArray(intCounter).newPassword)
                        PasswordCheck()
                    End If
                Loop Until (Found = True) Or (intCounter = intNumofLogins) 'Loops until a username is found or the end of the array is reached

                If Found = False Then
                    MsgBox("The username does not exist") 'If there is no username found, an error message is shown
                    UsernameSearch() 'The function is called again
                End If
        End If
        End If
    End Sub
    Private Sub PasswordCheck()
        Dim ValidInput As Boolean = True
        Dim Password As String
        Static Tries As Integer
        Password = InputBox("Please enter your current password:") 'The user is asked to enter their current password (for security purposes)
        If Password = "" Then
            MsgBox("Please enter your password") ' If no password is input, an error message is shown
            PasswordCheck()
        Else
            ValidateInput.ValidateClearAll()
            If Not ValidateInput.ValidateRequired("Password", Password) Then 'Checks if there is anything in the input box
                ValidInput = False
            End If
            If Not ValidInput Then
                MsgBox(ValidateInput.ToString) 'Outputs an error message into a message box
                PasswordCheck()
            Else
                If Password = CorrectPassword Then 'If the password matches the correct password already stored as a variable on the system, it calls the next function
                    EnterNewPassword()
                Else
                    Tries += 1 'Increments the number of tries by 1
                    If Tries = 3 Then 'If the number of tries = 3, the user is shown an error message and is logged out of the system
                        MsgBox("Incorrect password - you have no tries remaining." & vbNewLine & "Logging out")
                        Me.Visible = False
                        LoginForm.Visible = True
                    Else
                        MsgBox("The password entered does not match the username given - you have " & 3 - Tries & " tries remaining") 'If the number of tries does not = 3, the user is shown an error message and the loop occurs again
                        PasswordCheck() 'The function is called again
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub EnterNewPassword()
        Dim ValidInput As Boolean = True
        NewPassword = InputBox("Please enter your new password:") 'The user is asked to input their chosen new password
        If NewPassword = "" Then
            MsgBox("Please input a new password") 'If the input box is empty, an error message is shown
            EnterNewPassword()
        Else
            ValidateInput.ValidateClearAll()
            If Not ValidateInput.ValidateRequired("New password", NewPassword) Then 'If the input box is empty an error message is created
                ValidInput = False
            End If
            If Not ValidInput Then
                MsgBox(ValidateInput.ToString) 'The error message made is output into a message box
                EnterNewPassword() 'The function is called again
            Else
                ValidateNewPassword() 'The next function is called
            End If
        End If
    End Sub

    Private Sub ValidateNewPassword()
        Dim VerifyNewPassword As String
        Dim ValidInput As Boolean = True
        Static Tries As Integer
        VerifyNewPassword = InputBox("Please re-enter new password:") 'Calls an input box
        If VerifyNewPassword = "" Then
            MsgBox("Please re-enter your new password") 'If the input box is empty, an error message is shown
            ValidateNewPassword() 'The function is called again
        Else
            ValidateInput.ValidateClearAll()
            If Not ValidateInput.ValidateRequired("New password", VerifyNewPassword) Then 'If the input box is empty, an error message is created
                ValidInput = False
            End If
            If Not ValidInput Then
                MsgBox(ValidateInput.ToString) 'The rror message is output into a message box
                ValidateNewPassword() 'The function is called again
            Else
                If NewPassword <> VerifyNewPassword Then
                    Tries += 1 'Increments the number of tries by 1
                    If Tries = 3 Then 'If the number of tries = 3, an error message is shown and the user is logged out
                        MsgBox("Incorrect password - you have no tries remaining." & vbNewLine & "Logging out")
                        LoginForm.txtUsername.Text = ""
                        LoginForm.txtPassword.Text = ""
                        Me.Visible = False
                        LoginForm.Visible = True
                    Else 'If the number of tries does not = 3 then a message box is shown and the function is called again
                        MsgBox("The password entered does not match the previous password - you have " & 3 - Tries & " remaining")
                        ValidateNewPassword()
                    End If
                Else
                    ReDim Preserve myEmployeenewLoginArray(intNumofLogins)
                    myEmployeenewLoginArray(intCounter).newUsername = Encryption(Username) 'The information is read into the array
                    myEmployeenewLoginArray(intCounter).newPassword = Encryption(NewPassword)

                    WriteInnewLogin(intNumofLogins, myEmployeenewLoginArray) 'The information from the array is written into the employee login text file

                    MsgBox("Your password has been successfully changed.") 'A message box is shown
                End If
            End If
        End If
    End Sub
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadInnewLogin(intNumofLogins, myEmployeenewLoginArray) 'Information from the employee login infoirmation text file is read into the array
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Visible = False
        LoginForm.Visible = True
        LoginForm.txtUsername.Text = ""
        LoginForm.txtPassword.Text = ""
    End Sub

    Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click
        SaitamaPanel.Visible = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        SaitamaPanel.Visible = False
    End Sub
End Class