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
    Private NumberOfHouseholds, NumberOfBoreholes As Integer
    Private MaximumTapUsage, MaximumDamCapacity As Integer
    Private ProgramInitialised As Boolean = False
    Private CurrentDay As Integer
    Private Households() As Household
    Private AreaDam As Dam
    Private Boreholes() As Borehole

    Private Sub DisplayWaterSourceProfiles(ByRef AreaDam As Dam, ByRef Boreholes() As Borehole, ByVal NumberOfBoreholes As Integer, ByVal DayNumber As Integer)
        Dim NumberOfWaterSources As Integer = NumberOfBoreholes + 1
        Dim WaterSources() As WaterSource

        ReDim WaterSources(NumberOfWaterSources)
        WaterSources(1) = AreaDam

        For IWaterSource As Integer = 2 To WaterSources.Length - 1
            WaterSources(IWaterSource) = Boreholes(IWaterSource - 1)
        Next IWaterSource

        txtWaterSources.Text = "Day " & DayNumber & vbNewLine
        For IWaterSource As Integer = 1 To WaterSources.Length - 1
            txtWaterSources.Text &= WaterSources(IWaterSource).CheckAvailability() & vbNewLine
        Next IWaterSource
    End Sub

    Private Sub btnInit_Click(sender As Object, e As EventArgs) Handles btnInit.Click
        NumberOfHouseholds = CInt(txtHouseholds.Text)
        NumberOfBoreholes = CInt(txtBoreholes.Text)
        MaximumTapUsage = CInt(txtMaxTapUsage.Text)
        MaximumDamCapacity = CInt(txtDamMax.Text)

        If NumberOfBoreholes > 0 And NumberOfHouseholds > 0 And MaximumTapUsage > 0 And MaximumDamCapacity > 0 And Not ProgramInitialised Then
            ReDim Households(NumberOfHouseholds)
            ReDim Boreholes(NumberOfBoreholes)

            AreaDam = New Dam(MaximumDamCapacity)

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
            DisplayWaterSourceProfiles(AreaDam, Boreholes, Boreholes.Length - 1, CurrentDay)
        End If
    End Sub

    Private Sub btnHouseProfile_Click(sender As Object, e As EventArgs) Handles btnHouseProfile.Click
        Dim HouseChoice As Integer = CInt(InputBox("Enter the House Choice. (1-" & Households.Length - 1 & ")"))
        If HouseChoice > 0 And HouseChoice <= Households.Length - 1 Then
            txtHouse.Text = Households(HouseChoice).DisplayProfile()
        Else
            MsgBox("Invalid House Choice!")
        End If
    End Sub

    Private Sub btnHouseWater_Click(sender As Object, e As EventArgs) Handles btnHouseWater.Click
        Dim HouseChoice As Integer = CInt(InputBox("Enter the House Choice. (1-" & Households.Length - 1 & ")"))
        Dim Amount As Integer = CInt(InputBox("Enter the amount of water."))

        If HouseChoice > 0 And HouseChoice <= Households.Length - 1 Then
            If Amount > 0 Then
                Households(HouseChoice).UseTapWater(Amount)
                DisplayWaterSourceProfiles(AreaDam, Boreholes, Boreholes.Length - 1, CurrentDay)
            Else
                MsgBox("Invalid Amount Entered!")
            End If
        Else
            MsgBox("Invalid House Choice!")
        End If
    End Sub

    Private Sub btnUseBorehole_Click(sender As Object, e As EventArgs) Handles btnUseBorehole.Click
        Dim HouseChoice As Integer = CInt(InputBox("Enter the House Choice. (1-" & Households.Length - 1 & ")"))
        Dim BoreholeChoice As Integer = CInt(InputBox("Enter the Borehole Choice. (1-" & Boreholes.Length - 1 & ")"))
        Dim Amount As Integer = CInt(InputBox("Enter the amount of water."))

        If HouseChoice > 0 And HouseChoice <= Households.Length - 1 Then
            If Amount > 0 Then
                If BoreholeChoice > 0 And BoreholeChoice <= Boreholes.Length - 1 Then
                    Households(HouseChoice).UseBoreholeWater(Boreholes(BoreholeChoice), Amount)
                    DisplayWaterSourceProfiles(AreaDam, Boreholes, Boreholes.Length - 1, CurrentDay)
                Else
                    MsgBox("Invalid Borehole Choice!")
                End If
            Else
                MsgBox("Invalid Amount Entered!")
            End If
        Else
            MsgBox("Invalid House Choice!")
        End If
    End Sub

    Private Sub btnNewDay_Click(sender As Object, e As EventArgs) Handles btnNewDay.Click
        If CurrentDay = 7 Then
            CurrentDay = 1
            AreaDam.RefillWater()
            For IHouse As Integer = 1 To Households.Length - 1
                Households(IHouse).Tap.AvailableAmount = Households(IHouse).Tap.MaxUsableAmount
            Next IHouse
            For IBorehole As Integer = 1 To Boreholes.Length - 1
                Boreholes(IBorehole).RefillWater()
            Next IBorehole
            DisplayWaterSourceProfiles(AreaDam, Boreholes, Boreholes.Length - 1, CurrentDay)
        Else
            CurrentDay += 1
            For IBorehole As Integer = 1 To Boreholes.Length - 1
                Boreholes(IBorehole).RefillWater()
            Next IBorehole
            DisplayWaterSourceProfiles(AreaDam, Boreholes, Boreholes.Length - 1, CurrentDay)
        End If
    End Sub
End Class
