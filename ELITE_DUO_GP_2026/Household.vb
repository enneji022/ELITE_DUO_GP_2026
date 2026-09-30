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

Public Class Household
    Private _HouseholdID As Integer
    Private Shared IDCounter As Integer
    Private _Tap As Tap
    Private _AmountUsed As Integer

    Public Sub New(Tap As Tap)
        IDCounter += 1
        _HouseholdID = IDCounter
        _Tap = Tap
        _AmountUsed = 0
    End Sub

    Public ReadOnly Property HouseholdID As Integer
        Get
            Return _HouseholdID
        End Get
    End Property

    Public Property Tap As Tap
        Get
            Return _Tap
        End Get
        Set(value As Tap)
            _Tap = value
        End Set
    End Property

    Public Property AmountUsed As Integer
        Get
            Return _AmountUsed
        End Get
        Set(value As Integer)
            _AmountUsed = value
        End Set
    End Property

    'Returns True if household can still use the specified amount of water in their tap
    Private Function CanUseMoreWater(Amount As Integer) As Boolean
        If Amount < _Tap.AvailableAmount And Not _Tap.IsFaulty Then
            Return True
        End If

        Return False
    End Function

    Public Sub UseTapWater(ByVal Amount As Integer)
        If CanUseMoreWater(Amount) Then
            _AmountUsed += Amount
        End If
    End Sub

    Public Sub UseBoreholeWater(Borehole As Borehole, Amount As Integer)
        'Don't forget to implement this function
    End Sub

    Private Function GetTapCondition() As String
        If Me.Tap.IsFaulty Then
            Return "Broken!"
        End If

        Return "Good!"
    End Function

    Public Function DisplayProfile() As String
        Dim HouseholdProfile As String

        HouseholdProfile = "HouseholdID: " & Me.HouseholdID &
            vbNewLine & Me.Tap.CheckAvailability() &
        vbNewLine "Tap Condition: " & GetTapCondition()

        Return HouseholdProfile
    End Function

    Public Sub ReportFaultyTap()
        Me.Tap.IsFaulty = True
    End Sub
End Class
