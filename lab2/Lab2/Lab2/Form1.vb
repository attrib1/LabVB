Public Class Form1
    Const Vat = 0.07
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Salary As Integer '"ประกาศตัวแปร"
        Salary = 50000
        Debug.WriteLine("อัตราภาษีเท่ากับ" & Vat)
        Debug.WriteLine("ภาษีที่ต้องจ่าย" & Salary * Vat)





    End Sub
End Class
