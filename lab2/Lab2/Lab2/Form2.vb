Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim X(3) As Integer
        X(0) = 4000
        ChecTax(X(0))
        X(1) = 7000
        ChecTax(X(1))
        X(2) = 15000
        ChecTax(X(2))
        X(3) = 20000
        ChecTax(X(3))

    End Sub

    Private Sub ChecTax(ByVal X As Integer)

        If X < 5000 Then
            MsgBox("Your salary is : " & X & "Your tax rate is 5%")
        ElseIf X < 10000 Then
            MsgBox("Your salary is : " & X & "Your tax rate is 10%")
        Else
            MsgBox("Your salary is : " & X & "Your tax rate is 15%")

        End If


    End Sub

End Class