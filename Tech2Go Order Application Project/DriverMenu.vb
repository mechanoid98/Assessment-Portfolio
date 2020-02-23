Imports System.IO
Public Class DriverMenu
    Structure DriverDeliveries
        Dim OrderID As Integer
        Dim CustomerID As Integer
        Dim TotalPrice As Integer
        Dim Postcode As Integer
        Dim DriverID As Integer
    End Structure
    Dim intNumofOrderDets As Integer
    Dim intNumofDrivers As Integer
    Dim DriverNumber As Integer
    Dim OrderDetails() As OrderDetails
    Dim DriverInfo() As DriverInformation
    Dim DriverDeliveryArray() As DriverDeliveries
    Dim NumberofDeliveries As Integer
    Dim ValidateInput As New Validation
    Dim C As Integer
    Private Sub DriverMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim intCounter As Integer
        ReadInOrderDetails(intNumofOrderDets, OrderDetails)
        ReadInDriver(intNumofDrivers, DriverInfo)
        If intNumofOrderDets > 0 Then
            intCounter = 1
            txtOrderID.Text = OrderDetails(intCounter).OrderID
            txtCustomerID.Text = OrderDetails(intCounter).CustomerID
            txtTotalPrice.Text = OrderDetails(intCounter).TotalPrice
            txtPostcode.Text = OrderDetails(intCounter).Postcode
            If OrderDetails(intCounter).DriverID <> "" Then
                txtAvailability.BackColor = Color.Red
            Else
                txtAvailability.BackColor = Color.Lime
            End If
        Else
            txtOrderID.Text = ""
            txtCustomerID.Text = ""
            txtTotalPrice.Text = ""
            txtPostcode.Text = ""
            MsgBox("No Orders have been made - please check back in a short while")
        End If
        DriverOrderInfo.Rows.Clear()
        For I = 1 To intNumofOrderDets
            DriverOrderInfo.Rows.Add(OrderDetails(I).OrderID, OrderDetails(I).CustomerID, OrderDetails(I).TotalPrice, OrderDetails(I).Postcode,
                                     OrderDetails(I).DriverID)
        Next
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If intNumofOrderDets > 1 Then
            C = C + 1
            'Outputs the first person if the end of the array is reached
            If C > intNumofOrderDets Then C = 1
            txtOrderID.Text = OrderDetails(C).OrderID
            txtCustomerID.Text = OrderDetails(C).CustomerID
            txtTotalPrice.Text = OrderDetails(C).TotalPrice
            txtPostcode.Text = OrderDetails(C).Postcode
            If OrderDetails(C).DriverID <> "" Then
                txtAvailability.BackColor = Color.Red
            Else
                txtAvailability.BackColor = Color.Lime
            End If
        Else
            MsgBox("Order Directory - Empty", MsgBoxStyle.Information, "Order Directory")
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If intNumofOrderDets > 1 Then
            C = C - 1
            'Outputs the first person if the end of the array is reached
            If C < intNumofOrderDets Then C = 1
            txtOrderID.Text = OrderDetails(C).OrderID
            txtCustomerID.Text = OrderDetails(C).CustomerID
            txtTotalPrice.Text = OrderDetails(C).TotalPrice
            txtPostcode.Text = OrderDetails(C).Postcode
            If OrderDetails(C).DriverID <> "" Then
                txtAvailability.BackColor = Color.Red
            Else
                txtAvailability.BackColor = Color.Lime
            End If
        Else
            MsgBox("Order Directory - Empty", MsgBoxStyle.Information, "Order Directory")
        End If
    End Sub

    Private Sub btnmainmenu_Click(sender As Object, e As EventArgs) Handles btnmainmenu.Click
        Me.Visible = False
        LoginForm.Visible = True
    End Sub

    Private Sub btnaddorder_Click(sender As Object, e As EventArgs) Handles btnaddorder.Click
        DriverIDNumber()
        ReadInOrderDetails(intNumofOrderDets, OrderDetails)
        If OrderDetails(C).DriverID <> "" Then
            MsgBox("Order already assigned. Please choose another.")
        Else
            ReDim Preserve OrderDetails(intNumofOrderDets)
            OrderDetails(C).DriverID = DriverNumber
        End If

        ReDim Preserve DriverInfo(intNumofDrivers)
        DriverInfo(intNumofDrivers).NumberofDeliveries = NumberofDeliveries + 1

        WriteInOrderDetails(C, OrderDetails)
        WriteInDriver(intNumofDrivers, DriverInfo)

        DriverOrderInfo.Rows.Clear()
        DriverOrderInfo.Rows.Add(OrderDetails(C).OrderID, OrderDetails(C).CustomerID, OrderDetails(C).TotalPrice, OrderDetails(C).Postcode,
                                     OrderDetails(C).DriverID)
    End Sub

    Private Sub DriverIDNumber()
        Dim ValidInput As Boolean = True
        Dim intCounter As Integer
        DriverNumber = InputBox("Please enter your driver ID:")
        ValidateInput.ValidateClearAll()
        If Not ValidateInput.ValidateRequired("Driver ID", DriverNumber) Then
            ValidInput = False
        End If
        If Not ValidInput Then
            MsgBox(ValidateInput.ToString)
            DriverIDNumber()
        Else
            Dim Found As Boolean = False
            Do
                intCounter += 1
                If DriverNumber = DriverInfo(intCounter).DriverNo Then
                    NumberofDeliveries = DriverInfo(intCounter).NumberofDeliveries
                    Found = True
                End If
            Loop Until (Found = True) Or (intCounter = intNumofDrivers)
            If Found = False Then
                MsgBox("The driver ID does not exist. Please try again.")
                DriverIDNumber()
            End If
        End If
    End Sub

    Private Sub ConfirmDeliveriesPage_Click(sender As Object, e As EventArgs) Handles ConfirmDeliveriesPage.Click
        Dim temp As Integer
        Dim DriverNumber As Integer
        Dim Found As Boolean = False
        NumberofDeliveries = 0
        ReadInOrderDetails(intNumofOrderDets, OrderDetails)
        DriverNumber = InputBox("Please enter Driver ID:")
        Do
            temp += 1
            If DriverNumber = OrderDetails(temp).DriverID Then
                Found = True
                NumberofDeliveries += 1
                DriverDeliveryArray(NumberofDeliveries).OrderID = OrderDetails(temp).OrderID
                DriverDeliveryArray(NumberofDeliveries).CustomerID = OrderDetails(temp).CustomerID
                DriverDeliveryArray(NumberofDeliveries).Postcode = OrderDetails(temp).Postcode
                DriverDeliveryArray(NumberofDeliveries).TotalPrice = OrderDetails(temp).TotalPrice
                DriverDeliveryArray(NumberofDeliveries).DriverID = OrderDetails(temp).DriverID
            End If
        Loop Until (Found = True) Or (temp = intNumofOrderDets)
        DriverPersonalOrderGrid.Rows.Clear()
        For I = 1 To NumberofDeliveries
            DriverPersonalOrderGrid.Rows.Add(DriverDeliveryArray(I).OrderID, DriverDeliveryArray(I).CustomerID, DriverDeliveryArray(I).Postcode,
                                             DriverDeliveryArray(I).TotalPrice)
        Next
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If File.Exists("DeliveryInfo.txt") Then
            Dim myfilewriter As New StreamWriter("DeliveryInfo.txt")
            myfilewriter.WriteLine(NumberofDeliveries)

            For j = 1 To NumberofDeliveries
                myfilewriter.WriteLine(DriverDeliveryArray(j).OrderID)
                myfilewriter.WriteLine(DriverDeliveryArray(j).CustomerID)
                myfilewriter.WriteLine(DriverDeliveryArray(j).TotalPrice)
                myfilewriter.WriteLine(DriverDeliveryArray(j).Postcode)
                myfilewriter.WriteLine(DriverDeliveryArray(j).DriverID)
            Next
            myfilewriter.Close()
        End If
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim FileName As String = "DeliveryInfo.txt"
        Dim MyFont As New Font("Courier New", 12, FontStyle.Regular)
        Dim MyTitleFont As New Font("Courier New", 13, FontStyle.Bold Or FontStyle.Underline)
        Dim MyFormat As String = "{0, -20}{1, -10}{2, -12}"
        Dim OrderID, CustomerID, Postcode, LineToPrint As String
        Dim X, Y, TotalPrice, FontHeight As Integer
        X = 50
        Y = 50
        FontHeight = MyFont.GetHeight(e.Graphics)
        e.Graphics.DrawString(("List of Active Deliveries for Driver " & DriverDeliveryArray(C).DriverID), MyTitleFont, Brushes.Black, X, Y)
        Y = Y + FontHeight
        e.Graphics.DrawString("", MyFont, Brushes.Black, X, Y)
        Y = Y + FontHeight
        LineToPrint = String.Format(MyFormat, "Order ID", "Customer ID", "Total Price", "Postcode")
        e.Graphics.DrawString(LineToPrint, MyFont, Brushes.Black, X, Y)
        Y = Y + FontHeight
        e.Graphics.DrawString("", MyFont, Brushes.Black, X, Y)
        FileOpen(1, FileName, OpenMode.Input)
        Do While Not EOF(1)
            Input(1, OrderID)
            Input(1, CustomerID)
            Input(1, TotalPrice)
            Input(1, Postcode)
            Y = Y + FontHeight
            LineToPrint = String.Format(MyFormat, OrderID, CustomerID, Format(TotalPrice * 1000, "£#,##0"))
            e.Graphics.DrawString(LineToPrint, MyFont, Brushes.Black, X, Y)
        Loop
        FileClose(1)
    End Sub


    Private Sub btnremoveorder_Click(sender As Object, e As EventArgs) Handles btnremoveorder.Click
        DriverIDNumber()
        ReadInOrderDetails(intNumofOrderDets, OrderDetails)
        If OrderDetails(C).DriverID = DriverNumber Then
            ReDim Preserve OrderDetails(intNumofOrderDets)
            OrderDetails(C).DriverID = ""
        Else
            MsgBox("Order already assigned. Please choose another.")
        End If

        ReDim Preserve DriverInfo(intNumofDrivers)
        DriverInfo(C).NumberofDeliveries = NumberofDeliveries + 1

        WriteInOrderDetails(C, OrderDetails)
        WriteInDriver(intNumofDrivers, DriverInfo)

        DriverOrderInfo.Rows.Clear()
        DriverOrderInfo.Rows.Add(OrderDetails(C).OrderID, OrderDetails(C).CustomerID, OrderDetails(C).TotalPrice, OrderDetails(C).Postcode,
                                     OrderDetails(C).DriverID)
    End Sub

    Private Sub ConfirmDeliveriesPrevious_Click(sender As Object, e As EventArgs) Handles ConfirmDeliveriesPrevious.Click
        If NumberofDeliveries > 1 Then
            C = C - 1
            'Outputs the first person if the end of the array is reached
            If C < NumberofDeliveries Then C = 1
            txtOrderID.Text = DriverDeliveryArray(C).OrderID
            txtCustomerID.Text = DriverDeliveryArray(C).CustomerID
            txtTotalPrice.Text = DriverDeliveryArray(C).TotalPrice
            txtPostcode.Text = DriverDeliveryArray(C).Postcode
        Else
            MsgBox("Order Directory - Empty", MsgBoxStyle.Information, "Order Directory")
        End If
    End Sub

    Private Sub ConfirmDeliveriesNext_Click(sender As Object, e As EventArgs) Handles ConfirmDeliveriesNext.Click
        If NumberofDeliveries > 1 Then
            C = C + 1
            'Outputs the first person if the end of the array is reached
            If C > NumberofDeliveries Then C = 1
            txtOrderID.Text = DriverDeliveryArray(C).OrderID
            txtCustomerID.Text = DriverDeliveryArray(C).CustomerID
            txtTotalPrice.Text = DriverDeliveryArray(C).TotalPrice
            txtPostcode.Text = DriverDeliveryArray(C).Postcode
        Else
            MsgBox("Order Directory - Empty", MsgBoxStyle.Information, "Order Directory")
        End If
    End Sub
End Class