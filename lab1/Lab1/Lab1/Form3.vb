Public Class Form3
    Dim Total As Integer
    Dim Strsum As String
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Na.Click
       
        Total = Int(TextBox1.Text) - Int(TextBox2.Text)
        Strsum = "Total : " & Total
        Label3.Text = Strsum

    End Sub

    Private Sub div_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles div.Click
        Total = Int(TextBox1.Text) / Int(TextBox2.Text)
        Strsum = "Total : " & Total
        Label3.Text = Strsum

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mu.Click
        Total = Int(TextBox1.Text) * Int(TextBox2.Text)
        Strsum = "Total : " & Total
        Label3.Text = Strsum
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = ""

    End Sub

   
End Class