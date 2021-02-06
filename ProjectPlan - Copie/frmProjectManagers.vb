Public Class frmProjectManagers
    Private Sub frmProjectManagers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            pDisplayProjectManagers()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btcAdd_Click(sender As Object, e As EventArgs) Handles btcAdd.Click

        Try

            ID_ProjectManager = 0

            Dim myForm As Form = frmProjectManagerDetails

            myForm.ShowDialog()
            myForm.Dispose()

            pDisplayProjectManagers()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub pDisplayProjectManagers()
        Try

            'TODO: This line of code loads data into the 'DsProjectManagers.vprojectmanagers' table. You can move, or remove it, as needed.
            Me.VprojectmanagersTableAdapter.Fill(Me.DsProjectManagers.vprojectmanagers)

            Me.dgvProjectsManagers.Rows(0).Selected = True

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btcEdit_Click(sender As Object, e As EventArgs) Handles btcEdit.Click
        Try

            Dim myForm As Form = frmProjectManagerDetails
            myForm.ShowDialog()
            myForm.Dispose()

            pDisplayProjectManagers()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btcClose_Click(sender As Object, e As EventArgs) Handles btcClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub dgvProjectsManagers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjectsManagers.CellClick
        Try

            dgvProjectsManagers.Rows(dgvProjectsManagers.CurrentCell.RowIndex).Selected = True
            ID_ProjectManager = dgvProjectsManagers.Item(0, dgvProjectsManagers.CurrentCell.RowIndex).Value

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class