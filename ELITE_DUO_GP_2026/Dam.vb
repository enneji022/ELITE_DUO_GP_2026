Public Class Dam
    Inherits WaterSource

    Private _MaxUsableAmount As Integer

    Public Sub New(SourceID As Integer, IDCounter As Integer, AvailAmount As Integer, MaxUse As Integer)
        MyBase.New(SourceID, IDCounter, AvailAmount)
        _MaxUsableAmount = MaxUse
    End Sub
    Public Overrides Sub ReportFault()

    End Sub

    Public Overrides Sub FixFault()

    End Sub

    Public Overrides Function IsFaulty() As Boolean

    End Function

    Public Overrides Function CheckAvailability() As Integer

    End Function

    Public Overrides Function GetStatus() As String

    End Function
End Class
