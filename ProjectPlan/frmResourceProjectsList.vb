Public Class frmResourceProjectsList
    Private Sub frmResourceProjectsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            'TODO: This line of code loads data into the 'DsResourceProjectsList.vprojectlist' table. You can move, or remove it, as needed.
            Me.VprojectlistTableAdapter.Fill(Me.DsResourceProjectsList.vprojectlist)


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub dgvProjectsList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjectsList.CellClick
        Try
            'On lit le projet sélectionnée

            Dim thisDGV As DataGridView = Me.dgvProjectsList
            Dim ID_Project As Integer = 0


            ID_Project = thisDGV.Rows(thisDGV.CurrentRow.Index).Cells(0).Value
            G_ID_ResourceProject = ID_Project

            Me.Close()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub
End Class