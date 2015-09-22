Public Class Form2



    Private Sub btn_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_show.Click
        Dim strText As String
        strText = "สวัสดีคุณ : " & TextBox_name.Text & Chr(13)
        If RadioButton1.Checked = True Then
            strText = strText & " คุณเป็นผู้ชาย" & Chr(13)
        End If
        If RadioButton2.Checked = True Then
            strText = strText & " คุณเป็นผู้หญิง" & Chr(13)
        End If
        If Val(age.Text) > 1 Then
            strText = strText & "ขณะนี้อายุ " & age.Text & Chr(13)
        End If
        If ComboBox1.Text <> "โปรดเลือก" Then
            strText = strText & "การศึกษาของคุณอยู่ในระดับ : " & ComboBox1.Text & Chr(13)
        End If
        strText = strText & " งานอดิเรกของคุณได้แก่ : " & Chr(13)
        If CheckBox1.Checked = True Then
            strText = strText & CheckBox1.Text & " เล่นกีฬ้า" & Chr(13)
        End If
        If CheckBox2.Checked = True Then
            strText = strText & CheckBox1.Text & " อ่านหนังสือ" & Chr(13)
        End If
        If CheckBox3.Checked = True Then
            strText = strText & CheckBox1.Text & " ดูหนัง , ฟังเพลง " & Chr(13)
        End If
        If CheckBox4.Checked = True Then
            strText = strText & CheckBox1.Text & " ท่องเที่ยว" & Chr(13)
        End If


        MsgBox(strText)
    End Sub

    Private Sub TextBox_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_name.TextChanged

    End Sub

    Private Sub btn_end_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_end.Click
        End
    End Sub
End Class