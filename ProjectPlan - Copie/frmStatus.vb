Public Class frmStatus
    Private Sub frmStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            pDisplayStatus()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub pDisplayStatus()

        Try

            'TODO: This line of code loads data into the 'DsStatus.vstatus' table. You can move, or remove it, as needed.
            Me.VstatusTableAdapter.Fill(Me.DsStatus.vstatus)
            Me.dgvStatus.Rows(0).Selected = True
            ID_Status_Current = dgvStatus.Rows(dgvStatus.CurrentRow.Index).Cells(0).Value

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btcAdd_Click(sender As Object, e As EventArgs) Handles btcAdd.Click
        Try

            ID_Task_Current = 0

            Dim myForm As Form = frmStatusDetails

            myForm.ShowDialog()
            myForm.Dispose()

            pDisplayStatus()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btcEdit_Click(sender As Object, e As EventArgs) Handles btcEdit.Click
        Try

            Dim myForm As Form = frmStatusDetails

            myForm.ShowDialog()
            myForm.Dispose()

            pDisplayStatus()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub dgvStatus_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStatus.CellClick
        Try

            dgvStatus.Rows(dgvStatus.CurrentCell.RowIndex).Selected = True
            ID_Status_Current = dgvStatus.Rows(dgvStatus.CurrentRow.Index).Cells(0).Value

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
End Class