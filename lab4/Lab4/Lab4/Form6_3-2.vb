Public Class Form6_3_2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num(3), temp As Integer
        Dim I As Integer
        Dim J As Integer

        num(0) = Val(TextBox1.Text)
        num(1) = Val(TextBox2.Text)
        num(2) = Val(TextBox3.Text)


        For I = 3 - 1 To 1 Step -1 'the last element on the array does not get sorted.  
            For J = 0 To I - 1
                If num(J) > num(J + 1) Then  ' Compare neighboring elements  
                    temp = num(J)
                    num(J) = num(J + 1)
                    num(J + 1) = temp

                End If
            Next
        Next


        Label1.Text = "= " & num(0) & " " & num(1) & " " & num(2)
    End Sub

    Private Sub Form6_3_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class