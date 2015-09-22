Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim intSum, i As Integer
        intSum = 0
        For i = 1 To 100
            intSum = intSum + i
        Next
        MsgBox("ผลรวมตั้งแต่ 1 ถึง 100 เท่ากับ" & intSum)


    End Sub
End Class