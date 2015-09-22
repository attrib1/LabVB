Public Class Lab5_2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n(10) As Double
        Dim sum As Double = 0

        For i As Integer = 0 To 9 Step +1
            n(i) = InputBox("กรุราใส่ตัวเลขคนที่ " & (i + 1))
            sum = sum + n(i)
        Next
        MsgBox("คะแนนเฉลี่ยของนักเรียน 10 คนคือ : " & (sum / 10))

    End Sub

    Private Sub Lab5_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class