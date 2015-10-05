Public Class Lab6_3
    Dim nLucky As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
        If Val(TextBox1.Text) = nLucky Then
            MsgBox("ถูกต้องนะครับ !!!!")

        Else
            If Val(TextBox1.Text) > nLucky Then
                MsgBox("ผิดนะครับบ ตัวเลข มากเกินไป !!!")
            Else
                MsgBox("ผิดนะครับ ตัวเลขน้อยเกินไป !!!")

            End If

        End If

    End Sub

    Private Sub Lab6_3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        nLucky = Rnd()
        nLucky = Int(nLucky * 100)
        Label2.Text = nLucky
    End Sub
End Class