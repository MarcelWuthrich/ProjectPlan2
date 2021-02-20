Public Class frmResourceAdminList
    Private Sub frmResourceAdminList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            pRefreshDisplay()


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub



    Private Sub dgvAdminResources_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdminResources.CellClick
        Try


            dgvAdminResources.Rows(dgvAdminResources.CurrentCell.RowIndex).Selected = True
            ID_ResourceAdmin_Current = dgvAdminResources.Rows(dgvAdminResources.CurrentRow.Index).Cells(0).Value

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btcAdd_Click(sender As Object, e As EventArgs) Handles btcAdd.Click
        Try

            ID_ResourceAdmin_Current = 0


            Dim myForm As Form = frmResourceAdminDetails
            myForm.ShowDialog()
            myForm.Dispose()

            pRefreshDisplay()


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub pRefreshDisplay()
        Try

            'TODO: This line of code loads data into the 'DsResourcesAdmin.vresourcesadmin' table. You can move, or remove it, as needed.
            Me.VresourcesadminTableAdapter.Fill(Me.DsResourcesAdmin.vresourcesadmin)

            ID_ResourceAdmin_Current = dgvAdminResources.Rows(dgvAdminResources.CurrentRow.Index).Cells(0).Value

        Catch ex As Exception

            If DebugFlag = True Then MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Private Sub btcEdit_Click(sender As Object, e As EventArgs) Handles btcEdit.Click
        Try

            Dim myForm As Form = frmResourceAdminDetails
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
End Class