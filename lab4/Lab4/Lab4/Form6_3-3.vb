Public Class Form6_3_3

    Private Sub Form6_3_3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num As Integer
        Dim str As String
        num = Val(TextBox1.Text)
        Select Case num
            Case Is < 20
                str = "สินค้าใกล้จะหมดแล้ว"
            Case 20 To 50
                str = "ควรสั่งซื้อสินค้าแล้ว"
            Case 51 To 100
                str = "สินค้ายังพอเพียงกับการขาย"
            Case Is >= 101
                str = "สินค้าเหลืออยุ่มาก"
        End Select
        Label1.Text = str
    End Sub
End Class