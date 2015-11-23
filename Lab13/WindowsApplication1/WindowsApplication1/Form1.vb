Public Class Form1

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub GoogleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleToolStripMenuItem.Click
        WebBrowser1.Navigate("https://www.google.com/")
    End Sub

    Private Sub TwetterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TwetterToolStripMenuItem.Click

        WebBrowser1.Navigate("https://twitter.com/?lang=th")
    End Sub

    Private Sub FacebookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacebookToolStripMenuItem.Click
        WebBrowser1.Navigate("https://www.facebook.com/")
    End Sub
End Class
