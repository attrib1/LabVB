Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Values() As Single

        Dim num As String
        Dim NumberOfVaalues As Integer
        Dim i As Integer
        Dim Title As String

        NumberOfVaalues = InputBox("ป้อนจำนวนตัวเลขที่หาค่าเฉลี่ย")
        If NumberOfVaalues > 0 Then ReDim Values(NumberOfVaalues - 1)
        For i = 0 To NumberOfVaalues - 1

            Title = "ค่าที่" & CStr(i + 1)
            num = InputBox("กรุณาป้อนจำนวนตัวเลข", Title)
            If num = "end" Then


                Exit For
            End If
            Values(i) = num

        Next

        FineAverage(Values)
    End Sub

    Private Sub FineAverage(ByVal v() As Single)
        Dim Result As String
        Dim i As Integer
        Dim Total As Single = 0
        Result = "จำนวนตัวเลขที่นำมาหาค่าเฉลี่ย : " & ControlChars.CrLf
        Result = "-----------------------" & ControlChars.CrLf

        For i = 0 To v.GetUpperBound(0)
            Result &= "ค่าที่ " & (i + 1) & ControlChars.Tab & v(i) & ControlChars.CrLf

            Total = Total + v(i)
        Next
        Result &= "-------------------" & ControlChars.CrLf
        Result &= "ค่าเฉลี่ย : " & Format(Total / v.Length, "0.00")
        TextBox1.Text = Result

    End Sub

End Class