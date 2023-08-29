Imports System.Timers

Public Class TimerTick
    Private aTimer As Timer



    Sub New()
        InitializeComponent()

        ' Initialize timer
        aTimer = New Timer() With {
            .Interval = 1000,
            .AutoReset = True,
            .Enabled = True
        }
        AddHandler aTimer.Elapsed, AddressOf OnTimedEvent
    End Sub



    Private Sub OnTimedEvent(ByVal source As Object, ByVal e As ElapsedEventArgs)
        ' Get current time
        Console.WriteLine($"The Elapsed event was raised at {e.SignalTime}")

        ' Get new current form size
        Dim formWidth As Integer = Me.Width
        Dim formHeight As Integer = Me.Height
        Console.WriteLine($"Current from size: {formWidth}, {formHeight}")
    End Sub


End Class