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

Public Class Form1
    Private NumberOfHouseholds, NumberOfBoreholes, NumberOfWaterSources As Integer
    Private ProgramInitialised As Boolean = False
    Private CurrentDay As Integer
    Private Households() As Household
    Private Dams As Dam
    Private Boreholes() As Borehole
    Private WaterSources() As WaterSource

    Private Sub DisplayWaterSourceProfiles()
        'Implement This
    End Sub

    Private Sub btnInit_Click(sender As Object, e As EventArgs) Handles btnInit.Click
        NumberOfHouseholds = CInt(txtHouseholds.Text)
        NumberOfBoreholes = CInt(txtBoreholes.Text)

        If NumberOfBoreholes > 0 And NumberOfHouseholds > 0 And Not ProgramInitialised Then
            ReDim Households(NumberOfHouseholds)
            ReDim Boreholes(NumberOfBoreholes)
            NumberOfWaterSources = NumberOfBoreholes

            ProgramInitialised = True
            CurrentDay = 1
            MsgBox("Program Initialised Successfully!")
        End If
    End Sub

    Private Sub btnNewDay_Click(sender As Object, e As EventArgs) Handles btnNewDay.Click
        If CurrentDay = 7 Then
            CurrentDay = 1
        Else
            CurrentDay += 1
        End If
    End Sub
End Class
