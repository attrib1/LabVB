Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intScore As Integer

        Dim strResult As String

        intScore = InputBox("กรุณาใส่คะแนน")

        If intScore >= 0 And intScore < 50 Then

            strResult = "F"

        ElseIf intScore >= 50 And intScore < 60 Then

            strResult = "D"

        ElseIf intScore >= 60 And intScore < 70 Then

            strResult = "C"

        ElseIf intScore >= 70 And intScore < 80 Then

            strResult = "B"

        ElseIf intScore >= 80 And intScore <= 100 Then

            strResult = "A"

        End If

        MsgBox("คุณได้ระดับคะแนน " & strResult)
    End Sub
End Class