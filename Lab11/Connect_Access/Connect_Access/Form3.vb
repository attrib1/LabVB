Public Class Form3


    Private Sub StudentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet.Student' table. You can move, or remove it, as needed.

        Me.StudentTableAdapter.Fill(Me.StudentDataSet.Student)
        Label2.Text = "" & (Val(MidtermTextBox.Text) + Val(LabTextBox.Text) + Val(ProjectTextBox.Text) + Val(FinalTextBox.Text))

    End Sub

    Private Sub IDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IDTextBox.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        StudentBindingSource.MoveNext()

        Label2.Text = "" & Val(MidtermTextBox.Text) + Val(LabTextBox.Text) + Val(ProjectTextBox.Text) + Val(FinalTextBox.Text)
    End Sub

    Private Sub StudentBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentBindingSource.CurrentChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        StudentBindingSource.MovePrevious()

        Label2.Text = "" & Val(MidtermTextBox.Text) + Val(LabTextBox.Text) + Val(ProjectTextBox.Text) + Val(FinalTextBox.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        StudentBindingSource.MoveFirst()

        Label2.Text = "" & Val(MidtermTextBox.Text) + Val(LabTextBox.Text) + Val(ProjectTextBox.Text) + Val(FinalTextBox.Text)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        StudentBindingSource.MoveLast()

        Label2.Text = "" & Val(MidtermTextBox.Text) + Val(LabTextBox.Text) + Val(ProjectTextBox.Text) + Val(FinalTextBox.Text)
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub
End Class