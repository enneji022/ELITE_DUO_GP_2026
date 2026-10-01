Option Strict On
Option Explicit On
Option Infer Off

' ************************************************************************************************** 
' Team Name: ELITE DUO
' Team Member 1 Details: Sibuyi, EL 226047812 
' Team Member 2 Details: Banda, I 226019541
' Practical: Group Project 
' Class name: IUsageLimitable
' **************************************************************************************************
Public MustInherit Class WaterSource
    Private _SourceID As Integer
    Private Shared _IDCounter As Integer = 0
    Private _AvailableAmount As Integer

    Public Sub New(AvailAmount As Integer)
        _IDCounter += 1
        _SourceID = _IDCounter
        _AvailableAmount = AvailAmount
    End Sub

    Public ReadOnly Property SourceID() As Integer
        Get
            Return _SourceID
        End Get
    End Property

    Public Property AvailableAmount() As Integer
        Get
            Return _AvailableAmount
        End Get
        Set(value As Integer)
            _AvailableAmount = value
        End Set
    End Property


    Public MustOverride Function CheckAvailability() As String

    Public MustOverride Sub UseWater(Amount As Integer)

    Public MustOverride Function CanUseMore(Amount As Integer) As Boolean

End Class
