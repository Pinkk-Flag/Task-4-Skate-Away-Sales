Public Class Form3


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Thank you for shopping at Skate Away Sales")
    End Sub

    Private Sub txtFirst_TextChanged(sender As Object, e As EventArgs) Handles txtFirst.TextChanged

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtFirst.Text = Form1.txtFirst.Text

        txtLast.Text = Form1.txtLast.Text

        txtAddress.Text = Form1.txtAddress.Text

        txtTax.Text = ((Form2.Quant1.Value * 100) + (Form2.Quant2.Value * 100)) * 0.05

        txtSkate.Text = (Form2.Quant1.Value) + (Form2.Quant2.Value)

        txtTotal.Text = (Form2.Quant1.Value * 100) + Form2.Quant2.Value * 100 * 1.05
    End Sub
End Class