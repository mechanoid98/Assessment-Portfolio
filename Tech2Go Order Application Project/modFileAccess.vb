Imports System.IO
Module modFileAccess
    Dim myfilereader As StreamReader 'Stream reader and stream writer are declared
    Dim myfilewriter As StreamWriter
    Structure OrderArray 'Order Array structure is declared
        Dim CustomerID As Integer
        Dim EmployeeID As Integer
        Dim NumofItems As Integer
        Dim ProductNo As String
    End Structure
    Structure CustomerInfoArray 'Customer Info structure is declared
        Dim CustomerID As Integer
        Dim FirstName As String
        Dim Surname As String
        Dim HomeTelNum As String
        Dim MobTelNum As String
        Dim Address As String
        Dim TownProvince As String
        Dim PostCode As String
        Dim Email As String
    End Structure
    Structure ProductInfoArray 'Product Info Array structure is declared
        Dim ProductNo As Integer
        Dim ProductName As String
        Dim ProductPrice As Double
        Dim ProductStock As Integer
    End Structure
    Structure OrderDetails 'Order Details structure is declared
        Dim OrderID As Integer
        Dim CustomerID As Integer
        Dim TotalPrice As Double
        Dim Postcode As String
        Dim DriverID As String
    End Structure
    Structure LoginInformation 'Login Information structure is declared
        Dim Username As String
        Dim Password As String
    End Structure
    Structure EmployeeInformation 'Employee Information structure is declared
        Dim EmployeeID As Integer
        Dim EmployeeFirstName As String
        Dim EmployeeSurname As String
        Dim EmployeeGender As Char
    End Structure
    Structure DriverLoginInformation 'Driver Login Information Structure is declared
        Dim DriverUsername As String
        Dim DriverPassword As String
    End Structure
    Structure DriverInformation 'Driver Information Structure is declared
        Dim DriverNo As Integer
        Dim DriverFirstName As String
        Dim DriverSurname As String
        Dim DriverGender As Char
        Dim NumberofDeliveries As Integer
    End Structure
    Structure newLoginInformation 'newLoginInfromation structure is declared
        Dim newUsername As String
        Dim newPassword As String
    End Structure
    Dim Orders() As OrderArray 'All arrays and global variables are declared
    Dim Customers() As CustomerInfoArray
    Dim Products() As ProductInfoArray
    Dim OrderDets() As OrderDetails
    Dim Login() As LoginInformation
    Dim Employees() As EmployeeInformation
    Dim DriverLogin() As DriverLoginInformation
    Dim Drivers() As DriverInformation
    Dim newLogin() As newLoginInformation
    Dim strMyFileName As String
    Dim strResult As String
    Dim Key As String = "6"

    Public Sub ReadInOrder(ByRef intNumofOrders As Integer, ByRef Orders() As OrderArray)
        Dim intCounter As Integer
        strMyFileName = "OrderInfo.txt" 'Declares the file name
        myfilereader = New StreamReader(strMyFileName) 'Creates new streamreader
        intNumofOrders = myfilereader.ReadLine 'Sets the number of records in the array
        ReDim Preserve Orders(intNumofOrders)

        intCounter = 0
        Do Until myfilereader.EndOfStream = True 'Reads in all information from the text file into the array
            intCounter = intCounter + 1
            Orders(intCounter).CustomerID = myfilereader.ReadLine
            Orders(intCounter).EmployeeID = myfilereader.ReadLine
            Orders(intCounter).ProductNo = myfilereader.ReadLine
            Orders(intCounter).NumofItems = myfilereader.ReadLine
        Loop
        myfilereader.Close()
    End Sub

    Public Sub ReadInCustomers(ByRef intNumofCustomers As Integer, ByRef Customers() As CustomerInfoArray)
        Dim intCounter As Integer
        strMyFileName = "CustomerInfo.txt" 'Declares the file name
        myfilereader = New StreamReader(strMyFileName) 'Creates new streamreader
        intNumofCustomers = myfilereader.ReadLine 'Sets the number of records in the array
        ReDim Preserve Customers(intNumofCustomers)

        intCounter = 0
        Do Until myfilereader.EndOfStream = True 'Read in all the information from the text file into the array
            intCounter = intCounter + 1
            Customers(intCounter).CustomerID = myfilereader.ReadLine
            Customers(intCounter).FirstName = myfilereader.ReadLine
            Customers(intCounter).Surname = myfilereader.ReadLine
            Customers(intCounter).HomeTelNum = myfilereader.ReadLine
            Customers(intCounter).MobTelNum = myfilereader.ReadLine
            Customers(intCounter).Address = myfilereader.ReadLine
            Customers(intCounter).TownProvince = myfilereader.ReadLine
            Customers(intCounter).PostCode = myfilereader.ReadLine
            Customers(intCounter).Email = myfilereader.ReadLine
        Loop
        myfilereader.Close()
    End Sub

    Public Sub ReadInProducts(ByRef intNumofProducts As Integer, ByRef Products() As ProductInfoArray)
        Dim intCounter As Integer
        strMyFileName = "ProductInfo.txt" 'Declares the file name
        myfilereader = New StreamReader(strMyFileName) 'Creates new streamreader
        intNumofProducts = myfilereader.ReadLine 'Sets the number of records in the array
        ReDim Preserve Products(intNumofProducts)

        intCounter = 0
        Do Until myfilereader.EndOfStream = True 'Reads in all the information from the text file into the array
            intCounter = intCounter + 1
            Products(intCounter).ProductNo = myfilereader.ReadLine
            Products(intCounter).ProductName = myfilereader.ReadLine
            Products(intCounter).ProductPrice = myfilereader.ReadLine
            Products(intCounter).ProductStock = myfilereader.ReadLine
        Loop
        myfilereader.Close()
    End Sub

    Public Sub ReadInOrderDetails(ByRef intNumofOrderDets As Integer, ByRef OrderDets() As OrderDetails)
        Dim intCounter As Integer
        strMyFileName = "OrderDetails.txt" 'Decalres the file name
        myfilereader = New StreamReader(strMyFileName) 'Creates new streamreader
        intNumofOrderDets = myfilereader.ReadLine 'Sets the number of records in the array
        ReDim Preserve OrderDets(intNumofOrderDets)

        intCounter = 0
        Do Until myfilereader.EndOfStream = True 'Reads in all the information from the text file into the array
            intCounter = intCounter + 1
            OrderDets(intCounter).OrderID = myfilereader.ReadLine
            OrderDets(intCounter).CustomerID = myfilereader.ReadLine
            OrderDets(intCounter).TotalPrice = myfilereader.ReadLine
            OrderDets(intCounter).Postcode = myfilereader.ReadLine
            OrderDets(intCounter).DriverID = myfilereader.ReadLine
        Loop
        myfilereader.Close()
    End Sub
    Public Sub ReadInLogin(ByRef intNumofLogins As Integer, ByRef Login() As LoginInformation)
        intNumofLogins = 0
        If File.Exists("LoginInfo.txt") Then 'Checks if the file exists
            Dim myfilereader = New StreamReader("LoginInfo.txt") 'Creates new streamreader
            intNumofLogins = myfilereader.ReadLine 'Sets the number of records in the array
            ReDim Preserve Login(intNumofLogins)
            For intCounter = 1 To intNumofLogins 'Reads all information from the text file into the array
                Login(intCounter).Username = myfilereader.ReadLine
                Login(intCounter).Password = myfilereader.ReadLine
            Next
            myfilereader.Close()
        Else
            MsgBox("Login File does not exist", MsgBoxStyle.Information, "Login File") 'Creates an error message telling the user that the file does not exist
        End If
    End Sub

    Public Sub ReadInEmployee(ByRef intNumofEmployees As Integer, ByRef Employees() As EmployeeInformation)
        Dim intCounter As Integer
        strMyFileName = "EmployeeInfo.txt" 'Declares the file name
        myfilereader = New StreamReader(strMyFileName) 'Creates a new stream reader
        intNumofEmployees = myfilereader.ReadLine 'Sets the number of records in the array
        ReDim Preserve Employees(intNumofEmployees)

        intCounter = 0
        Do Until myfilereader.EndOfStream = True 'Reads all the information from the text file into the array
            intCounter = intCounter + 1
            Employees(intCounter).EmployeeID = myfilereader.ReadLine
            Employees(intCounter).EmployeeFirstName = myfilereader.ReadLine
            Employees(intCounter).EmployeeSurname = myfilereader.ReadLine
            Employees(intCounter).EmployeeGender = myfilereader.ReadLine
        Loop
        myfilereader.Close()
    End Sub

    Public Sub ReadInDriverLogin(ByRef intNumofDriverLogin As Integer, ByRef DriverLogin() As DriverLoginInformation)
        Dim intCounter As Integer
        strMyFileName = "DriverLogin.txt" 'Declares the file name
        myfilereader = New StreamReader(strMyFileName) 'Creates a new stream reader
        intNumofDriverLogin = myfilereader.ReadLine 'Sets the number of recrods in the array
        ReDim Preserve DriverLogin(intNumofDriverLogin)

        intCounter = 0
        Do Until myfilereader.EndOfStream = True 'Reads all the information from the text file into the array
            intCounter = intCounter + 1
            DriverLogin(intCounter).DriverUsername = myfilereader.ReadLine
            DriverLogin(intCounter).DriverPassword = myfilereader.ReadLine
        Loop
        myfilereader.Close()
    End Sub

    Public Sub ReadInDriver(ByRef intNumofDrivers As Integer, ByRef Drivers() As DriverInformation)
        Dim intCounter As Integer 'Declares the file name
        strMyFileName = "DriverInfo.txt" 'Creates a new stream reader
        myfilereader = New StreamReader(strMyFileName) 'Sets the number of records in the array
        intNumofDrivers = myfilereader.ReadLine
        ReDim Preserve Drivers(intNumofDrivers)

        intCounter = 0
        Do Until myfilereader.EndOfStream = True 'Reads all the information from the text file into the array
            intCounter = intCounter + 1
            Drivers(intCounter).DriverNo = myfilereader.ReadLine
            Drivers(intCounter).DriverFirstName = myfilereader.ReadLine
            Drivers(intCounter).DriverSurname = myfilereader.ReadLine
            Drivers(intCounter).DriverGender = myfilereader.ReadLine
            Drivers(intCounter).NumberofDeliveries = myfilereader.ReadLine
        Loop
        myfilereader.Close()
    End Sub

    Public Sub ReadInnewLogin(ByRef intNumofLogins As Integer, ByRef newLogin() As newLoginInformation)
        Dim intCounter As Integer
        strMyFileName = "LoginInfo.txt" 'Declares the file name
        myfilereader = New StreamReader(strMyFileName) 'Creates a new stream reader
        intNumofLogins = myfilereader.ReadLine 'Sets the number of records in the array
        ReDim Preserve newLogin(intNumofLogins)

        intCounter = 0
        Do Until myfilereader.EndOfStream = True 'Reads all the information from the text file into the array
            intCounter = intCounter + 1
            newLogin(intCounter).newUsername = myfilereader.ReadLine
            newLogin(intCounter).newPassword = myfilereader.ReadLine
        Loop
        myfilereader.Close()
    End Sub

    Public Sub WriteInOrder(ByRef intNumofOrders As Integer, ByRef Orders() As OrderArray)
        strMyFileName = "OrderInfo.txt" 'Decalres the file name
        myfilewriter = New StreamWriter(strMyFileName) 'Declares new stream writer
        myfilewriter.WriteLine(intNumofOrders) 'Sets the number of lines to be written as the number of records in the array

        For intCounter = 1 To intNumofOrders
            myfilewriter.WriteLine(Orders(intCounter).CustomerID) 'Writes in information from the array into the text file
            myfilewriter.WriteLine(Orders(intCounter).EmployeeID)
            myfilewriter.WriteLine(Orders(intCounter).NumofItems)
            myfilewriter.WriteLine(Orders(intCounter).ProductNo)
        Next
        myfilewriter.Close()
    End Sub

    Public Sub WriteInCustomers(ByRef intNumofCustomers As Integer, ByRef Customers() As CustomerInfoArray)
        strMyFileName = "CustomerInfo.txt" 'Declares the file name
        myfilewriter = New StreamWriter(strMyFileName) 'Creates new stream writer
        myfilewriter.WriteLine(intNumofCustomers) 'Sets the number of lines to be written as the number of records in the array

        For intCounter = 1 To intNumofCustomers
            myfilewriter.WriteLine(Customers(intNumofCustomers).CustomerID) 'Writes in information from the array into the text file
            myfilewriter.WriteLine(Customers(intNumofCustomers).FirstName)
            myfilewriter.WriteLine(Customers(intNumofCustomers).Surname)
            myfilewriter.WriteLine(Customers(intCounter).HomeTelNum)
            myfilewriter.WriteLine(Customers(intCounter).MobTelNum)
            myfilewriter.WriteLine(Customers(intCounter).Address)
            myfilewriter.WriteLine(Customers(intCounter).TownProvince)
            myfilewriter.WriteLine(Customers(intCounter).PostCode)
            myfilewriter.WriteLine(Customers(intCounter).Email)
        Next
        myfilewriter.Close()
    End Sub

    Public Sub WriteInProducts(ByRef intNumofProducts As Integer, ByRef Products() As ProductInfoArray)
        strMyFileName = "ProductInfo.txt" 'Declares the text file
        myfilewriter = New StreamWriter(strMyFileName) 'Creates new stream writer
        myfilewriter.WriteLine(intNumofProducts) 'Sets the number of lines to be written as the number of records in the array

        For intCounter = 1 To intNumofProducts
            myfilewriter.WriteLine(Products(intCounter).ProductNo) 'Writes in information from the array into the text file
            myfilewriter.WriteLine(Products(intCounter).ProductName)
            myfilewriter.WriteLine(Products(intCounter).ProductPrice)
            myfilewriter.WriteLine(Products(intCounter).ProductStock)
        Next
        myfilewriter.Close()
    End Sub

    Public Sub WriteInOrderDetails(ByRef intNumofOrderDets As Integer, ByRef OrderDets() As OrderDetails)
        strMyFileName = "OrderDetails.txt" 'Declares the text file
        myfilewriter = New StreamWriter(strMyFileName) 'Creates new stream writer
        myfilewriter.WriteLine(intNumofOrderDets) 'Sets the number of lines to be written as the number of records in the array

        For intCounter = 1 To intNumofOrderDets
            myfilewriter.WriteLine(OrderDets(intCounter).OrderID) 'Writes information from the array into the text file
            myfilewriter.WriteLine(OrderDets(intCounter).CustomerID)
            myfilewriter.WriteLine(OrderDets(intCounter).TotalPrice)
            myfilewriter.WriteLine(OrderDets(intCounter).Postcode)
            myfilewriter.WriteLine(OrderDets(intCounter).DriverID)
        Next
        myfilewriter.Close()
    End Sub

    Public Sub WriteInLogin(ByRef intNumofLogins As Integer, ByRef Login() As LoginInformation)
        strMyFileName = "LoginInfo.txt" 'Declares file name
        myfilewriter = New StreamWriter(strMyFileName) 'Creates new stream writer
        myfilewriter.WriteLine(intNumofLogins) 'Sets the number of lines to be written on as the number of records in the text file

        For intcounter = 1 To intNumofLogins
            myfilewriter.WriteLine(Login(intcounter).Username) 'Writes information from the array into the text file
            myfilewriter.WriteLine(Login(intcounter).Password)
        Next
        myfilewriter.Close()
    End Sub

    Public Sub WriteInEmployee(ByRef intNumofEmployee As Integer, ByRef Employee() As EmployeeInformation)
        strMyFileName = "EmployeeInfo.txt" 'Declares file name
        myfilewriter = New StreamWriter(strMyFileName) 'Creates new stream writer
        myfilewriter.WriteLine(intNumofEmployee) 'Sets the number of lines to be written on as the number of records in the text file

        For intcounter = 1 To intNumofEmployee
            myfilewriter.WriteLine(Employee(intcounter).EmployeeID) 'Writes information from the array into the text file
            myfilewriter.WriteLine(Employee(intCounter).EmployeeFirstName)
            myfilewriter.WriteLine(Employee(intcounter).EmployeeSurname)
            myfilewriter.WriteLine(Employee(intcounter).EmployeeGender)
        Next
        myfilewriter.Close()
    End Sub

    Public Sub WriteInDriverLogin(ByRef intNumofDriverLogin As Integer, ByRef DriverLogin() As DriverLoginInformation)
        strMyFileName = "DriverLogin.txt" 'Declares file name
        myfilewriter = New StreamWriter(strMyFileName) 'Creates new stream writer
        myfilewriter.WriteLine(intNumofDriverLogin) 'Sets the number of lines to be written on as the number of records in the text file

        For intCounter = 1 To intNumofDriverLogin
            myfilewriter.WriteLine(DriverLogin(intCounter).DriverUsername) 'Writes information from the array into the text file
            myfilewriter.WriteLine(DriverLogin(intCounter).DriverPassword)
        Next
        myfilewriter.Close()
    End Sub

    Public Sub WriteInDriver(ByRef intNumofDrivers As Integer, ByRef Driver() As DriverInformation)
        strMyFileName = "DriverInfo.txt" 'Declares file name
        myfilewriter = New StreamWriter(strMyFileName) 'Creates new stream writer
        myfilewriter.WriteLine(intNumofDrivers) 'Sets the number of lines to be written on as the number of records in the text file

        For intCounter = 1 To intNumofDrivers
            myfilewriter.WriteLine(Driver(intCounter).DriverNo) 'Writes information from the array into the text file
            myfilewriter.WriteLine(Driver(intCounter).DriverFirstName)
            myfilewriter.WriteLine(Driver(intCounter).DriverSurname)
            myfilewriter.WriteLine(Driver(intCounter).DriverGender)
            myfilewriter.WriteLine(Driver(intCounter).NumberofDeliveries)
        Next
        myfilewriter.Close()
    End Sub

    Public Sub WriteInnewLogin(ByRef intNumofLogins As Integer, ByRef newLogin() As newLoginInformation)
        strMyFileName = "LoginInfo.txt" 'Declares file name
        myfilewriter = New StreamWriter(strMyFileName) 'Creates new stream writer
        myfilewriter.WriteLine(intNumofLogins) 'Sets the number of lines to be written on as the number of records in the text file

        For intCounter = 1 To intNumofLogins
            myfilewriter.WriteLine(newLogin(intCounter).newUsername) 'Writes information from the array into the text file
            myfilewriter.WriteLine(newLogin(intCounter).newPassword)
        Next
        myfilewriter.Close()
    End Sub

    Public Function Encryption(ByVal DataToEncrypt As String) As String
        Dim NewString As String = String.Empty
        Dim Code As Short = 123
        Dim Letter As Char
        For i = 1 To DataToEncrypt.Length
            Letter = Mid(DataToEncrypt, i, 1)
            NewString &= (Asc(Letter) Xor Code) & " "
        Next i
        Encryption = NewString
    End Function

    Public Function Decryption(ByVal DataToDecrypt As String) As String
        Dim EncryptedPassword As String
        Dim DecryptedString As String = String.Empty
        Dim Code As Integer = 123
        Dim Numbers() As String
        Dim Number As Integer
        Dim ch As Char
        EncryptedPassword = DataToDecrypt.Trim
        Numbers = EncryptedPassword.Split(" ")
        For i = 0 To Numbers.Length - 1
            Number = CShort(Numbers(i))
            ch = Chr(Number Xor Code)
            DecryptedString &= ch
        Next
        Decryption = DecryptedString
    End Function
End Module

