Imports System.IO
Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog.ToString()

        ListBox2.Items.Add(OpenFileDialog1.FileName)

        ListBox1.Items.Add(Path.GetFileName(OpenFileDialog1.FileName))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ListBox2.Items.Remove(ListBox2.Items.Item(ListBox1.SelectedIndex).ToString)

        ListBox1.Items.Remove(ListBox1.Items(ListBox1.SelectedIndex))
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        AxWindowsMediaPlayer1.URL = ListBox2.Items.Item(ListBox1.SelectedIndex).ToString
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub
End Class