Public Class Form1

    Private Property intSec As Integer

    Private Property intMinute As Integer

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        intMinute = 0
        intSec = 0
    End Sub

    Private Sub ButtonStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStart.Click
        TimerClock.Enabled = True
        intMinute = 0
        intSec = 0
        LabelMinute.Text = "0"
        LabelSec.Text = "00"
        TimerClock.Enabled = True
    End Sub

    Private Sub ButtonPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPause.Click
        TimerClock.Enabled = False
    End Sub

    Private Sub ButtonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNext.Click
        TimerClock.Enabled = True
    End Sub

    Private Sub ButtonEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEnd.Click
        End
    End Sub



    Private Sub TimerClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerClock.Tick
        intSec = intSec + 1
        If intSec < 10 Then
            LabelSec.Text = "0" & intSec
        ElseIf intSec = 60 Then
            LabelSec.Text = "00"
            intSec = 0
            intMinute = intMinute + 1
        Else
            LabelSec.Text = intSec

        End If
        LabelMinute.Text = intMinute
    End Sub
End Class
