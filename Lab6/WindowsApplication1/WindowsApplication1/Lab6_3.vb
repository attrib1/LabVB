Public Class Lab6_3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim nLucky As Integer
        nLucky = Rnd()
        nLucky = Int(nLucky * 100)
        Label2.Text = nLucky
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
End Class