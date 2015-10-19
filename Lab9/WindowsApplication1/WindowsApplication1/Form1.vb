Imports System.IO
Public Class Form1

    Private Sub ViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub File1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles File1ToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub SelectFontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectFontToolStripMenuItem.Click
        Try
            With FontDialog1
                .Font = TextBox1.Font
                .Color = TextBox1.ForeColor
                If .ShowDialog = DialogResult.OK Then
                    setFont()
                End If
            End With
        Catch es As Exception
            MessageBox.Show(es.Message)

        End Try
    End Sub
    Private Sub setFont()
        Try
            With FontDialog1
                TextBox1.Font = .Font
                If .ShowColor Then
                    TextBox1.ForeColor = .Color

                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub File2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles File2ToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub File3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles File3ToolStripMenuItem.Click
        Dialog1.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        TextBox1.Text = " "
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim FileNAme As String
        Dim sr As StreamReader
        Try
            With OpenFileDialog1
                .Filter = "Text files (*.txt)|*.txt|" & "All files|*.*"
                If .ShowDialog() = DialogResult.OK Then
                    FileNAme = .FileName
                    sr = New StreamReader(.OpenFile)
                    TextBox1.Text = sr.ReadToEnd()

                End If
            End With
        Catch es As Exception
            MessageBox.Show(es.Message)
        Finally
            If Not (sr Is Nothing) Then
                sr.Close()
            End If

        End Try

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim FileName As String
        Dim sw As StreamWriter
        Try
            With SaveFileDialog1
                .FileName = FileName
                .Filter = "Text files (*.txt)|*.txt|" & "All files|*.*"
                If .ShowDialog() = DialogResult.OK Then
                    FileName = .FileName
                    sw = New StreamWriter(FileName)
                    sw.Write(TextBox1.Text)
                End If
            End With
        Catch es As Exception
            MessageBox.Show(es.Message)
        Finally
            If Not (sw Is Nothing) Then
                sw.Close()
            End If

        End Try
    End Sub

    Private Sub SelectColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectColorToolStripMenuItem.Click
        Static CustomColors() As Integer = {RGB(255, 0, 0), RGB(0, 255, 0), RGB(0, 0, 255)}
        Try
            With ColorDialog1
                .Color = TextBox1.ForeColor
                .CustomColors = CustomColors
                If .ShowDialog() = DialogResult.OK Then
                    TextBox1.ForeColor = .Color
                    CustomColors = .CustomColors

                End If
            End With
        Catch es As Exception
            MessageBox.Show(es.Message)

        End Try
    End Sub
End Class
