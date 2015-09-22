Public Class Form6_3_1

    Private Sub Form6_3_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num, n As Integer
        num = Integer.Parse(TextBox1.Text)
        n = num Mod 10

        If num > 0 Then
            MsgBox("เป็นจำนวนเต็มบวก" & " หลักหน่วย คือ : " & n)
        Else
            MsgBox("เป็นจำนวนเต็มลบ" & " หลักหน่วย คือ : " & n)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class