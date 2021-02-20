Public Class frmResourcesTableAddAdminResource
    Private Sub frmResourcesTableAddAdminResource_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try


            'TODO: This line of code loads data into the 'DsResourcesAdmin.vresourcesadmin' table. You can move, or remove it, as needed.
            Me.VresourcesadminTableAdapter.Fill(Me.DsResourcesAdmin.vresourcesadmin)



        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub



    Private Sub dgvAdminResources_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdminResources.CellClick
        Try
            'On lit la ressource administrative sélectionnée

            Dim thisDGV As DataGridView = Me.dgvAdminResources
            Dim ID_AdminResource As Integer = 0


            ID_AdminResource = thisDGV.Rows(thisDGV.CurrentRow.Index).Cells(0).Value
            G_ID_ResourceAdmin = ID_AdminResource

            Me.Close()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub
End Class