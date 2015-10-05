Public Class Form1
    Const picture_path As String = "D:\flag\"
    Dim m_strCountryName As String() = New String() {"spain", "england", "czech", "france", "portugal", "greece", "germany", "italy"}
    Dim m_blnUsed As Boolean() = New Boolean(m_strCountryName.GetUpperBound(0)) {}
    Dim m_intCount As Integer = 1
    Dim m_strCountry As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Array.Sort(m_strCountryName)
        cboOptions.DataSource = m_strCountryName
        DisplayFlag()

    End Sub
    Function BuildPathName() As String
        Dim strOutput As String = m_strCountry
        strOutput &= ".jpg"
        strOutput = picture_path & strOutput
        Return strOutput
    End Function

    Function GetUniqueRandomNumber() As Integer
        Dim objRandom As Random = New Random
        Dim intRandom As Integer

        Do
            intRandom = objRandom.Next(0, m_blnUsed.Length)

        Loop Until m_blnUsed(intRandom) = False
        m_blnUsed(intRandom) = False
        Return intRandom
    End Function

    Sub DisplayFlag()
        Dim intRandom As Integer = GetUniqueRandomNumber()
        m_strCountry = m_strCountryName(intRandom)
        Dim strPath As String = BuildPathName()
        picFlag.Image = Image.FromFile(strPath)
        Me.Text = "FlagQuiz : การทายครั้งที่ " & m_intCount
    End Sub




    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim strRespons As String = Convert.ToString(cboOptions.SelectedValue)
        If strRespons = m_strCountry Then
            lblFeedback.Text = "ถูกต้องแล้วครับบบบบ"
        Else
            lblFeedback.Text = "ผิดแล้วครับบ"
        End If
        If m_intCount >= 5 Then
            lblFeedback.Text &= ControlChars.CrLf & "จบเกม!!"
            btnNext.Enabled = False
            btnSubmit.Enabled = False
            cboOptions.Enabled = False
        Else
            btnSubmit.Enabled = False
            btnNext.Enabled = True
        End If

    End Sub



    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        lblFeedback.Text = ""
        cboOptions.SelectedIndex = 0
        m_intCount += 1
        btnSubmit.Enabled = True
        btnNext.Enabled = False
        DisplayFlag()
    End Sub
End Class
