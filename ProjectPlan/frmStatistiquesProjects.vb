Public Class frmStatistiquesProjects
    Private Sub frmStatistiquesProjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            'On génére la liste des projets
            pDisplayProjects()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub pDisplayProjects()
        Try

            'TODO: This line of code loads data into the 'DsProjectListStatistques.vprojectliststatistiques' table. You can move, or remove it, as needed.
            Me.VprojectliststatistiquesTableAdapter.Fill(Me.DsProjectListStatistques.vprojectliststatistiques)

            If Me.radProjectsAll.Checked = True Then
                VprojectliststatistiquesBindingSource.Filter = ""
            End If

            If Me.radProjectsInWork.Checked = True Then
                VprojectliststatistiquesBindingSource.Filter = "StatusProjectInWork = 1"
            End If


            'On sélectionne le premier projet de la liste
            If dgvProjectsList.RowCount > 0 Then
                dgvProjectsList.Rows(0).Selected = True
                Dim thisID_Project As Integer = 0
                thisID_Project = dgvProjectsList.Rows(dgvProjectsList.CurrentRow.Index).Cells(0).Value
                pDisplayPlanResources(thisID_Project)
                pDisplayExecutedResources(thisID_Project)
                pDisplayProjectInfo(thisID_Project)
            End If




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

    Private Sub radProjectsAll_CheckedChanged(sender As Object, e As EventArgs) Handles radProjectsAll.CheckedChanged
        Try
            pDisplayProjects()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub radProjectsInWork_CheckedChanged(sender As Object, e As EventArgs) Handles radProjectsInWork.CheckedChanged
        Try
            pDisplayProjects()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub



    Private Sub dgvProjectsList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjectsList.CellClick
        Try

            Dim thisID_Project As Integer = 0
            thisID_Project = dgvProjectsList.Rows(dgvProjectsList.CurrentRow.Index).Cells(0).Value

            pDisplayPlanResources(thisID_Project)
            pDisplayExecutedResources(thisID_Project)
            pDisplayProjectInfo(thisID_Project)



        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub pDisplayPlanResources(ID_Project As Integer)


        Try

            'TODO: This line of code loads data into the 'DsProjectListStatisquesPlanResources.vprojectliststatisquesplanresources' table. You can move, or remove it, as needed.
            Me.VprojectliststatisquesplanresourcesTableAdapter.Fill(Me.DsProjectListStatisquesPlanResources.vprojectliststatisquesplanresources)
            VprojectliststatisquesplanresourcesBindingSource.Filter = "CE_ID_Project = " & ID_Project

            Select Case dgvPlanResources.RowCount
                Case 0
                    Me.labTotalPlanResources.Text = "Total : aucune heure planifiée"
                Case = 1
                    Me.labTotalPlanResources.Text = "Total : 1 heure planfiée"
                Case Else
                    Me.labTotalPlanResources.Text = "Total : " & dgvPlanResources.RowCount & " heures planifiées"
            End Select


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try


    End Sub


    Private Sub pDisplayExecutedResources(ID_Project As Integer)


        Try

            'TODO: This line of code loads data into the 'DsProjectListStatisquesPlanResources.vprojectliststatisquesplanresources' table. You can move, or remove it, as needed.
            Me.VprojectliststatistiquesexecutedresourcesTableAdapter.Fill(Me.Dsvprojectliststatistiquesexecutedresources.vprojectliststatistiquesexecutedresources)
            VprojectliststatistiquesexecutedresourcesBindingSource.Filter = "CE_ID_Project = " & ID_Project

            Select Case dgvExecutedResources.RowCount
                Case 0
                    Me.labTotalExecutedResources.Text = "Total : aucune heure exécutée"
                Case = 1
                    Me.labTotalExecutedResources.Text = "Total : 1 heure exécutée"
                Case Else
                    Me.labTotalExecutedResources.Text = "Total : " & dgvExecutedResources.RowCount & " heures exécutées"
            End Select


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try


    End Sub


    Private Sub pDisplayProjectInfo(ID_Project As Integer)
        Try

            Dim thisProject As New myProject
            thisProject.ID_Project = ID_Project
            thisProject.Read()

            Me.texProjectDeadline.Text = Format(thisProject.DeadLine, "d")
            Me.texProjectInitialPlaned.Text = thisProject.EstimatedResources
            Me.texProjectRate.Text = thisProject.ImplementationRate & " %"
            Me.texEffectivePlusEstimatedResources.Text = dgvPlanResources.RowCount + dgvExecutedResources.RowCount

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

End Class