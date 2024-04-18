Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim pass As Boolean

        pass = True

        If txtFirst.Text = "" Then
            MsgBox("Please enter a valid first name")
            pass = False
        End If
        If txtLast.Text = "" Then
            MsgBox("Please enter a valid last name")
            pass = False
        End If
        If txtAddress.Text = "" Then
            MsgBox("Please enter a valid Address")
            pass = False
        End If

        If pass = True Then
            Form2.Show()
            Me.Hide()
        End If

    End Sub
End Class
