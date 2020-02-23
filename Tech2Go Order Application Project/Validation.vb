Imports System.Text
Public Class Validation

    Private _ValidationList As Dictionary(Of String, String)

    Public Property ValidationList As Dictionary(Of String, String)
        Get
            Return _ValidationList
        End Get
        Set(ByVal value As Dictionary(Of String, String))
            _ValidationList = value
        End Set
    End Property

    Public Sub New()
        ValidationList = New Dictionary(Of String, String)
    End Sub

    Public Sub ValidateClearAll()
        ValidationList.Clear()
    End Sub

    Private Sub AddValidationError(ByVal PropertyName As String, ByVal message As String)
        If ValidationList.ContainsKey(PropertyName) Then
            Dim existingmessage As String = ValidationList(PropertyName)
            If Not existingmessage.Contains(message) Then
                ValidationList(PropertyName) &= "; " & message
            End If
        Else
            ValidationList.Add(PropertyName, message)
        End If
    End Sub

    Public Function ValidateRequired(ByVal PropertyName As String, ByVal value As String)
        Dim message As String = String.Empty
        If String.IsNullOrEmpty(value) Then
            message = String.Format("{0} is required. Please enter valid value.", PropertyName)
            AddValidationError(PropertyName, message)
            Return False
        Else
            Return True
        End If
    End Function
    Public Function ValidateLength(ByVal PropertyName As String, ByVal value As String, ByVal maxLength As Integer)
        Dim sMessage As String = String.Empty
        If Not String.IsNullOrEmpty(value) AndAlso value.Length > maxLength Then
            sMessage = String.Format("{0} has a maximum size of {1}", PropertyName, maxLength)
            AddValidationError(PropertyName, sMessage)
            Return False
        Else
            Return True
        End If
    End Function
    Public Function ValidateFormat(ByVal PropertyName As String, ByVal value As String)
        Dim sMessage As String = String.Empty
        If Not String.IsNullOrEmpty(value) AndAlso Not IsNumeric(value) Then
            sMessage = String.Format("{0} should only be made up of numeric values", PropertyName)
            AddValidationError(PropertyName, sMessage)
            Return False
        Else
            Return True
        End If
    End Function
    Public Overrides Function ToString() As String
        Dim sb As New StringBuilder
        For Each k As String In ValidationList.Keys
            sb.AppendLine(k & "; " & ValidationList(k))
        Next
        Return sb.ToString()
    End Function
End Class

