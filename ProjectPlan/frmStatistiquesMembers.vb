Public Class frmStatistiquesMembers


    Dim ID_ProjectMember As Integer = 0

    Private Sub btcFermer_Click(sender As Object, e As EventArgs) Handles btcFermer.Click
        Try
            Me.Close()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub frmStatistiquesMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            'Affichage des membres de projets
            pDisplayProjectMembers()

            'On regarde s'il y a des lignes
            If dgvProjectMembers.RowCount > 0 Then

                'On sélectionne la première ligne
                dgvProjectMembers.Rows(0).Selected = True

                'On simule un clic sur la première ligne
                Dim arg = New DataGridViewCellEventArgs(0, 0)
                dgvProjectMembers_CellClick(dgvProjectMembers, arg)

            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub pDisplayProjectMembers()
        Try

            'TODO: This line of code loads data into the 'DsvProjectMembers.vprojectmembers' table. You can move, or remove it, as needed.
            Me.VprojectmembersTableAdapter.Fill(Me.DsvProjectMembers.vprojectmembers)

            'On affiche uniquemet les membres de projets actifs
            Me.VprojectmembersBindingSource.Filter = "Enable = 1"



        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub



    Private Sub dgvProjectMembers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjectMembers.CellClick
        Try

            Me.Cursor = Cursors.WaitCursor

            dgvProjectMembers.Rows(dgvProjectMembers.CurrentCell.RowIndex).Selected = True
            ID_ProjectMember = dgvProjectMembers.Item(0, dgvProjectMembers.CurrentCell.RowIndex).Value

            Debug.WriteLine("01 : " & Now)

            pDisplayNumberPlanedHourOnProjects(ID_ProjectMember)

            Debug.WriteLine("02 : " & Now)

            pDisplayNumberPlanedHourOnAdminResources(ID_ProjectMember)

            Debug.WriteLine("03 : " & Now)

            Dim myProjectMember As New myProjectMember
            myProjectMember.ID_ProjectMember = ID_ProjectMember
            myProjectMember.Read()

            Debug.WriteLine("04 : " & Now)

            Me.texProjectMember.Text = myProjectMember.FirstName & " " & myProjectMember.Lastname

            Dim myStats As New myStatistics
            myStats.ID_ProjectMember = myProjectMember.ID_ProjectMember

            Debug.WriteLine("05 : " & Now)

            myStats.GetProjectHours()
            Me.texStatProjects1Month.Text = myStats.HoursOnProjects1Month
            Me.texStatProjects3Month.Text = myStats.HoursOnProjects3Month
            Me.texStatProjects6Month.Text = myStats.HoursOnProjects6Month
            Me.texStatProjects12Month.Text = myStats.HoursOnProjects12Month
            Me.texStatProjectsEndYear.Text = myStats.HoursOnProjectsEndYear

            Debug.WriteLine("06 : " & Now)

            myStats.GetAdminHours()
            Me.texStatAdmin1Month.Text = myStats.HoursOnAdmin1Month
            Me.texStatAdmin3Month.Text = myStats.HoursOnAdmin3Month
            Me.texStatAdmin6Month.Text = myStats.HoursOnAdmin6Month
            Me.texStatAdmin12Month.Text = myStats.HoursOnAdmin12Month
            Me.texStatAdminEndYear.Text = myStats.HoursOnAdminEndYear

            Debug.WriteLine("07 : " & Now)

            myStats.GetFreeHours()
            Me.texStatFree1Month.Text = myStats.HoursFree1Month
            Me.texStatFree3Month.Text = myStats.HoursFree3Month
            Me.texStatFree6Month.Text = myStats.HoursFree6Month
            Me.texStatFree12Month.Text = myStats.HoursFree12Month
            Me.texStatFreeEndYear.Text = myStats.HoursFreeEndYear

            Debug.WriteLine("08 : " & Now)

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub pDisplayNumberPlanedHourOnProjects(CE_ID_ProjectMember As Integer)
        Try

            'TODO: This line of code loads data into the 'DsNumberPlanedHourOnProjects.vstatistiquesnumberofdaysplanonprojects' table. You can move, or remove it, as needed.
            Me.VstatistiquesnumberofdaysplanonprojectsTableAdapter.Fill(Me.DsNumberPlanedHourOnProjects.vstatistiquesnumberofdaysplanonprojects)

            Me.VstatistiquesnumberofdaysplanonprojectsBindingSource.Filter = "CE_ID_ProjectMember = " & CE_ID_ProjectMember

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub pDisplayNumberPlanedHourOnAdminResources(CE_ID_ProjectMember As Integer)
        Try

            'TODO: This line of code loads data into the 'DsNumberPlanedHourOnAdmin.vstatistiquesnumberofdaysplanonadminresources' table. You can move, or remove it, as needed.
            Me.VstatistiquesnumberofdaysplanonadminresourcesTableAdapter.Fill(Me.DsNumberPlanedHourOnAdmin.vstatistiquesnumberofdaysplanonadminresources)

            Me.VstatistiquesnumberofdaysplanonadminresourcesBindingSource.Filter = "CE_ID_ProjectMember = " & CE_ID_ProjectMember


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub dgvProjectMembers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjectMembers.CellContentClick

    End Sub
End Class