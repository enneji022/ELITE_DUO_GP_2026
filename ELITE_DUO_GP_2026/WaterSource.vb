Public MustInherit Class WaterSource
    Private _SourceID As Integer
    Private _IDCounter As Integer
    Private _AvailableAmount As Integer
    Private _MaxCapacity As Integer
    Private _IsFaulty As Boolean

    Public Sub New(SourceID As Integer, IDCounter As Integer, AvailAmount As Integer)
        _SourceID = SourceID
        _IDCounter = IDCounter
        _AvailableAmount = AvailAmount
    End Sub

    Public ReadOnly Property GetSourceID() As Integer
        Get
            Return _SourceID
        End Get
    End Property

    Public ReadOnly Property GetMaxCapacity() As Integer
        Get
            Return _MaxCapacity
        End Get
    End Property

    Public MustOverride Function IsFaulty() As Boolean

    Public MustOverride Function CheckAvailability() As Integer

    Public MustOverride Sub ReportFault()

    Public MustOverride Sub FixFault()

    Public MustOverride Function GetStatus() As String

End Class
