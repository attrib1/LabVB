Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataOnlyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataOnlyToolStripMenuItem.Click
        Dim NewMDIChild As New Form2()
        NewMDIChild.MdiParent = Me

        NewMDIChild.Show()

      
        'กา หนดฟอร์ม parent ของ Child Form คือ Me ซึ่งหมายถึง Form1
    End Sub

    Private Sub DataAndSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataAndSummaryToolStripMenuItem.Click
        Dim NewMDIChild As New Form3()
        NewMDIChild.MdiParent = Me

        NewMDIChild.Show()



        'กา หนดฟอร์ม parent ของ Child Form คือ Me ซึ่งหมายถึง Form1
    End Sub
End Class
