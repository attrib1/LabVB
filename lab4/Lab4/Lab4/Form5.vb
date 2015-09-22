Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intScore As Integer

        Dim strResult As String

        intScore = InputBox("กรุณาใส่คะแนน")

        Select Case intScore

            Case Is >= 80

                strResult = "A"

            Case Is >= 70

                strResult = "B"

            Case Is >= 60

                strResult = "C"

            Case Is >= 50

                strResult = "D"

            Case Else

                strResult = "F"

        End Select

        MsgBox("คุณได้ระดับคะแนน " & strResult)

        End
    End Sub
End Class