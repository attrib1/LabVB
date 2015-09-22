Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim X As Integer

        X = InputBox("กรุณาใส่ตวัเลขที่ตอ้งการทดสอบ")

        X = X Mod 2

        If X = 0 Then

            MsgBox("เป็นเลขคู๋")

        Else

            MsgBox("เป็ นเลขคี่")

        End If
    End Sub
End Class