Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strText As String
        strText = TextBox1.Text()
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Len = " & Len(strText))
        ListBox1.Items.Add("Len and LTrim = " & Len(LTrim(strText)))
        ListBox1.Items.Add("Len and TrimStart= " & Len(strText.TrimStart))
        ListBox1.Items.Add("Len and Rtrim = " & Len(RTrim(strText)))
        ListBox1.Items.Add("Len  and TrimEnd = " & Len(strText.TrimEnd))
        ListBox1.Items.Add("Len and trim  = " & Len(strText.Trim))
        ListBox1.Items.Add(StrDup(30, "*"))
        ListBox1.Items.Add("Lcase  = " & LCase(strText))
        ListBox1.Items.Add("Ucase = " & UCase(strText))
        ListBox1.Items.Add(StrDup(30, "*"))
        ListBox1.Items.Add("StartsWith , 3 = " & strText.StartsWith(3, "3"))
        ListBox1.Items.Add("EndWith , 3 = " & strText.EndsWith(3))
        ListBox1.Items.Add("Left , 3  = " & strText.StartsWith(3))
        ListBox1.Items.Add("Right   = " & strText.EndsWith(3))
        ListBox1.Items.Add("SubString , 3    = " & strText.Substring(3, 2))
        ListBox1.Items.Add("Mid 3,2    = " & Mid(strText, 3, 2))
        ListBox1.Items.Add("StrDup  = " & StrDup(30, "*"))
        ListBox1.Items.Add("Instr,b   = " & InStr(1, strText, "b", +vbBinaryCompare))

    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim intInput As Double
        intInput = TextBox1.Text
        ListBox1.Items.Clear()
        ListBox1.Items.Add(StrDup(30, "*"))
        ListBox1.Items.Add("Abs =" & Math.Abs(intInput))
        ListBox1.Items.Add("Fix =" & Fix(intInput))
        ListBox1.Items.Add(StrDup(30, "*"))
        ListBox1.Items.Add("Sin =" & Math.Sin(intInput))
        ListBox1.Items.Add("Cos =" & Math.Cos(intInput))
        ListBox1.Items.Add("Tan =" & Math.Tan(intInput))
        ListBox1.Items.Add(StrDup(30, "*"))
        ListBox1.Items.Add("Oct =" & Oct(intInput))
        ListBox1.Items.Add("Hex =" & Hex(intInput))

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim intInput As Double
        Randomize()
        intInput = Rnd()
        ListBox1.Items.Clear()
        ListBox1.Items.Add(StrDup(30, "*"))
        ListBox1.Items.Add("Rnd = " & intInput)
        ListBox1.Items.Add("Rnd 1-10 = " & Int(intInput * 10))
        ListBox1.Items.Add("Rnd 1-100 = " & Int(intInput * 100))
        ListBox1.Items.Add("Rnd 1-500 = " & Int(intInput * 500))
        ListBox1.Items.Add("Rnd 1-1000 = " & Int(intInput * 1000))

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim strInput As String
        strInput = TextBox1.Text
        ListBox1.Items.Clear()
        ListBox1.Items.Add(StrDup(30, "*"))
        ListBox1.Items.Add("CDb1 = " & CDbl(strInput))
        ListBox1.Items.Add("CInt = " & CInt(strInput))
        ListBox1.Items.Add("CLng = " & CLng(strInput))
        ListBox1.Items.Add("CSng = " & CSng(strInput))
        ListBox1.Items.Add("CBool = " & CBool(strInput))
        ListBox1.Items.Add("CByte = " & CByte(strInput))
        ListBox1.Items.Add("CDec = " & CDec(strInput))
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Date functions " & StrDup(30, "*"))
        ListBox1.Items.Add("CDate = " & CDate("1 July 2006"))
        ListBox1.Items.Add("DateSerial = " & DateSerial(2006, 7, 1))
        ListBox1.Items.Add("DateValue = " & DateValue("1/2/2006"))
        ListBox1.Items.Add("")
        ListBox1.Items.Add("Today " & StrDup(30, "*"))
        ListBox1.Items.Add("Date = " & Date.Today)
        ListBox1.Items.Add("Day = " & Date.Today.Day)
        ListBox1.Items.Add("WeekDay = " & Date.Today.DayOfWeek)
        ListBox1.Items.Add("Month = " & Date.Today.Month)
        ListBox1.Items.Add("Year = " & Date.Today.Year)
        ListBox1.Items.Add(" ")
        ListBox1.Items.Add("Time functions " & StrDup(30, "*"))
        ListBox1.Items.Add("TimeSerial = " & TimeSerial(8, 39, 49))
        ListBox1.Items.Add("")
        ListBox1.Items.Add("This Time " & StrDup(30, "*"))
        ListBox1.Items.Add("Now = " & Now)
        ListBox1.Items.Add("TimeValue = " & TimeValue(Now))
        ListBox1.Items.Add("Hour = " & Hour(Now))
        ListBox1.Items.Add("Minute = " & Minute(Now))
        ListBox1.Items.Add("Second = " & Second(Now))
    End Sub
End Class
