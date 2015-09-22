Public Class Lab5_1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num1 = Val(TextBox1.Text)
        Dim num2 = Val(TextBox2.Text)
        Dim str As String

        For i As Integer = num1 To num2 Step +1

            If ((i Mod 2) = 0) Then
                str = str & " " & i & " "
            End If


        Next

        MsgBox("" & str)


    End Sub

    Private Sub Lab5_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class