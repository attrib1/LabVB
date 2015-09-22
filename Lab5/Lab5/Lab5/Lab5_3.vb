Public Class Lab5_3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer = Val(TextBox1.Text)

        For i As Integer = 0 To 100 Step +1
            ListBox1.Items.Add(" " & n & " x " & i & "  =  " & (n * i))

        Next


    End Sub

    Private Sub Lab5_3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class