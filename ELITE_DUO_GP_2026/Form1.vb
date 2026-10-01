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
    Private MaximumTapUsage, MaximumDamCapacity As Integer
    Private ProgramInitialised As Boolean = False
    Private CurrentDay As Integer
    Private Households() As Household
    Private AreaDam As Dam
    Private Boreholes() As Borehole
    Private WaterSources() As WaterSource

    Private Sub DisplayWaterSourceProfiles()
        'Implement This
    End Sub

    Private Sub btnInit_Click(sender As Object, e As EventArgs) Handles btnInit.Click
        NumberOfHouseholds = CInt(txtHouseholds.Text)
        NumberOfBoreholes = CInt(txtBoreholes.Text)
        MaximumTapUsage = CInt(txtMaxTapUsage.Text)
        MaximumDamCapacity = CInt(txtDamMax.Text)

        If NumberOfBoreholes > 0 And NumberOfHouseholds > 0 And MaximumTapUsage > 0 And MaximumDamCapacity > 0 And Not ProgramInitialised Then
            ReDim Households(NumberOfHouseholds)
            ReDim Boreholes(NumberOfBoreholes)
            NumberOfWaterSources = NumberOfBoreholes

            For IHouse As Integer = 1 To NumberOfHouseholds
                Households(IHouse) = New Household(MaximumTapUsage, AreaDam)
            Next IHouse

            For IBorehole As Integer = 1 To NumberOfBoreholes
                Dim RefillRate As Integer = CInt(InputBox("Refill Rate of Borehole " & IBorehole))
                Boreholes(IBorehole) = New Borehole(RefillRate)
            Next IBorehole

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
