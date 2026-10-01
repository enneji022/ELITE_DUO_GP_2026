Option Strict On
Option Explicit On
Option Infer Off

' ************************************************************************************************** 
' Team Name: ELITE DUO
' Team Member 1 Details: Sibuyi, EL 226047812 
' Team Member 2 Details: Banda, I 226019541
' Practical: Group Project 
' Class name: Dam
' **************************************************************************************************
Public Class Dam
    Inherits WaterSource
    Implements IRefillable

    Private _MaxUsableAmount As Integer
    Private _MaxCapacity As Integer
    Private _WaterFlowRate As Integer

    Public Sub New(MaxCapacity As Integer)
        MyBase.New(MaxCapacity)
        _MaxCapacity = MaxCapacity
        _WaterFlowRate = CInt(MaxCapacity * (5 / 100))
        _MaxUsableAmount = CInt(MaxCapacity * (90 / 100))
    End Sub

    Public ReadOnly Property MaxUsableAmount As Integer
        Get
            Return _MaxUsableAmount
        End Get
    End Property

    Public ReadOnly Property WaterFlowRate As Integer
        Get
            Return _WaterFlowRate
        End Get
    End Property

    Public ReadOnly Property MaxCapacity As Integer
        Get
            Return _MaxCapacity
        End Get
    End Property

    Public Overrides Function CheckAvailability() As String
        Dim Availability As String
        Availability = "Dam ID: " & Me.SourceID & vbNewLine &
                        "Max capacity: " & _MaxCapacity & vbNewLine &
                        "Available amount: " & Me.AvailableAmount & vbNewLine
        Return Availability
    End Function

    Protected Overrides Function CanUseMore(Amount As Integer) As Boolean
        If Amount <= Me.AvailableAmount Then
            Return True
        End If
        Return False
    End Function

    Public Overrides Sub UseWater(Amount As Integer)
        If CanUseMore(Amount) Then
            Me.AvailableAmount -= Amount
        End If
    End Sub

    Public Sub RefillWater() Implements IRefillable.RefillWater
        Me.AvailableAmount = _MaxCapacity
    End Sub
End Class
