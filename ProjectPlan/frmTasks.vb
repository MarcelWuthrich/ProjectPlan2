Imports System.ComponentModel

Public Class frmTasks
    Private Sub frmTasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ID_Task_Current = 0
            pRefreshDisplay()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub frmTasks_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            ID_Task_Current = 0

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub pRefreshDisplay()
        Try
            Me.VtasksTableAdapter.Fill(Me.DsTasks.vtasks)
            ID_Task_Current = dgvTasks.Rows(dgvTasks.CurrentRow.Index).Cells(0).Value
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub dgvTasks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTasks.CellContentClick

    End Sub

    Private Sub dgvTasks_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTasks.CellClick
        Try

            dgvTasks.Rows(dgvTasks.CurrentCell.RowIndex).Selected = True
            ID_Task_Current = dgvTasks.Rows(dgvTasks.CurrentRow.Index).Cells(0).Value

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btcAdd_Click(sender As Object, e As EventArgs) Handles btcAdd.Click
        Try

            ID_Task_Current = 0


            Dim myForm As Form = frmTaskDetails
            myForm.ShowDialog()
            myForm.Dispose()

            pRefreshDisplay()


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

    Private Sub btcEdit_Click(sender As Object, e As EventArgs) Handles btcEdit.Click
        Try
            Dim myForm As Form = frmTaskDetails
            myForm.ShowDialog()
            myForm.Dispose()

            pRefreshDisplay()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class