Public Class frmTest
    Private Sub frmTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'TODO: This line of code loads data into the 'ProjectplanDataSet1.vstatus' table. You can move, or remove it, as needed.
            Me.VstatusTableAdapter.Fill(Me.ProjectplanDataSet1.vstatus)

            DataGridView1.Rows(0).HeaderCell.Value = "toto"
        Catch ex As Exception

        End Try
    End Sub
End Class