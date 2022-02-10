Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = System.Guid.NewGuid.ToString()
        If CheckBox1.Checked Then
            My.Computer.Clipboard.SetText(TextBox1.Text)
        End If
    End Sub
End Class
