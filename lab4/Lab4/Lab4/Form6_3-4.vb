Public Class Form6_3_4

    Dim num As Integer
    Dim t1 As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim num As Integer = Val(TextBox1.Text)
        Dim total, results As Integer
        Dim str(4) As String
        Dim l As Integer = num.ToString.Length 

        total = Math.Truncate((num / 1000)) Mod 10






        If num <= 9999 And num >= 0 Then

            If (Math.Truncate(num / 1000) Mod 10) <> 0 Then

                results = Math.Truncate(num / 1000) Mod 10

                str(0) = numbath(results) & "พัน"



            End If

            If (Math.Truncate(num / 100) Mod 10) <> 0 Then

                results = Math.Truncate(num / 100) Mod 10

                str(1) = numbath(results) & "ร้อย"



            End If

            If (Math.Truncate(num / 10) Mod 10) <> 0 Then


                results = Math.Truncate(num / 10) Mod 10

                If results >= 2 And results < 3 Then
                    str(2) = "ยี่สิบ"
                End If
                If results >= 1 And results < 2 Then
                    str(2) = "สิบ"
                End If

                If results > 3 Then
                    str(2) = numbath(results) & "สิบ"
                End If
            End If


            If (Math.Truncate(num Mod 10)) <> 0 Then
                results = Math.Truncate(num Mod 10)

                If results = 1 And l > 1 Then
                    str(3) = "เอ็ดบาท"
                Else
                    str(3) = numbath(results) & "บาท"
                End If
            End If




        Else
            MsgBox("ตัวเลขเกิน 9,999 หรือ น้อยกว่าหรือเท่ากับ 0")

        End If



        Label1.Text = str(0) & str(1) & str(2) & str(3)


    End Sub


    Private Function numbath(n As Integer) As String

        Select Case n
            Case Is = 1
                Return "หนึ่ง"
            Case Is = 2
                Return "สอง"
            Case Is = 3
                Return "สาม"
            Case Is = 4
                Return "สี่"
            Case Is = 5
                Return "ห้า"
            Case Is = 6
                Return "หก"
            Case Is = 7
                Return "เจ็ด"
            Case Is = 8
                Return "แปด"
            Case Is = 9
                Return "เก้า"

        End Select

    End Function


    Private Sub Form6_3_4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
    End Sub
End Class