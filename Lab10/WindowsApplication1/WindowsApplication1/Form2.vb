﻿Imports System.IO

Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FileName As String
        Dim sw As StreamWriter
        'streamwriter is used to write text
        Try
            With SaveFileDialog1
                .FileName = FileName
                .Filter = "Text files (*.txt)|*.txt|" & "All files|*.*"
                If .ShowDialog() = DialogResult.OK Then
                    FileName = .FileName
                    sw = New StreamWriter(FileName)
                    sw.Write(TextBox1.Text & vbCrLf)
                    sw.Write(TextBox2.Text & (ControlChars.NewLine))
                    sw.Write(TextBox3.Text & vbCrLf)
                    sw.Write(TextBox4.Text & vbCrLf)
                    Dim Tax As Double = (Val(TextBox4.Text) * 7) / 100
                    sw.Write("" & Tax)
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
       Dim FileName As String
        Dim sr As StreamReader
        'streamreader is used to read text
        Try
            With OpenFileDialog1
                .Filter = "Text files (*.txt)|*.txt|" & "All files|*.*"
                If .ShowDialog() = DialogResult.OK Then
                    FileName = .FileName
                    sr = New StreamReader(.OpenFile)
                    TextBox1.Text = sr.ReadLine()
                    TextBox2.Text = sr.ReadLine()
                    TextBox3.Text = sr.ReadLine()
                    TextBox4.Text = sr.ReadLine()
                    TextBox5.Text = sr.ReadLine()
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

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
End Class