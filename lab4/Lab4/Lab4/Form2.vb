Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x As Integer
        x = InputBox("กรุณาใส่รายได้")
        If x >= 0 And x <= 30000 Then
            Dim y As Integer
            y = x * 0.07
            MsgBox("คุณมีรายได้ " & x & " บาท ต้องเสียภาษี" & y & " บาท")
        End If

    End Sub
End Class