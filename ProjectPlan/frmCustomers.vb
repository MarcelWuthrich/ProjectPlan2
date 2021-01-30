Public Class frmCustomers
    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            pDisplayCustomers()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub dgvCustomers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellClick
        Try

            dgvCustomers.Rows(dgvCustomers.CurrentCell.RowIndex).Selected = True
            ID_Customer_Current = dgvCustomers.Item(0, dgvCustomers.CurrentCell.RowIndex).Value

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub pDisplayCustomers()
        Try
            'TODO: This line of code loads data into the 'DsCustomers.vcustomers' table. You can move, or remove it, as needed.
            Me.VcustomersTableAdapter.Fill(Me.DsCustomers.vcustomers)

            Me.dgvCustomers.Rows(0).Selected = True
            ID_Customer_Current = dgvCustomers.Item(0, dgvCustomers.CurrentCell.RowIndex).Value

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btcAdd_Click(sender As Object, e As EventArgs) Handles btcAdd.Click
        Try

            ID_Customer_Current = 0

            Dim myForm As Form = frmCustomerDetails

            myForm.ShowDialog()
            myForm.Dispose()

            pDisplayCustomers()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btcEdit_Click(sender As Object, e As EventArgs) Handles btcEdit.Click
        Try

            Dim myForm As Form = frmCustomerDetails
            myForm.ShowDialog()
            myForm.Dispose()

            pDisplayCustomers()

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