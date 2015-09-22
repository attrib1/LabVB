Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x As Integer
        x = InputBox("กรุณาใส่ตัวเลขที่ต้องการ")
        If x >= 100 And x <= 200 Then MsgBox("ค่า x อยู่ระหว่าง 100 ถึง 200")
    End Sub
End Class
