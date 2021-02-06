Public Class frmTest
    Private Sub frmTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyDialog As New ColorDialog()
        ' Keeps the user from selecting a custom color.
        MyDialog.AllowFullOpen = False
        ' Allows the user to get help. (The default is false.)
        MyDialog.ShowHelp = True
        ' Sets the initial color select to the current text color,
        MyDialog.Color = TextBox1.ForeColor

        ' Update the text box color if the user clicks OK 
        If (MyDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            TextBox1.BackColor = MyDialog.Color
        End If
    End Sub
End Class