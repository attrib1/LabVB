Public Class Form3
    Dim Year As Integer
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Year = InputBox("กรุณาใส่ พ.ศ.ที่เกิด", "คำนวนอายุ")

        MsgBox("คุณอายุ " & CalYear() & "ปี", vbInformation, "คำนวนอายุ")


    End Sub

    Private Function CalYear() As Integer

        CalYear = 2558 - Year
    End Function

 

End Class