Option Strict On
Option Explicit On
Option Infer Off

' ************************************************************************************************** 
' Team Name: ELITE DUO
' Team Member 1 Details: Sibuyi, EL 226047812 
' Team Member 2 Details: Banda, I 226019541
' Practical: Group Project 
' Class name: Tap
' **************************************************************************************************

Public Class Tap
    Inherits WaterSource

    Private _Dam As Dam
    Private Shared _MaxUsableAmount As Integer

    Public Sub New(AvailAmount As Integer, dam As Dam)
        MyBase.New(AvailAmount)
        _Dam = dam
    End Sub

    Public Property Dam() As Dam
        Get
            Return _Dam
        End Get
        Set(value As Dam)
            _Dam = value
        End Set
    End Property

    Public ReadOnly Property MaxUsableAmount As Integer
        Get
            Return _MaxUsableAmount
        End Get
    End Property

    Public Overrides Sub UseWater(Amount As Integer)
        If CanUseMore(Amount) Then
            AvailableAmount -= Amount
        End If
    End Sub

    Public Overrides Function CheckAvailability() As String
        Return "Tap ID: " & Me.SourceID & vbNewLine &
             "Available Amount: " & AvailableAmount

    End Function

    Public Overrides Function CanUseMore(Amount As Integer) As Boolean
        If Amount <= Me.AvailableAmount Then
            Return True
        End If
        Return False
    End Function
End Class
