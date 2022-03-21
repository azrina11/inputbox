Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strNama As String = txtName.Text
        Dim strOutput As String = "Hello " + strNama + " cantik"

        lblOutput.Text = strOutput

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles labelname.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblOutput.Click

    End Sub
End Class
