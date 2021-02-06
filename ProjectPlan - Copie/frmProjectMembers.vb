'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class frmProjectMembers


    Private Sub frmProjectMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            pDisplayProjectMembers()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub



    Private Sub pDisplayProjectMembers()

        Try


            'TODO: This line of code loads data into the 'DsProjectMembers.vprojectmembers' table. You can move, or remove it, as needed.
            Me.VprojectmembersTableAdapter.Fill(Me.DsProjectMembers.vprojectmembers)

            dgvProjectsMembers.Rows(0).Selected = True
            ID_ProjectMember = dgvProjectsMembers.Item(0, dgvProjectsMembers.CurrentCell.RowIndex).Value

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub dgvProjectsMembers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjectsMembers.CellClick

        Try

            dgvProjectsMembers.Rows(dgvProjectsMembers.CurrentCell.RowIndex).Selected = True
            ID_ProjectMember = dgvProjectsMembers.Item(0, dgvProjectsMembers.CurrentCell.RowIndex).Value

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

    Private Sub btcAdd_Click(sender As Object, e As EventArgs) Handles btcAdd.Click

        Try

            ID_ProjectMember = 0

            Dim myForm As Form = frmProjectMemberDetails

            myForm.ShowDialog()
            myForm.Dispose()

            pDisplayProjectMembers()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try


    End Sub

    Private Sub btcEdit_Click(sender As Object, e As EventArgs) Handles btcEdit.Click
        Try

            Dim myForm As Form = frmProjectMemberDetails
            myForm.ShowDialog()
            myForm.Dispose()

            pDisplayProjectMembers()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub dgvProjectsMembers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjectsMembers.CellContentClick

    End Sub

    Private Sub btcDelete_Click(sender As Object, e As EventArgs) Handles btcDelete.Click
        Try

            Dim myProjectMember As New myProjectMember

            myProjectMember.ID_ProjectMember = ID_ProjectMember
            myProjectMember.Read()
            myProjectMember.IsDeleted = 1
            myProjectMember.Save()

            pDisplayProjectMembers()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class