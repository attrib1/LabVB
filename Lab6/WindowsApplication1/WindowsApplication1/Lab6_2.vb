Public Class Lab6_2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String = TextBox1.Text
        Label1.Text = StrReverse(str)

    End Sub
End Class