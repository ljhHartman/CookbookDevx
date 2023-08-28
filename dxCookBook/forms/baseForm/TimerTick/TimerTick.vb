Imports System.Timers

Public Class TimerTick
    Private aTimer As Timer
    Private formWidth As Integer = Me.Width
    Private formHeight As Integer = Me.Height



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
        formWidth = Me.Width
        formHeight = Me.Height
        Console.WriteLine($"Current from size: {formWidth}, {formHeight}")
    End Sub


End Class