Public Class Form1

    Structure Employee
        Dim FirstName As String
        Dim LastName As String
        Dim Position As String
        Dim Salary As Decimal

    End Structure
    Dim Staff(2) As Employee
    Dim CurrentStaff As Integer = 0

    Private Sub ShowCurrentStaff()
        txtFirstName.Text = Staff(CurrentStaff).FirstName
        txtLastName.Text = Staff(CurrentStaff).LastName
        txtPosition.Text = Staff(CurrentStaff).Position
        txtSalary.Text = Staff(CurrentStaff).Salary

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Staff(0).FirstName = "Christiano"
        Staff(0).LastName = "Ronaldo"
        Staff(0).Position = "Manager"
        Staff(0).Salary = 20000

        Staff(1).FirstName = "Fornando"
        Staff(1).LastName = "torres"
        Staff(1).Position = "Financial"
        Staff(1).Salary = 15000

        Staff(2).FirstName = "Cese"
        Staff(2).LastName = "Fabregas"
        Staff(2).Position = "Manager"
        Staff(2).Salary = 10000

        ShowCurrentStaff()

    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        If CurrentStaff > 0 Then
            CurrentStaff -= 1
            ShowCurrentStaff()

        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If CurrentStaff < 2 Then
            CurrentStaff += 1
            ShowCurrentStaff()
        End If
    End Sub
End Class
