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

    Public Sub New()
        IDCounter += 1
        _HouseholdID = IDCounter
    End Sub

    Public ReadOnly Property HouseholdID As Integer
        Get
            Return _HouseholdID
        End Get
    End Property

    Public Function DisplayProfile() As String
        Return " " 'Don't forget to implement this
    End Function
End Class
