Option Strict On
Option Explicit On
Option Infer Off

' ************************************************************************************************** 
' Team Name: ELITE DUO
' Team Member 1 Details: Sibuyi, EL 226047812 
' Team Member 2 Details: Banda, I 226019541
' Practical: Group Project 
' Class name: Household
' **************************************************************************************************

Public Class Household
    Private _HouseholdID As Integer
    Private Shared IDCounter As Integer
    Private _Tap As Tap
    Private _AmountUsedInTaps As Integer

    Public Sub New(Tap As Tap)
        IDCounter += 1
        _HouseholdID = IDCounter
        _Tap = Tap
        _AmountUsedInTaps = 0
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

    Public Property AmountUsedInTaps As Integer
        Get
            Return _AmountUsedInTaps
        End Get
        Set(value As Integer)
            _AmountUsedInTaps = value
        End Set
    End Property


    'Returns True if household can still use the specified amount of water in their tap
    Private Function CanUseMoreWater(Amount As Integer) As Boolean
        Return Amount < _Tap.AvailableAmount
    End Function

    Public Sub UseTapWater(ByVal Amount As Integer)
        If CanUseMoreWater(Amount) Then
            _AmountUsedInTaps += Amount
            _Tap.UseWater(Amount)
        End If
    End Sub

    Public Sub UseBoreholeWater(Borehole As Borehole, Amount As Integer)
        Borehole.UseWater(Amount)
    End Sub

    Public Function DisplayProfile() As String
        Dim HouseholdProfile As String

        HouseholdProfile = "HouseholdID: " & Me.HouseholdID &
            vbNewLine & Me.Tap.CheckAvailability()

        Return HouseholdProfile
    End Function
End Class
