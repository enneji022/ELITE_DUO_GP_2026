Option Strict On
Option Explicit On
Option Infer Off

' ************************************************************************************************** 
' Team Name: ELITE DUO
' Team Member 1 Details: Sibuyi, EL 226047812 
' Team Member 2 Details: Banda, I 226019541
' Practical: Group Project 
' Class name: Borehole
' **************************************************************************************************
Public Class Borehole
    Inherits WaterSource
    Implements IRefillable

    Private _RefillRate As Integer
    Public Sub New(RefillRate As Integer)
        MyBase.New(RefillRate)
        _RefillRate = RefillRate
    End Sub

    Public ReadOnly Property RefillRate As Integer
        Get
            Return _RefillRate
        End Get
    End Property

    Public Overrides Sub UseWater(Amount As Integer)
        If CanUseMore(Amount) Then
            AvailableAmount -= CInt(Amount * (5 / 100))
        End If
    End Sub

    Public Overrides Function CheckAvailability() As String
        Return "Borehole ID: " & Me.SourceID & vbNewLine &
                "Available Amount: " & Me.AvailableAmount & vbNewLine
    End Function

    Public Sub RefillWater() Implements IRefillable.RefillWater
        Me.AvailableAmount = _RefillRate
    End Sub

    Protected Overrides Function CanUseMore(Amount As Integer) As Boolean
        If Amount <= Me.AvailableAmount Then
            Return True
        End If

        Return False
    End Function

End Class
